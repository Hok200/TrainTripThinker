﻿using System;
using System.Collections.ObjectModel;

using Prism.Mvvm;

using Reactive.Bindings;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{

    /// <summary>
    /// <see cref="View.ItineraryViewer"/>用ViewModel
    /// </summary>
    public class ItineraryViewModel : BindableBase
    {
        /// <summary>
        /// Mainインスタンスへの参照
        /// </summary>
        private readonly TttMain main = ModelManager<TttMain>.Instance;

        /// <summary>
        /// ドキュメントインスタンスへの参照
        /// </summary>
        private readonly TttDocument document;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ItineraryViewModel()
        {
            this.document = this.main.Document;

            this.Itineraries = this.document.Itineraries.ToReadOnlyReactiveCollection();

            this.AddItineraryCommand = new ReactiveCommand();
            this.AddItineraryCommand.Subscribe(_ => this.document.AddItinerary());
            this.RemoveItineraryCommand = new ReactiveCommand<int>();
            this.RemoveItineraryCommand.Subscribe(index => this.document.RemoveItinerary(index));
            this.AddTransportEelementCommand = new ReactiveCommand<Itinerary>();
            this.AddTransportEelementCommand.Subscribe(itinerary => itinerary.AddTransportElement());
        }

        /// <summary>
        /// 行程表インスタンス
        /// </summary>
        public ReadOnlyObservableCollection<Itinerary> Itineraries { get; }

        /// <summary>
        /// 行程表を追加
        /// </summary>
        public ReactiveCommand AddItineraryCommand { get; }

        /// <summary>
        /// 行程表を削除
        /// </summary>
        public ReactiveCommand<int> RemoveItineraryCommand { get; } 

        public ReactiveCommand<Itinerary> AddTransportEelementCommand { get; }
    }
}
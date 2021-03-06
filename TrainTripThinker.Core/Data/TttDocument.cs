﻿using System;
using System.Collections.ObjectModel;

using Newtonsoft.Json;

using Reactive.Bindings.Extensions;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// Train Trip Thinkerのドキュメントクラス
    /// </summary>
    /// <inheritdoc cref="FileChangeNotifyBase"/>
    public class TttDocument : FileChangeNotifyBase
    {
        /// <summary>
        /// 行程表コレクション
        /// </summary>
        private ObservableCollection<Itinerary> itineraries;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TttDocument()
        {
            Itineraries = new ObservableCollection<Itinerary>();
            Itineraries.CollectionChangedAsObservable().Subscribe(OnCollectionChanged);
        }

        /// <summary>
        /// 行程表の数
        /// </summary>
        [JsonIgnore]
        public int ItineraryCount => itineraries.Count;

        /// <summary>
        /// TrainTripThinkerのバージョン
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// 行程表コレクション
        /// </summary>
        public ObservableCollection<Itinerary> Itineraries
        {
            get => itineraries;
            set => SetProperty(ref itineraries, value);
        }

        /// <summary>
        /// 行程表を追加
        /// </summary>
        public void AddItinerary()
        {
            Itineraries.Add(new Itinerary("Itinerary" + ItineraryCount));
        }

        private void AddItinerary(Itinerary itinerary)
        {
            Itineraries.Add(itinerary);
        }

        /// <summary>
        /// <see cref="index"/>番目の行程表を削除
        /// </summary>
        /// <param name="index">行程表のインデックス</param>
        public void RemoveItinerary(int index)
        {
            itineraries.RemoveAt(index);
        }

        /// <summary>
        /// ドキュメントをリセットする
        /// </summary>
        public void Clear()
        {
            Itineraries.Clear();
        }

        public void Load(TttDocument another)
        {
            Clear();

            Version = another.Version;

            foreach (Itinerary itinerary in another.Itineraries)
            {
                itinerary.AddDelegateToElements();
                AddItinerary(itinerary);
            }
        }
    }
}
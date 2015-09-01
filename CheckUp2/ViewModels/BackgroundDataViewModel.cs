using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CheckUp2.Models;

namespace CheckUp2.ViewModels {
    class BackgroundDataViewModel {

        private ObservableCollection<BackgroundDataModel> _backgroundData;
        public ObservableCollection<BackgroundDataModel> BackgroundData {
            get {
                return _backgroundData;
            }
        } 

        public BackgroundDataViewModel() {
            _backgroundData = new ObservableCollection<BackgroundDataModel>();
        }

        public void AddData(BackgroundDataModel data) {
            BackgroundData.Add(data);
        }

    }
}

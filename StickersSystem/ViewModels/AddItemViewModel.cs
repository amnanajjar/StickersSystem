using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StickersSystem.Models;

namespace StickersSystem.ViewModels
{
    public class AddItemViewModel
    {
        private ICommand _BrowseImageCommand;

        private ICommand _SaveItemCommand;

        public ItemModel Item { get; set; } = new ItemModel();

        public ICommand BrowseImageCommand
        {
            get
            {
                if(_BrowseImageCommand == null)
                {
                    _BrowseImageCommand = new RelayCommand(param => Browse());
                }
                return _BrowseImageCommand;
            }
        }

        public ICommand SaveItemCommand
        {
            get
            {
                if (_SaveItemCommand == null)
                {
                    _SaveItemCommand = new RelayCommand(param => Save());
                }
                return _SaveItemCommand;
            }
        }

        private void Browse()
        {

        }

        private void Save()
        {

        }
    }
}

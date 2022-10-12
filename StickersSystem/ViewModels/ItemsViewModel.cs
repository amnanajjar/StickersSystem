using StickersSystem.Models;
using StickersSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StickersSystem.ViewModels
{
    public class ItemsViewModel
    {
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        private ICommand _AddItemCommand;

        private ICommand _EditItemCommand;

        private ICommand _DeleteItemCommand;

        private ICommand _PrintItemCommand;

        public ICommand AddItemCommand
        {
            get
            {
                if (_AddItemCommand == null)
                {
                    _AddItemCommand = new RelayCommand(param => AddItem());
                }
                return _AddItemCommand;
            }
        }

        public ICommand EditItemCommand
        {
            get
            {
                if (_EditItemCommand == null)
                {
                    _EditItemCommand = new RelayCommand(param => EditItem());
                }
                return _EditItemCommand;
            }
        }

        public ICommand DeleteItemCommand
        {
            get
            {
                if (_DeleteItemCommand == null)
                {
                    _DeleteItemCommand = new RelayCommand(param => DeleteItem());
                }
                return _DeleteItemCommand;
            }
        }

        public ICommand PrintItemCommand
        {
            get
            {
                if (_PrintItemCommand == null)
                {
                    _PrintItemCommand = new RelayCommand(param => PrintItem());
                }
                return _PrintItemCommand;
            }
        }

        private void AddItem()
        {
            AddItemView view = new AddItemView();
            view.ShowDialog();

        }

        private void DeleteItem()
        {

        }

        private void EditItem()
        {

        }

        private void PrintItem()
        {

        }

        public ItemsViewModel()
        {
            Items.Add(new ItemModel() { Name = "sdff" });
        }
    }
}

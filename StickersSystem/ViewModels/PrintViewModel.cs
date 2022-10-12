using StickersSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StickersSystem.ViewModels
{
    public class PrintViewModel
    {
        public PrintModel Print { get; set; } = new PrintModel();

        private ICommand _PrintCommand;

        private ICommand _PrintPreviewCommand;

        public ICommand PrintCommand
        {
            get
            {
                if (_PrintCommand == null)
                {
                    _PrintCommand = new RelayCommand(param => PrintSticker());
                }
                return _PrintCommand;
            }
        }

        public ICommand PrintPreviewCommand
        {
            get
            {
                if (_PrintPreviewCommand == null)
                {
                    _PrintPreviewCommand = new RelayCommand(param => PrintPreview());
                }
                return _PrintPreviewCommand;
            }
        }

        private void PrintPreview()
        {

        }

        private void PrintSticker()
        {

        }
    }
}

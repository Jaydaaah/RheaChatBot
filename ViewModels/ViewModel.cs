using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RheaChatBot.Models;

namespace RheaChatBot.ViewModels
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<object> Items { get;  } = new ObservableCollection<object>();

        private String _messagebox = String.Empty;
        public String MessageBox
        {
            get => _messagebox;
            set
            {
                if (_messagebox != value)
                {
                    _messagebox = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(EnableSent));
                }
            }
        }

        public bool EnableSent
        {
            get => MessageBox != String.Empty;
        }

        public ViewModel()
        {
            Items.Add(new ReceiveItem() { Value = "Sample Conversation only" });
            Items.Add(new ReceiveItem() { Value = "Hello there! I am Rhea Marie Alonda Chatbot" });
            Items.Add(new SentItem() { Value = "Hello" });
            Items.Add(new ReceiveItem() { Value = "How may I help you today?" });
            Items.Add(new SentItem() { Value = "Generate Lorem Ipsum" });
            Items.Add(new ReceiveItem() { Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." });
            Items.Add(new SentItem() { Value = "Thank you" });
            Items.Add(new SentItem() { Value = "Anytime!!" });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        internal void AddItem(ReceiveItem item) => Items.Add(item);
        internal void AddItem(SentItem item) => Items.Add(item);
    }
}

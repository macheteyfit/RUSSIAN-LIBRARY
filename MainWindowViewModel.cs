using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace WpfApp1
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        private Book _selectedBook;
        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        private Book _selectedBookDetails;
        public Book SelectedBookDetails
        {
            get => _selectedBookDetails;
            set
            {
                _selectedBookDetails = value;
                OnPropertyChanged(nameof(SelectedBookDetails));
            }
        }

        public ICommand ShowDetailsCommand { get; set; }

        public MainWindowViewModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book { Name = "Война и мир", Author = "Лев Толстой", PublicationYear = "1869", Genre = "Роман", Description = "Исторический роман-эпопея, описывающий события Отечественной войны 1812 года." },
                new Book { Name = "Преступление и наказание", Author = "Фёдор Достоевский", PublicationYear = "1866", Genre = "Роман", Description = "Психологический роман о борьбе добра и зла в душе человека." },
                new Book { Name = "Мастер и Маргарита", Author = "Михаил Булгаков", PublicationYear = "1967", Genre = "Фантастика", Description = "Философский роман о судьбе человека, любви и морали на фоне мистических событий." },
                new Book { Name = "Евгений Онегин", Author = "Александр Пушкин", PublicationYear = "1833", Genre = "Роман в стихах", Description = "Роман в стихах, описывающий жизнь дворянской молодёжи начала XIX века." },
                new Book { Name = "Тихий Дон", Author = "Михаил Шолохов", PublicationYear = "1940", Genre = "Роман", Description = "Эпопея, описывающая жизнь казаков во время Первой мировой войны и революции." },
            };

            ShowDetailsCommand = new RelayCommand(ShowDetails);
        }

        private void ShowDetails()
        {
            if (SelectedBook != null)
            {
                SelectedBookDetails = SelectedBook; // Переносим выбранную книгу в область "подробностей"
            }
        }
    }
}
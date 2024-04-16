using System; // Подключение пространства имен System для базовых функций
using System.Drawing; // Подключение пространства имен System.Drawing для работы с графикой
using System.Windows.Forms; // Подключение пространства имен System.Windows.Forms для работы с элементами управления Windows Forms

namespace WindowsFormsApp10 // Объявление пространства имен WindowsFormsApp10
{
    // Интерфейс для печати
    interface IPrintable
    {
        string Print(); // Метод Print() для вывода информации
    }

    // Интерфейс для работы приложения
    interface IApplication
    {
        void Run(); // Метод Run() для запуска приложения
    }

    // Абстрактный класс ПО
    abstract class Software : IPrintable, IApplication
    {
        public abstract void Run(); // Абстрактный метод Run() для запуска приложения

        public virtual string Print() // Виртуальный метод Print() для печати информации
        {
            return "Printing Software"; // Возвращает строку при печати
        }
    }

    // Класс Набор операций
    class OperationsSet : Software
    {
        public override void Run() // Реализация метода Run() для класса OperationsSet
        {
            MessageBox.Show("OperationsSet is running..."); // Вывод сообщения о запуске
        }

        public override string Print() // Переопределение метода Print() для класса OperationsSet
        {
            return "Printing OperationsSet"; // Возвращает строку при печати
        }
    }

    // Абстрактный класс Текстовый процессор
    abstract class TextProcessor : Software
    {
        public abstract void EditText(); // Абстрактный метод EditText() для редактирования текста
    }

    // Класс Word, наследуемый от Текстового процессора
    class Word : TextProcessor
    {
        public override void Run() // Реализация метода Run() для класса Word
        {
            MessageBox.Show("Word is running..."); // Вывод сообщения о запуске Word
        }

        public override void EditText() // Реализация метода EditText() для класса Word
        {
            MessageBox.Show("Editing text in Word..."); // Вывод сообщения о редактировании текста в Word
        }

        public override string Print() // Переопределение метода Print() для класса Word
        {
            return "Printing Word"; // Возвращает строку при печати
        }
    }

    // Класс Вирус
    class Virus : IPrintable, IApplication
    {
        public void Infect() // Метод Infect() для заражения
        {
            MessageBox.Show("Virus is infecting..."); // Вывод сообщения о заражении
        }

        public string Print() // Реализация метода Print() для класса Virus
        {
            return "Printing Virus"; // Возвращает строку при печати
        }

        public void Run() // Реализация метода Run() для класса Virus
        {
            Infect(); // Запуск заражения
        }
    }

    // Класс CConficker, наследуемый от Вирус
    class Conficker : Virus
    {
        public void InfectNetwork() // Метод InfectNetwork() для заражения сети
        {
            MessageBox.Show("Conficker is infecting network..."); // Вывод сообщения о заражении сети
        }
    }

    // Интерфейс для клонирования
    interface ICloneable
    {
        bool DoClone(); // Метод DoClone() для клонирования
    }

    // Абстрактный класс для клонирования
    abstract class BaseClone : ICloneable
    {
        public abstract bool DoClone(); // Абстрактный метод DoClone() для клонирования
    }

    // Класс UserClass, наследуемый от BaseClone и реализующий ICloneable и IPrintable
    class UserClass : BaseClone, IPrintable, IApplication
    {
        public override bool DoClone() // Реализация метода DoClone() для класса UserClass
        {
            MessageBox.Show("UserClass DoClone() implementation"); // Вывод сообщения о клонировании
            return true; // Возвращение значения о выполнении операции клонирования
        }

        public string Print() // Реализация метода Print() для класса UserClass
        {
            return "Printing UserClass"; // Возвращает строку при печати
        }

        public void Run() // Реализация метода Run() для класса UserClass
        {
            DoClone(); // Выполнение клонирования
        }
    }

    // Класс Игрушка
    class Toy : IPrintable, IApplication
    {
        public virtual void Play() // Виртуальный метод Play() для игры с игрушкой
        {
            MessageBox.Show("Playing with the toy..."); // Вывод сообщения о игре с игрушкой
        }

        public string Print() // Реализация метода Print() для класса Toy
        {
            return "Printing Toy"; // Возвращает строку при печати
        }

        public void Run() // Реализация метода Run() для класса Toy
        {
            Play(); // Запуск игры с игрушкой
        }
    }

    // Класс Сапер, наследуемый от Игрушки
    class Minesweeper : Toy
    {
        public override void Play() // Переопределение метода Play() для класса Minesweeper
        {
            MessageBox.Show("Playing Minesweeper..."); // Вывод сообщения о игре в Сапер
        }
    }

    // Класс Разработчик
    class Developer : IPrintable, IApplication
    {
        public void Code() // Метод Code() для написания кода
        {
            MessageBox.Show("Developer is coding..."); // Вывод сообщения о написании кода
        }

        public string Print() // Реализация метода Print() для класса Developer
        {
            return "Printing Developer"; // Возвращает строку при печати
        }

        public void Run() // Реализация метода Run() для класса Developer
        {
            Code(); // Выполнение написания кода
        }
    }

    // Дополнительный класс Printer
    class Printer
    {
        public void IAmPrinting(IPrintable printable) // Метод IAmPrinting() для вывода на печать
        {
            MessageBox.Show(printable.Print()); // Вывод на печать информации, возвращаемой методом Print()
        }
    }

    // Частичный класс Form1, наследуемый от Form
    public partial class Form1 : Form
    {
        public Form1() // Конструктор класса Form1
        {
            InitializeComponent(); // Инициализация компонентов формы
            InitializeButtons(); // Инициализация кнопок на форме
        }

        private void InitializeButtons() // Метод InitializeButtons() для инициализации кнопок
        {
            // Создаем кнопки и настраиваем их свойства
            Button btnOperationsSet = new Button();
            btnOperationsSet.Text = "Run OperationsSet";
            btnOperationsSet.Location = new Point(10, 10);
            btnOperationsSet.Click += BtnOperationsSet_Click;
            this.Controls.Add(btnOperationsSet);

            Button btnWord = new Button();
            btnWord.Text = "Run Word";
            btnWord.Location = new Point(10, 40);
            btnWord.Click += BtnWord_Click;
            this.Controls.Add(btnWord);

            Button btnConficker = new Button();
            btnConficker.Text = "Run Conficker";
            btnConficker.Location = new Point(10, 70);
            btnConficker.Click += BtnConficker_Click;
            this.Controls.Add(btnConficker);

            Button btnMinesweeper = new Button();
            btnMinesweeper.Text = "Run Minesweeper";
            btnMinesweeper.Location = new Point(10, 100);
            btnMinesweeper.Click += BtnMinesweeper_Click;
            this.Controls.Add(btnMinesweeper);

            Button btnDeveloper = new Button();
            btnDeveloper.Text = "Run Developer";
            btnDeveloper.Location = new Point(10, 130);
            btnDeveloper.Click += BtnDeveloper_Click;
            this.Controls.Add(btnDeveloper);

            Button btnUserClass = new Button();
            btnUserClass.Text = "Run UserClass";
            btnUserClass.Location = new Point(10, 160);
            btnUserClass.Click += BtnUserClass_Click;
            this.Controls.Add(btnUserClass);

            Button btnPrinter = new Button();
            btnPrinter.Text = "Run Printer";
            btnPrinter.Location = new Point(10, 190);
            btnPrinter.Click += BtnPrinter_Click;
            this.Controls.Add(btnPrinter);
        }

        // Обработчики событий для кнопок
        private void BtnOperationsSet_Click(object sender, EventArgs e) // Обработчик события клика для кнопки OperationsSet
        {
            OperationsSet ops = new OperationsSet(); // Создание экземпляра класса OperationsSet
            ops.Run(); // Запуск приложения OperationsSet
        }

        private void BtnWord_Click(object sender, EventArgs e) // Обработчик события клика для кнопки Word
        {
            Word word = new Word(); // Создание экземпляра класса Word
            word.Run(); // Запуск приложения Word
            word.EditText(); // Редактирование текста в Word
        }

        private void BtnConficker_Click(object sender, EventArgs e) // Обработчик события клика для кнопки Conficker
        {
            Conficker conficker = new Conficker(); // Создание экземпляра класса Conficker
            conficker.Run(); // Запуск приложения Conficker
        }

        private void BtnMinesweeper_Click(object sender, EventArgs e) // Обработчик события клика для кнопки Minesweeper
        {
            Minesweeper minesweeper = new Minesweeper(); // Создание экземпляра класса Minesweeper
            minesweeper.Run(); // Запуск приложения Minesweeper
        }

        private void BtnDeveloper_Click(object sender, EventArgs e) // Обработчик события клика для кнопки Developer
        {
            Developer developer = new Developer(); // Создание экземпляра класса Developer
            developer.Run(); // Запуск приложения Developer
        }

        private void BtnUserClass_Click(object sender, EventArgs e) // Обработчик события клика для кнопки UserClass
        {
            UserClass userClass = new UserClass(); // Создание экземпляра класса UserClass
            userClass.Run(); // Запуск приложения UserClass
        }

        private void BtnPrinter_Click(object sender, EventArgs e) // Обработчик события клика для кнопки Printer
        {
            Printer printer = new Printer(); // Создание экземпляра класса Printer
            OperationsSet ops = new OperationsSet(); // Создание экземпляра класса OperationsSet
            Word word = new Word(); // Создание экземпляра класса Word
            Conficker conficker = new Conficker(); // Создание экземпляра класса Conficker
            Minesweeper minesweeper = new Minesweeper(); // Создание экземпляра класса Minesweeper
            Developer developer = new Developer(); // Создание экземпляра класса Developer
            UserClass userClass = new UserClass(); // Создание экземпляра класса UserClass

            // Выполнение печати информации об объектах
            printer.IAmPrinting(ops);
            printer.IAmPrinting(word);
            printer.IAmPrinting(conficker);
            printer.IAmPrinting(minesweeper);
            printer.IAmPrinting(developer);
            printer.IAmPrinting(userClass);
        }
    }
}

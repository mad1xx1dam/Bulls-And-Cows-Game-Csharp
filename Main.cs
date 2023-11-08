using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using NAudio.Wave;
using System.Text.RegularExpressions;

namespace BullsAndCows
{
    public partial class Main : Form
    {
        //список открытых форм
        public static List<Form> openForms = new List<Form>();
        public static int guess = 0;
        public int count = 1;
        public bool isUsed = false; //будет отвечать за случай, если вдруг форма победы или проигрыша уже открывалась
        int flag = 1;
        public static AudioFileReader reader = new AudioFileReader(@"Resources\sound.wav");
        public LoopStream loop = new LoopStream(reader);
        public WaveOutEvent player = new WaveOutEvent();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            // список всех кнопок, чтобы для них одновременно можно было менять свойства
            List<Button> buttonList = new List<Button> { newGameButton, adviceButton, authorButton, 
                surrenderButton, gameInfoButton, inputButton};

            //распространяю на все кнопки обработчик button_MouseEnter при наведении курсора
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].MouseEnter += button_MouseEnter;
            }
            //Вывод начального текста в richTextBox
            outputText.Text = "\tБыло загадано число\n\n\t\t     Ваш вариант\t\t     Результат\n\n";
            //создание случайного числа
            guess = NewNumber();
            //работа со звуком
            player.Init(loop);
            player.Play();
        }

        //обработчик при наведении курсора, чтобы фон кнопки не становился белым
        private void button_MouseEnter(object sender, EventArgs e)
        {
            //sender - это объект, который вызвал событие, в контексте которого выполняется этот код, таким образом, под button может иметься в виду любая  кнопка
            Button button = (Button)sender;
            //цвет при наведении - серый
            button.FlatAppearance.MouseOverBackColor = Color.Gray;
        }
        //обработчик при наведении курсора, чтобы фон кнопки не становился белым
        private void soundButton_MouseEnter(object sender, EventArgs e)
        {
            soundButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }




        //обработчик нажатия кноки Новая игра
        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (IsWinOrLoseOpen()) //если вдруг окна с результатом открыты, то их надо закрыть прежде, чем начать новую игру
            {
                foreach (Form form in openForms)
                {
                    if (form.GetType() == typeof(Win) || form.GetType() == typeof(Lose))
                    {
                        form.Hide();
                        openForms.Remove(form);
                        break;
                    }
                }
            }
            //обнуление счетчика попыток
            isUsed = false;
            count = 1;
            guess = NewNumber();
            outputText.Text = "\tБыло загадано новое число\n\n\t\t     Ваш вариант\t\t     Результат\n\n";
        }
        //обработчик нажатия кноки Сдаться
        private void surrenderButton_Click(object sender, EventArgs e)
        {
            if (!isUsed) //чтобы вдруг после победы человек не нажал сдаться и не выскочило окно поражения
            {
                isUsed = true; //Указываем, что форма проигрыша вызывалась
                Lose lose = new Lose();
                lose.label2.Text = $"Компьютер загадал число {guess}";

                //проигрывание звука при поражении
                var reader_lose = new Mp3FileReader("Resources\\zvuk-neudachy.mp3");
                var waveOut = new WaveOut(); // or WaveOutEvent()
                waveOut.Init(reader_lose);
                waveOut.Play();


                ShowForm(lose);
            }
            else
            {
                outputText.Text = "Нажмите 'Новая игра', чтобы попробовать снова";
            }
        }
        //обработчик нажатия кноки Смысл игры
        private void gameInfoButton_Click(object sender, EventArgs e)
        {
            ShowForm(new GameInfo());
        }
        //обработчик нажатия кноки Справка
        private void adviceButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Advice());
        }
        //обработчик нажатия кноки Автор
        private void authorButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Authorcs());
        }
        //обработчик нажатия кноки Угадать
        private void inputButton_Click(object sender, EventArgs e)
        {
            //если вдруг при нажатии кнопки угадать уже открыта форма победы или проигрыша, чтобы не продолжалось угадывание
            if (!isUsed)
            { 
                string inputResultString = InputCheck(inputText.Text); //получаем строку с результатом ввода (либо содержит строку с названием ошибки, либо 4-значное число)
                if (Int32.TryParse(inputResultString, out int inputResultInt)) //если получается конвертировать в число, то значит был корректный ввод и начинается проверка числа
                {
                    string result = (string)CowsAndBulls(inputResultInt)[0];
                    //в случае, если пользователь ввел оригинальное число, появятся 3 колонки
                    outputText.Text += $"{count}\t\t\t {inputResultInt}\t\t\t\t{result}\n";
                    //если второе значение в функции - правда, то есть 4 быка, то пользователь победил -> открываем победную форму
                    if ((bool)CowsAndBulls(inputResultInt)[1]) //случай, если пользователь получил 4 быка, то есть победил
                    {
                        isUsed = true; //Указываем, что форма победы вызывалась
                        Win win = new Win();
                        win.label2.Text = $"Компьютер действительно загадал число {inputResultString}\nвы угадали за {count} ходов";
                        //проигрывание звука при победе
                        var reader_win = new Mp3FileReader("Resources\\win.mp3");
                        var waveOut = new WaveOut(); 
                        waveOut.Init(reader_win);
                        waveOut.Play();
                        ShowForm(win);
                    }
                }
                else
                {
                    //в случае, если пользователь ввел с ошибкой, появятся 2 колонки
                    outputText.Text += $"{count}\t\t     {inputResultString}\t\t\n";
                }
                count += 1;
            }
            else
            {
                outputText.Text = "Нажмите 'Новая игра', чтобы попробовать снова";
            }
        }
        //обработчик нажатия по кнопке звука (чтобы менялась картинка и отключался/включался звук)
        private void soundButton_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b = new Bitmap(@"Resources\soundNo.png");
                soundButton.BackgroundImage = b;
                player.Stop();
            }
            if (flag == 1)
            {
                Bitmap b = new Bitmap(@"Resources\sound.png");
                soundButton.BackgroundImage = b;
                player.Play();
            }
        }
        //обработчик нажатия Enter
        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputButton_Click(sender, e);
            }
        }



        //метод для вызова определенной формы (таким образом, не надо в обработчике нажатия каждой кнопки)
        //прописывать один и тот же код, в котором меняется только класс формы; для этого в качестве параметра
        //просто передаем new FormClass() frm, где FormClass - класс нужной формы
        public static void ShowForm(Form frm)
        {
            Type type = frm.GetType(); //считываем тип (класс) формы
            bool isExist = false; //флаг, если такая форма уже будет в списке открытых
            foreach (Form form in openForms)
            {
                if (form.GetType() == type)//если находится такая форма в открытых
                {
                    form.Activate(); //то просто показать форму, а не открывать еще такую же
                    isExist = true;//отмечаем, что такая форма уже открыта
                    break;
                }
            }
            if (!isExist) //но если форма не открыта
            {
                frm.Show(); //то ее полноценно открываем
                openForms.Add(frm); //и добавляем 
            }
        }
        //Ищет форму такого же класса, что и frm, и удаляет ее из списка открытых форм openForms
        public static void FormDelete(Form frm)
        {
            Type type = frm.GetType();
            foreach (Form form in openForms)
            {
                if (form.GetType() == type)
                {
                    openForms.Remove(form);
                    break;
                }
            }
        }
        //проверка на корректность ввода числа
        private static string InputCheck(string str)
        {
            //список доступных цифр для проверки уникальности
            List<int> availableDigits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Regex regex = new Regex(@"^\d+$"); //регулярное выражение для проверки на то, число или нет

            if (!regex.IsMatch(str))
            {
                return "Было введено не число";
            }
            else if (str.StartsWith("0"))
            {
                return "Не может начинаться с 0";
            }
            else if (str.Length != 4)
            {
                return "Должно быть 4 цифры";
            }
            else
            {
                foreach (char c in str)
                {
                    int symb = (int)Char.GetNumericValue(c);
                    if (availableDigits.Contains(symb)) //если окажется, что такая цифра недоступна, это значит, что цифра уже использовалась
                    {
                        availableDigits.Remove(symb); //если такая цифра доступна, то удаляем из списка доступных цифр
                    }
                    else
                    {
                        return "Неоригинальное число";
                    }
                }
                return str; //если все хорошо, то вернется строка, в которой содержится число с уникальными цифрами
            }
        }
        //Генерация уникального числа
        private static int NewNumber()
        {
            Random rnd = new Random();
            //список доступных цифр для проверки уникальности
            List<int> availableDigits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string strNumber = "";
            for (int i = 0; i < 4; i++)
            {
                int index = rnd.Next(0, availableDigits.Count);
                strNumber += availableDigits[index];
                availableDigits.RemoveAt(index);
                if (i == 0)
                {
                    availableDigits.Add(0); //так как на первом месте не может стоять 0
                }
            }

            return Convert.ToInt32(strNumber); 
        }
        //метод для определения количества быков и коров
        public static ArrayList CowsAndBulls(int number)
        {
            int cows = 0;
            int bulls = 0;
            string inputStr = Convert.ToString(number);
            string guessStr = Convert.ToString(guess);

            for (int i = 0; i < 4; i++)
            {
                if (guessStr[i] == inputStr[i]) //если совпадают на одинкаовых позициях
                {
                    bulls += 1;
                }
                else if (guessStr.Contains(inputStr[i].ToString())) //если в числе компьютера есть такая же цифра, но на другой позиции
                {
                    cows += 1;
                }
            }
            if (bulls == 4)
            {
                return new ArrayList { $"{bulls}Б{cows}К", true }; //2 поле будет обозначать, выиграл или пока нет
            }
            else
            {
                return new ArrayList { $"{bulls}Б{cows}К", false };
            }  
        }
        //если уже открыта форма победы или проигрыша
        public static bool IsWinOrLoseOpen()
        {
            bool flag = false;
            foreach (Form form in openForms)
            {
                //ищет формы такого типа (Win, Lose)
                if (form.GetType() == typeof(Win) || form.GetType() == typeof(Lose))
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}

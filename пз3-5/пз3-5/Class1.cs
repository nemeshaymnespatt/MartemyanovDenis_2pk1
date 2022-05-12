using System;
namespace pz_3._2
{
    public class BookCard
    {
        public string ID;
        public string author;
        public string title;
        public int year;
        public string condition;
        public string direction;




        public BookCard(string id, string au, string ti, int ye, string co, string di)
        {
            this.direction = di;
            if (id != "")
                this.ID = id;
            else
                this.ID = "Нет данных";
            this.year = ye;
            if (au != "")
                this.author = au;
            else
                this.author = "Нет данных";
            if (ti != "")
                this.title = ti;
            else
                this.title = "Нет данных";
            switch (co)
            {
                case "0":
                    this.condition = "На списание";
                    break;
                case "1":
                    this.condition = "На списание";
                    break;
                case "2":
                    this.condition = "На списание";
                    break;
                case "3":
                    this.condition = "На списание";
                    break;
                case "4":
                    this.condition = "Хорошее";
                    break;
                case "5":
                    this.condition = "Хорошее";
                    break;
                case "6":
                    this.condition = "Хорошее";
                    break;
                case "7":
                    this.condition = "Хорошее";
                    break;
                case "8":
                    this.condition = "Новая";
                    break;
                case "9":
                    this.condition = "Новая";
                    break;
                case "10":
                    this.condition = "Новая";
                    break;
                default:
                    this.condition = "Некоректные данные";
                    break;


            }



        }
        public void GetTicketInfo()
        {

            Console.WriteLine($"Ваш уникальный номер:{ID}\nАвтор:{ author }\nНазвание:{title}\nГод издания экземпляра:{year}\nСостояние книги:{condition}\nНаправление книги:{direction} ");
        }
    }
}
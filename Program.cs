using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Бой с боссом. 10 баллов.
            /*Легенда: Вы – теневой маг и у вас в арсенале есть несколько заклинаний, которые вы можете использовать против Босса.Вы должны уничтожить босса и только после этого будет вам покой.

                   Формально: перед вами босс, у которого есть определенное кол - во жизней и определенный ответный урон.у вас есть 4 заклинания для нанесения урона боссу.Программа завершается только после смерти босса или смерти пользователя.
                    Проиллюстрировать босса!
                    Пример заклинаний
                    Рашамон – призывает теневого духа для нанесения атаки(Отнимает 100 хп игроку)
                    Хуганзакура(Может быть выполнен только после призыва теневого духа), наносит 100 ед.урона
                    Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп.Урон босса по вам не проходит
                    Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь какие-то условия выполнения(пример -Хуганзакура). Босс должен иметь возможность убить пользователя.*/


            int userHP = 500;
            int bossHP = 1000;
            Console.WriteLine("Вы выходите на арену против Вивека");
            bool endGame = false;
            bool canBurn = false;

            while (!endGame && userHP > 0 && bossHP > 0)
            {
                Console.WriteLine($"Player HP: {userHP} \n Boss HP: {bossHP}");
                Console.WriteLine("Выберите что делать: 1 - phys dmg(100), 2 - fireball(250), 3 - heal(100), 4 - burn(500) можно произнести только после огненного шара");
                int playerChoice = int.Parse(Console.ReadLine());
                switch (playerChoice)
                {
                    case 1:
                        bossHP -= 100;
                        Console.WriteLine($"Босс получил физ урон");
                        break;
                    case 2:
                        bossHP -= 250;
                        Console.WriteLine("Босс получает урон от шара огня");
                        canBurn = true;
                        break;
                    case 3:
                        userHP += 100;
                        Console.WriteLine("Вы восстанавливаете здоровье");
                        break;
                    case 4:
                        if (canBurn)
                        {
                            bossHP -= 500;
                            Console.WriteLine("Вы вызываете внутреннее горение у противника и наносите крит. урон");
                            canBurn = false;
                        }
                        else
                        {
                            Console.WriteLine("Заклинание не удалось");
                        }
                        break;
                    default:
                        Console.WriteLine("Растерялись и получили урон просто так, будьте точней с выбором");
                        break;


                }
                userHP -= 75;
            }
            if(bossHP <= 0)
            {
                Console.WriteLine("Поздравляю - вы победили!!!");
            }
            else
            {
                Console.WriteLine("Соболезную, в другой раз повезет.");
            }
        }
    }
}

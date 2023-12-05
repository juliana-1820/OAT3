using exercicio002;

namespace exercicio002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LISTA DE EXERCÍCIOS 02");

            do
            {
                Console.WriteLine("Escolha o número do exercício (1 ao 64)");
                int numexercicio = int.Parse(Console.ReadLine());

                while (numexercicio > 0 || numexercicio <= 64)
                {
                    switch (numexercicio)
                    {
                        case 1:
                            Exercicio01 exercicio_01 = new Exercicio01();
                            exercicio_01.Executarexercicioum();
                            continue;

                        case 2:
                            Exercicio02 exercicio_02 = new Exercicio02();
                            exercicio_02.Executarexerciciodois();
                            continue;

                        case 3:
                            Exercicio03 exercicio_03 = new Exercicio03();
                            exercicio_03.Executarexerciciotres();
                            break;

                        case 4:
                            Exercicio04 exercicio_04 = new Exercicio04();
                            exercicio_04.Executarexercicioquatro();
                            break;

                        case 5:
                            Exercicio05 exercicio_05 = new Exercicio05();
                            exercicio_05.Executarexerciciocinco();
                            break;

                        case 6:
                            Exercicio06 exercicio_06 = new Exercicio06();
                            exercicio_06.Executarexercicioseis();
                            break;

                        case 7:
                            Exercicio07 exercicio_07 = new Exercicio07();
                            exercicio_07.Executarexerciciosete();
                            break;

                        case 8:
                            Exercicio08 exercicio_08 = new Exercicio08();
                            exercicio_08.Executarexerciciooito();
                            break;

                        case 9:
                            Exercicio09 exercicio_09 = new Exercicio09();
                            exercicio_09.Executarexercicionove();
                            break;

                        case 10:
                            Exercicio10 exercicio_10 = new Exercicio10();
                            exercicio_10.Executarexerciciodez();
                            break;

                        case 11:
                            Exercicio11 exercicio_11 = new Exercicio11();
                            exercicio_11.Executarexercicioonze();
                            break;

                        case 12:
                            Exercicio12 exercicio_12 = new Exercicio12();
                            exercicio_12.Executarexerciciodoze();
                            break;

                        case 13:
                            Exercicio13 exercicio_13 = new Exercicio13();
                            exercicio_13.Executarexerciciotreze();
                            break;

                        case 14:
                            Exercicio14 exercicio_14 = new Exercicio14();
                            exercicio_14.Executarexercicioquatorze();
                            break;

                        case 15:
                            Exercicio15 exercicio_15 = new Exercicio15();
                            exercicio_15.Executarexercicioquinze();
                            break;

                        case 16:
                            Exercicio16 exercicio_16 = new Exercicio16();
                            exercicio_16.Executarexerciciodezesseis();
                            break;

                        case 17:
                            Exercicio17 exercicio_17 = new Exercicio17();
                            exercicio_17.Executarexerciciodezessete();
                            break;

                        case 18:
                            Exercicio18 exercicio_18 = new Exercicio18();
                            exercicio_18.Executarexerciciodezoito();
                            break;

                        case 19:
                            Exercicio19 exercicio_19 = new Exercicio19();
                            exercicio_19.Executarexerciciodezenove();
                            break;

                        case 20:
                            Exercicio20 exercicio_20 = new Exercicio20();
                            exercicio_20.Executarexerciciovinte();
                            break;

                        case 21:
                            Exercicio21 exercicio_21 = new Exercicio21();
                            exercicio_21.Executarexerciciovinteeum();
                            break;

                        case 22:
                            Exercicio22 exercicio_22 = new Exercicio22();
                            exercicio_22.Executarexerciciovinteedois();
                            break;

                        case 23:
                            Exercicio23 exercicio_23 = new Exercicio23();
                            exercicio_23.Executarexerciciovinteetres();
                            break;

                        case 24:
                            Exercicio24 exercicio_24 = new Exercicio24();
                            exercicio_24.Executarexerciciovinteequatro();
                            break;

                        case 25:
                            Exercicio25 exercicio_25 = new Exercicio25();
                            exercicio_25.Executarexerciciovinteecinco();
                            break;

                        case 26:
                            Exercicio26 exercicio_26 = new Exercicio26();
                            exercicio_26.Executarexerciciovinteeseis();
                            break;

                        case 27:
                            Exercicio27 exercicio_27 = new Exercicio27();
                            exercicio_27.Executarexerciciovinteesete();
                            break;

                        case 28:
                            Exercicio28 exercicio_28 = new Exercicio28();
                            exercicio_28.Executarexerciciovinteeoito();
                            break;

                        case 29:
                            Exercicio29 exercicio_29 = new Exercicio29();
                            exercicio_29.Executarexerciciovinteenove();
                            break;

                        case 30:
                            Exercicio30 exercicio_30 = new Exercicio30();
                            exercicio_30.Executarexerciciotrinta();
                            break;

                        case 31:
                            Exercicio31 exercicio_31 = new Exercicio31();
                            exercicio_31.Executarexerciciotrintaeum();
                            break;

                        case 32:
                            Exercicio32 exercicio_32 = new Exercicio32();
                            exercicio_32.Executarexerciciotrintaedois();
                            break;

                        case 33:
                            Exercicio33 exercicio_33 = new Exercicio33();
                            exercicio_33.Executarexerciciotrintaetres();
                            break;

                        case 34:
                            Exercicio34 exercicio_34 = new Exercicio34();
                            exercicio_34.Executarexerciciotrintaequatro();
                            break;

                        case 35:
                            Exercicio35 exercicio_35 = new Exercicio35();
                            exercicio_35.Executarexerciciotrintaecinco();
                            break;

                        case 36:
                            Exercicio36 exercicio_36 = new Exercicio36();
                            exercicio_36.Executarexerciciotrintaeseis();
                            break;

                        case 37:
                            Exercicio37 exercicio_37 = new Exercicio37();
                            exercicio_37.Executarexerciciotrintaesete();
                            break;

                        case 38:
                            Exercicio38 exercicio_38 = new Exercicio38();
                            exercicio_38.Executarexerciciotrintaeoito();
                            break;

                        case 39:
                            Exercicio39 exercicio_39 = new Exercicio39();
                            exercicio_39.Executarexerciciotrintaenove();
                            break;

                        case 40:
                            Exercicio40 exercicio_40 = new Exercicio40();
                            exercicio_40.Executarexercicioquarenta();
                            break;

                        case 41:
                            Exercicio41 exercicio_41 = new Exercicio41();
                            exercicio_41.Executarexercicioquarentaeum();
                            break;

                        case 42:
                            Exercicio42 exercicio_42 = new Exercicio42();
                            exercicio_42.Executarexercicioquarentaedois();
                            break;

                        case 43:
                            Exercicio43 exercicio_43 = new Exercicio43();
                            exercicio_43.Executarexercicioquarentaetres();
                            break;

                        case 44:
                            Exercicio44 exercicio_44 = new Exercicio44();
                            exercicio_44.Executarexercicioquarentaequatro();
                            break;

                        case 45:
                            Exercicio45 exercicio_45 = new Exercicio45();
                            exercicio_45.Executarexercicioquarentaecinco();
                            break;

                        case 46:
                            Exercicio46 exercicio_46 = new Exercicio46();
                            exercicio_46.Executarexercicioquarentaeseis();
                            break;

                        case 47:
                            Exercicio47 exercicio_47 = new Exercicio47();
                            exercicio_47.Executarexercicioquarentaesete();
                            break;

                        case 48:
                            Exercicio48 exercicio_48 = new Exercicio48();
                            exercicio_48.Executarexercicioquarentaeoito();
                            break;

                        case 49:
                            Exercicio49 exercicio_49 = new Exercicio49();
                            exercicio_49.Executarexercicioquarentaenove();
                            break;

                        case 50:
                            Exercicio50 exercicio_50 = new Exercicio50();
                            exercicio_50.Executarexerciciocinquenta();
                            break;

                        case 51:
                            Exercicio51 exercicio_51 = new Exercicio51();
                            exercicio_51.Executarexerciciocinquentaeum();
                            break;

                        case 52:
                            Exercicio52 exercicio_52 = new Exercicio52();
                            exercicio_52.Executarexerciciocinquentaedois();
                            break;

                        case 53:
                            Exercicio53 exercicio_53 = new Exercicio53();
                            exercicio_53.Executarexerciciocinquentaetres();
                            break;

                        case 54:
                            Exercicio54 exercicio_54 = new Exercicio54();
                            exercicio_54.Executarexerciciocinquentaequatro();
                            break;

                        case 55:
                            Exercicio55 exercicio_55 = new Exercicio55();
                            exercicio_55.Executarexerciciocinquentaecinco();
                            break;

                        case 56:
                            Exercicio56 exercicio_56 = new Exercicio56();
                            exercicio_56.Executarexerciciocinquentaeseis();
                            break;

                        case 57:
                            Exercicio57 exercicio_57 = new Exercicio57();
                            exercicio_57.Executarexerciciocinquentaesete();
                            break;

                        case 58:
                            Exercicio58 exercicio_58 = new Exercicio58();
                            exercicio_58.Executarexerciciocinquentaeoito();
                            break;

                        case 59:
                            Exercicio59 exercicio_59 = new Exercicio59();
                            exercicio_59.Executarexerciciocinquentaenove();
                            break;

                        case 60:
                            Exercicio60 exercicio_60 = new Exercicio60();
                            exercicio_60.Executarexerciciosessenta();
                            break;

                        case 61:
                            Exercicio61 exercicio_61 = new Exercicio61();
                            exercicio_61.Executarexerciciosessentaeum();
                            break;

                        case 62:
                            Exercicio62 exercicio_62 = new Exercicio62();
                            exercicio_62.Executarexerciciosessentaedois();
                            break;

                        case 63:
                            Exercicio63 exercicio_63 = new Exercicio63();
                            exercicio_63.Executarexerciciosessentaetres();
                            break;

                        case 64:
                            Exercicio64 exercicio_64 = new Exercicio64();
                            exercicio_64.Executarexerciciosessentaequatro();
                            break;
                    }
                }
            } while (true);
        }
    }
}
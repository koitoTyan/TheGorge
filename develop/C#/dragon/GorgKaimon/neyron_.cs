using GorgKaimon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace GorgKaimon
{
    
    #region ПОДКЛАССЫ

    /*
        объедени операции добавления и удаления базы и буфера, оставив 
        разделение только в _unsafe- коде
    */
    public delegate int fn();
    public delegate int fn_return_digital(int arg);
    public delegate T[] fn_data<T>(T[] DATA);
   /*
    public class DATA
    {
        public char data_type;
    }
    */
    public class prototype<F>
    {
        public prototype(F type) { }
        public neyron_<F> _get_neyron(F type, neyron_<F> neyron)
        {
            return neyron;
        }
    }

    struct neyrs
    {
        public neyrs(char Type, object val)
        {
            type = Type; value = val; _fn = null;
            data_ret = null;
            _fn = null_;            
        }
        public char type { get; set; }
        public object value { get; set; }
        public fn _fn { get; set; }
        private int null_() { return 0; }
        public object data_ret { get; set; }
    }
    public delegate int width__(List<int> w, List<string> w_n);
    public class neyron_<T>
    {
        //public string Name;
        //public fn Func;
        public char NEYRON_TYPE;
        //public fn_return_digital __func;
        //public fn_data<T> __operate_data;
        //public width__ width__function;
        //public int _width_fn()
        //{
        //    return width__function(width, width_name);
        //}
        //List<neyrs> neyron__;
        //public int input_data;
        neyrs NEY;
        //DATA d;
        T[] Data;

        public List<int> width;
        public List<string> width_name;
        public int __search_for_width_name(string name)
        {
            for (int i = 0; i < width_name.Count; i++)
            {
                if (name == width_name[i])
                    return i;
            }
            return -1;
        }
        public void __add_width(int width_, string name) { width.Add(width_); width_name.Add(name); }
        public void __remove_width(string name)
        {
            for (int i = 0; i < width_name.Count; i++)
            {
                if(name == width_name[i])
                {
                    width_name.RemoveAt(i);
                    width.RemoveAt(i);
                    break;
                }
            }
        }

        //public void _add__<F>(F type, neyron_<F> neyron)
        //{
        //    char types = '\0';
        //    if (type.GetType() == typeof(string))
        //    {
        //        types = 's';
        //    }
        //    if (type.GetType() == typeof(int))
        //    {
        //        types = 'i';
        //    }
        //    if (type.GetType() == typeof(double))
        //    {
        //        types = 'd';
        //    }

        //    //neyron__.Add(new neyrs(types, neyron));
        //}

        //public T[] func__data_()
        //{
        //    return __operate_data(Data);
        //}

        //public void _func()
        //{
        //    Func();
        //}
        //public int _r_func()
        //{
        //    return Func();
        //}
        
        //public void _update_input_data(int input)
        //{
        //    input_data = input;
        //}

        //public int __func_input__()
        //{
        //    return __func(input_data);
        //}

        public neyron_(T DATA_TYPE)
        {
            //NEY = new neyrs();      
            if (DATA_TYPE.GetType() == typeof(string))
            {                
                NEY.type = 's';
            }
            if (DATA_TYPE.GetType() == typeof(int))
            {
                NEY.type = 'i';
            }
            if (DATA_TYPE.GetType() == typeof(double))
            {
                NEY.type = 'd';
            }
            //neyron__ = new List<neyrs>();
            width = new List<int>();
            width_name = new List<string>();
        }

        public Type _return_data_type()
        {
            switch (NEY.type)
            {
                case 'i': int i=0; return i.GetType(); break;
                case 'd': double d = 0; return d.GetType(); break;
            }
            return new string(new char[] { }).GetType();
        }

        public void _recv_data(T[] data_s)
        {
            Data = data_s;
        }
        public T[] _send_data()
        {
            return Data;     
        }

        public void _add_recv_data(T[] DATAS)
        {
            T[] d = new T[DATAS.Length + Data.Length];
            int i = 0, k = 0;
            for (; i < DATAS.Length; i++)
            {
                d[i] = DATAS[i];
            }
            for (; k < Data.Length; k++, i++)
            {
                d[i] = Data[k];
            }
            Data = d;
        }
    }
       

    public class NeyGorge
    {
        private neyron_<int> MAIN_NEYRON;

        public void CREATE_TABLE_BRANCH_FROM_MAIN_NEYRON(string name, int count_sheet, int[] neyrons)
        {
            Branch br = new Branch(name);

            int[] limit = GET_LIMIT_FROM_MAIN_NEYRON(count_sheet);

            int[,] element = GET_ID_ELEMENT_TO_LIMIT_VALUE(limit);

            //int id = neyrons__.Count;

            for (int i = 1; i < neyrons.Length; i++)
                br.Add(i.ToString(), neyrons[i], neyrons[i - 1], limit, element);

            branchs.Add(br);            
        }
        
        public void LEARN_NEYRON(int INDEX_LEARNING_NEYRON)
        {
            neyron_<int> learning = neyrons__[INDEX_LEARNING_NEYRON].Neyron as neyron_<int>;

            for(int i = 0; i < learning.width.Count; i++)
            {
                #region CODE
                bool created = false; int k = 0;
                for (; k < MAIN_NEYRON.width_name.Count; k++)
                    if (k < learning.width_name.Count &&
                        MAIN_NEYRON.width_name[k] == learning.width_name[i])
                            { created = true; break; }
                if (created)
                    if ((MAIN_NEYRON.width[k] + 1) == 0)
                        MAIN_NEYRON.width[k] = 1;
                    else
                        if (learning.width[k] != 0)
                            MAIN_NEYRON.width[k] += 1;
                        else
                            ;
                else
                {
                    MAIN_NEYRON.width_name.Add(learning.width_name[i]);
                    MAIN_NEYRON.width.Add(0);
                }                
                #endregion
            }
        }

        public void LEARN_NEYRON_MINUS(int INDEX_LEARNING_NEYRON)
        {
            neyron_<int> learning = neyrons__[INDEX_LEARNING_NEYRON].Neyron as neyron_<int>;

            for (int i = 0; i < learning.width.Count; i++)
            {
                #region CODE                
                bool created = false; int k = 0;
                for (; k < MAIN_NEYRON.width_name.Count; k++)
                    if (k < learning.width_name.Count &&
                        MAIN_NEYRON.width_name[k] == learning.width_name[i])
                    { created = true; break; }
                if (created)
                    if ((MAIN_NEYRON.width[k] - 1) == 0)
                        MAIN_NEYRON.width[k] = -1;
                    else
                        MAIN_NEYRON.width[k] -= 1;
                //else
                //{
                //    MAIN_NEYRON.width_name.Add(learning.width_name[i]);
                //    MAIN_NEYRON.width.Add(1);
                //}                
                #endregion
            }
        }

        public void MAIN_NEYRON_CLEAR() { MAIN_NEYRON = new neyron_<int>(1); }

        public void SET_WIDTH_ALL_ZERO(int COUNT, int INDEX)
        {
            neyron_<int> n = new neyron_<int>(0);
            for(int i = 0; i < COUNT; i++)
            { n.width.Add(0); n.width_name.Add("w"+(i+1).ToString()); }
            neyrons__[INDEX] = 
                new Neyron_DB.object_s(
                    n, neyrons__[INDEX].type, 
                    neyrons__[INDEX].get_id(), 
                    neyrons__[INDEX].name_neyron
                );
        }

        public int[] GET_LIMIT_FROM_MAIN_NEYRON(int in_sheet_count)
        {
            List<int> sums = new List<int>();
            int sum = 0;
            int k = 0;
            for (int i = 0; i < MAIN_NEYRON.width.Count; i++, k++)
                if (k >= in_sheet_count)
                { k = 0; sums.Add(sum); sum = 0; sum += MAIN_NEYRON.width[i]; }
                else
                    sum += MAIN_NEYRON.width[i];
            sums.Add(sum);
            return sums.ToArray();
        }

        public int[,] GET_ID_ELEMENT_TO_LIMIT_VALUE(int[] LIMITS)
        {
            int[,] ret_ar = new int[LIMITS.Length, MAIN_NEYRON.width.Count / LIMITS.Length];
            int q = 0;
            for (int i = 0; i < LIMITS.Length; i++)
                for (int k = 0; k < MAIN_NEYRON.width.Count / LIMITS.Length; k++, q++)
                    if (q < MAIN_NEYRON.width.Count &&
                        MAIN_NEYRON.width[q] != 0)
                        ret_ar[i, k] = q;
                    else if (q < MAIN_NEYRON.width.Count)
                        ret_ar[i, k] = -1;
                        

            return ret_ar;
        }
        #region OTHER
        bool position_analyzer;
        public Neyron_DB DATA_BASE;
        private List<Branch> branchs;
        public int[] OK_NEYRON;// нейроны в буффере, которые проходят по лимитам
        List<Neyron_DB.object_s> neyrons__;
        public List<Neyron_DB.object_s> get_buffer() { return neyrons__; }
        private int search_index_to_buffer(string name)
        {
            for (int i = 0; i < neyrons__.Count; i++)
            {
                if (neyrons__[i].name_neyron == name)
                    return i;
            }
            return -1;
        }

        // нерон для небезопасного кода
        Neyron_DB.object_s __unsafe_neyron_buffer;
        //int[] value_;//нейрон(ID), тип(значение(name, value)ID)
        //List<int[]> values_;//нейроны

        //public struct Neyron
        //{
        //    public List<string> name;
        //    public List<int> value_;

        //    public char type;
        //    public string neyron_name;
        //}

        /// <summary>
        /// выполняем итерацию по нейронам нейросети
        /// </summary>
        /// <param name="">текстовое близкое значение</param>
        /// <param name="value_">близкое значение</param>
        //public List<Neyron> search_value(int value_, int limit)
        //{
        //    // перебор по близким словам, если есть - записываем в values_
        //    List<Neyron> __list = new List<Neyron>();
            
        //        List<string> names__ = DATA_BASE.names;

        //        for (int i = 0; i < names__.Count; i++)
        //        {
        //            Neyron_DB.object_s s = DATA_BASE.create_to_name(names__[i]);

        //            switch (s.type)
        //            {
        //                case 'i':
        //                    {
        //                        neyron_<int> neyron_ = s.Neyron as neyron_<int>;
        //                        Neyron n = new Neyron();
        //                        //n.name = neyron_.width_name;
        //                        for (int k = 0; k < neyron_.width.Count; k++)
        //                        {
        //                            if (neyron_.width[k] <= value_ + limit
        //                                && neyron_.width[k] >= value_ - limit)
        //                            {
        //                                n.value_.Add(neyron_.width[k]);
        //                                n.name.Add(neyron_.width_name[k]);
        //                                n.type = 'i';
        //                                n.neyron_name = names__[i];
        //                            }
        //                        }
        //                        __list.Add(n);
        //                    }
        //                    //neyron_
        //                    break;

        //                case 'd':
        //                    {
        //                        neyron_<double> neyron_ = s.Neyron as neyron_<double>;
        //                        Neyron n = new Neyron();
        //                        //n.name = neyron_.width_name;
        //                        for (int k = 0; k < neyron_.width.Count; k++)
        //                        {
        //                            if (neyron_.width[k] <= value_ + limit
        //                                && neyron_.width[k] >= value_ - limit)
        //                            {
        //                                n.value_.Add(neyron_.width[k]);
        //                                n.name.Add(neyron_.width_name[k]);
        //                                n.type = 'd';
        //                                n.neyron_name = names__[i];
        //                            }
        //                        }
        //                        __list.Add(n);
        //                    }
        //                    break;
        //            }
        //        }
            
        //        WORD w = new WORD();
        //        w.SELECT_FROM_FILE("1.txt");
                
        //        //w.
            
        //    return __list;
        //}

        // функции языка

        public NeyGorge()
        {
            MAIN_NEYRON = new neyron_<int>(1);
            branchs = new List<Branch>();
            DATA_BASE = new Neyron_DB();            
            neyrons__ = new List<Neyron_DB.object_s>();
            position_analyzer = true;

            //while (!cons.Created) ;
            //Timer time = new Timer();


            //cons = new Console();
            //time.Interval = 1000;            
            //time.Tick += Time_Tick;
            //time.Start();
        }
        
        /// <summary>
        /// Обработчик комманд
        /// </summary>
        /// <param name="action"></param>
        /// <param name="arg"></param>
        public void act_(string action, string arg)
        {
            
            switch (action)
            {
                case "add-": neyrons__.Add(new Neyron_DB.object_s(new neyron_<int>(1),
                    'i', -1, arg)); break;//добавить
                case "defer-": neyrons__.Add(search_neyron(arg)); break;
                    //отложить
                    // add- d_gorge
                    // add- i_gorge
                    // add- str_gorge
                case "remove-": remove_neyron(arg); act_("buffer-", "remove_" + arg); break;
                //change_index: w1name<value> w2name<value> ... wNname<value>
                case "change-": change_neyron(arg, neyrons__);  break;
                //изменить
                // "0:w1<32>"
                // "0->1" // ошибка в нуле, повысить не схожий (если нет - один из схожих) вес
                // "0<-1" // ошибка в нуле, понизить не схожий (если нет - один из схожих) вес
                case "buffer-": buffer_control(arg);
                    if (arg.Trim().StartsWith("clear"))
                    {
                        DATA_BASE.names = new List<string>();
                        DATA_BASE.__clear_stek();                       
                    }
                    break;
                case "test_limit-": OK_NEYRON = test_limit(arg);
                    // test_limit- ID0: LIMIT, ID1: LIMIT, ID2: LIMIT
                    break;
                case "branch-": branch_control(arg);
                    // branch- add- NAME(ID, ID, ID)
                    // branch- remove-
                    break;
                //bufferCommand_arg
                // clear_
                // remove_1, remove_0, remove_2, ..., remove_N


                //fast_create- ИМЯ: КОЛВО_ВЕСОВ
                case "fast_create-":
                    {
                        arg = arg.Trim();
                        string name = arg.Split(':')[0];
                        int w_count = Convert.ToInt32(arg.Split(':')[1]);
                        int index = neyrons__.Count;
                        act_("add-", name);
                        SET_WIDTH_ALL_ZERO(w_count, index);
                    } break;

                // main_to- ИМЯ
                // присваиваем main нейрону значения из другого нейрона
                case "main_to-":
                    {
                        arg = arg.Trim();
                        for(int i = 0; i < neyrons__.Count; i++)
                            if(arg == neyrons__[i].name_neyron)
                            {
                                LEARN_NEYRON(i);
                            }
                    } break;
                case "main_clear-": MAIN_NEYRON_CLEAR(); break;
                // branch_from_main- 2: { 1, 2, 3, 4,...,N } (либо имена вместо циферок) 
                case "branch_from_main-":  branch_from_name(arg); break;
                case "last_branch_rename-": branchs[branchs.Count - 1].name = arg.Trim(); break;


                // main_from_branch- BRANCH_NAME 
                case "main_from_branch-": {
                        arg = arg.Trim();
                        for (int i = 0; i < branchs.Count; i++)
                            if (branchs[i].name == arg)
                                SET_MAIN_FROM_BRANCH(i);
                    } break;

                case "_unsafe-":
                    _unsafe_code(arg);
                    break;
                default:
                    break;
            }
        }

        private void SET_MAIN_FROM_BRANCH(int indx)
        {
            
        }

        private void branch_from_name(string arg)
        {
            arg = arg.Trim();
            int sheet_value = Convert.ToInt32(arg.Split(':')[0]);

            string[] IDs = arg.Split(':')[1].Split('{')[1].Split('}')[0].Split(',');


            int[] Ids = new int[IDs.Length];

            for (int i = 0; i < Ids.Length; i++)
            {
                Ids[i] = Convert.ToInt32(IDs[i]);
            }

            string str = branchs.Count.ToString();


            CREATE_TABLE_BRANCH_FROM_MAIN_NEYRON(str, sheet_value, Ids);
        }

        private string branch_control(string arg)
        {
            string arg_r = "";
            string command = arg.Split('-')[0].Trim() + "-";
            switch (command)
            {
               
            } return arg_r;
        }
        private bool test_limit_bool(neyron_<int> n, int limit)
        {
            int summ = 0;
            for (int i = 0; i < n.width.Count; i++)
                summ += n.width[i];
            if (summ >= limit)
                return true;
            return false;
        }

        /// <summary>
        /// тестируем лимиты и возвращаем индексы тех, кто проходит, если длинна массива ноль - значит не один
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private int[] test_limit(string arg)
        {
            List<int> return_arg = new List<int>();
            string[] args_ = arg.Split(',').ToArray();
            for (int i = 0; i < args_.Length; i++)
            {
                args_[i] = args_[i].Trim();
                string[] ar_ = args_[i].Split(':').ToArray();

                ar_[0] = ar_[0].Trim();
                ar_[1] = ar_[1].Trim();

                bool is_word = false;

                int ID =    -1;// Convert.ToInt32(ar_[0]);
                for(int q = 0; q <ar_[0].Length; q++)
                {
                    if(Char.IsDigit(ar_[0][q]) == false)
                    {
                        is_word = true;

                        ID = search_index_to_buffer(ar_[0]);
                    }
                }
                if (!is_word && ar_[0].Length != 0 && 
                    ar_[0] != "\0" && ar_[0] != " ")
                    ID = Convert.ToInt32(ar_[0].Trim());
                else if (ID == -1)
                    continue;
                // предположим что не может быть ошибок... 
                ar_[1] = ar_[1].Trim(new char[] {
                ' ', '\n', '\0' });

                is_word = false;
                int LIMIT;
                for (int y = 0; y < ar_[1].Length; y++)
                {
                    if (Char.IsDigit(ar_[1][y]) == false && ar_[1][y] != '-')
                    {
                        is_word = true; break;
                    }
                }
                if (is_word)
                    continue;

                LIMIT = Convert.ToInt32(ar_[1]);
                
                switch (neyrons__[ID].type)
                {
                    case 'i':
                        {
                            neyron_<int> n = neyrons__[ID].Neyron as neyron_<int>;
                            int summ = 0;
                            for (int k = 0; k < n.width.Count; k++)
                            {
                                summ += n.width[k];
                            }
                            if (summ > LIMIT)
                                return_arg.Add(i);//что-то тут в случае если нейрон проходит
                        }
                        break;

                    case 'd':
                        {
                            neyron_<double> n = neyrons__[ID].Neyron as neyron_<double>;
                            int summ = 0;
                            for (int k = 0; k < n.width.Count; k++)
                            {
                                summ += n.width[k];
                            }
                            if (summ > LIMIT)
                                return_arg.Add(i);//что-то тут в случае если нейрон проходит
                        }
                        break;
                }
            }
            if(return_arg.Count != 0)
                return return_arg.ToArray();
            return new int[0];
        }


        //public void read_console_command()
        //{
        //    System.Threading.Thread th = new System.Threading.Thread(read_console_thread);
        //    th.Start();
        //}

        /// <summary>
        /// запуск формочки с консолью
        /// </summary>
        //public void read_console_thread()
        //{
        //    cons = new Console();
        //    cons.Show();
        //}

        //private void Time_Tick(object sender, EventArgs e)
        //{
        //    Timer time_ = sender as Timer;
        //    if (cons.IsDisposed == false && cons.Created == true)
        //    {
        //        if(cons.command_ != "" && cons.command_ != null)
        //        {
        //            cons.listBox1.Items.Clear();
        //            cons.listBox1.Items.Add("Ожидайте выполнения комманды...");
        //            string[] command = cons.command_.Split('-').ToArray();
        //            command[0] += "-";
        //            string command_s = "";
        //            if (command.Length > 2)
        //            {
        //                for (int i = 1; i < command.Length; i++)
        //                {
        //                    if (i < command.Length - 1)
        //                        command_s += command[i] + "-";
        //                    else command_s += command[i];
        //                }
        //            }
        //            else command_s = command[1];
        //            act_(command[0], command_s);
        //            cons.listBox1.Items.Add("Комманда выполнена успешно!");
        //            cons.command_ = "";                    
        //        }
        //    }                
        //}

        /// <summary>
        /// удаление элементов из буфера
        /// </summary>
        /// <param name="commands">clear_ - полное очищение, remove(ID) - удаление из буфера по индексу</param>
        public void buffer_control(string commands)
        {
            commands = commands.Trim();
            string[] so_command = commands.Split('_').ToArray();
            switch (so_command[0])
            {
                case "clear":
                    neyrons__ = new List<Neyron_DB.object_s>();                    
                    break;
                case "remove":
                    int i = -1;
                    for (int k = 0; k < neyrons__.Count; k++)
                        if (neyrons__[k].name_neyron == so_command[1])
                        { i = k; break; }
                    if (i < neyrons__.Count && i != -1)
                        neyrons__.RemoveAt(i);
                    break;
                    
                default:
                    break;
            }
            /*if (commands == "clear")
                neyrons__ = new List<Neyron_DB.object_s>();
            else if (commands == "") */
        }
        

        /// <summary>
        /// Небезопасный код! (следующие обновления добавляют сюда код для теста, и стабильный код входит в safe-API код)
        /// </summary>
        /// <param name="text"></param>
        public void _unsafe_code(string text)
        {
            #region COMMENT
            /*string[] name_args = text.Split(' ').ToArray();

            string args = "";
            for (int i = 1; i < name_args.Length; i++)
            {
                args += name_args;
            }
            */



            // -> // _unsafe- buffer+=values
            // _unsafe- new neyron = type_name
            // _unsafe- neyron: widthName1<value>, ... , widthTypeN<value>

            // _unsafe- buffer add(neyron)
            // _unsafe- buffer_read(index)
            // _unsafe- buffer_write(index)<-value

            // _unsafe- thread_TYPE ACTIVE(BREAK)


            // _unsafe- neyron=buffer_read(index)

            // _unsafe- merger(neyron1, neyron2,...,neyronN)-name:
            // merger - слияние

            #endregion
            
            string[] keywords = new string[] 
            { "buffer", "thread", "merger", "new" };// new - новый нейрон тип_имя

            for (int i = 0; i < keywords.Length; i++)
            {
                if(check_word(text, keywords[i]))
                {
                    switch (keywords[i])
                    {
                        case "buffer": // а мне это нравится, войдёт в safe код
                            // тут нечего дополнить, всё в комменте
                            #region CODE
                            // _unsafe- buffer add  //(neyron)
                            // _unsafe- buffer_read(index)
                            // _unsafe- buffer_write(index)  //<-value                
                            string[] __text = text.Split(' ').ToArray();

                            for (int k = 0; k < __text.Length; k++)
                            {
                                if(check_word(__text[i], "add"))
                                {                                    
                                    neyrons__.Add(__unsafe_neyron_buffer);
                                }
                                else if(check_word(__text[k], "buffer_read"))
                                {
                                    string stext_ = text.Split(' ')[k].
                                        Split('(')[1].Split(')')[0];
                                    for (int g = 0; g < stext_.Length; g++)
                                    {
                                        if (Char.IsDigit(stext_[g]) == false)
                                            return;
                                    }
                                    __unsafe_neyron_buffer = neyrons__[
                                        Convert.ToInt32(stext_)];

                                } else if (check_word(__text[k], "buffer_write"))
                                {

                                    string stext_ = text.Split(' ')[k].
                                        Split('(')[1].Split(')')[0].Trim();
                                    for (int g = 0; g < stext_.Length; g++)
                                    {
                                        if (Char.IsDigit(stext_[g]) == false)
                                            return;
                                    }
                                    neyrons__[
                                        Convert.ToInt32(stext_)
                                        ] = __unsafe_neyron_buffer;
                                } else if (check_word(__text[k], "buffer_remove"))
                                {
                                    string stext_ = text.Split(' ')[k].
                                        Split('(')[1].Split(')')[0].Trim();
                                    for (int g = 0; g < stext_.Length; g++)
                                    {
                                        if (Char.IsDigit(stext_[g]) == false)
                                            return;
                                    }
                                    int index__ = Convert.ToInt32(stext_);
                                    if (index__ < neyrons__.Count)
                                        neyrons__.RemoveAt(index__);
                                }
                            }
                            #endregion
                            break;

                        case "merger": // больно будет проверять..........
                            // merger(ID, ID, ID)
                            #region CODE
                            {
                                string[] merge_neyron_id = text.Split('(').ToArray()
                                    [1].Split(')')[0].
                                    Split(',').ToArray();
                                if (merge_neyron_id.Length == 0)
                                    return;
                                Neyron_DB.object_s neyro = 
                                    new Neyron_DB.object_s
                                    (
                                        new neyron_<int>(0),
                                        'i', -1, "UnsafeIntNeyron"
                                    );

                                for (int q = 0; q < merge_neyron_id.Length; q++)
                                {
                                    merge_neyron_id[q] = merge_neyron_id[q].Trim();
                                    if (merge_neyron_id[q].Length == 0 || 
                                        merge_neyron_id[q] ==
                                        "" || merge_neyron_id[q] == null)
                                        continue;

                                    // больно будет это проверять...

                                    #region Добавляем веса..... 
                                    for (int oi = 0; oi < (neyrons__[Convert.ToInt32(merge_neyron_id[q])].Neyron as neyron_<int>).width.Count; oi++)
                                    {
                                        (neyro.Neyron as neyron_<int>).
                                                width.Add((neyrons__[
                                                    Convert.ToInt32(merge_neyron_id[q])
                                                    ]
                                                        .Neyron as neyron_<int>
                                                )
                                         .width[oi]);
                                        // представляем neyro как нейрон типа инт, далее по индексу 
                                        // находим нейрон, представляем как нейрон типа инт
                                        // ну и наконец выводим вес...
                                        (neyro.Neyron as neyron_<int>).
                                                width_name.Add((neyrons__[
                                                    Convert.ToInt32(merge_neyron_id[q])
                                                    ]
                                                        .Neyron as neyron_<int>
                                                )
                                         .width_name[oi]);
                                    }                                    

                                    #endregion
                                }
                                __unsafe_neyron_buffer = neyro;
                            }
                            #endregion
                            break;

                        case "thread": // трудно будет дополнять..........
                            // thread_TYPE ACTIVE(BREAK)
                            #region CODE
                            {

                                string type = text.Split('_')[1].Split(' ')[0];
                                string action = text
                                    .Split('_')[1]
                                    .Split(' ')[1]
                                    .Trim().ToUpper();

                                switch (type)
                                {
                                    //case "console":
                                    //    {
                                    //        if(action == "ACTIVE")
                                    //        {
                                    //            if (cons.IsDisposed == false || cons.Created == true)
                                    //                ;
                                    //            else
                                    //            {
                                    //                cons = new Console();
                                    //                cons.Show();
                                    //            }
                                    //        } else if(action == "BREAK")
                                    //        {
                                    //            if (cons.IsDisposed || cons.Created == false)
                                    //                ;
                                    //            else cons.Dispose();
                                    //        }
                                    //    }
                                    //    break;
                                }
                            }
                            #endregion
                            break;

                        default:
                            break;
                    }
                }
            }
            //return new Neyron_DB.object_s(null, '\0', -1);
        }

        /// <summary>
        /// есть ли искомое слово в строке для проверки
        /// </summary>
        /// <param name="text">строка для проверки</param>
        /// <param name="text_s">искомое слово</param>
        /// <returns></returns>
        private bool check_word(string text, string text_s)
        {
            char[] text_array = text.ToCharArray();
            char[] text_s_array = text_s.ToCharArray();

            for (int i = 0, k = 0; i < text_array.Length; i++)
            {
                if (i >= text_array.Length)
                    return false;
                if (text_array[i] == text_s_array[k])
                { k++;  if (k >= text_s_array.Length) return true; }
                else { k = 0; }
            }
            return false;
        }

        /// <summary>
        /// есть ли искомое слово в строке для проверки, возврат конца искомого (последняя буква)
        /// </summary>
        /// <param name="text">строка для проверки</param>
        /// <param name="text_s">искомое слово</param>
        /// <returns></returns>
        private int check_word_and_return_index_end(string text, string text_s)
        {
            char[] text_array = text.ToCharArray();
            char[] text_s_array = text_s.ToCharArray();

            for (int i = 0, k = 0; i < text_array.Length; i++)
            {
                if (i >= text_array.Length)
                    return -1;
                if (text_array[i] == text_s_array[k])
                { k++; if (k >= text_s_array.Length) return i; }
                else { k = 0; }
            }
            return -1;
        }


        public void test()
        {
            // _unsafe- new neyron = type_name
            // _unsafe- neyron: widthName1<value>, ... , widthTypeN<value>
            // _unsafe- buffer add(neyron)
            // _unsafe- buffer_read(index)
            // _unsafe- buffer_write(index)<-value
            // _unsafe- thread_TYPE ACTIVE(PASSIVE)
            // _unsafe- neyron=buffer_read(index)
            // _unsafe- merger(neyron1, neyron2,...,neyronN)-name:
            // merger - слияние
            //act_("add-", "d_gorge");
            //act_("add-", "i_morge");
            //act_("add-", "str_rodger");
            //act_("add-", "d_c##");
            /* act_("defer-", "gorge");
            act_("defer-", "morge");
            act_("defer-", "rodger");
            act_("defer-", "c##");
            act_("change-", "0:w1<32>");
            act_("change-", "1:w2<32>");
            act_("change-", "2:w3<32>");
            act_("change-", "3:w4<32>");
            _unsafe_code("buffer_read(3)");
            //_unsafe_code("buffer_write(1)");
            //_unsafe_code("merger(0, 1)");
            act_("remove-", "gorge"); */
            //act_("buffer-", "clear_");
            //read_console_thread();
            neyrons__ = new List<Neyron_DB.object_s>();
            //neyrons__.Add(new Neyron_DB.object_s(null, 'n', 0));
            __unsafe_neyron_buffer = new Neyron_DB.object_s(new neyron_<double>(0.0), 'd', 0, null);
            //_unsafe_code("buffer_read(0)");
        }
        /// <summary>
        /// Добавляем нейрон в базу
        /// </summary>
        /// <param name="arg"></param>
        private void add_neyron(string arg)
        {
            string[] args = arg.Split('_').ToArray();
            args[0] = args[0].Trim(); args[1] = args[1].Trim();
            if (args[0] == "d")
            {
                DATA_BASE._add<double>(0.0, args[1]);
            }
            else if (args[0] == "str")
            {
                DATA_BASE._add<string>("", args[1]);
            }
            else if (args[0] == "i")
            {
                DATA_BASE._add<int>(0, args[1]);
            }
        }

        /// <summary>
        /// Создаём буферное представление нейрона, через имя в БД
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private Neyron_DB.object_s search_neyron(string name)
        {
            return DATA_BASE.create_to_name(name);
        }
        /// <summary>
        /// Удаляем нейрон по имени
        /// </summary>
        /// <param name="name"></param>
        private void remove_neyron(string name)
        {            
            DATA_BASE.remove_neyron(name);                        
        }
        /// <summary>
        /// Изменяем веса в нейроне
        /// </summary>
        /// <param name="change_command"></param>
        /// <param name="objs"></param>
        private void change_neyron(string change_command, List<Neyron_DB.object_s> objs)
        {
            #region Комментарий чтобы не забыть
            /*
                public struct object_s {
                    public object Neyron;
                    public char type;
                    private int ID;
                    public object_s(object neyron, char type_, int ID_) {
                        Neyron = neyron;  type = type_; ID = ID_;
                    }
                } 
             */
            //change_index: w1name<value> w2name<value> ... wNname<value>

            #endregion

            

            // "0:w1<32>"
            // "name:w1<32>"
            if (change_command.Split(':').Length > 1)
            {
                #region Код для int, double, string

                string[] str_s = change_command.Split(':').ToArray();
                str_s[0] = str_s[0].Trim();
                int index = -1;
                bool it_s_word = false;
                for (int i = 0; i < str_s[0].Length; i++)
                {
                    if (Char.IsDigit(str_s[0][i]) == false)
                    {
                        // проверка по имени ; воткнуть булевскую чтоль....

                        // реализованноо=-

                        it_s_word = true;
                        if ((index = search_index_to_buffer(str_s[0])) == -1)
                            return;
                        else break;
                    }
                }
                if (!it_s_word)
                    index = Convert.ToInt32(str_s[0]);

                if (objs[index].type == 'i')
                {
                    neyron_<int> n = objs[index].Neyron as neyron_<int>;
                    //int index__ = DATA_BASE.__search_index_neyron(n);

                    string[] commands = str_s[1].Split(' ').ToArray();
                    //string limit_ = str_s[1].Split(';')[1].Trim();

                    for (int i = 0; i < commands.Length; i++)
                    {
                        if (commands[i] == null || commands[i] == "")
                            continue;
                        string[] name_value = commands[i].Split('<').ToArray();
                        string[] value_ = name_value[1].Split('>').ToArray();
                        // value_[0] -> значение между '<' и '>'
                        int id = n.__search_for_width_name(name_value[0]);
                        if (id == -1)
                        {
                            n.width.Add(Convert.ToInt32(value_[0]));
                            n.width_name.Add(name_value[0]);                            
                            //DATA_BASE.re_int_neyrs(n, index__);
                            //DATA_BASE._add<double>(0.0, str_s[0]);
                        }
                        else
                        {
                            //DATA_BASE.remove_neyron(str_s[0]);
                            //int index__ = DATA_BASE._add<double>(0.0, str_s[0]);
                            n.width[id] = Convert.ToInt32(value_[0].Trim());
                            //DATA_BASE.re_int_neyrs(n, index__);
                            //DATA_BASE. косяяяяяяк
                        }
                    }
                    int ID = neyrons__[index].get_id();
                    string s = neyrons__[index].name_neyron;
                    neyrons__[index] = new Neyron_DB.object_s(
                        n, 'i', ID, s);
                }
                #endregion
            } else if (check_word(change_command, "->"))
            {
                #region CODE
                string[] command__ = change_command.Split('-').ToArray();
                command__[0] = command__[0].Trim(new char[] { ' ', '>', '-' });
                command__[1] = command__[1].Trim(new char[] { ' ', '>', '-' });

                int id_1 = 0;
                int id_2 = 0;

                #region присваевам индексы...


                bool is_word = false;
                for (int j = 0; j < command__[0].Length; j++)
                {
                    if (Char.IsDigit(command__[0][j]) == false)
                    {
                        is_word = true;

                        if ((id_1 = search_index_to_buffer(command__[0])) == -1)
                            return;
                        break;
                    }
                }
                if (!is_word)
                {
                    id_1 = Convert.ToInt32(command__[0]);
                }

                is_word = false;
                for (int j = 0; j < command__[1].Length; j++)
                {
                    if (Char.IsDigit(command__[1][j]) == false)
                    {
                        is_word = true;

                        if ((id_2 = search_index_to_buffer(command__[1])) == -1)
                            return;
                        break;
                    }
                }
                if (!is_word)
                {
                    id_2 = Convert.ToInt32(command__[1]);
                }

                // шаблон (см. выше)
                #endregion


                switch (neyrons__[id_1].type)
                {
                    case 'i':
                        {
                            switch (neyrons__[id_2].type)
                            {
                                case 'i':
                                    {
                                        neyron_<int> n1 = neyrons__[id_1].Neyron as neyron_<int>;
                                        neyron_<int> n2 = neyrons__[id_2].Neyron as neyron_<int>;

                                        //анализ не схожих и повышение не схожего веса 
                                        // вес не существует (не схож) если: он равен '0', нету схожего имени

                                        // "0->1" // ошибка в нуле, повысить не схожий (если нет - один из схожих) вес
                                        List<int> indexs_difrent = new List<int>();

                                        for (int i = 0; i < n1.width.Count; i++)
                                        {
                                            if (n1.width[i] == 0)
                                                continue;
                                            bool diffrent = true;
                                            for (int k = 0; k < n2.width.Count; k++)
                                            {
                                                if (n1.width[i] == n2.width[k])
                                                {
                                                    diffrent = false;
                                                    break;
                                                }
                                            }
                                            if (diffrent)
                                                indexs_difrent.Add(i);
                                        }
                                        // если же все равные....
                                        if (indexs_difrent.Count == 0)
                                        {
                                            for (int i = 0; i < n1.width.Count; i++)
                                            {
                                                if (n1.width[i] != 0)
                                                {
                                                    indexs_difrent.Add(i);
                                                }
                                            }
                                        }
                                        //int[] difrent_int_array = indexs_difrent.ToArray();

                                        // тут будет сортировка массива по возрастанию

                                        for (int i = 0; i < indexs_difrent.Count; i++)
                                        {
                                            if (i == indexs_difrent.Count - 1)
                                                ;//последний элемент
                                            else if (n1.width[indexs_difrent[i]] > n1.width[indexs_difrent[i + 1]])
                                            {
                                                int gost_value = indexs_difrent[i];
                                                indexs_difrent[i] = indexs_difrent[i + 1];
                                                indexs_difrent[i + 1] = gost_value;
                                            }
                                        }
                                        // теперь мы точно знаем что в '0' (n1) нету нулевых весов 
                                        // и веса отсортированны по возрастанию

                                        // теперь мы будем :
                                        // "0->1" // ошибка в нуле, повысить не схожий (если нет - один из схожих) вес

                                        /*
                                        for(int i = 0; i < indexs_difrent.Count; i++)
                                        {
                                            
                                        }
                                        */

                                        if (n1.width[indexs_difrent[0]] >= 1 || n1.width[indexs_difrent[0]] < -1)
                                        {
                                            n1.width[indexs_difrent[0]] = n1.width[indexs_difrent[0]] + 1;
                                        }
                                        else if (n1.width[indexs_difrent[0]] == -1)
                                        {
                                            n1.width[indexs_difrent[0]] = 1;
                                        }
                                        else
                                            return;
                                        //DATA_BASE.re_int_neyrs(n1, id_1);
                                        neyrons__.Insert(id_1, new Neyron_DB.object_s(n1, 'i', neyrons__[id_1].get_id(), neyrons__[id_1].name_neyron));
                                        DATA_BASE.re_int_neyrs(n1, neyrons__[id_1].get_id());
                                        neyrons__.RemoveAt(id_1 + 1);
                                    }
                                    break;
                                    /*case 'd':
                                        {

                                        } break;
                                        */
                            }
                        }
                        break;/*
                    case 'd':
                        {

                        }
                        break;
                        */
                }
                #endregion
                return;
            }
            else if (check_word(change_command, "<-"))
            {
                #region CODE
                string[] command__ = change_command.Split('-').ToArray();
                command__[0] = command__[0].Trim(new char[] { ' ', '<', '-' });
                command__[1] = command__[1].Trim(new char[] { ' ', '<', '-' });

                int id_1 = -1;
                int id_2 = -1;

                #region присваевам индексы...


                bool is_word = false;
                for (int j = 0; j < command__[0].Length; j++)
                {
                    if (Char.IsDigit(command__[0][j]) == false)
                    {
                        is_word = true;

                        if ((id_1 = search_index_to_buffer(command__[0])) == -1)
                            return;
                        break;
                    }
                }
                if (!is_word)
                {
                    id_1 = Convert.ToInt32(command__[0]);
                }

                is_word = false;
                for (int j = 0; j < command__[1].Length; j++)
                {
                    if (Char.IsDigit(command__[1][j]) == false)
                    {
                        is_word = true;

                        if ((id_2 = search_index_to_buffer(command__[1])) == -1)
                            return;
                        break;
                    }
                }
                if (!is_word)
                {
                    id_2 = Convert.ToInt32(command__[1]);
                }

                // шаблон (см. выше)
                #endregion

                switch (neyrons__[id_1].type)
                {
                    case 'i':
                        {
                            switch (neyrons__[id_2].type)
                            {
                                case 'i':
                                    {
                                        neyron_<int> n1 = neyrons__[id_1].Neyron as neyron_<int>;
                                        neyron_<int> n2 = neyrons__[id_2].Neyron as neyron_<int>;

                                        //анализ не схожих и повышение не схожего веса 
                                        // вес не существует (не схож) если: он равен '0', нету схожего имени

                                        // "0<-1" // ошибка в нуле, понизить не схожий (если нет - один из схожих) вес
                                        List<int> indexs_difrent = new List<int>();

                                        for (int i = 0; i < n1.width.Count; i++)
                                        {
                                            if (n1.width[i] == 0)
                                                continue;
                                            bool diffrent = true;
                                            for (int k = 0; k < n2.width.Count; k++)
                                            {
                                                if (n1.width[i] == n2.width[k] || n1.width[i] == 0)
                                                {
                                                    diffrent = false;
                                                    break;
                                                }
                                            }
                                            if (diffrent)
                                                indexs_difrent.Add(i);
                                        }
                                        // если же все равные....
                                        if (indexs_difrent.Count == 0)
                                        {
                                            for (int i = 0; i < n1.width.Count; i++)
                                            {
                                                if (n1.width[i] != 0)
                                                {
                                                    indexs_difrent.Add(i);
                                                }
                                            }
                                        }
                                        //int[] difrent_int_array = indexs_difrent.ToArray();

                                        // тут будет сортировка массива по возрастанию

                                        for (int i = 0; i < indexs_difrent.Count; i++)
                                        {
                                            if (i == indexs_difrent.Count - 1)
                                                ;//последний элемент
                                            else if (n1.width[indexs_difrent[i]] < n1.width[indexs_difrent[i + 1]])
                                            {
                                                int gost_value = indexs_difrent[i];
                                                indexs_difrent[i] = indexs_difrent[i + 1];
                                                indexs_difrent[i + 1] = gost_value;
                                            }
                                        }
                                        // теперь мы точно знаем что в '0' (n1) нету нулевых весов 
                                        // и веса отсортированны по возрастанию

                                        // теперь мы будем :
                                        // "0<-1" // ошибка в нуле, понизить не схожий (если нет - один из схожих) вес

                                        /*
                                        for(int i = 0; i < indexs_difrent.Count; i++)
                                        {
                                            
                                        }
                                        */

                                        if (n1.width[indexs_difrent[0]] > 1 || n1.width[indexs_difrent[0]] < -1)
                                        {
                                            n1.width[indexs_difrent[0]] = n1.width[indexs_difrent[0]] - 1;
                                        }
                                        else if (n1.width[indexs_difrent[0]] == 1)
                                        {
                                            n1.width[indexs_difrent[0]] = -1;
                                        }
                                        else
                                            return;
                                        //DATA_BASE.re_int_neyrs(n1, id_1);
                                        neyrons__.Insert(id_1, new Neyron_DB.object_s(n1, 'i', neyrons__[id_1].get_id(), neyrons__[id_1].name_neyron));
                                        DATA_BASE.re_int_neyrs(n1, neyrons__[id_1].get_id());
                                        neyrons__.RemoveAt(id_1 + 1);
                                    }
                                    break;
                                    /*case 'd':
                                        {

                                        } break;
                                        */
                            }
                        }
                        break;/*
                    case 'd':
                        {

                        }
                        break;
                        */
                }
                #endregion
                return;
            }
        }

        #endregion
    }
    public struct Stek { public int ID; public char type; }
    public class Branch
    {
        //public List<int> id_neyrons;//нейкон к которому обращаются

        public string name;

        //public bool branch_result;

        private List<string> step_name;

        //private List<int>       id_equalse_neyron;
        private List<int[]> id_way;
        private int[] limit_value;
        private int[,] id_element;


        ///// <summary>
        ///// Запуск по ветке
        ///// </summary>
        ///// <param name="buffer">буффер</param>
        ///// <param name="plus_minus">погрешность</param>
        ///// <returns></returns>
        //public string sStart(List<Neyron_DB.object_s> buffer, int plus_minus)
        //{
        //    string arg_return = "";

        //    int step_by = 0;

        //    //int this_way = 1;

        //    int step_id = id_way[step_by][0];
        //    int id_neyron = id_way[step_by][1];

        //    int MAX_VALUE_VALUE = 0;
        //    int MAX_VALUE_ID = 0;

        //    int[] limits = limit_value[step_id];

        //    Neyron_DB.object_s obj = buffer[id_neyron];
        //    neyron_<int> n = obj.Neyron as neyron_<int>;

        //    //bool its_end = false;

        //    while (true)
        //    {
        //        if (step_by >= id_way.Count)
        //            break;

        //        step_id = id_way[step_by][0];
        //        id_neyron = id_way[step_by][1];

        //        if (id_neyron == -1 ||
        //            step_id == -1)
        //        {
        //            //its_end = true;
        //            break;
        //        }

        //        limits = limit_value[step_id];
        //        int[,] elements = id_element[step_id];

        //        int k = 0;
        //        int q = 0;

        //        for (int i = 0; i < limits.Length; i++)
        //        {
        //            k = 0;
        //            for (int e = 0; e < elements.Length / limits.Length; e++)
        //            {
        //                // + neyrons__.summ                        
        //                k += n.width[elements[i, e]];
        //            }

        //            if (k >= limits[i])
        //                q++;
        //        }
        //        if ((q + plus_minus) >= limits.Length && step_by < buffer.Count)
        //        {
        //            obj = buffer[id_neyron];

        //            if((q + plus_minus) > MAX_VALUE_VALUE)
        //            {
        //                MAX_VALUE_VALUE = q;
        //                MAX_VALUE_ID = id_neyron;
        //            }
                    
        //            obj = buffer[id_neyron];

        //            step_by += 1;                    
        //        }
        //        else
        //            break;
        //    }
        //    arg_return += arg_return += "Последний нейрон приближенный по значению: '" + buffer[MAX_VALUE_ID].name_neyron + "' равны " + MAX_VALUE_VALUE.ToString() + " лимита(ов) из " + limits.Length + "ти(х)" + "info: ID- " + MAX_VALUE_ID.ToString();
        //    return arg_return;
        //}


        public bool bStart(List<Neyron_DB.object_s> buffer, int plus_minus)
        {
            //string arg_return = "";

            int step_by = 0;

            //int this_way = 1;

            int step_id = id_way[step_by][0];
            int id_neyron = id_way[step_by][1];

            int MAX_VALUE_VALUE = 0;
            int MAX_VALUE_ID = 0;

            int[] limits = limit_value;

            Neyron_DB.object_s obj = buffer[id_neyron];
            neyron_<int> n = obj.Neyron as neyron_<int>;

            //bool its_end = false;

            while (true)
            {
                if (step_by >= id_way.Count)
                    break;

                step_id = id_way[step_by][0];
                id_neyron = id_way[step_by][1];

                
                limits = limit_value;
                int[,] elements = id_element;

                int k = 0;
                int q = 0;

                for (int i = 0; i < limits.Length; i++)
                {
                    k = 0;
                    for (int e = 0; e < elements.Length / limits.Length; e++)
                    {
                        // + neyrons__.summ      
                        if (elements[i, e] == -1)
                            continue;                  
                        k += n.width[elements[i, e]];
                    }

                    if ((k + plus_minus) >= limits[i])
                        q++;
                }
                if (q >= limits.Length && step_by < buffer.Count)
                {
                    obj = buffer[id_neyron];

                    if ((q + plus_minus) > MAX_VALUE_VALUE)
                    {
                        MAX_VALUE_VALUE = q;
                        MAX_VALUE_ID = id_neyron;
                    }

                    obj = buffer[id_neyron];

                    step_by += 1;
                }
                else if (step_by + 1 < buffer.Count)
                { step_by++; continue; }
                else
                    break;
            }
            //arg_return += arg_return += "Последний нейрон приближенный по значению: '" + buffer[MAX_VALUE_ID].name_neyron + "' равны " + MAX_VALUE_VALUE.ToString() + " лимита(ов) из " + limits.Length + "ти(х)" + "info: ID- " + MAX_VALUE_ID.ToString();
            if ((MAX_VALUE_VALUE + plus_minus) > limits.Length)
                return true;
            return false;
        }


        ///// <summary>
        ///// 1 - ID, 2 - VALUE, 3 - result (1-true, 0 - false)
        ///// </summary>
        ///// <param name="buffer"></param>
        ///// <param name="plus_minus"></param>
        ///// <returns></returns>
        //public int[] arStart(List<Neyron_DB.object_s> buffer, int plus_minus)
        //{
        //    int step_by = 0;

        //    //int this_way = 1;

        //    int step_id = id_way[step_by][0];
        //    int id_neyron = id_way[step_by][1];

        //    int MAX_VALUE_VALUE = 0;
        //    int MAX_VALUE_ID = 0;

        //    int[] limits = limit_value[step_id];

        //    Neyron_DB.object_s obj = buffer[id_neyron];
        //    neyron_<int> n = obj.Neyron as neyron_<int>;

        //    //bool its_end = false;

        //    while (true)
        //    {
        //        if (step_by >= id_way.Count)
        //            break;

        //        step_id = id_way[step_by][0];
        //        id_neyron = id_way[step_by][1];

        //        if (id_neyron == -1 ||
        //            step_id == -1)
        //        {
        //            //its_end = true;
        //            break;
        //        }

        //        limits = limit_value[step_id];
        //        int[,] elements = id_element[step_id];

        //        int k = 0;
        //        int q = 0;

        //        for (int i = 0; i < limits.Length; i++)
        //        {
        //            k = 0;
        //            for (int e = 0; e < elements.Length / limits.Length; e++)
        //            {
        //                // + neyrons__.summ                        
        //                k += n.width[elements[i, e]];
        //            }

        //            if (k >= limits[i])
        //                q++;
        //        }
        //        if ((q + plus_minus) >= limits.Length && step_by < buffer.Count)
        //        {
        //            obj = buffer[id_neyron];

        //            if ((q + plus_minus) > MAX_VALUE_VALUE)
        //            {
        //                MAX_VALUE_VALUE = q;
        //                MAX_VALUE_ID = id_neyron;
        //            }

        //            obj = buffer[id_neyron];

        //            step_by += 1;
        //        }
        //        else
        //            break;
        //    }
        //    //arg_return += arg_return += "Последний нейрон приближенный по значению: '" + buffer[MAX_VALUE_ID].name_neyron + "' равны " + MAX_VALUE_VALUE.ToString() + " лимита(ов) из " + limits.Length + "ти(х)" + "info: ID- " + MAX_VALUE_ID.ToString();
        //    if ((MAX_VALUE_VALUE + plus_minus) > limits.Length)
        //        return new int[] { MAX_VALUE_ID, MAX_VALUE_VALUE, 1};
        //    return new int[] { MAX_VALUE_ID, MAX_VALUE_VALUE, 0 };
        //}

        private int get_summ(List<int> width_)
        {
            int summ = 0;

            for (int i = 0; i < width_.Count; i++)
                summ += width_[i];

            return summ;
        }

        ///// <summary>
        ///// Получаем информирующую строку
        ///// </summary>
        ///// <param name="step_id"></param>
        ///// <returns></returns>
        //public string get_information(int step_id)
        //{
        //    string arg_ret = "";
        //    arg_ret += "'" + step_name[step_id] + "': #" + id_way[step_id].ToString() + " [";

        //    for (int q = 0; q < limit_value[step_id].Count(); q++)
        //    {
        //        for (int i = 0; i < limit_value[step_id].Length; i++)
        //        {
        //            arg_ret += " " + i.ToString() + ": {";
        //            for (int k = 0; k < id_element[step_id].Length / limit_value[step_id].Length; k++)
        //            {
        //                if (k == 0)
        //                {
        //                    arg_ret += " " + id_element[step_id][i, k].ToString();
        //                    continue;
        //                }
        //                arg_ret += ", " + id_element[step_id][i, k].ToString();
        //            }
        //            arg_ret += " }";
        //        }
        //        arg_ret += "<" + limit_value[step_id][q].ToString() + ">";
        //    }
        //    return arg_ret;
        //}

        /// <summary>
        /// получаем имя шага по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string get_stepName_to_ID(int id)
        {
            return step_name[id];
        }

        /// <summary>
        /// количество шагов
        /// </summary>
        /// <returns></returns>
        public int get_stepCount()
        {
            return step_name.Count;
        }

        /// <summary>
        /// Добавление шага
        /// </summary>
        /// <param name="step_name_">Имя шага</param>
        /// <param name="way_id_">ID следующего шага (если прошли лимиты)</param>
        /// <param name="step_id">ID этого шага</param>
        /// <param name="limits_">Лимиты (список лимитов, которые надо пройти)</param>
        /// <param name="neyrons">Список нейронов (1 лимит - несколько нейронов)</param>
        public void Add(string step_name_,
            int way_id_, int step_id,
            int[] limits_, int[,] neyrons)
        {
            step_name.Add(step_name_);
            //id_equalse_neyron.Add(eql_neyronID);
            id_way.Add(new int[] { step_id, way_id_ });
            limit_value = limits_;
            id_element = neyrons;
        }

        /// <summary>
        /// ищем ID по имени шага
        /// </summary>
        /// <param name="_name"></param>
        /// <returns></returns>
        public int searchID_to_stepName(string _name)
        {
            for (int i = 0; i < step_name.Count; i++)
                if (step_name[i] == _name)
                    return i;
            return -1;
        }

        /// <summary>
        /// безопасное (safe) удаление по имени
        /// </summary>
        /// <param name="step_name">имя шага</param>
        public void Remove(string step_name)
        {
            int id = 0;
            if ((id = searchID_to_stepName(step_name)) != -1)
                RemoveAt(id);
        }

        /// <summary>
        /// небезопасное (unsafe) удаление по индексу
        /// </summary>
        /// <param name="step_id"></param>
        public void RemoveAt(int step_id)
        {
            step_name.RemoveAt(step_id);
            //id_element.RemoveAt(step_id);
            //id_equalse_neyron.RemoveAt(step_id);
            id_way.RemoveAt(step_id);
            //limit_value.RemoveAt(step_id);
        }


        //public List<int[,,,]> idEqualseNeyron_idWay_limitValue_idElement;

        //public string limit_name;

        public Branch(string name_)
        {
            name = name_;
            //id_equalse_neyron = new List<int>();
            id_way = new List<int[]>();
            //limit_value = new List<int[]>();
            //id_element = new List<int[,]>();
            step_name = new List<string>();
        }


    }
    public class Neyron_DB
    {
        private List<Branch> neyro_branchs;



        /// <summary>
        /// переименовываем ветку и возвращаем результат операции
        /// </summary>
        /// <param name="new_name">новое имя</param>
        /// <param name="last_branch_name">старое имя</param>
        /// <returns></returns>
        public bool change_name_brench(string new_name, string last_branch_name)
        {
            for (int i = 0; i < neyro_branchs.Count; i++)
            {
                if (neyro_branchs[i].name == last_branch_name)
                {
                    neyro_branchs[i].name = new_name;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// возвращаем ID ветки по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int search_branchID_to_branch_name(string name)
        {
            for (int i = 0; i < neyro_branchs.Count; i++)
            {
                if (neyro_branchs[i].name == name)
                    return i;
            }
            return -1;
        }


        /// <summary>
        /// удаление ветки по индексу (если -1 - удаляем все ветки)
        /// </summary>
        /// <param name="ID"></param>
        public void remove_branch(int ID)
        {
            if (ID == -1)
                neyro_branchs = new List<Branch>();
            else neyro_branchs.RemoveAt(ID);
        }

        /// <summary>
        /// удаление ветки по имени
        /// </summary>
        /// <param name="name"></param>
        public void remove_branch(string name)
        {
            for (int i = 0; i < neyro_branchs.Count; i++)
                if (neyro_branchs[i].name == name)
                {
                    remove_branch(i);
                    return;
                }
        }

        /// <summary>
        /// создать ветку
        /// </summary>
        /// <returns></returns>
        public int add_branch(string name)
        {
            neyro_branchs.Add(new Branch(name));
            return neyro_branchs.Count - 1;
        }




        List<neyron_<string>> neyrn_s__string;
        private List<Stek> stek;
        public List<string> names;

        List<neyron_<int>> neyrn_s__int;
        List<neyron_<double>> neyrn_s__double;
        public void re_double_neyrs(neyron_<double> d_n, int i) { neyrn_s__double[i] = d_n; }
        public void re_int_neyrs(neyron_<int> d_n, int i) { neyrn_s__int[i] = d_n; }
        public void re_string_neyrs(neyron_<string> d_n, int i) { neyrn_s__string[i] = d_n; }
        public int __search_index_neyron(neyron_<double> n__)
        {
            for (int i = 0; i < neyrn_s__double.Count; i++)
            {
                if (n__ == neyrn_s__double[i])
                    return i;
            }
            return -1;
        }
        public int __search_index_neyron(neyron_<int> n)
        {
            for (int i = 0; i < neyrn_s__int.Count; i++)
            {
                if (n == neyrn_s__int[i])
                    return i;
            }
            return -1;
        }
        public int __search_index_neyron(neyron_<string> n)
        {
            for (int i = 0; i < neyrn_s__string.Count; i++)
            {
                if (n == neyrn_s__string[i])
                    return i;
            }
            return -1;
        }
        public Neyron_DB()
        {
            names = new List<string>();
            neyrn_s__string = new List<neyron_<string>>();
            neyrn_s__int = new List<neyron_<int>>();
            neyrn_s__double = new List<neyron_<double>>();
            stek = new List<Stek>();
            neyro_branchs = new List<Branch>();
        }

        public struct object_s
        {
            public object Neyron { get; set; }
            public char type { get; set; }
            private int ID;
            public string name_neyron { get; set; }
            //public int limit { get; set; }
            public object_s(object neyron, char type_, int ID_, string name_)
            {
                Neyron = neyron; type = type_; ID = ID_; name_neyron = name_; 
            }
            public int get_id() { return ID; }
        }
        // нейрон, тип, порядкоый номер в стеке
        public object_s create_to_name(string name)
        {
            name = name.Trim();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == name)
                    if (stek[i].type == 'd')
                        return new object_s(
                            neyrn_s__double[stek[i].ID], 'd', i, name);
                    else if (stek[i].type == 'i')
                        return new object_s(
                            neyrn_s__int[stek[i].ID], 'i', i, name);
                    else if (stek[i].type == 's')
                        return new object_s(
                            neyrn_s__string[stek[i].ID], 's', i, name);
            }
            return new object_s(null, '\0', 0, null);
        }

        public void __clear_stek()
        {
            stek = new List<Stek>();
        }

        public int remove_neyron(string name)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == name)
                {
                    if (stek[i].type == 'd')
                    { neyrn_s__double.RemoveAt(stek[i].ID); stek.RemoveAt(i); }
                    else if (stek[i].type == 'i')
                    { stek.RemoveAt(i); }
                    else if (stek[i].type == 's')
                    { neyrn_s__string.RemoveAt(stek[i].ID); stek.RemoveAt(i); }
                    names.RemoveAt(i);
                    return i;
                }
            }
            return -1;
        }

        public int _add<T>(T neyron, string name)
        {
            if (neyron.GetType() == typeof(double))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__double.Count();
                s.type = 'd';
                stek.Add(s);
                neyrn_s__double.Add(new neyron_<double>(3.14));
            }
            else if (neyron.GetType() == typeof(int))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__int.Count();
                s.type = 'i';
                stek.Add(s);
                neyrn_s__int.Add(new neyron_<int>(0));
            }
            else
            {
                Stek s = new Stek();
                s.ID = neyrn_s__string.Count();
                s.type = 's';
                stek.Add(s);
                neyrn_s__string.Add(new neyron_<string>(""));
            }
            names.Add(name);
            return stek.Count - 1;
        }

        public int _add<T>(T neyron)
        {
            if (neyron.GetType() == typeof(double))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__double.Count();
                s.type = 'd';
                stek.Add(s);
                neyrn_s__double.Add(new neyron_<double>(3.14));
            }
            else if (neyron.GetType() == typeof(int))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__int.Count();
                s.type = 'i';
                stek.Add(s);
                neyrn_s__int.Add(new neyron_<int>(0));
            }
            else
            {
                Stek s = new Stek();
                s.ID = neyrn_s__string.Count();
                s.type = 's';
                stek.Add(s);
                neyrn_s__string.Add(new neyron_<string>(""));
            }
            names.Add((stek.Count - 1).ToString());
            return stek.Count - 1;
        }
        public Stek _get_stek(int index)
        {
            return stek[index];
        }
        public neyron_<string> _get_string_neyron(int index)
        {
            return neyrn_s__string[index];
        }
        public neyron_<int> _get_int_neyron(int index)
        {
            return neyrn_s__int[index];
        }
        public neyron_<double> _get_double_neyron(int index)
        {
            return neyrn_s__double[index];
        }
    }

    #endregion
}
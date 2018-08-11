using GorgKaimon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace GorgKaimon
{
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
    
    class BOXING
    {
        public string string_data;
        public int int_data;
        public double double_data;

        public delegate byte[] __fn_normalize_data();
        //public __fn_normalize_data func;
        public BOXING()
        {
            //func = BOXING_;
        }
        public byte[] _boxing()
        {
            return BOXING_();
        }     
        private byte[] BOXING_()
        {
            int leng_ = 0;
            if (int_data != 0)
                leng_ += 1;
            if (double_data != 0.0)
                leng_ += 1;
            leng_ += string_data.Length;
            byte[] return_arg = new byte[leng_];

            bool int__, double__;
            int__ = double__ = true;
            for (int i = 0; i < leng_; i++)
            {
                if(i >= string_data.Length)
                {
                    if (int_data != 0 && int__)
                    {
                        return_arg[i] = Convert.ToByte(int_data);
                        int__ = false;
                        continue;                       
                    }
                    if (double_data != 0 && double__)
                    {
                        return_arg[i] = Convert.ToByte(double_data);
                        double__ = false;
                        continue;
                    }
                }
                else
                {
                    return_arg[i] = Convert.ToByte(string_data[i]);
                }
            }
            return return_arg;
        }
    }
    class UNBOXING
    {
        public byte[] boxing_;

        public string data_str_;
        public int data_i_;
        //public double data_d_;

        //public delegate void __fn_unboxing(byte[] data);
        //public __fn_unboxing Func;
        public UNBOXING()
        {
            //Func = UNBOX;
        }
        public void _unboxing()
        {
            UNBOX(boxing_);
        }
        private void UNBOX(byte[] data)
        {
            data_str_ = System.Text.Encoding.Default.GetString(data);
            data_i_ = System.Convert.ToInt32(data[0]);
        }
    }

    public class LIMIT
    {
        int limit_arg;
        public LIMIT(int limit_arg_)
        {
            limit_arg = limit_arg_;
        }

        /// <summary>
        /// больше ли значения лимита
        /// </summary>
        /// <param name="value">значение</param>
        /// <returns></returns>
        public bool test_limit(int value)
        {
            if (limit_arg < value)
                return true;
            return false;
        }

        /// <summary>
        /// больше ли значения лимита
        /// </summary>
        /// <param name="value">значение</param>
        /// <returns></returns>
        public bool test_limit(double value)
        {
            if (Convert.ToDouble(limit_arg) < value)
                return true;
            return false;
        }
    }

    public class NeyGorge
    {
        string console_command;
        //bool stop_flag_read_console_command = false;
        //public static Neyron_DB variable_for_thread_starting;
        Console cons;
        bool position_analyzer;
        public Neyron_DB DATA_BASE;
        public int[] OK_NEYRON;// нейроны в буффере, которые проходят по лимитам
        List<Neyron_DB.object_s> neyrons__;
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
            DATA_BASE = new Neyron_DB();            
            neyrons__ = new List<Neyron_DB.object_s>();
            position_analyzer = true;

            //while (!cons.Created) ;
            Timer time = new Timer();


            cons = new Console();
            time.Interval = 1000;            
            time.Tick += Time_Tick;
            time.Start();
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
                case "add-": add_neyron(arg); break;//добавить
                case "defer-": neyrons__.Add(search_neyron(arg, Convert.ToInt32(arg.Split(';')[1].Trim()))); break;
                    //отложить
                    // add- d_gorge
                    // add- i_gorge
                    // add- str_gorge
                case "remove-": remove_neyron(arg); break;
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
                case "_unsafe-":
                    _unsafe_code(arg);
                    break;
                default:
                    break;
            }
        }

        private string branch_control(string arg)
        {
            string arg_r = "";
            string command = arg.Split('-')[0].Trim() + "-";
            switch (command)
            {
                case "add-":
                    {
                        #region CODE
                        // add- name(ID, ID, ID, ID)
                        string text_command = arg.Split('-')[1];

                        string name = text_command.Split('(')[0].Trim();
                        
                        string[] ID_neyron = text_command
                            .Split('(')[1]
                            .Split(')')[0].Trim()
                            .Split(',');
                        List<int> ID_S = new List<int>();
                        for(int i = 0; i < ID_neyron.Length; i++)
                        {
                            bool is_word = false;
                            int ID = -1;
                            for (int k = 0; k < ID_neyron[i].Length; k++)
                                if (Char.IsDigit(ID_neyron[i][k]) == false)
                                {
                                    is_word = true;

                                    ID = search_index_to_buffer(ID_neyron[i].Trim());
                                }
                            if (!is_word)
                                ID = Convert.ToInt32(ID_neyron[i]);
                            ID_S.Add(ID);
                        }


                        int branch_id = DATA_BASE.add_branch(name);
                        for (int i = 0; i < ID_S.Count; i++)
                        {
                            DATA_BASE.add_to_work_branch(ID_S[i], branch_id);
                        }
                        #endregion
                    }
                    break;

                case "remove-":
                    {
                        #region CODE
                        string name = arg.Split('-')[1].Trim();
                        if(name == "_")
                        {
                            DATA_BASE.remove_branch(-1);
                            return "error remove";
                        }
                        //string name = text_command.Split('-')[].Trim();

                        DATA_BASE.remove_branch(name);
                        #endregion
                    }
                    break;
                // change_value-
                case "cnahge_value-":
                    {
                        // ИМЯ(ID, ID, ID): ИМЯ(либо ДРУГОЕ_ИМЯ)(ID, ID, ID)
                        #region CODE
                        string text_program = arg.Split('-')[1].Trim();

                        string one_part = text_program.Split(':')[0];
                        string one_name = one_part.Split('(')[0];

                        string[] one_IDs = one_part
                            .Split('(')[1].Split(')')[0]
                            .Split(',').ToArray();


                        string two_part = text_program.Split(':')[1];
                        string two_name = two_part.Split(':')[0];

                        string[] two_IDs = two_part
                            .Split('(')[1].Split(')')[0]
                            .Split(',').ToArray();
                        int i = 0, k = 0;
                        while(i >= one_IDs.Length && k >= two_IDs.Length)
                        {
                            bool is_word = false;
                            #region проверка символов на буквы..
                                for (int l = 0; l < one_IDs[i].Length; l++)
                                {
                                    if (
                                        (Char.IsDigit(one_IDs[i][l])
                                        || one_IDs[i][l] == '-') == false
                                        )
                                    { is_word = true; break; }
                                }
                                if(!is_word)
                                for (int l = 0; l < two_IDs[k].Length; l++)
                                {
                                    if (
                                        (Char.IsDigit(two_IDs[k][l])
                                        || one_IDs[i][l] == '-') == false
                                        )
                                    { is_word = true; break; }
                                }
                            #endregion
                            if (!is_word)
                            {
                                DATA_BASE.change_id_in_deferent_brench(
                                    DATA_BASE.search_branchID_to_branch_name(
                                        one_name),
                                    DATA_BASE.search_branchID_to_branch_name(
                                        two_name),
                                    Convert.ToInt32(one_IDs[i]),
                                    Convert.ToInt32(two_IDs[k]));
                            }
                            if (i < one_IDs.Length)
                                i++;
                            if (k < two_IDs.Length)
                                k++;
                        }
                        #endregion
                    }
                    break;
                case "add_neyron_to":
                    {
                        // ИМЯ(ID): ID, ID, ID
                        #region CODE
                        



                        #endregion
                    }
                    break;
                case "change_name-":
                    {
                        #region CODE
                        // ИМЯ(ID, ID, ID): ИМЯ(либо ДРУГОЕ_ИМЯ)(ID, ID, ID)
                        // ИМЯ: НОВОЕ_ИМЯ

                        // если обе скобки пустые '()' , то это значит ВСЕ элементы
                        
                        string text_programm = arg.Split('-')[1].Trim();

                        string name_ = text_programm.Split(':')[0];
                        string new_name_ = text_programm.Split(':')[1];

                        DATA_BASE.change_name_brench(new_name_, name_);
                        #endregion
                    }
                    break;
                case "clear-":
                    {
                        #region CODE
                        DATA_BASE.remove_branch(-1);
                        #endregion
                    }
                    break;

                case "start_one-":
                case "start_in_this_thread-":
                case "start_in-":
                    {
                        //выполняем итерации по ветке
                        
                        string name_ = arg.Split('-')[1].Trim();
                        int branch_id =
                            DATA_BASE.search_branchID_to_branch_name(name_);

                        //int[] IDs =
                        //    DATA_BASE.get_IDs_from_branch(
                        //        DATA_BASE.search_branchID_to_branch_name(
                        //            name_));
                        //Neyron_DB.object_s kon_logic = DATA_BASE.

                        int[] kon_logics = 
                            DATA_BASE.get_kon_logics_neyron_to_branchID(branch_id)
                            .ToArray();

                        int[][] layer_neyron =
                            DATA_BASE.get_layer_neyron_to_branchID(branch_id)
                            .ToArray();//массив массивов

                        int[][] limits =
                            DATA_BASE.get_limits_from_branchID(branch_id)
                            .ToArray();

                        int[][] limit_ways =
                            DATA_BASE.get_limit_way_from_branchID(branch_id)
                            .ToArray();

                        int logic_index   = 0;


                        int layer_index   = 0;
                        int layer_element = 0;


                        int limit_index   = 0;
                        int limit_element = 0;


                        int true_index    = 0;
                        int true_answer   = 0;


                        while (true)
                        {                           
                            
                            Neyron_DB.object_s neyron =
                               neyrons__[kon_logics[logic_index]];

                            neyron_<int> kon_logic = neyron.Neyron as neyron_<int>;
                            
                            for(int i = 0; i < layer_neyron[kon_logics[logic_index]].Length; i++)
                            {
                                neyron_<int> other_neyron = neyrons__
                                    [layer_neyron[kon_logics[logic_index]][i]]
                                        .Neyron as neyron_<int>;
                                
                                for(int width_i = 0; width_i < kon_logic.width.Count; width_i++)
                                {

                                }
                            }
                        }
                    }
                    break;
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
        public void read_console_thread()
        {
            cons = new Console();
            cons.Show();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Timer time_ = sender as Timer;
            if (cons.IsDisposed == false && cons.Created == true)
            {
                if(cons.command_ != "" && cons.command_ != null)
                {
                    cons.listBox1.Items.Clear();
                    cons.listBox1.Items.Add("Ожидайте выполнения комманды...");
                    string[] command = cons.command_.Split('-').ToArray();
                    command[0] += "-";
                    string command_s = "";
                    if (command.Length > 2)
                    {
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (i < command.Length - 1)
                                command_s += command[i] + "-";
                            else command_s += command[i];
                        }
                    }
                    else command_s = command[1];
                    act_(command[0], command_s);
                    cons.listBox1.Items.Add("Комманда выполнена успешно!");
                    cons.command_ = "";                    
                }
            }                
        }

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
                    int i = Convert.ToInt32(so_command[1].Trim());
                    if (i < neyrons__.Count)
                        neyrons__.RemoveAt(Convert.ToInt32(so_command[1].Trim()));
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
                                        'i', -1, "UnsafeIntNeyron", 100
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
                                    case "console":
                                        {
                                            if(action == "ACTIVE")
                                            {
                                                if (cons.IsDisposed == false || cons.Created == true)
                                                    ;
                                                else
                                                {
                                                    cons = new Console();
                                                    cons.Show();
                                                }
                                            } else if(action == "BREAK")
                                            {
                                                if (cons.IsDisposed || cons.Created == false)
                                                    ;
                                                else cons.Dispose();
                                            }
                                        }
                                        break;
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
            read_console_thread();
            neyrons__ = new List<Neyron_DB.object_s>();
            //neyrons__.Add(new Neyron_DB.object_s(null, 'n', 0));
            __unsafe_neyron_buffer = new Neyron_DB.object_s(new neyron_<double>(0.0), 'd', 0, null, -1);
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
            } else if (args[0] == "str")
            {
                DATA_BASE._add<string>("", args[1]);
            } else if (args[0] == "i")
            {
                DATA_BASE._add<int>(0, args[1]);
            }
        }

        /// <summary>
        /// Создаём буферное представление нейрона, через имя в БД
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private Neyron_DB.object_s search_neyron(string name, int limit__)
        {
            return DATA_BASE.create_to_name(name, limit__);
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

                if (objs[index].type == 'd')
                {
                    neyron_<double> n = objs[index].Neyron as neyron_<double>;
                    int index__ = DATA_BASE.__search_index_neyron(n);

                    string[] commands = str_s[1].Split(' ').ToArray();
                    string limit_ = str_s[1].Split(';')[1].Trim();

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
                            DATA_BASE.re_double_neyrs(n, index__);
                            //DATA_BASE._add<double>(0.0, str_s[0]);
                        } else
                        {
                            //DATA_BASE.remove_neyron(str_s[0]);
                            //int index__ = DATA_BASE._add<double>(0.0, str_s[0]);
                            n.width[id] = Convert.ToInt32(value_[0].Trim());
                            DATA_BASE.re_double_neyrs(n, index__);
                            //DATA_BASE. косяяяяяяк
                        }
                    }
                    int ID = neyrons__[index].get_id();
                    string s = neyrons__[index].name_neyron;
                    neyrons__[index] = new Neyron_DB.object_s(
                        n, 'd', ID, s, Convert.ToInt32(limit_));
                } else if (objs[index].type == 'i')
                {
                    neyron_<int> n = objs[index].Neyron as neyron_<int>;
                    int index__ = DATA_BASE.__search_index_neyron(n);

                    string[] commands = str_s[1].Split(' ').ToArray();
                    string limit_ = str_s[1].Split(';')[1].Trim();

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
                            DATA_BASE.re_int_neyrs(n, index__);
                            //DATA_BASE._add<double>(0.0, str_s[0]);
                        }
                        else
                        {
                            //DATA_BASE.remove_neyron(str_s[0]);
                            //int index__ = DATA_BASE._add<double>(0.0, str_s[0]);
                            n.width[id] = Convert.ToInt32(value_[0].Trim());
                            DATA_BASE.re_int_neyrs(n, index__);
                            //DATA_BASE. косяяяяяяк
                        }
                    }
                    int ID = neyrons__[index].get_id();
                    string s = neyrons__[index].name_neyron;
                    neyrons__[index] = new Neyron_DB.object_s(
                        n, 'i', ID, s, Convert.ToInt32(limit_));
                } else if (objs[index].type == 's')
                {
                    neyron_<string> n = objs[index].Neyron as neyron_<string>;
                    int index__ = DATA_BASE.__search_index_neyron(n);

                    string[] commands = str_s[1].Split(' ').ToArray();
                    string limit_ = str_s[1].Split(';')[1].Trim();

                    for (int i = 0; i < commands.Length; i++)
                    {
                        string[] name_value = commands[i].Split('<').ToArray();
                        string[] value_ = name_value[1].Split('>').ToArray();
                        // value_[0] -> значение между '<' и '>'
                        int id = n.__search_for_width_name(name_value[0]);
                        if (id == -1)
                        {
                            n.width.Add(Convert.ToInt32(value_[0]));
                            n.width_name.Add(name_value[0]);
                            DATA_BASE.re_string_neyrs(n, index__);
                            //DATA_BASE._add<double>(0.0, str_s[0]);
                        }
                        else
                        {
                            //DATA_BASE.remove_neyron(str_s[0]);
                            //int index__ = DATA_BASE._add<double>(0.0, str_s[0]);
                            n.width[id] = Convert.ToInt32(value_[0].Trim());
                            DATA_BASE.re_string_neyrs(n, index__);
                            //DATA_BASE. косяяяяяяк
                        }
                    }
                    int ID = neyrons__[index].get_id();
                    string s = neyrons__[index].name_neyron;
                    neyrons__[index] = new Neyron_DB.object_s(
                        n, 's', ID, s, Convert.ToInt32(limit_));
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
                                        neyrons__.Insert(id_1, new Neyron_DB.object_s(n1, 'i', neyrons__[id_1].get_id(), neyrons__[id_1].name_neyron, neyrons__[id_1].limit));
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
                                        neyrons__.Insert(id_1, new Neyron_DB.object_s(n1, 'i', neyrons__[id_1].get_id(), neyrons__[id_1].name_neyron, neyrons__[id_1].limit));
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
    }
}

// пока не допишешь движок - не трогать
class WORD
{
    public string[] table;

    public List<int[]> sheme_;
    public last_value last_value__;
    public List<pattern> patterns;
    /*
     * Рандомный набор правил...
     * 
     * 1, 3 - привет, Алиса ( 1, 2 - привет ИМЯ )
     * 3, 18, 24 - Алиса, как твои дела? ( ? -> требует ответа, ! - не обрабатывается )
     * 3, 4 - Алиса, правильно  Алиса, молодец  Алиса, да
     * 3, 10 - Алиса, спасибо
     * 3, 6 - Алиса, умничка
     * 3, 17, 7 - Алиса, ты милашка )
    */
    public int[] matrix;
    /*
     * 1 - Приветствие
     * 2 - Имя хозяина.
     * 3 - Моё имя.
     * 4 - одобрение
     * 5 - отрицание
     * 6 - хвала 
     * 7 - качество объекта (милый, добрый и т.п.)
     * 8 - негатив 
     * 9 - указание (туда, сюда, там, куда)
     * 10- благодарность
     * 11- объект разговора
     * 12- прощание
     * 13- свойства объекта (цветовые)
     * 14- свойства объекта (метрические (длинна ширина))
     * 15- свойства объекта (длинный, широкий, тяжёлый)
     * 16- имя объекта разговора
     * 17- я
     * 18- ты
     * 19- мы
     * 20- вы
     * 21- он (она оно)
     * 22- они
     * 23- состояние
     * 24- финальный знак
     */

     

    public WORD()
    {
        table = new string[0];
        sheme_ = new List<int[]>();
        matrix = new int[0];
        //words = new NeyGorge();
        last_value__ = new last_value();
        patterns = new List<pattern>();
    }

    public void SELECT_FROM_FILE(string path)
    {
        System.IO.StreamReader str_r = new System.IO.StreamReader(path);
        string str_ = "";
        str_ += str_r.ReadToEnd();
        string[] cache = str_.Split('\n').ToArray();
        List<int> index__ = new List<int>();
        for (int i = 0; i < cache.Length; i++)
        {
            //cache[i] = cache[i].Trim();
            cache[i] = cache[i].Trim(new char[] { '\n' });

            if (cache[i] == "" || cache[i] == '\0'.ToString()
                || cache[i] == null || cache[i].Length <= 2)
                index__.Add(i);

        }
        if (cache.Length - index__.Count <= 0)
            return;
        matrix =   new int[cache.Length - index__.Count];
        table = new string[cache.Length - index__.Count];
        for (int k = 0, j = 0, i = 0; k < cache.Length; k++)
        {
            if (k == index__[j])
                j++;
            else
            {
                //table[i] = cache[k];
                string[] _t = cache[k].Split(':').ToArray();

                table[i] = _t[0];
                matrix[i] = Convert.ToInt32(_t[1].Trim());
                
                i++;
            }   
        }
        str_r.Close();
    }

    public struct last_value
    {
        public string word;
        public int[] last_value_;
        // фраза и предыдущие значения нейронов (слов) в ней                
    }
    public struct pattern
    {
        public string words;
        public int[] values;
        // фраза и значение слов (нейронов) в ней 
        // для сравнения с другими фразами и выдачи правильного ответа
    }

    public int[] ANALIZE(
        string word, 
        List<int[]> 
        neyron_value_sheme, 
        int limit)
    {        
        int error = 0;
        List<List<int>> error_list = new List<List<int>>();
        List<int> return_arg = new List<int>();


        string[] _word = word.Split(' ').ToArray();
        for (int i = 0; i < _word.Length; i++)
        {
            List<int> array_list = new List<int>();
            for (int k = 0; k < matrix.Length; k++)
            {
                if(table[k].Trim() == _word[i].Trim())
                {
                    array_list.Add(matrix[k]);
                    // считываем все слова из табицы, и 
                    // добавляем их в ar_list для 
                    // понимания типа наших слов
                }
            }
            if(array_list.Count != 0)
                error_list.Add(array_list);
        }


        for (int i = 0; i < error_list.Count; i++)
        {
            int[] __d = error_list[i].ToArray();
            if (i >= neyron_value_sheme.Count)
                break;
            int[] __a = neyron_value_sheme[i];
            int j = 0;
            // вытаскиваем значения (схему хранимую в нейроне) нейрона
            // и обрабатываем её по элементам других схем
            if(__d.Length > __a.Length)
            {
                for(; j<__a.Length; j++)
                {
                    if (__a[j] != __d[j])
                        error += 1;
                    if (error > limit)
                    { error = 0; break; }

                    if (j > __a.Length - 2)
                        return_arg.Add(i);
                }
                j = 0;
            } else
            {
                for(; j < __d.Length; j++)
                {
                    if (__a[j] != __d[j])
                        error += 1;
                    if (error > limit)
                    { error = 0; break; }

                    if (j > __d.Length - 2)
                        return_arg.Add(i);
                }
            }
        }



        if(return_arg.ToArray().Length <= 0)
            return new int[0];
        
        return return_arg.ToArray();
    }

    /// <summary>
    /// анализируем по паттернам (заранее заготовленным фразам)
    /// </summary>
    /// <param name="word">слова (фраза)</param>
    /// <param name="limit">порог, перешагивая который получаем индекс паттерна, то бишь 1 у нейрона</param>
    /// <returns>Таблица интексов паттерна</returns>
    public int[] ANALIZE_TO_PATTERN(string word, int limit)
    {
        List<int> return_arg = new List<int>();
        for (int i = 0; i < patterns.Count; i++)
        {
            if (word.Split(' ').Length > patterns[i].values.Length)
            {
                string[] words_ = word.ToLower().Split(' ').ToArray();
                string[] patterns_word = patterns[i].words.Split(' ').ToArray();
                int OK = 0;
                for (int k = 0; k < patterns_word.Length; k++)
                {
                    if (words_[k] == patterns_word[k])
                        OK++;
                }
                if(OK >= limit)
                {
                    return_arg.Add(i);
                }
            }
            else
            {
                string[] words_ = word.ToLower().Split(' ').ToArray();
                string[] patterns_word = patterns[i].words.Split(' ').ToArray();
                int OK = 0;
                for (int k = 0; k < words_.Length; k++)
                {
                    if (words_[k] == patterns_word[k])
                        OK++;
                }
                if (OK >= limit)
                {
                    return_arg.Add(i);
                }
            }
        }

        if(return_arg.Count == 0)
            return new int[0];

        return return_arg.ToArray();
    }

    /// <summary>
    /// анализируем и суммируем все паттерны и если они больше лимита выводим индекс паттерна
    /// </summary>
    /// <param name="word_">слово (фраза)</param>
    /// <param name="limit">максимальная похожесть</param>
    /// <param name="error_limit">количество неодинаковых слов</param>
    /// <returns></returns>
    public int[] ANALYZE_AND_SUMM_TO_PATTERN(string word_, int limit, int error_limit)
    {
        int[] indexs = ANALIZE_TO_PATTERN(word_, error_limit);
        List<int> ret_arg = new List<int>();

        for (int i = 0; i < indexs.Length; i++)
        {
            int[] index_value = patterns[indexs[i]].values;
            int arg_step = 0;
            for (int k = 0; k < index_value.Length; k++)
            {
                arg_step += index_value[k];
            }
            if (arg_step >= limit)
                ret_arg.Add(indexs[i]);
        }        
        return ret_arg.ToArray();
    }

    //public void 

    /// <summary>
    /// ищем объект разговора
    /// </summary>
    public string SEARCH_TELL_OBJECT(string word)
    {

        
        return null;
    }
}
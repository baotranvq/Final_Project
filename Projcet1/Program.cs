using ConsoleTables;
using Projcet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Project1
{
    internal class Program
    {
        static void Menu(List<PRODUCT> data)
        {
            int menu;
            int option1;
            int option2;
            //Setchu();
            do
            {
                toBi();
                Console.WriteLine(" 1. Admin");
                Console.WriteLine(" 2. Khách Hàng");
                Console.WriteLine(" 3. Thoát");
                Console.Write(" Mời bạn chọn: ");
                menu = Convert.ToInt32(Console.ReadLine());
                while (menu >= 3)
                {
                    Console.Write("Mời bạn chọn lại: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        {
                            
                            do
                            {
                                toBi();
                                Console.WriteLine(" 1. Thêm sản phẩm");
                                Console.WriteLine(" 2. Hiển thị danh sách sản phẩm");
                                Console.WriteLine(" 3. Tìm kiếm sản phẩm");
                                Console.WriteLine(" 4. Xóa sản phẩm");
                                Console.WriteLine(" 0. Quay lại ");
                                Console.Write(" Mời bạn chọn: ");
                                option1 = Convert.ToInt32(Console.ReadLine());
                                while (option1 > 5)
                                {
                                    Console.Write(" Mời bạn chọn lại: ");
                                    option1 = Convert.ToInt32(Console.ReadLine());
                                }
                                switch (option1)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            // Nhập dữ liệu từ bàn phím
                                            char c = 'y';
                                            
                                            while (c == 'y')
                                            {
                                                toBi();
                                                Console.WriteLine("\t\t ---NHAP THONG TIN SAN PHAM---");

                                                // Nhập sản phẩm mới
                                                var product = InputProduct();
                                                data.Add(product);

                                                Console.Write(" Nhap ky tu 'y' de tiep tuc, ky tu bat ky de thoat: ");
                                                c = Convert.ToChar(Console.ReadLine().ToLower());
                                                Console.Clear();
                                                // Hiển thị danh sách sản phẩm
                                            }
                                            //ShowProductTable(data);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            bang();
                                            // Hiển thị danh sách sản phẩm
                                            ShowProductTable(data);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            toBi();
                                            var productToDelete = FindProduct(data);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            toBi();
                                            Console.Write(" Nhập MA SP muốn xóa: ");
                                            string deleteMa = Convert.ToString(Console.ReadLine());
                                            deleteProduct(data, deleteMa);
                                            Console.Clear();
                                            //ShowProductTable(data);
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.Clear();
                                            break;
                                        }

                                }
                            } while (option1 < 5 && option1 > 0);
                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                toBi();
                                Console.WriteLine(" 1. Hiển thị danh sách sản phẩm");
                                Console.WriteLine(" 2. Tìm kiếm sản phẩm");
                                Console.WriteLine(" 0. Quay lại ");
                                Console.Write(" Mời bạn chọn: ");
                                option2 = Convert.ToInt32(Console.ReadLine());
                                while (option2 > 4)
                                {
                                    Console.Write(" Mời bạn chọn lại: ");
                                    option2 = Convert.ToInt32(Console.ReadLine());
                                }
                                switch (option2)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            toBi();
                                            // Hiển thị danh sách sản phẩm
                                            ShowProductTable(data);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            toBi();
                                            var productToDelete = FindProduct(data);
                                            break ;
                                        }
                                    case 0:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    
                                }
                            } while (option2 < 3 && option2 > 0);
                            break;
                        }
                }

            } while (true);

            
            
            
            
        }

       

        //
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo danh sách sản phẩm
            var data = new List<PRODUCT>();
            Menu(data);

            //// Nhập dữ liệu từ bàn phím
            //while (true)
            //{
            //    Console.WriteLine("\t\t ---NHAP THONG TIN SAN PHAM---");

            //    // Nhập sản phẩm mới
            //    var product = InputProduct();
            //    data.Add(product);

            //    Console.WriteLine("Nhap ky tu 'y' de tiep tuc, ky tu bat ky de thoat: ");
            //    var c = Console.ReadKey().KeyChar;
            //    if (c != 'y')
            //        break;

            //    Console.Clear();
            //}
            //Console.Clear();
            //// Hiển thị danh sách sản phẩm
            //ShowProductTable(data);

            //// Tìm kiếm sản phẩm
            //var productToDelete = FindProduct(data);
        

            ////
            //// Xóa sản phẩm theo mã sản phẩm
            //Console.Write("Nhập MA SP muốn xóa: ");
            //string deleteMa = Convert.ToString(Console.ReadLine());
            //deleteProduct(data, deleteMa);
            //Console.Clear();
            //ShowProductTable(data);


            Console.ReadKey();
        }

        static PRODUCT InputProduct()
        {
            Console.Write("Nhap ma SP: ");
            string ma = Console.ReadLine();

            Console.Write("Nhap ten SP: ");
            string ten = Console.ReadLine();

            Console.Write("Nhap size SP: ");
            string size = Console.ReadLine();

            Console.Write("Nhap mau SP: ");
            string mau = Console.ReadLine();

            Console.Write("Nhap SL SP: ");
            int sl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap gia SP: ");
            double gia = Convert.ToDouble(Console.ReadLine());

            return new PRODUCT { Ma = ma, Ten = ten, Size = size, Mau = mau, Sl = sl, Gia = gia };
        }

        static void ShowProductTable(List<PRODUCT> data)
        {
            // Tạo DataTable
            var table = new ConsoleTable("MA", "TEN", "SIZE", "MAU", "SL", "GIA");

            // Thêm dữ liệu vào DataTable
            foreach (var item in data)
            {
                table.AddRow(item.Ma, item.Ten, item.Size, item.Mau, item.Sl, item.Gia);
            }

            // Hiển thị bảng
            table.Write();
        }

        static PRODUCT FindProduct(List<PRODUCT> data)
        {
            Console.Write("Nhập MA SP muốn tìm: ");
            string searchMa = Console.ReadLine();
            var product = data.FirstOrDefault(e => e.Ma == searchMa);
            if (product != null)
            {
                Console.WriteLine($"San Pham có Ma {searchMa} là:");
                Console.WriteLine($"MA: {product.Ma}  | TEN: {product.Ten}  | SIZE: {product.Size}  | MAU: {product.Mau}  | SL: {product.Sl}  | GIA: {product.Gia}  |");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy SP có MA {searchMa}");
            }
            return product;

        }

        // Xóa sản phẩm theo mã sản phẩm
        static void deleteProduct(List<PRODUCT> data, string searchMa)
        {
            var product = data.FirstOrDefault(e => e.Ma == searchMa);
            if (product != null)
            {
                Console.WriteLine($"San Pham có Ma {searchMa} là:");
                Console.WriteLine($"MA: {product.Ma}  | TEN: {product.Ten}  | SIZE: {product.Size}  | MAU: {product.Mau}  |SL: {product.Sl}  | GIA: {product.Gia}  |");
                
                // Xác nhận xóa sản phẩm
                Console.Write($"Bạn có muốn xóa SP có MA {searchMa} không? (Y/N): ");
                var confirm = Console.ReadLine().ToUpper();
                if (confirm == "Y")
                {
                    data.Remove(product);
                    Console.WriteLine($"Đã xóa SP có MA {searchMa}");
                }
                else
                {
                    Console.WriteLine("Không xóa SP");
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy SP có MA {searchMa}");
            }
        }

        static void toBi()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("\t***** TOBI SHOP *****");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void bang()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("\t***** Danh Sach San Pham *****");
            Console.ForegroundColor = ConsoleColor.White;
        }
  
        static void Setchu()
        {
            Console.SetWindowSize(60, 30); // Thiết lập kích thước cửa sổ console
            SetConsoleFontSize(100, "arial black"); // Thiết lập kích thước font chữ arial black

            Console.ForegroundColor = ConsoleColor.Red; // Thiết lập màu chữ trắng
            Console.BackgroundColor = ConsoleColor.Black; // Thiết lập màu nền đen
            Console.Clear(); // Xóa màn hình console

            Console.WriteLine("\t    TOBI"); // In chữ "XIN CHAO" ra console

            
        }
        

        // Hàm thiết lập kích thước font chữ
        static void SetConsoleFontSize(int size, string fontName)
        {
            IntPtr hnd = GetStdHandle(-11);
            CONSOLE_FONT_INFO_EX cfi = new CONSOLE_FONT_INFO_EX();
            cfi.cbSize = (uint)Marshal.SizeOf(cfi);
            cfi.FontWeight = 400;
            cfi.dwFontSize.X = 0;
            cfi.dwFontSize.Y = (short)size;
            cfi.FontFamily = 0;
            cfi.FaceName = new ushort[LF_FACESIZE];
            var fontNameChars = fontName.ToCharArray();
            for (int i = 0; i < fontNameChars.Length; i++)
            {
                cfi.FaceName[i] = (ushort)fontNameChars[i];
            }
            SetCurrentConsoleFontEx(hnd, false, ref cfi);
        }

        // Dữ liệu cấu trúc cho hàm SetCurrentConsoleFontEx
        [StructLayout(LayoutKind.Sequential)]
        public struct COORD
        {
            public short X;
            public short Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CONSOLE_FONT_INFO_EX
        {
            public uint cbSize;
            public uint nFont;
            public COORD dwFontSize;
            public int FontFamily;
            public int FontWeight;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = LF_FACESIZE)]
            public ushort[] FaceName;
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetCurrentConsoleFontEx(IntPtr consoleOutput, bool maximumWindow, ref CONSOLE_FONT_INFO_EX consoleCurrentFontEx);

        private const int LF_FACESIZE = 32;
    }



}

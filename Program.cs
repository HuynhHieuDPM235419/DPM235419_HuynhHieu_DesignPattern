using System;
using System.Collections.Generic;

namespace DPM235419_HuynhHieu_DesignPattern
{
    // Một mẫu thiết kế gồm 2 project: bản Pattern (cấu trúc chuẩn) và bản Real (ứng dụng bán hàng)
    internal class PatternEntry
    {
        public string Name { get; }
        public string Group { get; }
        public string RealDescription { get; }
        public Action<string[]> RunPattern { get; }
        public Action<string[]> RunReal { get; }

        public PatternEntry(string name, string group, string realDescription,
                            Action<string[]> runPattern, Action<string[]> runReal)
        {
            Name = name;
            Group = group;
            RealDescription = realDescription;
            RunPattern = runPattern;
            RunReal = runReal;
        }
    }

    internal class Program
    {
        private const string Creational = "CREATIONAL";
        private const string Structural = "STRUCTURAL";
        private const string Behavioral = "BEHAVIORAL";

        // 23 mẫu x 2 project = 46 project
        private static readonly List<PatternEntry> Patterns = new List<PatternEntry>
        {
            // ---------- CREATIONAL (5 mẫu) ----------
            new PatternEntry("Singleton", Creational, "PosSessionManager - cấp số hóa đơn duy nhất",
                DPM235419_HuynhHieu_SingletonPattern.Program.Main, DPM235419_HuynhHieu_Singleton.Program.Main),
            new PatternEntry("Builder", Creational, "OrderBuilder - dựng đơn hàng Fluent API",
                DPM235419_HuynhHieu_BuilderPattern.Program.Main, DPM235419_HuynhHieu_Builder.Program.Main),
            new PatternEntry("Prototype", Creational, "Order.Clone() - Re-order đơn hàng cũ",
                DPM235419_HuynhHieu_PrototypePattern.Program.Main, DPM235419_HuynhHieu_Prototype.Program.Main),
            new PatternEntry("Factory Method", Creational, "PaymentFactory - Tiền mặt / MoMo / Visa",
                DPM235419_HuynhHieu_FactoryMethodPattern.Program.Main, DPM235419_HuynhHieu_FactoryMethod.Program.Main),
            new PatternEntry("Abstract Factory", Creational, "IDocumentFactory - chứng từ Offline / Online",
                DPM235419_HuynhHieu_AbstractFactoryPattern.Program.Main, DPM235419_HuynhHieu_AbstractFactory.Program.Main),

            // ---------- STRUCTURAL (7 mẫu) ----------
            new PatternEntry("Adapter", Structural, "GhtkAdapter - chuẩn hóa API vận chuyển",
                DPM235419_HuynhHieu_AdapterPattern.Program.Main, DPM235419_HuynhHieu_Adapter.Program.Main),
            new PatternEntry("Bridge", Structural, "Đơn lẻ/sỉ x Web/App/POS",
                DPM235419_HuynhHieu_BridgePattern.Program.Main, DPM235419_HuynhHieu_Bridge.Program.Main),
            new PatternEntry("Composite", Structural, "ComboProduct - gói sản phẩm Combo",
                DPM235419_HuynhHieu_CompositePattern.Program.Main, DPM235419_HuynhHieu_Composite.Program.Main),
            new PatternEntry("Decorator", Structural, "Hóa đơn động: Topping, VAT, Ship",
                DPM235419_HuynhHieu_DecoratorPattern.Program.Main, DPM235419_HuynhHieu_Decorator.Program.Main),
            new PatternEntry("Facade", Structural, "CheckoutFacade - nút \"Đặt hàng\" 1-chạm",
                DPM235419_HuynhHieu_FacadePattern.Program.Main, DPM235419_HuynhHieu_Facade.Program.Main),
            new PatternEntry("Flyweight", Structural, "ProductSpecification - tối ưu RAM",
                DPM235419_HuynhHieu_FlyweightPattern.Program.Main, DPM235419_HuynhHieu_Flyweight.Program.Main),
            new PatternEntry("Proxy", Structural, "ProductServiceProxy - bộ nhớ đệm danh mục",
                DPM235419_HuynhHieu_ProxyPattern.Program.Main, DPM235419_HuynhHieu_Proxy.Program.Main),

            // ---------- BEHAVIORAL (11 mẫu) ----------
            new PatternEntry("Chain of Resp.", Behavioral, "Duyệt hoàn tiền theo cấp quản lý",
                DPM235419_HuynhHieu_ChainOfResponsibilityPattern.Program.Main, DPM235419_HuynhHieu_ChainOfResponsibility.Program.Main),
            new PatternEntry("Command", Behavioral, "Giỏ hàng POS có Undo/Redo",
                DPM235419_HuynhHieu_CommandPattern.Program.Main, DPM235419_HuynhHieu_Command.Program.Main),
            new PatternEntry("Interpreter", Behavioral, "Thông dịch luật khuyến mãi",
                DPM235419_HuynhHieu_InterpreterPattern.Program.Main, DPM235419_HuynhHieu_Interpreter.Program.Main),
            new PatternEntry("Iterator", Behavioral, "Duyệt danh mục: lọc, phân trang",
                DPM235419_HuynhHieu_IteratorPattern.Program.Main, DPM235419_HuynhHieu_Iterator.Program.Main),
            new PatternEntry("Mediator", Behavioral, "Điều phối đơn giữa các bộ phận",
                DPM235419_HuynhHieu_MediatorPattern.Program.Main, DPM235419_HuynhHieu_Mediator.Program.Main),
            new PatternEntry("Memento", Behavioral, "Lưu nháp & hoàn tác giỏ hàng",
                DPM235419_HuynhHieu_MementoPattern.Program.Main, DPM235419_HuynhHieu_Memento.Program.Main),
            new PatternEntry("Observer", Behavioral, "Báo có hàng, giảm giá, cảnh báo kho",
                DPM235419_HuynhHieu_ObserverPattern.Program.Main, DPM235419_HuynhHieu_Observer.Program.Main),
            new PatternEntry("State", Behavioral, "Vòng đời trạng thái đơn hàng",
                DPM235419_HuynhHieu_StatePattern.Program.Main, DPM235419_HuynhHieu_State.Program.Main),
            new PatternEntry("Strategy", Behavioral, "Chiến lược khuyến mãi khi tính tiền",
                DPM235419_HuynhHieu_StrategyPattern.Program.Main, DPM235419_HuynhHieu_Strategy.Program.Main),
            new PatternEntry("Template Method", Behavioral, "Quy trình xử lý đơn đa kênh",
                DPM235419_HuynhHieu_TemplateMethodPattern.Program.Main, DPM235419_HuynhHieu_TemplateMethod.Program.Main),
            new PatternEntry("Visitor", Behavioral, "Thuế VAT, phí ship, đổi trả theo loại hàng",
                DPM235419_HuynhHieu_VisitorPattern.Program.Main, DPM235419_HuynhHieu_Visitor.Program.Main),
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                ClearScreen();
                PrintMenu();

                Console.Write("\nNhập lựa chọn: ");
                string input = (Console.ReadLine() ?? "").Trim().ToUpper();

                if (input == "0") break;

                switch (input)
                {
                    case "A": RunGroup(null); continue;
                    case "C": RunGroup(Creational); continue;
                    case "S": RunGroup(Structural); continue;
                    case "B": RunGroup(Behavioral); continue;
                }

                int choice;
                if (int.TryParse(input, out choice) && choice >= 1 && choice <= Patterns.Count * 2)
                {
                    RunByNumber(choice);
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ! Nhấn Enter để nhập lại...");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("\nTạm biệt!");
        }

        // Số lẻ = bản Pattern, số chẵn = bản Real của cùng một mẫu
        private static void RunByNumber(int number)
        {
            PatternEntry p = Patterns[(number - 1) / 2];
            bool isPattern = number % 2 == 1;
            RunDemo(number, p, isPattern);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║      23 DESIGN PATTERNS (46 PROJECT) - HỆ THỐNG QUẢN LÝ BÁN HÀNG         ║");
            Console.WriteLine("║      SV: Huỳnh Hiếu - MSSV: DPM235419                                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("   Số lẻ = bản PATTERN (cấu trúc chuẩn) | Số chẵn = bản REAL (ứng dụng bán hàng)");

            string currentGroup = null;
            for (int i = 0; i < Patterns.Count; i++)
            {
                var p = Patterns[i];
                if (p.Group != currentGroup)
                {
                    currentGroup = p.Group;
                    Console.WriteLine($"\n  --- {GroupTitle(currentGroup)} ---");
                }
                int patternNo = i * 2 + 1;
                int realNo = i * 2 + 2;
                Console.WriteLine($"  [{patternNo,2}] Pattern  [{realNo,2}] Real   {p.Name,-17} {p.RealDescription}");
            }

            Console.WriteLine("\n   C. Chạy tất cả Creational   S. Chạy tất cả Structural   B. Chạy tất cả Behavioral");
            Console.WriteLine("   A. Chạy lần lượt TẤT CẢ 46 project");
            Console.WriteLine("   0. Thoát");
        }

        private static string GroupTitle(string group)
        {
            if (group == Creational) return "CREATIONAL PATTERNS (5 mẫu khởi tạo)";
            if (group == Structural) return "STRUCTURAL PATTERNS (7 mẫu cấu trúc)";
            return "BEHAVIORAL PATTERNS (11 mẫu hành vi)";
        }

        private static void RunDemo(int number, PatternEntry p, bool isPattern)
        {
            ClearScreen();
            string kind = isPattern ? "PATTERN - cấu trúc chuẩn" : "REAL - " + p.RealDescription;
            Console.WriteLine($">>> [{number}/{Patterns.Count * 2}] {p.Name.ToUpper()} ({kind})");
            Console.WriteLine(">>> Khi demo chạy xong, nhấn Enter để tiếp tục.\n");

            try
            {
                if (isPattern) p.RunPattern(new string[0]);
                else p.RunReal(new string[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[LỖI] Demo {p.Name} gặp lỗi: {ex.Message}");
                Console.WriteLine("Nhấn Enter để quay lại menu...");
                Console.ReadLine();
            }
        }

        // group = null nghĩa là chạy tất cả
        private static void RunGroup(string group)
        {
            for (int i = 0; i < Patterns.Count; i++)
            {
                if (group != null && Patterns[i].Group != group) continue;
                RunDemo(i * 2 + 1, Patterns[i], true);
                RunDemo(i * 2 + 2, Patterns[i], false);
            }
        }

        // Console.Clear() có thể lỗi khi chạy trong một số cửa sổ Output, nên bọc try-catch
        private static void ClearScreen()
        {
            try { Console.Clear(); } catch (System.IO.IOException) { }
        }
    }
}

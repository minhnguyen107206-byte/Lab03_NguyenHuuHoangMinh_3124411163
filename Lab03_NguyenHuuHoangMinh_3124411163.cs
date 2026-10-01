using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ
{
    // === CÁC LỚP DỮ LIỆU (BÀI 4 & 6) ===
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }

    public class He
    {
        public string MaHe { get; set; } = "";
        public string TenHe { get; set; } = "";
    }

    public class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                new MonHoc { MaMon="HP2_1", TenMon="Nền tảng C#", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP2_2", TenMon="Công nghệ ADO.NET", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP3_1", TenMon="Lập trình Windows Forms", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP3_2", TenMon="Xây dựng ứng dụng Windows Forms", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP4_1", TenMon="Lập trình Web với HTML, CSS và JavaScript", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP4_2", TenMon="Xây dựng ứng dụng Web với ASP.NET", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP5_1", TenMon="Lập trình CSDL SQL Server căn bản", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="HP5_2", TenMon="Lập trình CSDL SQL Server nâng cao", He="KTV", SoTiet=64 },
                new MonHoc { MaMon="JLCB", TenMon="Joomla cơ bản", He="CD", SoTiet=72 },
                new MonHoc { MaMon="LINQ", TenMon="Language-Integrated Query", He="CD", SoTiet=64 },
                new MonHoc { MaMon="DAWEB", TenMon="Đồ án thực tế Web với ASP.NET", He="CD", SoTiet=40 },
                new MonHoc { MaMon="DAWIN", TenMon="Đồ án thực tế Windows Forms", He="CD", SoTiet=40 },
                new MonHoc { MaMon="CC++", TenMon="Lập trình hướng đối tượng với C/C++", He="CD", SoTiet=128 },
                new MonHoc { MaMon="JQUE", TenMon="JQuery", He="CD", SoTiet=22 },
                new MonHoc { MaMon="XML", TenMon="Công nghệ XML", He="CD", SoTiet=32 },
                new MonHoc { MaMon="CRYS", TenMon="Crystal Report trong Visual Studio", He="CD", SoTiet=32 },
                new MonHoc { MaMon="BWEB", TenMon="HTML, CSS và JavaScript", He="CD", SoTiet=32 },
                new MonHoc { MaMon="XYZ", TenMon="Chưa đặt tên môn", He="", SoTiet=0 }
            };
        }
        
        public static List<He> DS_He()
        {
            return new List<He>
            {
                new He { MaHe="KTV", TenHe="Kỹ thuật viên" },
                new He { MaHe="CD", TenHe="Chuyên đề" },
                new He { MaHe="QT", TenHe="Chứng chỉ quốc tế" }
            };
        }
    }

    // === CHƯƠNG TRÌNH CHÍNH ===
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Bai21();
            Bai22();
            Bai31();
            Bai32();
            Bai51();
            Bai52();
            Bai62();

            Console.Readline();
        }

        static void Bai21()
        {
            Console.WriteLine("\n=== BÀI 2.1: TRUY VẤN MẢNG SỐ NGUYÊN ===");
            int[] mangSo = {50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

            // a. Chia hết cho 4 và 3
            var cauA = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);
            Console.WriteLine("a. Chia hết cho 3 và 4: " + string.Join(", ", cauA));

            // b. Nhỏ hơn hoặc bằng 3
            var cauB = mangSo.Where(x => x <= 3);
            Console.WriteLine("b. <= 3: " + string.Join(", ", cauB));

            // c. Số chẵn chia đôi, lẻ giữ nguyên
            var cauC = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);
            Console.WriteLine("c. Dãy mới: " + string.Join(", ", cauC));
        }

        static void Bai22()
        {
            Console.WriteLine("\n=== BÀI 2.2: TRUY VẤN MẢNG CHUỖI ===");
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

            // a. 4 ký tự, xếp tăng dần theo ký tự đầu
            var cauA = mangChuoi.Where(x => x.Length == 4).OrderBy(x => x[0]);
            Console.WriteLine("a. 4 ký tự, tăng dần: " + string.Join(", ", cauA));

            // b. <thường> - <HOA>
            var cauB = mangChuoi.Select(x => $"{x.ToLower()} - {x.ToUpper()}");
            Console.WriteLine("b. Biến đổi: " + string.Join(" | ", cauB));

            // c. Chứa chữ "u"
            var cauC = mangChuoi.Where(x => x.Contains("u"));
            Console.WriteLine("c. Chứa chữ 'u': " + string.Join(", ", cauC));

            // d. Bắt đầu bằng chữ in hoa
            var cauD = mangChuoi.Where(x => !string.IsNullOrEmpty(x) && char.IsUpper(x[0]));
            Console.WriteLine("d. Bắt đầu bằng chữ hoa: " + string.Join(" ", cauD));
        }

        static void Bai31()
        {
            Console.WriteLine("\n=== BÀI 3.1: THỐNG KÊ MẢNG SỐ ===");
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            // a. Tổng số phần tử, chẵn, lẻ
            Console.WriteLine($"a. Tổng PT: {mangSo.Count()}, Chẵn: {mangSo.Count(x => x % 2 == 0)}, Lẻ: {mangSo.Count(x => x % 2 != 0)}");

            // b. Tổng, Min, Max
            Console.WriteLine($"b. Tổng: {mangSo.Sum()}, Min: {mangSo.Min()}, Max: {mangSo.Max()}");

            // c. Số lượng giá trị khác nhau
            Console.WriteLine($"c. Số giá trị khác nhau: {mangSo.Distinct().Count()}");

            // d. Nhóm theo số dư khi chia cho 5
            var cauD = mangSo.GroupBy(x => x % 5);
            Console.WriteLine("d. Phân nhóm theo số dư chia cho 5:");
            foreach (var group in cauD)
            {
                Console.WriteLine($"   - Số dư {group.Key}: {string.Join(", ", group)}");
            }
        }

        static void Bai32()
        {
            Console.WriteLine("\n=== BÀI 3.2: THỐNG KÊ MẢNG CHUỖI ===");
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì", "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

            // a. Ngắn nhất và dài nhất
            int minLen = monAn.Min(x => x.Length);
            int maxLen = monAn.Max(x => x.Length);
            var nganNhat = monAn.Where(x => x.Length == minLen);
            var daiNhat = monAn.Where(x => x.Length == maxLen);
            Console.WriteLine($"a. Ngắn nhất: {string.Join(", ", nganNhat)} | Dài nhất: {string.Join(", ", daiNhat)}");

            // b. Phân nhóm theo từ đầu tiên
            var cauB = monAn.GroupBy(x => x.Split(' ')[0]);
            Console.WriteLine("b. Nhóm theo từ đầu tiên:");
            foreach (var group in cauB)
            {
                Console.WriteLine($"   - Nhóm '{group.Key}': {string.Join(", ", group)}");
            }

            // c. Đếm bắt đầu bằng "Bánh"
            int countBanh = monAn.Count(x => x.StartsWith("Bánh"));
            Console.WriteLine($"c. Số món bắt đầu bằng 'Bánh': {countBanh}");
        }

        static void Bai51()
        {
            Console.WriteLine("\n=== BÀI 5.1: TRUY VẤN CƠ BẢN LIST<MONHOC> ===");
            var dsMon = DuLieu.DS_Mon();

            // a. Bắt đầu bằng "Lập trình"
            var cauA = dsMon.Where(x => x.TenMon.StartsWith("Lập trình"));
            Console.WriteLine("a. Môn bắt đầu bằng 'Lập trình':");
            foreach (var m in cauA) Console.WriteLine($"   {m.MaMon} - {m.TenMon}");

            // b. Hệ CD, Số tiết giảm dần, Mã môn tăng dần
            var cauB = dsMon.Where(x => x.He == "CD").OrderByDescending(x => x.SoTiet).ThenBy(x => x.MaMon);
            Console.WriteLine("b. Hệ CD (Sắp xếp Tiết giảm, Mã tăng):");
            foreach (var m in cauB) Console.WriteLine($"   {m.MaMon} - {m.TenMon} - {m.SoTiet}");

            // c. Chứa từ "web", chỉ lấy Tên và Hệ
            var cauC = dsMon.Where(x => x.TenMon.ToLower().Contains("web")).Select(x => new { x.TenMon, x.He });
            Console.WriteLine("c. Môn chứa 'web':");
            foreach (var m in cauC) Console.WriteLine($"   {m.TenMon} (Hệ: {m.He})");

            // d. Hệ KTV, tăng dần theo Mã môn
            var cauD = from m in dsMon where m.He == "KTV" orderby m.MaMon select m;
            Console.WriteLine("d. Hệ KTV sắp xếp theo Mã môn:");
            foreach (var m in cauD) Console.WriteLine($"   {m.MaMon} - {m.TenMon}");
        }

        static void Bai52()
        {
            Console.WriteLine("\n=== BÀI 5.2: THỐNG KÊ LIST<MONHOC> ===");
            var dsMon = DuLieu.DS_Mon();

            Console.WriteLine($"a. Tổng số môn: {dsMon.Count}");
            Console.WriteLine($"b. Số môn 'Lập trình': {dsMon.Count(x => x.TenMon.StartsWith("Lập trình"))}");
            Console.WriteLine($"c. Tổng số tiết hệ KTV: {dsMon.Where(x => x.He == "KTV").Sum(x => x.SoTiet)}");

            // d. Tổng số môn mỗi hệ
            var cauD = dsMon.GroupBy(x => x.He).Select(g => new { He = g.Key == "" ? "Chưa rõ" : g.Key, TongMon = g.Count() });
            Console.WriteLine("d. Tổng số môn theo Hệ:");
            foreach (var i in cauD) Console.WriteLine($"   Hệ {i.He}: {i.TongMon} môn");

            // e. Nhóm theo Số tiết
            var cauE = dsMon.GroupBy(x => x.SoTiet).Select(g => new { SoTiet = g.Key, TongMon = g.Count() }).OrderByDescending(x => x.SoTiet);
            Console.WriteLine("e. Nhóm theo số tiết (Giảm dần):");
            foreach (var i in cauE) Console.WriteLine($"   {i.SoTiet} tiết: {i.TongMon} môn");

            // f. Môn có số tiết cao nhất
            int maxTiet = dsMon.Max(x => x.SoTiet);
            var cauF = dsMon.Where(x => x.SoTiet == maxTiet);
            Console.WriteLine("f. Môn có số tiết cao nhất:");
            foreach (var m in cauF) Console.WriteLine($"   {m.TenMon} ({m.SoTiet} tiết)");

            // g. Thống kê theo Hệ
            var cauG = dsMon.GroupBy(x => x.He).Select(g => new {
                He = g.Key, TongMon = g.Count(), TongTiet = g.Sum(x => x.SoTiet),
                MaxTiet = g.Max(x => x.SoTiet), MinTiet = g.Min(x => x.SoTiet)
            });
            Console.WriteLine("g. Thống kê theo Hệ:");
            foreach (var i in cauG) Console.WriteLine($"   Hệ '{i.He}': {i.TongMon} môn, Tổng {i.TongTiet} tiết, Max: {i.MaxTiet}, Min: {i.MinTiet}");

            // h & i. Phân nhóm
            Console.WriteLine("h. Liệt kê phân nhóm theo Hệ:");
            foreach (var g in dsMon.GroupBy(x => x.He))
                Console.WriteLine($"   Hệ '{g.Key}': " + string.Join(", ", g.Select(x => x.MaMon)));

            Console.WriteLine("i. Liệt kê phân nhóm theo Số tiết (Tăng dần):");
            foreach (var g in dsMon.GroupBy(x => x.SoTiet).OrderBy(g => g.Key))
                Console.WriteLine($"   {g.Key} tiết: " + string.Join(", ", g.Select(x => x.MaMon)));

            // j. KTV phân nhóm theo HP2, HP3...
            var cauJ = dsMon.Where(x => x.He == "KTV")
                            .GroupBy(x => x.MaMon.Substring(0, 3))
                            .Select(g => new { Nhom = g.Key, CacMon = g.OrderBy(x => x.MaMon) });
            Console.WriteLine("j. KTV phân nhóm theo Mã HP:");
            foreach (var g in cauJ)
            {
                Console.WriteLine($"   Nhóm {g.Nhom}:");
                foreach (var m in g.CacMon) Console.WriteLine($"      {m.MaMon} - {m.TenMon}");
            }

            // k. Phân nhóm theo hệ (chỉ lấy môn > 40 tiết)
            var cauK = dsMon.Where(x => x.SoTiet > 40)
                            .GroupBy(x => x.He)
                            .Select(g => new { He = g.Key, CacMon = g.OrderBy(x => x.MaMon) });
            Console.WriteLine("k. Hệ có môn > 40 tiết:");
            foreach (var g in cauK)
            {
                Console.WriteLine($"   Hệ '{g.He}': " + string.Join(", ", g.CacMon.Select(x => x.MaMon)));
            }
        }

        static void Bai62()
        {
            Console.WriteLine("\n=== BÀI 6.2: JOIN VÀ CÁC TOÁN TỬ TẬP HỢP ===");
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            // a. Inner Join
            var cauA = dsHe.Join(dsMon, h => h.MaHe, m => m.He, (h, m) => new { h.TenHe, m.MaMon, m.TenMon });
            Console.WriteLine("a. Join Tên Hệ, Mã Môn, Tên Môn:");
            foreach (var item in cauA) Console.WriteLine($"   {item.TenHe} | {item.MaMon} - {item.TenMon}");

            // b. Left Outer Join (Hệ chưa có môn)
            var cauB = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He, (h, ms) => new { He = h, Mons = ms.DefaultIfEmpty() })
                           .SelectMany(x => x.Mons, (x, m) => new { x.He.TenHe, TenMon = m?.TenMon ?? "<Chưa có môn học>" });
            Console.WriteLine("\nb. Left Outer Join (Liệt kê cả hệ chưa có môn):");
            foreach (var item in cauB) Console.WriteLine($"   {item.TenHe} | {item.TenMon}");

            // c. Full Outer Join (Mô phỏng: Left Join UNION Right Anti Join)
            var rightAntiJoin = dsMon.Where(m => !dsHe.Any(h => h.MaHe == m.He))
                                     .Select(m => new { TenHe = "<Chưa khai báo hệ>", TenMon = m.TenMon });
            var cauC = cauB.Union(rightAntiJoin);
            Console.WriteLine("\nc. Hệ chưa môn & Môn chưa hệ (Full Outer):");
            foreach (var item in cauC) Console.WriteLine($"   {item.TenHe} | {item.TenMon}");

            // d. Chỉ Hệ chưa môn VÀ Môn chưa hệ
            var heChuaMon = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe)).Select(h => $"Hệ: {h.TenHe}");
            var monChuaHe = dsMon.Where(m => !dsHe.Any(h => h.MaHe == m.He)).Select(m => $"Môn: {m.TenMon}");
            Console.WriteLine("\nd. Chỉ liệt kê rác (Hệ ko môn, Môn ko hệ):");
            foreach (var item in heChuaMon.Concat(monChuaHe)) Console.WriteLine($"   {item}");

            // e. 5 môn đầu tiên số tiết giảm dần + Join
            var cauE = dsMon.OrderByDescending(x => x.SoTiet).Take(5)
                            .Join(dsHe, m => m.He, h => h.MaHe, (m, h) => new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet });
            Console.WriteLine("\ne. Top 5 môn số tiết cao nhất:");
            foreach (var item in cauE) Console.WriteLine($"   {item.TenHe} | {item.MaMon} - {item.TenMon} ({item.SoTiet} tiết)");

            // f. Tổng số môn mỗi hệ (Tính cả hệ 0 môn)
            var cauF = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He, (h, ms) => new { h.MaHe, h.TenHe, TongMon = ms.Count() });
            Console.WriteLine("\nf. Tổng số môn mỗi hệ:");
            foreach (var item in cauF) Console.WriteLine($"   {item.MaHe} - {item.TenHe}: {item.TongMon} môn");

            // g. Số loại số tiết khác nhau
            int cauG = dsMon.Select(x => x.SoTiet).Distinct().Count();
            Console.WriteLine($"\ng. Có {cauG} loại số tiết khác nhau.");

            // h. Môn đầu tiên bắt đầu bằng "Lập trình"
            var cauH = dsMon.FirstOrDefault(x => x.TenMon.StartsWith("Lập trình"));
            Console.WriteLine($"\nh. Môn đầu tiên 'Lập trình': {(cauH != null ? cauH.TenMon : "Không tìm thấy")}");

            // i. Môn theo hệ có đánh STT
            Console.WriteLine("\ni. Liệt kê theo hệ có STT:");
            var cauI = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He, (h, ms) => new { He = h.TenHe, Mons = ms });
            foreach (var nhom in cauI)
            {
                Console.WriteLine($"   Hệ: {nhom.He}");
                int stt = 1;
                foreach (var m in nhom.Mons) Console.WriteLine($"      {stt++}. {m.TenMon}");
                if (!nhom.Mons.Any()) Console.WriteLine("      (Không có môn học)");
            }
        }
    }
}

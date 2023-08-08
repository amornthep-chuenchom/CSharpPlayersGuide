Console.Write("Enter number of chocolate eggs: ");
int totalEggs = Convert.ToInt32(Console.ReadLine());

int sisterEggs = totalEggs / 4;
int duckbearEggs = totalEggs % 4;

Console.WriteLine("Each sister get " + sisterEggs + " eggs.");
Console.WriteLine("Duckbear get " + duckbearEggs + " eggs.");

// Answer this question: What are three total egg counts where the duckbear gets more than each sister does?
// You can use the program you created to help you find the answer

// ถ้าไข่มีน้อยกว่า 4 ฟอง (1-3), สี่พี่น้องจะได้ 0 ฟอง ส่วน duckbear ได้ 1, 2, 3 ตามลำดับ
// ถ้าไข่มี 6 ฟอง, สี่พี่น้องจะได้คนละ 1 ฟองและ duckbear ได้ 2 ฟอง
// ถ้าไข่มี 7 ฟอง, สี่พี่น้องจะได้คนละ 1 ฟองและ duckbear ได้ 3 ฟอง
// ถ้าไข่มี 11 ฟอง, สี่พี่น้องจะได้คนละ 2 ฟองและ duckbear ได้ 3 ฟอง
// นอกจากนี้ไม่มีกรณีที่ duckbear ได้ไข่มากกว่าอีกแล้ว


open System

let rec fib (n:int): int64 = 
    match n with
    | n when n < 3 -> 1L
    | _ -> fib(n-1) + fib(n-2)
let main ()= 
    let a = DateTime.Now
    let mutable s: int64 = 0L
    for _ in 1 .. 3 do
        s <- fib(45)
    let b = DateTime.Now
    let c = b.Subtract(a)
    Console.WriteLine(s);
    Console.WriteLine(c.Seconds);
    Console.WriteLine((float c.Seconds)/3.0);
main()

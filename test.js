function fib(n) {
    if (n < 3) return 1;
    return fib(n - 1) + fib(n - 2);
}

var a = new Date();
s = 0;
for (i = 0; i < 3; i++) {
    s = fib(45);
}
var b = new Date();
var c = b - a;
console.log(s)
console.log(c / 1000)
console.log(c / 1000 / 3.0)
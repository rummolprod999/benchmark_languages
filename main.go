package main

import (
	"fmt"
	"time"
)

func fib(n int) int64 {
	if n < 3 {
		return 1
	}
	return fib(n-1) + fib(n-2)
}
func main() {
	a := time.Now()
	var s int64
	for i := 0; i < 3; i++ {
		s = fib(45)
	}
	b := time.Now()
	c := b.Sub(a)
	fmt.Println(s)
	fmt.Println(c)
	fmt.Println(c / 3.0)
}

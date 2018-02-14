package main

import (
	"fmt"
	"time"
)

func fib(n int) int {
	if n < 3 {
		return 1
	}
	return fib(n-1) + fib(n-2)
}
func main() {
	a := time.Now()
	s := fib(45)
	b := time.Now()
	c := b.Sub(a)
	fmt.Println(c)
	fmt.Println(s)
}

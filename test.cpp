#include <iostream>
#include <ctime>

using namespace std;

unsigned long long int fib(int n)
{
    if(n < 3) return 1;
    
 
    return fib(n-1)+fib(n-2);
}

	int main()

{
    time_t t1 = time(0);  
    long s = 0;
    for(int i =0; i<3; i++){
        s = fib(45);
    }   
    time_t t2 = time(0); 
    time_t t3 = t2 -t1;
    cout << s << endl << t3 << endl << t3/3.0 << endl;
}
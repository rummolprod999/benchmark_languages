<?php

function fib($n)
{
    if($n<3) return 1;
    return fib($n-1) + fib($n-2);
}

$a = new DateTime();
$s = 0;
for($i = 0; $i <3; $i++){
    $s = fib(45);
}
$b = new DateTime();
$c = $b->diff($a);
printf("%d\n", $s);
printf("%f\n", $c->s);
printf("%f\n", $c->s/3.0);
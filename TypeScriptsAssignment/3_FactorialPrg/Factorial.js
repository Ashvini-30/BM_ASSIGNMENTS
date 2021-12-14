function Factorial(num1) {
    var fact = 1;
    for (var i = 1; i <= num1; i++) {
        fact = fact * i;
    }
    return fact;
}
console.log(Factorial(5));

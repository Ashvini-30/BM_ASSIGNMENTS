function Calculate(num1, num2, op) {
    if (op.charAt(0) == '+') {
        return num1 + num2;
    }
    else if (op.charAt(0) == '-') {
        return num1 - num2;
    }
    else if (op.charAt(0) == '*') {
        return num1 * num2;
    }
    else if (op.charAt(0) == '/') {
        if (num2 != 0) {
            return num1 / num2;
        }
        else {
            return 0;
        }
    }
    else {
        return "Invalid";
    }
}
console.log(Calculate(30, 10, '-'));
console.log(Calculate(30, 10, '+'));
console.log(Calculate(30, 10, '*'));
console.log(Calculate(30, 10, '/'));

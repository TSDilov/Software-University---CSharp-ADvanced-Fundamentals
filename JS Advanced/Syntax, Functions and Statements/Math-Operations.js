function operation(firstNumber, secondNumber, operator){
    let result;
    switch(operator){
        case '+': result = firstNumber + secondNumber; break;
        case '-': result = firstNumber - secondNumber; break;
        case '*': result = firstNumber * secondNumber; break;
        case '/': result = firstNumber / secondNumber; break;
        case '%': result = firstNumber % secondNumber; break;
        case '**': result = firstNumber ** secondNumber; break;
    }
    console.log(result);
}
operation(5, 2, '**');
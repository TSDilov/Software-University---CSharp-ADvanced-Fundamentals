function sameDigitsOfNumber(number){
    let firstDigit = number % 10;
    number -= firstDigit;
    number /= 10;
    let sum = firstDigit;
    let isSame = true;
    while (number !== 0) {
        let digit = number % 10;
        if (digit !== firstDigit) {
            isSame = false
        }
        number -= digit;
        number /= 10; 
        sum += digit;     
    }
    if (isSame) {
        console.log('true');
    }else{
        console.log('false');
    }
    console.log(sum);
}
sameDigitsOfNumber(2222222);

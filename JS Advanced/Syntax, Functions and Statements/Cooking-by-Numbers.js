function cookingByNumbers(numberAsString, firstOperation, secondOperation,
    thirdOperation, forthOperation, fifthOperation) {
    let number = Number(numberAsString);
    let operations = [firstOperation, secondOperation, thirdOperation, forthOperation, fifthOperation];
    for (let i = 0; i < operations.length; i++) {
        let currentOperation = operations[i];
        switch (currentOperation) {
            case 'chop':
                number /= 2;
                console.log(number);
                break;
            case 'dice':
                number = Math.sqrt(number);
                console.log(number);
                break;
            case 'spice':
                number += 1;
                console.log(number);
                break;
            case 'bake':
                number *= 3;
                console.log(number);
                break;
            case 'fillet':
                number -= number * 0.2;
                console.log(number);
                break;
        }
    }
}
cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');
function notation(array) {
    let numbersArray = [];
    for (let i = 0; i < array.length; i++) {
        if (Number.isInteger(array[i])) {
            numbersArray.push(array[i]);
        }else{
            let result = 0;
            switch (array[i]) {
                case '+':
                    result = numbersArray[numbersArray.length - 2] + numbersArray[numbersArray.length - 1];
                    break;
                case '-':
                    result = numbersArray[numbersArray.length - 2] - numbersArray[numbersArray.length - 1];
                    break;
                case '*':
                    result = numbersArray[numbersArray.length - 2] * numbersArray[numbersArray.length - 1];
                    break;
                case '/':
                    result = numbersArray[numbersArray.length - 2] / numbersArray[numbersArray.length - 1];
                    break;
            }
            numbersArray.pop();
            numbersArray.pop();
            numbersArray.push(result);
        }
    }

    if(numbersArray.length === 1 && !Number.isNaN(numbersArray[0])) {

        console.log(numbersArray[0]);
        return;

    }

    if(numbersArray.length > 1) {

        console.log('Error: too many operands!');
        return;
        
    } else if(array.filter(x => !Number.isInteger(x))) {

        console.log(`Error: not enough operands!`);
        return;
    }    
} 
notation([15,
    '/']
   
   );
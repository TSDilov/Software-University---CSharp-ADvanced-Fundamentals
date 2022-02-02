function addOrRemoveElements(arrayOfCommands) {
    let number = 1;
    let arrayOfNumbers = [];
    for (let command of arrayOfCommands) {
        if (command === 'add') {
            arrayOfNumbers.push(number);
        }
        else{
            arrayOfNumbers.pop();
        }

        number++;
    }

    if (arrayOfNumbers.length === 0) {
        console.log('Empty');
        return;
    }
    for (let number of arrayOfNumbers) {
        console.log(number);
    }
}
addOrRemoveElements(['add', 
'add', 
'add', 
'add']
);
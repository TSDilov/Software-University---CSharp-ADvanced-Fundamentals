function listProcessor(input) {
    let arrayOfStrings = [];
    for (let command of input) {
        currentCommand = command.split(' ');
        let commandType = currentCommand[0];
        let value = currentCommand[1];
        if (commandType === 'add') {
            arrayOfStrings.push(value);
        }else if (commandType === 'remove') {
            arrayOfStrings = arrayOfStrings.filter(s => s != value);
        }else{
            console.log(arrayOfStrings.join(','));
        }
    }
}

listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);
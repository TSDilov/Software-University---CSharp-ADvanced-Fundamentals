function argumentInfo(...arguments) {
    let numberCount = 0;
    let stringCount = 0;
    let functionCount = 0;
    let dictionaryOFArguments = {}
    for (let argument of arguments) { 
            console.log(`${typeof argument}: ${argument}`);
            let key = typeof argument;
            if (!dictionaryOFArguments[key]) {
                dictionaryOFArguments[key] = 0;
            }
            dictionaryOFArguments[key]++;
    }

    dictionaryOFArguments = Object.fromEntries(Object.entries(dictionaryOFArguments).sort(([, a], [, b]) => b - a));

    for (const key in  dictionaryOFArguments) {
        console.log(`${key} = ${dictionaryOFArguments[key]}`);
    }
}
argumentInfo('cat', 42, function () { console.log('Hello world!'); });

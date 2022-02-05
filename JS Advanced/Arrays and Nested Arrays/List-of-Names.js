function sortingNames(arrayOfNames) {
    arrayOfNames.sort((a, b) => a.localeCompare(b));
    for (let i = 1; i <= arrayOfNames.length; i++) {
        console.log(`${i}.${arrayOfNames[i - 1]}`);
    }
}
sortingNames(["John", "Bob", "Christina", "Ema"]);
function wordsUppercase(string) {
    string = string.toUpperCase();
    let regex = /[A-Za-z0-9]+/g;
    let strArray = [...string.matchAll(regex)];
    console.log(strArray.join(', '));
}
wordsUppercase('Hi, how are you?');
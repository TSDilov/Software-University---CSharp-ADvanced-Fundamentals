function nThElementFromArray(array, n) {
    let newArray = [];
    for (let i = 0; i < array.length; i += n) {
        newArray.push(array[i]);
    }
    return newArray;
}
console.log(nThElementFromArray(['5', 
'20', 
'31', 
'4', 
'20'], 
2
))
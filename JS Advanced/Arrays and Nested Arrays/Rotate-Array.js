function rotateArray(array, numberOfRotations) {
    for (let i = 0; i < numberOfRotations; i++) {
        let lastElement = array.pop();
        array.unshift(lastElement);
    }
    console.log(array.join(' '));
}
rotateArray(['1', 
'2', 
'3', 
'4'], 
2
);
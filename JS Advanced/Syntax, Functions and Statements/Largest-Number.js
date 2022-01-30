function largestNumber (a, b, c){
    let largestNumber;
    if(a > b){
        largestNumber = a;
        if(a < c){
            largestNumber = c;
        }
    }
    else{
        largestNumber = b;
        if(b < c){
            largestNumber = c;
        }
    }
    console.log(`The largest number is ${number}.`);
}
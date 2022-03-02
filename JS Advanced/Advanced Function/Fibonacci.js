function getFibonator() {
    let array = [ 0, 1 ];
    let number = 0;
    return function (){
        array[array.length] = array[array.length - 1] + array[array.length - 2]; 
        number = array[array.length - 2];
        return number;
    }
}
let fib = getFibonator();
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());


let array1 = ["string", 1, true, ["array1"], ["array2"], ["array3"], ["array4"]];

// console.log(array1);
// console.log(array1[0]);

// forEach
array1.forEach(function(item, index){
	console.log(item, index);
}); // [ 'string', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ], 'push' ] 0

// push
array1.push("push");
console.log(array1); // [ 'string', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ], 'push' ]

// pop
array1.pop();
console.log(array1); // [ 'string', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

// shift
array1.shift();
console.log(array1); // [ 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

// unshift
array1.unshift("unshift");
console.log(array1); // [ 'unshift', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

// indexOf
console.log(array1.indexOf(true)); // 1

// splice
array1.splice(true, 2); // [ 'unshift', 1, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

// slice
console.log(array1.slice(0, 2)); // [ 'unshift', 1 ]
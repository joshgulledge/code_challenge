// Write a simple parser that will parse and run Deadfish.

// Deadfish has 4 commands, each 1 character long:

// i increments the value (initially 0)
// d decrements the value
// s squares the value
// o outputs the value into the return array
// Invalid characters should be ignored.

function parse(data) {
	let value = 0;
	const retArr = [];

	[...data].forEach((letter) => {
		switch (letter) {
			case "i":
				value++;
				break;
			case "s":
				value = value * value;
				break;
			case "d":
				value--;
				break;
			case "o":
				retArr.push(value);
				break;
		}
	});

	return retArr;
}

console.log(parse("iiisdoso"));

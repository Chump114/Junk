if ((abs(x - x_fixed) <= 10) && (abs(y - y_fixed) <= 10))
	{
		isTouching = true;
	}
	else { isTouching = false; }


/*

It's basically saying that (absolute value of) the difference between their centers should be less than sum of their radii.

if 400 - 200 is less and equal than 5 + 5

*/
/******************************************************************************************************

I think it's more effective (and clean-looking) to create two new functions to handle the poo bounce.
Definitions:

******************************************************************************************************/
BounceScreenX(short int x, short int vx, short int width)
{
 short int left = x;
 short int right = x + width;

 if ((left + vx < 0) || (right + vx > gfx.ScreenWidth)) {
  return -vx;
 }
 else {
  return vx;
 }
}
BounceScreenY(short int y, short int vy, short int height)
{
 short int top = y;
 short int bottom = y + height;

 if ((top + vy < 0) || (bottom + vy > gfx.ScreenHeight)) {
  return -vy;
 }
 else {
  return vy;
 }
}

/******************************************************************************************************
These functions take the current position and velocity and calculate if the poos will be drawn off 
screen if they are drawn. If they would be drawn off the screen, they change the velocity to make 
the poo go the other direction ie a bounce.

Implementation ( in UpdateModel() ):
//Check if poo will go off screen and correct if necessary
poo0vx = BounceScreenX(poo0X, poo0vx, pooWidth);
poo0vy = BounceScreenY(poo0Y, poo0vy, pooWidth);

//Move poo
poo0X += poo0vx;
poo0Y += poo0vy;
// so I go to the shop to get some weapon for self defence

using _03_Abstract_Factory;

MilitaryItemsFactory factory = new RealMilitaryItemsFactory();

// this gun looks nice, i want to try it!
var pistolInMyHands = factory.CreatePistol();

pistolInMyHands.Shoot();

// whats inside this medikit?
var medikit = factory.CreateMedikit();
medikit.Use();

// Daddy! Can I also have a gun ? 
// Sure son, let me get you one!

// leaving the shop and going for the toy shop

// ok, lets find you something son...

factory = new KidsMilitaryItemsFactory();
pistolInMyHands = factory.CreatePistol();
// let my try it
pistolInMyHands.Shoot();

// oh and lets see what inside kids medikit
medikit = factory.CreateMedikit();
medikit.Use();

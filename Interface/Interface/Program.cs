using Interface;

/*Bird bird = new Bird();
IBird bird2 = new Bird();
Pterodactyl bird3 = new Pterodactyl();*/

IBird pterodactyl = new Pterodactyl();
pterodactyl.Sound();

((Pterodactyl)pterodactyl).Move();
pterodactyl.Breathe();
((ILizard)pterodactyl).Breathe();
((Pterodactyl)pterodactyl).Breathe();

if (pterodactyl is ILizard iLizard)
    iLizard.Breathe();

if (pterodactyl is ILizard)
{
    (pterodactyl as ILizard).Breathe();
}
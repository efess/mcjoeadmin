using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DummyConsole
{
    public static class MinecraftLog
    {
        public static string GetLog()
        {
            return @"2010-12-27 18:21:51 [INFO] Starting minecraft server version Beta 1.1_02
2010-12-27 18:21:51 [INFO] Loading properties
2010-12-27 18:21:51 [WARNING] server.properties does not exist
2010-12-27 18:21:51 [INFO] Generating new properties file
2010-12-27 18:21:51 [INFO] Starting Minecraft server on *:25565
2010-12-27 18:21:51 [WARNING] Failed to load ban list: java.io.FileNotFoundException: banned-players.txt (The system cannot find the file specified)
2010-12-27 18:21:51 [WARNING] Failed to load ip ban list: java.io.FileNotFoundException: banned-ips.txt (The system cannot find the file specified)
2010-12-27 18:21:51 [WARNING] Failed to load ip ban list: java.io.FileNotFoundException: ops.txt (The system cannot find the file specified)
2010-12-27 18:21:51 [INFO] Preparing level ""world""
2010-12-27 18:21:51 [INFO] Preparing start region
2010-12-27 18:21:59 [INFO] Done! For help, type ""help"" or ""?""
2010-12-27 18:22:14 [INFO] To run the server without a gui, start it like this:
2010-12-27 18:22:14 [INFO]    java -Xmx1024M -Xms1024M -jar minecraft_server.jar nogui
2010-12-27 18:22:14 [INFO] Console commands:
2010-12-27 18:22:14 [INFO]    help  or  ?               shows this message
2010-12-27 18:22:14 [INFO]    kick <player>             removes a player from the server
2010-12-27 18:22:14 [INFO]    ban <player>              bans a player from the server
2010-12-27 18:22:14 [INFO]    pardon <player>           pardons a banned player so that they can connect again
2010-12-27 18:22:14 [INFO]    ban-ip <ip>               bans an IP address from the server
2010-12-27 18:22:14 [INFO]    pardon-ip <ip>            pardons a banned IP address so that they can connect again
2010-12-27 18:22:14 [INFO]    op <player>               turns a player into an op
2010-12-27 18:22:14 [INFO]    deop <player>             removes op status from a player
2010-12-27 18:22:14 [INFO]    tp <player1> <player2>    moves one player to the same location as another player
2010-12-27 18:22:14 [INFO]    give <player> <id> [num]  gives a player a resource
2010-12-27 18:22:14 [INFO]    tell <player> <message>   sends a private message to a player
2010-12-27 18:22:14 [INFO]    stop                      gracefully stops the server
2010-12-27 18:22:14 [INFO]    save-all                  forces a server-wide level save
2010-12-27 18:22:14 [INFO]    save-off                  disables terrain saving (useful for backup scripts)
2010-12-27 18:22:14 [INFO]    save-on                   re-enables terrain saving
2010-12-27 18:22:14 [INFO]    list                      lists all currently connected players
2010-12-27 18:22:14 [INFO]    say <message>             broadcasts a message to all players
2010-12-27 18:23:53 [INFO] Stopping server
2010-12-27 18:23:53 [INFO] Saving chunks
2010-12-27 18:24:32 [INFO] Starting minecraft server version Beta 1.1_02
2010-12-27 18:24:32 [INFO] Loading properties
2010-12-27 18:24:32 [INFO] Starting Minecraft server on *:25565
2010-12-27 18:24:32 [INFO] Preparing level ""world""
2010-12-27 18:24:32 [INFO] Preparing start region
2010-12-27 18:24:33 [INFO] Done! For help, type ""help"" or ""?""
2010-12-27 18:27:38 [INFO] Disconnecting efess [/69.119.7.235:30998]: Took too long to log in
2010-12-27 18:27:50 [INFO] efess [/69.119.7.235:31007] logged in with entity id 1
2010-12-27 18:32:36 [INFO] efess tried command: home
2010-12-27 18:32:39 [INFO] efess tried command: home
2010-12-27 18:32:40 [INFO] efess tried command: spawn
2010-12-27 18:34:48 [INFO] efess lost connection: disconnect.quitting
2010-12-28 08:23:16 [WARNING] Time ran backwards! Did the system time change?
2010-12-28 08:23:16 [WARNING] Time ran backwards! Did the system time change?
2010-12-29 08:05:48 [INFO] Starting minecraft server version Beta 1.1_02
2010-12-29 08:05:48 [INFO] Loading properties
2010-12-29 08:05:48 [INFO] Starting Minecraft server on *:25565
2010-12-29 08:05:48 [INFO] Preparing level ""world""
2010-12-29 08:05:48 [INFO] Preparing start region
2010-12-29 08:05:53 [INFO] Done! For help, type ""help"" or ""?""
2010-12-29 08:05:55 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2010-12-29 09:34:54 [INFO] /0:0:0:0:0:0:0:1:3178 lost connection
2010-12-29 09:40:29 [INFO] Disconnecting /206.251.36.137:60544: Took too long to log in
2010-12-29 09:41:51 [INFO] Starting minecraft server version Beta 1.1_02
2010-12-29 09:41:51 [INFO] Loading properties
2010-12-29 09:41:51 [INFO] Starting Minecraft server on *:25565
2010-12-29 09:41:51 [INFO] Preparing level ""world""
2010-12-29 09:41:51 [INFO] Preparing start region
2010-12-29 09:41:52 [INFO] Done! For help, type ""help"" or ""?""
2010-12-29 09:48:33 [INFO] Disconnecting /206.251.36.137:60211: Took too long to log in
2010-12-29 09:48:34 [INFO] nawf [/76.23.232.27:55066] logged in with entity id 22
2010-12-29 09:53:42 [INFO] nawf lost connection: disconnect.quitting
2010-12-29 18:18:00 [INFO] nawf [/76.23.232.27:55036] logged in with entity id 4271
2010-12-29 19:12:06 [INFO] To run the server without a gui, start it like this:
2010-12-29 19:12:06 [INFO]    java -Xmx1024M -Xms1024M -jar minecraft_server.jar nogui
2010-12-29 19:12:06 [INFO] Console commands:
2010-12-29 19:12:06 [INFO]    help  or  ?               shows this message
2010-12-29 19:12:06 [INFO]    kick <player>             removes a player from the server
2010-12-29 19:12:06 [INFO]    ban <player>              bans a player from the server
2010-12-29 19:12:06 [INFO]    pardon <player>           pardons a banned player so that they can connect again
2010-12-29 19:12:06 [INFO]    ban-ip <ip>               bans an IP address from the server
2010-12-29 19:12:06 [INFO]    pardon-ip <ip>            pardons a banned IP address so that they can connect again
2010-12-29 19:12:06 [INFO]    op <player>               turns a player into an op
2010-12-29 19:12:06 [INFO]    deop <player>             removes op status from a player
2010-12-29 19:12:06 [INFO]    tp <player1> <player2>    moves one player to the same location as another player
2010-12-29 19:12:06 [INFO]    give <player> <id> [num]  gives a player a resource
2010-12-29 19:12:06 [INFO]    tell <player> <message>   sends a private message to a player
2010-12-29 19:12:06 [INFO]    stop                      gracefully stops the server
2010-12-29 19:12:06 [INFO]    save-all                  forces a server-wide level save
2010-12-29 19:12:06 [INFO]    save-off                  disables terrain saving (useful for backup scripts)
2010-12-29 19:12:06 [INFO]    save-on                   re-enables terrain saving
2010-12-29 19:12:06 [INFO]    list                      lists all currently connected players
2010-12-29 19:12:06 [INFO]    say <message>             broadcasts a message to all players
2010-12-29 19:14:31 [INFO] efess [/192.168.0.198:15142] logged in with entity id 42442
2010-12-29 19:14:42 [INFO] <efess> yo
2010-12-29 19:14:45 [INFO] <nawf> yo
2010-12-29 19:14:54 [INFO] <efess> so I guess there's no way to change it
2010-12-29 19:14:57 [INFO] <efess> in multiplayer
2010-12-29 19:15:05 [INFO] <nawf> I jumped down, one heart left
2010-12-29 19:15:05 [INFO] <efess> monsters are either off, or hard
2010-12-29 19:15:57 [INFO] <efess> fkn decaying leaves are awesome
2010-12-29 19:20:04 [INFO] <efess> sux starting from scratch
2010-12-29 19:24:50 [INFO] <nawf> yeah, I have a safe place
2010-12-29 19:24:55 [INFO] <nawf> which way did you go from the spawn?
2010-12-29 19:25:03 [INFO] <efess> i'm not far off
2010-12-29 19:25:10 [INFO] <efess> you can see torches
2010-12-29 19:25:26 [INFO] <efess> in the side of a mountain
2010-12-29 19:25:27 [INFO] <efess> shit spid
2010-12-29 19:25:29 [INFO] <efess> er
2010-12-29 19:27:57 [INFO] <efess> so tempted to bake smooth stone right now... OCD kickin gin
2010-12-29 19:29:30 [INFO] <nawf> lol, snow on sand
2010-12-29 19:30:53 [INFO] <efess> find a cave yet?
2010-12-29 19:32:10 [INFO] <nawf> yeah, now I'm looking for you
2010-12-29 19:33:26 [INFO] <nawf> can you see the floating islands up in the sky?
2010-12-29 19:33:29 [INFO] <efess> fuckin creeper on the mountain peak
2010-12-29 19:33:35 [INFO] <efess> im at the spawn
2010-12-29 19:34:02 [INFO] <nawf> I found your house
2010-12-29 19:34:48 [INFO] <efess> 1/2 health
2010-12-29 19:34:49 [INFO] <efess> lol
2010-12-29 19:34:56 [INFO] <nawf> lol arrows
2010-12-29 19:35:05 [INFO] <nawf> I made a house over here
2010-12-29 19:35:34 [INFO] <efess> lol sand tower
2010-12-29 19:35:47 [INFO] <nawf> yeah, thats where I was stuck
2010-12-29 19:36:15 [INFO] <efess> the john abode
2010-12-29 19:36:29 [INFO] <efess> nice cave in your house
2010-12-29 19:36:51 [INFO] <nawf> I just liked the snowy mountain
2010-12-29 19:36:54 [INFO] <efess> ya
2010-12-29 19:37:06 [INFO] <efess> my other world is snow
2010-12-29 19:37:11 [INFO] <efess> i can't appreciate snow anymore
2010-12-29 19:37:12 [INFO] <efess> lol
2010-12-29 19:37:20 [INFO] <nawf> ah, I barely have any
2010-12-29 19:37:45 [INFO] <efess> need to kill biggs
2010-12-29 19:37:47 [INFO] <efess> pigz
2010-12-29 19:40:17 [INFO] <nawf> lawl
2010-12-29 19:40:24 [INFO] <efess> bastard
2010-12-29 19:41:28 [INFO] <efess> i have to turn that off
2010-12-29 19:41:29 [INFO] <nawf> lol
2010-12-29 19:41:29 [INFO] <efess> lol
2010-12-29 19:42:00 [INFO] <efess> woa
2010-12-29 19:42:00 [INFO] <efess> wtf
2010-12-29 19:42:14 [INFO] <efess> missing chunk here lol
2010-12-29 19:42:20 [INFO] <nawf> lay torches down
2010-12-29 19:42:34 [INFO] <nawf> see I see it ok
2010-12-29 19:42:47 [INFO] <efess> damnit notch
2010-12-29 19:43:40 [INFO] <efess> haha
2010-12-29 19:44:27 [INFO] <efess> cave here
2010-12-29 19:44:42 [INFO] <efess> oh its nothign
2010-12-29 19:44:43 [INFO] <nawf> found one
2010-12-29 19:44:55 [INFO] <nawf> and two creepers
2010-12-29 19:44:59 [INFO] <nawf> sssssssssssss
2010-12-29 19:45:06 [INFO] <efess> Boom?
2010-12-29 19:45:14 [INFO] <nawf> I'll clear them out
2010-12-29 19:45:47 [INFO] <nawf> shit, they are not jumping
2010-12-29 19:45:51 [INFO] <efess> my client is freakin gout
2010-12-29 19:45:59 [INFO] <efess> server's still not updating it
2010-12-29 19:46:15 [INFO] <efess> ouch
2010-12-29 19:46:17 [INFO] <efess> i sqw that
2010-12-29 19:46:18 [INFO] <efess> brb
2010-12-29 19:46:20 [INFO] efess lost connection: disconnect.quitting
2010-12-29 19:46:22 [INFO] <nawf> I cleared them out
2010-12-29 19:46:26 [INFO] efess [/192.168.0.198:15480] logged in with entity id 74619
2010-12-29 19:46:30 [INFO] <efess> there we go
2010-12-29 19:47:26 [INFO] <nawf> lol
2010-12-29 19:47:37 [INFO] <nawf> there's the moon
2010-12-29 19:47:44 [INFO] <efess> nice haha
2010-12-29 19:47:52 [INFO] <nawf> there was another way down
2010-12-29 19:47:54 [INFO] <efess> pretty sweet
2010-12-29 19:49:44 [INFO] <nawf> oh fuck
2010-12-29 19:49:48 [INFO] <nawf> creeper fell on me
2010-12-29 19:50:00 [INFO] <efess> asshole
2010-12-29 19:50:24 [INFO] <nawf> damn, I died
2010-12-29 19:50:27 [INFO] <nawf> get my shit
2010-12-29 19:50:33 [INFO] <nawf> lol
2010-12-29 19:54:59 [INFO] <nawf> foudn ironz
2010-12-29 19:55:06 [INFO] <efess> nice
2010-12-29 19:55:16 [INFO] <nawf> lol, stole your stick
2010-12-29 19:55:19 [INFO] <nawf> ssssss
2010-12-29 19:55:50 [INFO] <nawf> fuck
2010-12-29 19:56:09 [INFO] <efess> stop playing with the monsters
2010-12-29 19:56:42 [INFO] <nawf> fuck
2010-12-29 19:58:46 [INFO] <efess> saplings wooo
2010-12-29 20:01:28 [INFO] <efess> omg wtf monsters
2010-12-29 20:01:49 [INFO] <efess> droppin gfrom the ceiling
2010-12-29 20:04:31 [INFO] <efess> lol
2010-12-29 20:04:51 [INFO] <nawf> lol
2010-12-29 20:04:55 [INFO] <nawf> pool has aids
2010-12-29 20:04:59 [INFO] <nawf> gtfo
2010-12-29 20:05:10 [INFO] <efess> ffffuuuu
2010-12-29 20:05:13 [INFO] <efess> hahaha
2010-12-29 20:06:37 [INFO] <nawf> I half a heart
2010-12-29 20:06:55 [INFO] <efess> rofl
2010-12-29 20:07:01 [INFO] <nawf> yay, you healed me
2010-12-29 20:07:06 [INFO] <efess> np
2010-12-29 20:07:57 [INFO] <efess> lol @ fence
2010-12-29 20:11:06 [INFO] <efess> fu creeper
2010-12-29 20:12:08 [INFO] <nawf> that place were the monsters dropped in opens into a huge cavern
2010-12-29 20:12:11 [INFO] <nawf> coal, iron
2010-12-29 20:12:15 [INFO] <efess> oh your down there
2010-12-29 20:12:45 [INFO] <efess> SSSSSSSSS
2010-12-29 20:12:46 [INFO] <efess> FU
2010-12-29 20:13:48 [INFO] <nawf> lol
2010-12-29 20:14:00 [INFO] <nawf> my fences nooooo
2010-12-29 20:15:07 [INFO] <nawf> uh wtf
2010-12-29 20:15:17 [INFO] <efess> ?
2010-12-29 20:15:21 [INFO] <nawf> client going nuts
2010-12-29 20:15:23 [INFO] nawf lost connection: disconnect.quitting
2010-12-29 20:15:29 [INFO] nawf [/76.23.232.27:55032] logged in with entity id 96051
2010-12-29 20:22:07 [INFO] <efess> wtf
2010-12-29 20:22:08 [INFO] <nawf> roflrofl
2010-12-29 20:22:11 [INFO] <efess> ??
2010-12-29 20:22:14 [INFO] <nawf> I tried to aggro him to you
2010-12-29 20:22:14 [INFO] <efess> tnt?
2010-12-29 20:22:17 [INFO] <efess> haha
2010-12-29 20:22:21 [INFO] <efess> slut
2010-12-29 20:22:23 [INFO] <nawf> ofl
2010-12-29 20:22:33 [INFO] <nawf> I think they just aggro to one player
2010-12-29 20:24:02 [INFO] <nawf> I torched out above our base
2010-12-29 20:24:07 [INFO] <efess> nince
2010-12-29 20:24:10 [INFO] <nawf> maybe they won't drop on our heads anymore
2010-12-29 20:24:38 [INFO] <efess> weird watching the numbers change
2010-12-29 20:24:39 [INFO] <efess> in the chest
2010-12-29 20:24:40 [INFO] <efess> lol
2010-12-29 20:25:02 [INFO] <nawf> at least we have shit now
2010-12-29 20:25:06 [INFO] efess lost connection: disconnect.genericReason
2010-12-29 20:25:12 [INFO] efess [/192.168.0.198:15993] logged in with entity id 102213
2010-12-29 20:27:01 [INFO] <nawf> another cave by the gravel i nthe stairway down
2010-12-29 20:29:17 [INFO] <efess> wtf zombies can jump on fences
2010-12-29 20:29:27 [INFO] <nawf> they shouldn't
2010-12-29 20:29:33 [INFO] <efess> that bitch did
2010-12-29 20:32:28 [INFO] <efess> oh
2010-12-29 20:32:30 [INFO] <efess> got sonic 4
2010-12-29 20:32:33 [INFO] <efess> for wii
2010-12-29 20:32:37 [INFO] <nawf> good?
2010-12-29 20:32:42 [INFO] <efess> yea nothing special though
2010-12-29 20:33:00 [INFO] <efess> its like... sonic 2.. exactly.. with different physics
2010-12-29 20:34:06 [INFO] <efess> love the creeper right at our door
2010-12-29 20:34:08 [INFO] <efess> lol
2010-12-29 20:34:23 [INFO] <nawf> I fell
2010-12-29 20:36:07 [INFO] <nawf> wtf
2010-12-29 20:36:11 [INFO] nawf lost connection: disconnect.quitting
2010-12-29 20:36:46 [INFO] Disconnecting /76.23.232.27:55019: Took too long to log in
2010-12-29 20:37:22 [INFO] Disconnecting nawf [/76.23.232.27:55072]: Took too long to log in
2010-12-29 20:38:08 [INFO] nawf [/76.23.232.27:55020] logged in with entity id 111012
2010-12-29 20:38:36 [INFO] <nawf> that fence thing looks cool
2010-12-29 20:38:42 [INFO] <nawf> saw it on reddit before
2010-12-29 20:38:53 [INFO] <nawf> I mean the stairs
2010-12-29 20:39:33 [INFO] <efess> nicee
2010-12-29 20:40:43 [INFO] <nawf> lol pig
2010-12-29 20:40:50 [INFO] <efess> haha
2010-12-29 20:40:58 [INFO] <efess> get down from there pig
2010-12-29 20:45:21 [INFO] <efess> think it nees to be higher
2010-12-29 20:45:23 [INFO] <efess> >
2010-12-29 20:45:30 [INFO] <efess> ?
2010-12-29 20:45:41 [INFO] <nawf> yeah
2010-12-29 20:47:09 [INFO] <efess> haha
2010-12-29 20:51:25 [INFO] <nawf> he
2010-12-29 20:51:30 [INFO] <nawf> is still by the door
2010-12-29 20:51:59 [INFO] <efess> burn baby
2010-12-29 20:52:21 [INFO] <efess> lol
2010-12-29 20:52:56 [INFO] <efess> got string
2010-12-29 20:53:12 [INFO] <nawf> I saw some in the chest I htink
2010-12-29 20:53:20 [INFO] <efess> yup
2010-12-29 20:53:22 [INFO] <efess> got more
2010-12-29 20:53:23 [INFO] <efess> bow time
2010-12-29 20:59:07 [INFO] <efess> do you ahve any use for gravel?
2010-12-29 20:59:18 [INFO] <nawf> filler
2010-12-29 21:00:20 [INFO] <nawf> lol, creeper made a pond for me
2010-12-29 21:01:52 [INFO] <efess> jess almost punched me in the face
2010-12-29 21:01:57 [INFO] <efess> dancing to michael jackson
2010-12-29 21:02:01 [INFO] <efess> for the wii
2010-12-29 21:03:17 [INFO] <nawf> lol
2010-12-29 21:03:54 [INFO] <efess> nice bridge
2010-12-29 21:06:33 [INFO] <efess> this cave is dead?
2010-12-29 21:06:36 [INFO] <nawf> I think so
2010-12-29 21:06:38 [INFO] <nawf> lame
2010-12-29 21:07:19 [INFO] <nawf> nope
2010-12-29 21:07:24 [INFO] <nawf> found a dark room
2010-12-29 21:08:10 [INFO] <nawf> I have no torches
2010-12-29 21:08:49 [INFO] <nawf> thats a mob spawner
2010-12-29 21:08:54 [INFO] <efess> iice
2010-12-29 21:08:56 [INFO] <efess> zombie
2010-12-29 21:09:38 [INFO] <nawf> found it
2010-12-29 21:09:58 [INFO] efess lost connection: disconnect.genericReason
2010-12-29 21:10:04 [INFO] efess [/192.168.0.198:16464] logged in with entity id 134376
2010-12-29 21:10:11 [INFO] <efess> nice
2010-12-29 21:10:12 [INFO] <nawf> dude, you know what we can do
2010-12-29 21:10:17 [INFO] <nawf> if you go over me and dig down
2010-12-29 21:10:19 [INFO] <efess> zombie killing machine?
2010-12-29 21:10:37 [INFO] <efess> well I gtg
2010-12-29 21:10:44 [INFO] <efess> oh hold on
2010-12-29 21:10:52 [INFO] <efess> gotta get some wii games for Jess
2010-12-29 21:10:54 [INFO] <efess> brb
2010-12-29 21:11:01 [INFO] efess lost connection: disconnect.quitting
2010-12-29 21:21:26 [INFO] Unknown console command. Type ""help"" for help.
2010-12-29 21:21:32 [INFO] [CONSOLE] arrrrr
2010-12-29 21:27:47 [INFO] efess [/192.168.0.198:16645] logged in with entity id 145008
2010-12-29 21:28:06 [INFO] <efess> k what'd I miss
2010-12-29 21:28:20 [INFO] <nawf> nothing much
2010-12-29 21:28:35 [INFO] <nawf> I torched out the mob spawner
2010-12-29 21:28:47 [INFO] <efess> yea that chest has a lot of iron
2010-12-29 21:28:54 [INFO] <nawf> nice
2010-12-29 21:29:01 [INFO] <efess> goin gto bring it up b4 I die
2010-12-29 21:29:01 [INFO] <efess> lol
2010-12-29 21:29:07 [INFO] <nawf> yeah, I have one heart left
2010-12-29 21:30:11 [INFO] <efess> lol faggots
2010-12-29 21:30:14 [INFO] <nawf> rofl
2010-12-29 21:30:25 [INFO] <efess> hahaha
2010-12-29 21:30:26 [INFO] <efess> rofl
2010-12-29 21:30:41 [INFO] <efess> you know
2010-12-29 21:30:51 [INFO] <efess> there's a team that created a minecraft decompiler
2010-12-29 21:30:57 [INFO] <nawf> figured I'd oranize, seems weird though, have to finish the room before wsettle on where shit is
2010-12-29 21:31:04 [INFO] <nawf> yeah, I heard
2010-12-29 21:31:10 [INFO] <nawf> they say notch is dumb
2010-12-29 21:31:16 [INFO] <efess> really
2010-12-29 21:31:40 [INFO] <efess> not suprised, knowing all the bugs that he put in here
2010-12-29 21:31:41 [INFO] <nawf> yeah, lots of hardcoded stuff, lots of public fields that should be private
2010-12-29 21:31:48 [INFO] <efess> he sounds like a get er done programmer
2010-12-29 21:31:48 [INFO] <nawf> save data isn't optimized
2010-12-29 21:32:00 [INFO] <nawf> yeah, this was his hobby project so who cares right?
2010-12-29 21:32:17 [INFO] <efess> yea, I am impressed with shit like water and the world generator
2010-12-29 21:32:28 [INFO] <nawf> fcking creeper in my river
2010-12-29 21:33:44 [INFO] <nawf> I'm going to respawn and go, I was supposed to get something done tonight
2010-12-29 21:33:46 [INFO] <nawf> lol
2010-12-29 21:33:50 [INFO] <efess> haha alright
2010-12-29 21:33:51 [INFO] <nawf> first take my egg
2010-12-29 21:33:56 [INFO] <nawf> I have one egg
2010-12-29 21:34:12 [INFO] <efess> nice
2010-12-29 21:34:58 [INFO] <nawf> aight, ttyl
2010-12-29 21:35:04 [INFO] <efess> l8er dude
2010-12-29 21:35:07 [INFO] nawf lost connection: disconnect.quitting
2010-12-29 21:35:08 [INFO] <efess> hey
2010-12-29 22:03:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2010-12-29 22:41:40 [INFO] efess lost connection: disconnect.genericReason
2010-12-29 22:41:45 [INFO] efess [/192.168.0.198:17435] logged in with entity id 192263
2010-12-29 23:24:26 [INFO] efess lost connection: disconnect.quitting
2010-12-30 19:21:49 [INFO] efess [/192.168.0.198:33206] logged in with entity id 220593
2010-12-30 20:18:06 [INFO] efess lost connection: disconnect.quitting
2010-12-31 11:30:34 [INFO] efess [/192.168.0.198:48402] logged in with entity id 259513
2010-12-31 12:17:16 [INFO] efess lost connection: disconnect.quitting
2010-12-31 12:17:24 [INFO] efess [/192.168.0.198:48901] logged in with entity id 288211
2010-12-31 12:17:28 [INFO] efess lost connection: disconnect.genericReason
2010-12-31 12:17:47 [INFO] efess [/192.168.0.198:48908] logged in with entity id 288243
2010-12-31 12:17:51 [INFO] nawf [/76.23.232.27:55066] logged in with entity id 288264
2010-12-31 12:17:58 [INFO] <efess> lulz
2010-12-31 12:17:59 [INFO] <nawf> oh , lol
2010-12-31 12:18:04 [INFO] <efess> you have one too
2010-12-31 12:18:05 [INFO] <efess> weird
2010-12-31 12:18:22 [INFO] <efess> maybe because of new years
2010-12-31 12:18:26 [INFO] <nawf> oh yeah
2010-12-31 12:18:41 [INFO] <efess> lol mr jones
2010-12-31 12:19:42 [INFO] <efess> do you use a texture mod?
2010-12-31 12:19:51 [INFO] <nawf> naw, just better grass and better light
2010-12-31 12:19:56 [INFO] <efess> ya
2010-12-31 12:20:00 [INFO] <efess> I downloaded that too
2010-12-31 12:20:07 [INFO] <efess> you don' tuse the minimap?
2010-12-31 12:20:12 [INFO] <nawf> naw
2010-12-31 12:20:24 [INFO] <nawf> lol
2010-12-31 12:21:18 [INFO] <nawf> holy cave to the left
2010-12-31 12:21:22 [INFO] <efess> ya
2010-12-31 12:21:23 [INFO] <efess> hehe
2010-12-31 12:21:23 [INFO] <nawf> lol
2010-12-31 12:21:25 [INFO] <nawf> boom
2010-12-31 12:21:36 [INFO] <efess> creeper didn't recognize me
2010-12-31 12:22:09 [INFO] <nawf> zombie in cave
2010-12-31 12:22:11 [INFO] <efess> I think the cave is done though
2010-12-31 12:22:48 [INFO] <efess> so I have a theory
2010-12-31 12:22:55 [INFO] <efess> difficulty increases the more people are on the server
2010-12-31 12:23:12 [INFO] <efess> that's a skeleton and a zombie I saw here
2010-12-31 12:23:22 [INFO] <efess> but nothign spawned b4 you joined
2010-12-31 12:23:27 [INFO] <nawf> well it looks kinda dark in here
2010-12-31 12:24:13 [INFO] <nawf> well I gtg get this build out
2010-12-31 12:24:17 [INFO] <efess> good luck
2010-12-31 12:24:18 [INFO] <nawf> I'll join in later
2010-12-31 12:24:25 [INFO] nawf lost connection: disconnect.quitting
2010-12-31 12:41:54 [INFO] efess lost connection: disconnect.quitting
2010-12-31 13:37:21 [INFO] nawf [/76.23.232.27:55019] logged in with entity id 303048
2010-12-31 14:31:51 [INFO] nawf lost connection: disconnect.quitting
2010-12-31 15:09:01 [INFO] efess [/192.168.0.198:49627] logged in with entity id 422554
2010-12-31 16:04:04 [INFO] efess lost connection: disconnect.quitting
2011-01-01 10:55:04 [INFO] efess [/192.168.0.198:50746] logged in with entity id 457695
2011-01-01 11:15:16 [INFO] nawf [/76.23.232.27:55093] logged in with entity id 470715
2011-01-01 11:15:21 [INFO] <efess> yo
2011-01-01 11:15:24 [INFO] <nawf> yo
2011-01-01 11:15:31 [INFO] <efess> found first diamondz
2011-01-01 11:15:34 [INFO] <nawf> woo
2011-01-01 11:15:50 [INFO] <efess> let me show you the cave
2011-01-01 11:19:05 [INFO] <nawf> do you have an iron pick
2011-01-01 11:19:08 [INFO] <efess> ya\
2011-01-01 11:19:22 [INFO] <nawf> bucket?
2011-01-01 11:19:27 [INFO] <efess> no
2011-01-01 11:19:38 [INFO] <nawf> I'll clear lava, just smelting some ironz
2011-01-01 11:19:42 [INFO] <efess> ah
2011-01-01 11:20:05 [INFO] <efess> so I downloaded a tron skin pack
2011-01-01 11:20:18 [INFO] <efess> makes everything flat colors
2011-01-01 11:20:20 [INFO] <efess> its real cool
2011-01-01 11:22:53 [INFO] <efess> lol it takes a iron pick axe to mine gold
2011-01-01 11:23:12 [INFO] <nawf> do you have wood?  I'm out of torches?
2011-01-01 11:23:23 [INFO] <efess> all I have
2011-01-01 11:23:33 [INFO] <efess> ill go get more
2011-01-01 11:23:45 [INFO] <efess> moar!
2011-01-01 11:23:53 [INFO] <nawf> need faggots
2011-01-01 11:24:02 [INFO] <efess> we require more faggots
2011-01-01 11:30:11 [INFO] <nawf> diamonds!
2011-01-01 11:30:21 [INFO] <nawf> lol, you pushed me down here
2011-01-01 11:30:21 [INFO] <efess> is nice
2011-01-01 11:33:57 [INFO] <nawf> lol
2011-01-01 11:38:24 [INFO] <efess> lol gold
2011-01-01 11:40:32 [INFO] <nawf> I think there is mob spawner around here
2011-01-01 11:40:32 [INFO] <efess> where is he
2011-01-01 11:40:34 [INFO] <efess> hehe
2011-01-01 11:42:13 [INFO] <efess> yay pool
2011-01-01 11:44:28 [INFO] <nawf> god damnit zombies where are you
2011-01-01 11:47:14 [INFO] <efess> 3d maze?
2011-01-01 11:47:21 [INFO] <nawf> lol
2011-01-01 11:47:25 [INFO] <nawf> rying to find the zombies
2011-01-01 11:47:33 [INFO] <efess> don't hear them anymore
2011-01-01 11:48:20 [INFO] <efess> i hear them over here
2011-01-01 11:48:53 [INFO] <efess> here they rae
2011-01-01 11:48:59 [INFO] <nawf> I found them too
2011-01-01 11:51:08 [INFO] <nawf> lol
2011-01-01 11:51:10 [INFO] <efess> lulz.
2011-01-01 11:53:45 [INFO] <efess> lol
2011-01-01 11:58:32 [INFO] <nawf> need anything?
2011-01-01 11:58:38 [INFO] <efess> pickaxes
2011-01-01 11:58:52 [INFO] <nawf> alright
2011-01-01 11:59:01 [INFO] <nawf> oh, your here
2011-01-01 11:59:03 [INFO] <nawf> lol
2011-01-01 11:59:05 [INFO] <efess> haha
2011-01-01 12:06:31 [INFO] <efess> boom
2011-01-01 12:07:47 [INFO] <nawf> diamondzzzzzz
2011-01-01 12:07:47 [INFO] <efess> mmm splunk splunk
2011-01-01 12:08:33 [INFO] <efess> damn this place is huge
2011-01-01 12:11:11 [INFO] <nawf> found skeleton archer
2011-01-01 12:11:13 [INFO] <nawf> he's a dick
2011-01-01 12:12:24 [INFO] <nawf> holy fuck
2011-01-01 12:12:29 [INFO] <nawf> there is more huge caverns
2011-01-01 12:12:33 [INFO] <efess> I know haha
2011-01-01 12:12:45 [INFO] <efess> I had to make more torches
2011-01-01 12:21:00 [INFO] <efess> f8coer]
2011-01-01 12:21:08 [INFO] <efess> scared the shit
2011-01-01 12:21:10 [INFO] <efess> outa me
2011-01-01 12:21:11 [INFO] <efess> lo
2011-01-01 12:21:11 [INFO] <nawf> rofl
2011-01-01 12:21:20 [INFO] <efess> fffuuu
2011-01-01 12:21:25 [INFO] <efess> jess was like ""creeper?""
2011-01-01 12:21:28 [INFO] <efess> yea fucking john
2011-01-01 12:22:28 [INFO] <nawf> I have tons of pick axes
2011-01-01 12:22:32 [INFO] <nawf> if you need them
2011-01-01 12:22:37 [INFO] <efess> got 5
2011-01-01 12:22:46 [INFO] <nawf> 11
2011-01-01 12:24:22 [INFO] <nawf> I think I cleared this hallway
2011-01-01 12:29:22 [INFO] <efess> man
2011-01-01 12:29:27 [INFO] <efess> i did not have much to drink last night
2011-01-01 12:29:33 [INFO] <efess> but I feel like I got hammered
2011-01-01 12:29:45 [INFO] <efess> nice
2011-01-01 12:29:56 [INFO] <nawf> gonna seal it off
2011-01-01 12:30:06 [INFO] <efess> ya fuck that closed area
2011-01-01 12:36:04 [INFO] <nawf> daym
2011-01-01 12:36:16 [INFO] <nawf> I'm building a stairway up so we can haul out shit out
2011-01-01 12:36:21 [INFO] <nawf> and I think I'm inside of a mountain
2011-01-01 12:41:04 [INFO] <nawf> ;
2011-01-01 12:41:20 [INFO] <efess> spiders
2011-01-01 12:41:24 [INFO] <nawf> I think this connects into our earlier cave
2011-01-01 12:41:51 [INFO] <efess> lol chunk errors
2011-01-01 12:42:14 [INFO] <nawf> lol, another opening
2011-01-01 12:43:19 [INFO] <nawf> you have any fud?
2011-01-01 12:43:26 [INFO] <efess> ya a little
2011-01-01 12:43:30 [INFO] <nawf> I have one heart
2011-01-01 12:43:39 [INFO] <efess> here
2011-01-01 12:43:51 [INFO] <nawf> sweet, thanks
2011-01-01 12:44:32 [INFO] <nawf> brb
2011-01-01 12:56:16 [INFO] <nawf> wheat farm?
2011-01-01 12:56:24 [INFO] <efess> yesssss
2011-01-01 12:56:41 [INFO] <nawf> there is a nice flat area to the right of our base
2011-01-01 13:00:10 [INFO] <nawf> yo
2011-01-01 13:00:19 [INFO] <efess> ?
2011-01-01 13:00:25 [INFO] <nawf> I'm going to jet, heading into torrington to go to target actually
2011-01-01 13:00:32 [INFO] <efess> alright
2011-01-01 13:00:37 [INFO] <nawf> then maybe work on the wheat farm or something
2011-01-01 13:00:41 [INFO] <nawf> or work
2011-01-01 13:00:43 [INFO] <nawf> :/
2011-01-01 13:00:51 [INFO] <efess> i'll probably be around
2011-01-01 13:00:53 [INFO] <efess> most of the dya
2011-01-01 13:00:59 [INFO] <efess> feel like shit
2011-01-01 13:01:07 [INFO] <efess> can't do anything but minecraft
2011-01-01 13:01:08 [INFO] <efess> haha
2011-01-01 13:01:14 [INFO] <nawf> ok, I'll ttyl then, that stinks, I only had 2 more drinks, I keep pretty sober
2011-01-01 13:01:27 [INFO] <efess> ya I donno, maybe it was something else
2011-01-01 13:01:38 [INFO] <efess> usually my hangovers go away by now
2011-01-01 13:01:38 [INFO] <nawf> aids in the pool
2011-01-01 13:01:40 [INFO] <efess> yea
2011-01-01 13:01:51 [INFO] <nawf> see yah
2011-01-01 13:01:53 [INFO] <efess> l8r man
2011-01-01 13:01:55 [INFO] nawf lost connection: disconnect.quitting
2011-01-01 15:36:36 [INFO] efess lost connection: disconnect.quitting
2011-01-01 15:36:40 [INFO] efess [/192.168.0.198:52525] logged in with entity id 668316
2011-01-01 16:04:44 [INFO] efess lost connection: disconnect.quitting
2011-01-01 16:06:20 [INFO] nawf [/76.23.232.27:55118] logged in with entity id 686803
2011-01-01 16:17:37 [INFO] Disconnecting efess [/192.168.0.198:53115]: Took too long to log in
2011-01-01 16:17:46 [INFO] efess [/192.168.0.198:53120] logged in with entity id 694907
2011-01-01 16:22:50 [INFO] <efess> damn night
2011-01-01 16:23:16 [INFO] <nawf> sun needs mods
2011-01-01 16:25:55 [INFO] <nawf> lol, hugggssssssssss
2011-01-01 16:25:59 [INFO] <efess> haha
2011-01-01 16:27:12 [INFO] <nawf> creeper incoming
2011-01-01 16:27:28 [INFO] <nawf> circle strafe, circle strafe!
2011-01-01 16:27:43 [INFO] <efess> oopa
2011-01-01 16:28:33 [INFO] <nawf> rofl
2011-01-01 16:28:35 [INFO] <nawf> you have friends
2011-01-01 16:28:41 [INFO] <efess> lol
2011-01-01 16:31:00 [INFO] <efess> lol
2011-01-01 16:31:40 [INFO] <nawf> rofl
2011-01-01 16:31:40 [INFO] <efess> ow
2011-01-01 16:39:33 [INFO] <efess> how far out are you going?
2011-01-01 16:39:45 [INFO] <nawf> I dunno
2011-01-01 16:40:02 [INFO] <efess> got an extra bucket?
2011-01-01 16:40:08 [INFO] <nawf> just one, need it?
2011-01-01 16:40:14 [INFO] <efess> sure
2011-01-01 16:40:54 [INFO] <nawf> I figured this flat part over here would be good for a wheat farm
2011-01-01 16:45:52 [INFO] <nawf> lol
2011-01-01 16:46:18 [INFO] <efess> mob grinder potential?
2011-01-01 16:46:27 [INFO] <nawf> maybe, low spawn rate though
2011-01-01 16:46:43 [INFO] <nawf> athough the zombie spawner is right underneath us
2011-01-01 16:48:19 [INFO] <efess> hoe it up
2011-01-01 16:48:33 [INFO] <nawf> meed seeds
2011-01-01 16:51:47 [INFO] <nawf> holy shit
2011-01-01 16:51:56 [INFO] <efess> fuckin backstabber
2011-01-01 16:52:00 [INFO] <nawf> a skeleton archer saved my life by missing and shooting a spider chasing me
2011-01-01 16:52:04 [INFO] <efess> haha
2011-01-01 17:03:25 [INFO] <nawf> the wiki said 4 squares for hydration
2011-01-01 17:03:37 [INFO] <efess> cool, are you going to use water to harvest?
2011-01-01 17:03:45 [INFO] <nawf> I think so
2011-01-01 17:03:52 [INFO] <nawf> drop a bucket on it
2011-01-01 17:07:07 [INFO] <efess> brb
2011-01-01 17:16:58 [INFO] nawf lost connection: disconnect.quitting
2011-01-01 17:39:16 [INFO] /76.23.232.27:55101 lost connection
2011-01-01 17:39:33 [INFO] nawf [/76.23.232.27:55033] logged in with entity id 752343
2011-01-01 17:54:30 [INFO] <nawf> cow is swimming
2011-01-01 17:54:38 [INFO] <efess> silly cow
2011-01-01 18:02:12 [INFO] <nawf> O
2011-01-01 18:02:24 [INFO] <nawf> halp
2011-01-01 18:02:28 [INFO] <efess> oh noes
2011-01-01 18:06:25 [INFO] <nawf> dyood
2011-01-01 18:06:31 [INFO] <nawf> spider rider skeleton
2011-01-01 18:06:36 [INFO] <nawf> first one I've seen ever
2011-01-01 18:06:43 [INFO] <nawf> its all glitched out though
2011-01-01 18:06:53 [INFO] <efess> haha
2011-01-01 18:06:55 [INFO] <efess> ya first one
2011-01-01 18:07:53 [INFO] <nawf> lol
2011-01-01 18:07:58 [INFO] <nawf> he in in your moat
2011-01-01 18:08:12 [INFO] <efess> spider rider
2011-01-01 18:08:13 [INFO] <efess> ?
2011-01-01 18:08:33 [INFO] <nawf> lol, he is fighting the sheep
2011-01-01 18:08:46 [INFO] <efess> haha
2011-01-01 18:20:47 [INFO] <nawf> are you going to drown them?
2011-01-01 18:20:50 [INFO] <efess> trying to
2011-01-01 18:20:55 [INFO] <nawf> need glass walls
2011-01-01 18:21:01 [INFO] <efess> hehe
2011-01-01 18:25:34 [INFO] <efess> fail!
2011-01-01 18:25:38 [INFO] <nawf> lol
2011-01-01 18:28:08 [INFO] <efess> lulz.
2011-01-01 18:28:31 [INFO] <efess> haha
2011-01-01 18:29:04 [INFO] <nawf> lol, you pushed me in
2011-01-01 18:50:45 [INFO] <efess> fu
2011-01-01 18:50:48 [INFO] <nawf> lol
2011-01-01 18:52:01 [INFO] <efess> coudln't resist?
2011-01-01 18:52:06 [INFO] <efess> haha
2011-01-01 18:52:34 [INFO] <nawf> there was some loot
2011-01-01 18:52:36 [INFO] <nawf> t
2011-01-01 18:52:39 [INFO] <efess> ya
2011-01-01 18:53:26 [INFO] <nawf> I'm going to jet, gotta get some work done today
2011-01-01 18:53:32 [INFO] <nawf> see yah
2011-01-01 18:53:33 [INFO] <efess> aight man
2011-01-01 18:53:34 [INFO] <efess> l8r
2011-01-01 18:53:38 [INFO] nawf lost connection: disconnect.quitting
2011-01-01 19:17:58 [INFO] efess lost connection: disconnect.quitting
2011-01-02 00:30:06 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-02 09:25:57 [INFO] nawf [/76.23.232.27:55020] logged in with entity id 819317
2011-01-02 10:05:49 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 10:19:40 [INFO] nawf [/76.23.232.27:55067] logged in with entity id 842939
2011-01-02 10:26:50 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 10:36:24 [INFO] nawf [/76.23.232.27:55132] logged in with entity id 847666
2011-01-02 10:49:54 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 11:19:07 [INFO] nawf [/76.23.232.27:55030] logged in with entity id 856003
2011-01-02 11:20:11 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 11:37:59 [INFO] nawf [/76.23.232.27:55026] logged in with entity id 856645
2011-01-02 11:53:42 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 13:31:29 [INFO] nawf [/76.23.232.27:55046] logged in with entity id 866154
2011-01-02 13:41:39 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 15:13:26 [INFO] nawf [/76.23.232.27:55062] logged in with entity id 871592
2011-01-02 15:40:07 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 21:15:09 [INFO] nawf [/76.23.232.27:55021] logged in with entity id 890017
2011-01-02 21:38:54 [INFO] nawf lost connection: disconnect.quitting
2011-01-02 21:45:09 [INFO] nawf [/76.23.232.27:55019] logged in with entity id 904076
2011-01-02 21:45:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-02 21:49:59 [INFO] nawf lost connection: disconnect.quitting
2011-01-03 00:30:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-03 17:36:06 [INFO] nawf [/76.23.232.27:55059] logged in with entity id 907045
2011-01-03 17:36:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-03 17:36:30 [INFO] <nawf> you here?
2011-01-03 17:48:12 [INFO] nawf lost connection: disconnect.quitting
2011-01-03 18:05:12 [INFO] efess [/192.168.0.198:47602] logged in with entity id 912137
2011-01-03 18:10:13 [INFO] efess lost connection: disconnect.quitting
2011-01-03 18:10:27 [INFO] nawf [/76.23.232.27:55124] logged in with entity id 916483
2011-01-03 18:18:08 [INFO] nawf lost connection: disconnect.quitting
2011-01-03 18:24:38 [INFO] nawf [/76.23.232.27:55064] logged in with entity id 921584
2011-01-03 18:24:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-03 18:25:50 [INFO] efess [/192.168.0.198:47788] logged in with entity id 921887
2011-01-03 18:25:58 [INFO] <nawf> yo
2011-01-03 18:26:05 [INFO] <efess> hey
2011-01-03 18:26:24 [INFO] <efess> where'd you find the jackolanterns?
2011-01-03 18:26:26 [INFO] <nawf> I think I found a couple of good spots for the mob spawner
2011-01-03 18:26:33 [INFO] <nawf> I was just out and about
2011-01-03 18:26:44 [INFO] <nawf> to the west or east where I found the cave
2011-01-03 18:26:56 [INFO] <nawf> are you at the base?
2011-01-03 18:27:00 [INFO] <efess> i'm at your garden
2011-01-03 18:27:11 [INFO] <nawf> I'm in the middle of an ocean
2011-01-03 18:27:14 [INFO] <nawf> I'll come to you
2011-01-03 18:29:15 [INFO] <efess> so what I gathered from that guide - just a huge open space is required
2011-01-03 18:29:21 [INFO] <efess> as low as possible
2011-01-03 18:29:37 [INFO] <nawf> yeah, I think I found one
2011-01-03 18:30:46 [INFO] <nawf> wheeeaatz
2011-01-03 18:30:51 [INFO] <efess> woooo
2011-01-03 18:31:04 [INFO] <nawf> so yeah, big open space over to the north I think
2011-01-03 18:31:08 [INFO] <nawf> ocean
2011-01-03 18:31:22 [INFO] <nawf> want me to show you?
2011-01-03 18:31:24 [INFO] <efess> ya
2011-01-03 18:31:29 [INFO] <nawf> ok, lets bring wood too
2011-01-03 18:33:12 [INFO] <efess> got the woodz
2011-01-03 18:33:13 [INFO] <efess> ?
2011-01-03 18:33:15 [INFO] <nawf> yeah
2011-01-03 18:33:18 [INFO] <nawf> need tools
2011-01-03 18:34:23 [INFO] <efess> you're in a missing chunk
2011-01-03 18:34:24 [INFO] <efess> lol
2011-01-03 18:34:42 [INFO] <nawf> lol
2011-01-03 18:34:44 [INFO] <efess> no caves though
2011-01-03 18:34:45 [INFO] <nawf> walking on air
2011-01-03 18:35:01 [INFO] <efess> so you propose putting it in an ocean
2011-01-03 18:35:04 [INFO] <efess> and sanding it out?
2011-01-03 18:35:11 [INFO] <nawf> naw, leave it ocean
2011-01-03 18:36:11 [INFO] <nawf> ww
2011-01-03 18:36:13 [INFO] <nawf> w
2011-01-03 18:36:16 [INFO] <efess> youtube linkz
2011-01-03 18:36:49 [INFO] <nawf> so check that one out, its just a single floor
2011-01-03 18:36:57 [INFO] <efess> k
2011-01-03 18:37:02 [INFO] <nawf> but I think he built it inefficiently, doesn't need to be so high
2011-01-03 18:37:14 [INFO] <nawf> its safe to idle here too, no mobs spawn even close
2011-01-03 18:37:46 [INFO] <nawf> which I guess is the point
2011-01-03 18:38:59 [INFO] <efess> is that why you chose the ocean?
2011-01-03 18:39:12 [INFO] <nawf> yeah, because the mobs will spawn on available ground
2011-01-03 18:39:36 [INFO] <nawf> and because a lot of space is taken up by the ocean and the air above
2011-01-03 18:39:46 [INFO] <nawf> then our trap will get the majority of spawns
2011-01-03 18:41:48 [INFO] <efess> only prob is this is so far from the base
2011-01-03 18:42:02 [INFO] <nawf> there is a closer spot over here
2011-01-03 18:42:15 [INFO] <nawf> but its not as open
2011-01-03 18:47:24 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 18:49:31 [INFO] efess [/192.168.0.198:48030] logged in with entity id 934197
2011-01-03 19:08:33 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 19:08:37 [INFO] efess [/192.168.0.198:48151] logged in with entity id 945100
2011-01-03 19:09:04 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 19:09:54 [INFO] efess [/192.168.0.198:48162] logged in with entity id 945537
2011-01-03 19:12:06 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 19:12:34 [INFO] efess [/192.168.0.198:48191] logged in with entity id 946637
2011-01-03 20:15:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:16:32 [INFO] efess [/192.168.0.198:48656] logged in with entity id 965603
2011-01-03 20:16:52 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:17:08 [INFO] efess [/192.168.0.198:48662] logged in with entity id 965709
2011-01-03 20:17:21 [INFO] <nawf> call again?
2011-01-03 20:27:52 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:28:30 [INFO] efess [/192.168.0.198:48802] logged in with entity id 968687
2011-01-03 20:35:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:36:25 [INFO] efess [/192.168.0.198:48844] logged in with entity id 970500
2011-01-03 20:38:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:39:00 [INFO] efess [/192.168.0.198:48862] logged in with entity id 971001
2011-01-03 20:40:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:41:18 [INFO] efess [/192.168.0.198:48912] logged in with entity id 971534
2011-01-03 20:51:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:52:00 [INFO] efess [/192.168.0.198:48973] logged in with entity id 974103
2011-01-03 20:52:09 [INFO] <efess> call now
2011-01-03 20:53:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 20:54:21 [INFO] efess [/192.168.0.198:49013] logged in with entity id 974625
2011-01-03 21:04:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:05:19 [INFO] efess [/192.168.0.198:49093] logged in with entity id 977433
2011-01-03 21:05:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:06:25 [INFO] efess [/192.168.0.198:49115] logged in with entity id 977803
2011-01-03 21:19:53 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:20:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-03 21:22:51 [INFO] Disconnecting /192.168.0.198:49392: Took too long to log in
2011-01-03 21:23:17 [INFO] efess [/192.168.0.198:49401] logged in with entity id 986764
2011-01-03 21:23:48 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:24:18 [INFO] efess [/192.168.0.198:49428] logged in with entity id 986904
2011-01-03 21:24:48 [INFO] nawf [/76.23.232.27:55240] logged in with entity id 987044
2011-01-03 21:25:06 [INFO] efess lost connection: disconnect.endOfStream
2011-01-03 21:26:27 [INFO] nawf lost connection: disconnect.timeout
2011-01-03 21:27:21 [INFO] efess [/192.168.0.198:49625] logged in with entity id 987350
2011-01-03 21:28:07 [INFO] efess lost connection: disconnect.endOfStream
2011-01-03 21:28:26 [INFO] nawf [/76.23.232.27:55024] logged in with entity id 987617
2011-01-03 21:28:32 [INFO] efess [/192.168.0.198:49646] logged in with entity id 987722
2011-01-03 21:28:37 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:29:01 [INFO] nawf lost connection: disconnect.endOfStream
2011-01-03 21:32:30 [INFO] Disconnecting /76.23.232.27:55053: Took too long to log in
2011-01-03 21:34:10 [INFO] Starting minecraft server version Beta 1.1_02
2011-01-03 21:34:10 [INFO] Loading properties
2011-01-03 21:34:10 [INFO] Starting Minecraft server on *:25565
2011-01-03 21:34:10 [INFO] Preparing level ""world""
2011-01-03 21:34:10 [INFO] Preparing start region
2011-01-03 21:34:11 [INFO] Done! For help, type ""help"" or ""?""
2011-01-03 21:34:48 [INFO] Starting minecraft server version Beta 1.1_02
2011-01-03 21:34:48 [INFO] Loading properties
2011-01-03 21:34:48 [INFO] Starting Minecraft server on *:25565
2011-01-03 21:34:48 [INFO] Preparing level ""world""
2011-01-03 21:34:48 [INFO] Preparing start region
2011-01-03 21:34:48 [INFO] Done! For help, type ""help"" or ""?""
2011-01-03 21:35:18 [INFO] efess [/192.168.0.198:49750] logged in with entity id 5
2011-01-03 21:35:41 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:37:18 [INFO] Starting minecraft server version Beta 1.1_02
2011-01-03 21:37:18 [INFO] Loading properties
2011-01-03 21:37:18 [INFO] Starting Minecraft server on *:25565
2011-01-03 21:37:18 [INFO] Preparing level ""world""
2011-01-03 21:37:18 [INFO] Preparing start region
2011-01-03 21:37:18 [INFO] Done! For help, type ""help"" or ""?""
2011-01-03 21:38:14 [INFO] Disconnecting efess [/192.168.0.198:49875]: Took too long to log in
2011-01-03 21:38:35 [INFO] efess [/192.168.0.198:49881] logged in with entity id 5
2011-01-03 21:39:19 [INFO] efess lost connection: disconnect.quitting
2011-01-03 21:39:22 [INFO] efess [/192.168.0.198:49889] logged in with entity id 209
2011-01-03 21:39:49 [INFO] efess lost connection: disconnect.genericReason
2011-01-03 21:41:46 [INFO] Starting minecraft server version Beta 1.1_02
2011-01-03 21:41:46 [INFO] Loading properties
2011-01-03 21:41:46 [INFO] Starting Minecraft server on *:25565
2011-01-03 21:41:47 [INFO] Preparing level ""world""
2011-01-03 21:41:47 [INFO] Preparing start region
2011-01-03 21:41:58 [INFO] Done! For help, type ""help"" or ""?""
2011-01-03 21:42:06 [INFO] nawf [/76.23.232.27:55042] logged in with entity id 3
2011-01-03 21:42:13 [INFO] nawf lost connection: disconnect.genericReason
2011-01-03 21:42:13 [INFO] nawf lost connection: disconnect.genericReason
2011-01-03 21:42:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-03 21:42:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-03 21:42:59 [INFO] efess [/192.168.0.198:51917] logged in with entity id 141
2011-01-03 21:43:39 [INFO] nawf [/76.23.232.27:55172] logged in with entity id 338
2011-01-03 22:12:24 [INFO] efess lost connection: disconnect.quitting
2011-01-03 22:12:27 [INFO] efess [/192.168.0.198:52123] logged in with entity id 21386
2011-01-03 22:21:50 [INFO] <nawf> it was the ocean
2011-01-03 22:21:54 [INFO] <efess> lol.
2011-01-03 22:33:23 [INFO] nawf lost connection: disconnect.quitting
2011-01-03 23:22:05 [INFO] efess lost connection: disconnect.quitting
2011-01-04 18:26:09 [INFO] Disconnecting /192.168.0.198:19893: Took too long to log in
2011-01-04 18:27:01 [INFO] Disconnecting /192.168.0.198:20095: Took too long to log in
2011-01-04 18:27:08 [INFO] efess [/192.168.0.198:20327] logged in with entity id 69833
2011-01-04 18:47:20 [INFO] nawf [/76.23.232.27:55126] logged in with entity id 74384
2011-01-04 18:47:24 [INFO] <efess> what up
2011-01-04 18:47:39 [INFO] <nawf> same ole, just got back from errands, beers
2011-01-04 18:47:46 [INFO] <efess> berr
2011-01-04 18:47:49 [INFO] <nawf> only have an hour or so, then I have to work moar
2011-01-04 18:47:56 [INFO] <efess> same
2011-01-04 18:47:59 [INFO] <efess> cept for the work
2011-01-04 18:48:50 [INFO] <nawf> its almost over, first demo is tomorrow at 8pm
2011-01-04 18:49:24 [INFO] <nawf> wtf stairway to nothing
2011-01-04 18:49:28 [INFO] <efess> oh
2011-01-04 18:49:33 [INFO] <efess> lol
2011-01-04 18:49:37 [INFO] <efess> I tried to go all the way up
2011-01-04 18:49:41 [INFO] <efess> 'cause I was lost
2011-01-04 18:49:45 [INFO] <efess> but ran out of pic axe
2011-01-04 18:49:52 [INFO] <nawf> you were so close
2011-01-04 18:49:58 [INFO] <efess> yea i could hear the animalz
2011-01-04 18:50:08 [INFO] <efess> and from the minimap it'll come up at the island
2011-01-04 18:50:10 [INFO] <nawf> yeah, 6 blocks
2011-01-04 18:51:16 [INFO] <nawf> diamondz are safe
2011-01-04 18:51:20 [INFO] <efess> woo
2011-01-04 18:51:26 [INFO] <efess> it works
2011-01-04 18:51:27 [INFO] <nawf> oh yeah, it was my neighbor who was banging on the wall
2011-01-04 18:51:33 [INFO] <nawf> I had a talk with him this morning
2011-01-04 18:51:34 [INFO] <efess> did you talk to them
2011-01-04 18:51:47 [INFO] <nawf> yeah, I told him 9:10pm is uncalled for, fuck, 11pm is uncalled for
2011-01-04 18:51:51 [INFO] <efess> he said it was the talking?
2011-01-04 18:51:57 [INFO] <nawf> he has it easy, he's lucky if I fart loudly
2011-01-04 18:52:06 [INFO] <efess> no kidding
2011-01-04 18:52:10 [INFO] <nawf> yeah, talking, but still, thats messed up
2011-01-04 18:52:14 [INFO] <efess> yea
2011-01-04 18:52:19 [INFO] <nawf> with michelle gone and no tv there is almost no noise here
2011-01-04 18:52:27 [INFO] <efess> watch out
2011-01-04 18:52:59 [INFO] <nawf> lol
2011-01-04 18:53:15 [INFO] <efess> fuckin skeleton
2011-01-04 18:53:18 [INFO] <efess> went up your stairs
2011-01-04 18:53:34 [INFO] <efess> yea I killed the torches
2011-01-04 18:53:36 [INFO] <efess> to see how it'd work
2011-01-04 18:53:39 [INFO] <nawf> oh
2011-01-04 18:53:42 [INFO] <efess> and it does
2011-01-04 18:53:43 [INFO] <efess> haha
2011-01-04 18:53:54 [INFO] <efess> lulz
2011-01-04 18:54:24 [INFO] <nawf> so now we need walls?
2011-01-04 18:54:39 [INFO] <efess> well
2011-01-04 18:54:43 [INFO] <efess> platforms over here
2011-01-04 18:55:49 [INFO] <nawf> I dun gooded
2011-01-04 18:55:52 [INFO] <nawf> goofed
2011-01-04 19:06:18 [INFO] <nawf> platforms dun
2011-01-04 19:06:24 [INFO] <efess> NICE
2011-01-04 19:06:26 [INFO] <efess> er
2011-01-04 19:06:28 [INFO] <efess> lol
2011-01-04 19:07:00 [INFO] <nawf> if we build the walls out of wood, we can burn it down if we expand it
2011-01-04 19:07:11 [INFO] <efess> I like the way you think
2011-01-04 19:07:18 [INFO] <nawf> with fire?
2011-01-04 19:07:26 [INFO] <nawf> lol, forgot platforms
2011-01-04 19:13:28 [INFO] <efess> woot
2011-01-04 19:15:07 [INFO] <nawf> torches melt ice?
2011-01-04 19:15:10 [INFO] <efess> yea
2011-01-04 19:15:49 [INFO] <efess> haha
2011-01-04 19:15:51 [INFO] <nawf> lol
2011-01-04 19:17:59 [INFO] <efess> lumberjack time
2011-01-04 19:26:44 [INFO] <nawf> see there we have a protected walkway
2011-01-04 19:26:48 [INFO] <efess> nice
2011-01-04 19:27:11 [INFO] <nawf> and then thats the roof level
2011-01-04 19:27:18 [INFO] <efess> aight
2011-01-04 19:27:20 [INFO] <nawf> we could stagger it but that will just make building harder
2011-01-04 19:27:38 [INFO] <nawf> maybe use a couple more blocks on the walls, thats not bad though
2011-01-04 19:28:28 [INFO] <efess> have some wood
2011-01-04 19:31:04 [INFO] <nawf> just make a flat wall on this side?
2011-01-04 19:31:22 [INFO] <nawf> or should we make another walk way?
2011-01-04 19:31:22 [INFO] <efess> ya
2011-01-04 19:31:25 [INFO] <efess> nah
2011-01-04 19:32:42 [INFO] <efess> mmm trees
2011-01-04 19:32:44 [INFO] <efess> renewable resource
2011-01-04 19:33:04 [INFO] <nawf> we are green minecrafters
2011-01-04 19:33:47 [INFO] <efess> then we need tons more cobblestone for half steps..
2011-01-04 19:34:08 [INFO] <efess> maybe we should make the roof cobblestone
2011-01-04 19:34:10 [INFO] <efess> so it doens't burn
2011-01-04 19:34:20 [INFO] <nawf> oh right
2011-01-04 19:34:24 [INFO] <nawf> cause we can keep the roof
2011-01-04 19:34:28 [INFO] <efess> yea
2011-01-04 19:36:14 [INFO] <efess> so I guess trees don't age when we're not connected :o
2011-01-04 19:36:21 [INFO] <efess> i planted these suckers last night
2011-01-04 19:36:27 [INFO] <nawf> I thought the wheat was going slow
2011-01-04 19:37:55 [INFO] <efess> weee
2011-01-04 19:38:03 [INFO] <nawf> awwwwwwwwwwwwwwww yeeeeeeeeeeeeeaaaaaaaaaaaaaaahhhhhhhhhh
2011-01-04 19:39:06 [INFO] <efess> woo trees
2011-01-04 19:44:08 [INFO] <efess> alright dude I gtg
2011-01-04 19:44:23 [INFO] <efess> gg!
2011-01-04 19:44:24 [INFO] <nawf> aight, I should too, see yah
2011-01-04 19:44:26 [INFO] <nawf> gg
2011-01-04 19:44:29 [INFO] <nawf> lpb
2011-01-04 19:44:33 [INFO] <efess> haha
2011-01-04 19:44:37 [INFO] <efess> woo one of your trees
2011-01-04 19:44:39 [INFO] <efess> two
2011-01-04 19:44:45 [INFO] <efess> nice
2011-01-04 19:44:50 [INFO] <efess> I didn't know they grew so fast
2011-01-04 19:44:51 [INFO] <nawf> soo many saprolings
2011-01-04 19:45:16 [INFO] <efess> lol
2011-01-04 19:45:32 [INFO] nawf lost connection: disconnect.quitting
2011-01-04 19:47:59 [INFO] efess lost connection: disconnect.quitting
2011-01-04 21:57:29 [INFO] nawf [/76.23.232.27:55242] logged in with entity id 94564
2011-01-04 22:06:38 [INFO] nawf lost connection: disconnect.quitting
2011-01-04 22:18:19 [INFO] nawf [/76.23.232.27:55041] logged in with entity id 96986
2011-01-04 22:28:22 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 14:44:55 [INFO] nawf [/76.23.232.27:55021] logged in with entity id 99666
2011-01-05 14:48:56 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 14:49:22 [INFO] nawf [/76.23.232.27:55010] logged in with entity id 100824
2011-01-05 14:55:14 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 14:57:35 [INFO] nawf [/76.23.232.27:55043] logged in with entity id 102644
2011-01-05 15:01:46 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 15:06:03 [INFO] Disconnecting /76.23.232.27:55052: Took too long to log in
2011-01-05 15:07:03 [INFO] nawf [/76.23.232.27:55064] logged in with entity id 103774
2011-01-05 15:20:57 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 15:54:57 [INFO] nawf [/76.23.232.27:55014] logged in with entity id 107460
2011-01-05 17:01:12 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 17:15:30 [INFO] nawf [/76.23.232.27:55024] logged in with entity id 199787
2011-01-05 18:03:24 [INFO] Disconnecting efess [/192.168.0.198:1166]: Took too long to log in
2011-01-05 18:03:33 [INFO] efess [/192.168.0.198:1189] logged in with entity id 282435
2011-01-05 18:03:45 [INFO] <efess> hello sir
2011-01-05 18:03:48 [INFO] <nawf> so much wood
2011-01-05 18:03:57 [INFO] <nawf> walls are done
2011-01-05 18:03:58 [INFO] <efess> need moar
2011-01-05 18:04:13 [INFO] <nawf> follow me
2011-01-05 18:05:06 [INFO] <nawf> stand back
2011-01-05 18:05:07 [INFO] <efess> oh hai
2011-01-05 18:05:21 [INFO] <nawf> lol swimming
2011-01-05 18:05:35 [INFO] <efess> why so far down
2011-01-05 18:05:49 [INFO] <nawf> because of the spawn radius
2011-01-05 18:05:59 [INFO] <nawf> err, no spawn zone
2011-01-05 18:06:08 [INFO] <nawf> and we get some fall damage, kill faster
2011-01-05 18:06:19 [INFO] <efess> ahh yes
2011-01-05 18:06:23 [INFO] <efess> gravity ftw.
2011-01-05 18:06:50 [INFO] <nawf> need a good path back up though
2011-01-05 18:07:05 [INFO] <nawf> we cross that tunnel you built, I just can't fine the down end
2011-01-05 18:07:25 [INFO] <efess> mmm crock pot roast
2011-01-05 18:07:49 [INFO] <efess> also have to fix the flow at the bottom of the pit
2011-01-05 18:08:55 [INFO] <efess> brb
2011-01-05 18:08:57 [INFO] <efess> gotta eat
2011-01-05 18:09:01 [INFO] <nawf> fud gud
2011-01-05 18:20:08 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 18:21:12 [INFO] efess lost connection: disconnect.timeout
2011-01-05 18:29:35 [INFO] efess [/192.168.0.198:1408] logged in with entity id 287658
2011-01-05 18:29:47 [INFO] <efess> omg died
2011-01-05 18:33:00 [INFO] nawf [/76.23.232.27:55098] logged in with entity id 289506
2011-01-05 18:33:09 [INFO] <efess> hey
2011-01-05 18:33:11 [INFO] <nawf> HEY
2011-01-05 18:33:15 [INFO] <nawf> I mean hey
2011-01-05 18:33:15 [INFO] <efess> YO
2011-01-05 18:33:19 [INFO] <efess> i mean yo
2011-01-05 18:33:32 [INFO] <nawf> so that sign shit I did won't work, because of spiders
2011-01-05 18:33:40 [INFO] <nawf> what we need is cactii
2011-01-05 18:33:44 [INFO] <efess> I have an idea
2011-01-05 18:33:57 [INFO] <efess> don't know if it'll work
2011-01-05 18:34:22 [INFO] <efess> ow
2011-01-05 18:34:33 [INFO] <nawf> I only have one heart left
2011-01-05 18:34:41 [INFO] <nawf> fuck
2011-01-05 18:34:56 [INFO] <efess> died?
2011-01-05 18:34:59 [INFO] <efess> haha
2011-01-05 18:35:21 [INFO] <efess> yea so we should make metal doors
2011-01-05 18:35:26 [INFO] <efess> so we can turn it off
2011-01-05 18:35:27 [INFO] <efess> rofl
2011-01-05 18:35:43 [INFO] <nawf> yeah, but that lets in light
2011-01-05 18:35:52 [INFO] <efess> I mean at the bottom
2011-01-05 18:36:03 [INFO] <nawf> oh right
2011-01-05 18:36:15 [INFO] <nawf> still need cactii
2011-01-05 18:36:21 [INFO] <efess> yessir
2011-01-05 18:37:32 [INFO] <nawf> oh yeah, spawner is working awesome, can't
2011-01-05 18:37:44 [INFO] <nawf> do shit at night, even on top
2011-01-05 18:37:52 [INFO] <efess> :D
2011-01-05 18:38:27 [INFO] <nawf> I can't pickup my stuff
2011-01-05 18:38:32 [INFO] <nawf> did you pick it up?
2011-01-05 18:38:45 [INFO] <efess> I donno it was all spread out
2011-01-05 18:38:48 [INFO] <efess> here
2011-01-05 18:38:55 [INFO] <nawf> I mean thats cool, I just see glitched out stuff
2011-01-05 18:39:46 [INFO] <nawf> your doing the doors there?
2011-01-05 18:39:50 [INFO] <efess> nooo
2011-01-05 18:40:11 [INFO] <efess> trying to fix the ""flow""
2011-01-05 18:40:20 [INFO] <nawf> it has to be one block wide
2011-01-05 18:40:22 [INFO] <nawf> I remember now
2011-01-05 18:40:24 [INFO] <efess> yup
2011-01-05 18:40:36 [INFO] <nawf> I have sand for glass
2011-01-05 18:40:43 [INFO] <efess> so
2011-01-05 18:40:48 [INFO] <nawf> walls have to be glass
2011-01-05 18:40:51 [INFO] <efess> yea
2011-01-05 18:40:58 [INFO] <efess> see the gravel?
2011-01-05 18:41:06 [INFO] <efess> er
2011-01-05 18:41:08 [INFO] <efess> cobblestone
2011-01-05 18:41:10 [INFO] <nawf> yeah
2011-01-05 18:41:11 [INFO] <efess> that needs to stay
2011-01-05 18:41:18 [INFO] <nawf> wait why?
2011-01-05 18:41:29 [INFO] <efess> to make a flow
2011-01-05 18:41:49 [INFO] <nawf> the drownwer needs to be 2x1
2011-01-05 18:41:55 [INFO] <nawf> like replace your walls with glass
2011-01-05 18:42:10 [INFO] <efess> 2x1?
2011-01-05 18:42:13 [INFO] <nawf> yeah
2011-01-05 18:42:33 [INFO] <nawf> because that will have the same issue, the dead zone will be on the cobblestone
2011-01-05 18:42:51 [INFO] <efess> so you don't think i'tll flow off the cobblestone
2011-01-05 18:43:00 [INFO] <nawf> you can try
2011-01-05 18:43:00 [INFO] <efess> like those dirt blocks
2011-01-05 18:43:07 [INFO] <efess> kill the cobblestone at top
2011-01-05 18:43:08 [INFO] <efess> and see
2011-01-05 18:44:05 [INFO] <efess> ok so needs a bit of tweeking
2011-01-05 18:44:05 [INFO] <nawf> oic
2011-01-05 18:44:36 [INFO] <nawf> well the way online I saw and used before is 2x1 with a border of cactii up top
2011-01-05 18:44:42 [INFO] <nawf> well mine was 8x1
2011-01-05 18:44:52 [INFO] <efess> cacti is just a bitch since you can't have adjacent blocks
2011-01-05 18:44:56 [INFO] <nawf> yeah
2011-01-05 18:45:32 [INFO] <efess> but as long as that can flow
2011-01-05 18:45:32 [INFO] <nawf> or we can use lava
2011-01-05 18:45:33 [INFO] <efess> we're fine
2011-01-05 18:45:43 [INFO] <efess> 'cause we can route the upper flow
2011-01-05 18:45:44 [INFO] <efess> down
2011-01-05 18:46:18 [INFO] <nawf> well I see, then we don't need flows from two directions
2011-01-05 18:46:34 [INFO] <nawf> but wait, spiders will get stuck I think
2011-01-05 18:46:47 [INFO] <efess> I don't know, its 2x2 at tomp
2011-01-05 18:46:52 [INFO] <nawf> yeah maybe
2011-01-05 18:49:23 [INFO] <nawf> fuck
2011-01-05 18:49:40 [INFO] <efess> ?
2011-01-05 18:49:44 [INFO] <nawf> lots of zombies
2011-01-05 18:49:48 [INFO] <efess> lulz.
2011-01-05 18:58:02 [INFO] <efess> I think this works
2011-01-05 18:58:39 [INFO] <nawf> rofl
2011-01-05 18:58:45 [INFO] <efess> lol.
2011-01-05 18:59:34 [INFO] <efess> fuuuuuu
2011-01-05 18:59:40 [INFO] <efess> I hate you water
2011-01-05 18:59:49 [INFO] <nawf> 2x1 find cactii or make lava burner
2011-01-05 19:00:07 [INFO] <efess> so I think we should make one of each
2011-01-05 19:00:22 [INFO] <efess> with redstone controlling doors into each one
2011-01-05 19:00:22 [INFO] <efess> :)
2011-01-05 19:00:32 [INFO] <nawf> lol
2011-01-05 19:00:39 [INFO] <efess> what do you think
2011-01-05 19:00:57 [INFO] <nawf> well it would be hard to divert the water flow
2011-01-05 19:01:38 [INFO] <efess> true, if you could put ""upside down"" doors it would be fine
2011-01-05 19:01:56 [INFO] <nawf> yeah, too bad notch iw working on dyes and instruments :/
2011-01-05 19:02:07 [INFO] <efess> I know, how gay
2011-01-05 19:02:49 [INFO] <nawf> well I'll head up and scout for cactii
2011-01-05 19:02:53 [INFO] <efess> k
2011-01-05 19:02:56 [INFO] <nawf> have any cobble?
2011-01-05 19:03:02 [INFO] <nawf> I'll add it to ceiling while I'm up there
2011-01-05 19:03:02 [INFO] <efess> 63
2011-01-05 19:10:58 [INFO] <nawf> ok, big stack of gravel west? of the spawner, cave is about 8 blocks below that
2011-01-05 19:11:08 [INFO] <nawf> well 15ish
2011-01-05 19:11:11 [INFO] <nawf> missing chunks ftw
2011-01-05 19:13:22 [INFO] <nawf> lol, lava lake surrounded by snow
2011-01-05 19:25:27 [INFO] <efess> experimenting w/ lava
2011-01-05 19:25:37 [INFO] <nawf> still looking
2011-01-05 19:25:40 [INFO] <efess> oh hai creeper
2011-01-05 19:25:59 [INFO] <nawf> the sun sets in the ****?
2011-01-05 19:26:05 [INFO] <nawf> east right?
2011-01-05 19:26:13 [INFO] <efess> oh I don't know
2011-01-05 19:26:20 [INFO] <efess> almost killed myself
2011-01-05 19:26:25 [INFO] <efess> opened a chest w/ lava in hand
2011-01-05 19:26:25 [INFO] <nawf> I did
2011-01-05 19:26:29 [INFO] <efess> I guess notch fixed that bug
2011-01-05 19:26:35 [INFO] <nawf> same with fud
2011-01-05 19:27:28 [INFO] <nawf> oh god I see them!
2011-01-05 19:27:31 [INFO] <efess> wooo
2011-01-05 19:29:44 [INFO] <efess> lolz.
2011-01-05 19:30:09 [INFO] <efess> well that works
2011-01-05 19:30:57 [INFO] <nawf> FFFFUUUU
2011-01-05 19:31:19 [INFO] <nawf> I died
2011-01-05 19:31:23 [INFO] <efess> oh noes.
2011-01-05 19:38:33 [INFO] <efess> died . duh.
2011-01-05 19:38:56 [INFO] <nawf> shoot a flare gun or something?
2011-01-05 19:39:09 [INFO] <efess> how far out were you
2011-01-05 19:39:16 [INFO] <nawf> now? dunnno
2011-01-05 19:39:27 [INFO] <efess> lol breadcrumbs
2011-01-05 19:39:34 [INFO] <nawf> I ran out
2011-01-05 19:40:57 [INFO] <nawf> ok, phew, I wasn't lost, was heading the right way
2011-01-05 19:44:16 [INFO] <nawf> YES
2011-01-05 19:44:30 [INFO] <efess> don't come down yet the zombies are loose
2011-01-05 19:44:37 [INFO] <nawf> ROOOOOOFFFFFFFFFFFFLLLLLLLLLLLLL
2011-01-05 19:44:44 [INFO] <efess> ?
2011-01-05 19:44:51 [INFO] <nawf> thats just funny
2011-01-05 19:44:54 [INFO] <nawf> zombies are loose
2011-01-05 19:44:58 [INFO] <efess> hahaah
2011-01-05 19:45:31 [INFO] <efess> they're dying quickly as well
2011-01-05 19:45:32 [INFO] <efess> ;D
2011-01-05 19:47:01 [INFO] <efess> need lots of glass
2011-01-05 19:47:46 [INFO] <nawf> YES
2011-01-05 19:47:51 [INFO] <nawf> I think I know the way up too
2011-01-05 19:48:40 [INFO] <efess> I think this should work fine
2011-01-05 19:49:11 [INFO] <nawf> yeah
2011-01-05 19:49:24 [INFO] <nawf> I found our old chest, brough 60 sand too
2011-01-05 19:49:28 [INFO] <efess> nice
2011-01-05 19:50:13 [INFO] <efess> so, we have a way up?
2011-01-05 19:50:19 [INFO] <nawf> I think so
2011-01-05 19:50:23 [INFO] <efess> cool
2011-01-05 19:54:51 [INFO] <nawf> lol
2011-01-05 19:54:54 [INFO] <nawf> this way won't work
2011-01-05 19:55:01 [INFO] <efess> no/
2011-01-05 19:55:03 [INFO] <efess> ?
2011-01-05 19:55:06 [INFO] <nawf> look where I am
2011-01-05 19:55:15 [INFO] <efess> rofl
2011-01-05 19:55:23 [INFO] <nawf> fuck
2011-01-05 19:55:26 [INFO] <efess> i can't let them out yet
2011-01-05 19:55:31 [INFO] <efess> lol
2011-01-05 19:55:35 [INFO] <efess> give me as ec
2011-01-05 19:55:37 [INFO] <efess> almost done
2011-01-05 19:55:45 [INFO] <nawf> I hit foward
2011-01-05 19:55:48 [INFO] <efess> haha
2011-01-05 19:55:48 [INFO] <nawf> by accident
2011-01-05 19:55:58 [INFO] <nawf> how did I live?
2011-01-05 19:56:06 [INFO] <efess> lucky bastard
2011-01-05 19:56:39 [INFO] <nawf> I'm out
2011-01-05 19:56:49 [INFO] <nawf> need door
2011-01-05 20:00:00 [INFO] <efess> heheheh
2011-01-05 20:01:47 [INFO] <nawf> I want to line that wall with cobble, less walking space
2011-01-05 20:03:19 [INFO] <efess> ?
2011-01-05 20:03:29 [INFO] <nawf> ?
2011-01-05 20:03:32 [INFO] <nawf> its working
2011-01-05 20:03:39 [INFO] <nawf> fuck
2011-01-05 20:03:43 [INFO] <efess> hahah
2011-01-05 20:03:44 [INFO] <efess> scared?
2011-01-05 20:03:47 [INFO] <nawf> yeah
2011-01-05 20:03:56 [INFO] <nawf> chicken?
2011-01-05 20:04:00 [INFO] <efess> yes...
2011-01-05 20:04:01 [INFO] <efess> lol
2011-01-05 20:04:07 [INFO] <efess> egg!
2011-01-05 20:08:02 [INFO] <efess> I ugh
2011-01-05 20:08:06 [INFO] <efess> took out the dirt up here
2011-01-05 20:08:08 [INFO] <efess> fyi
2011-01-05 20:08:20 [INFO] <nawf> where?
2011-01-05 20:08:26 [INFO] <efess> the harvestor
2011-01-05 20:08:50 [INFO] <nawf> the wheat harvestor?
2011-01-05 20:08:56 [INFO] <efess> the canalsz
2011-01-05 20:08:58 [INFO] <nawf> oh
2011-01-05 20:09:24 [INFO] <efess> oh its still lit
2011-01-05 20:10:02 [INFO] <efess> LOL
2011-01-05 20:10:09 [INFO] <efess> ffffuuuuuu
2011-01-05 20:11:02 [INFO] <nawf> I got your shit
2011-01-05 20:11:08 [INFO] <nawf> it went into the loot collector
2011-01-05 20:11:10 [INFO] <efess> fuck yea
2011-01-05 20:11:19 [INFO] <efess> hahah
2011-01-05 20:11:59 [INFO] <nawf> wtf
2011-01-05 20:12:09 [INFO] <nawf> fuck
2011-01-05 20:12:12 [INFO] <efess> that'ssome crazy shit.
2011-01-05 20:12:13 [INFO] <efess> what
2011-01-05 20:12:17 [INFO] <nawf> I died too
2011-01-05 20:12:21 [INFO] <efess> where
2011-01-05 20:12:22 [INFO] <nawf> zombies going through walls
2011-01-05 20:12:27 [INFO] <efess> haha.
2011-01-05 20:12:41 [INFO] <efess> fuck you mobs
2011-01-05 20:12:45 [INFO] <nawf> need to glass that shit off
2011-01-05 20:13:27 [INFO] <efess> christ
2011-01-05 20:14:12 [INFO] <nawf> oh, wtf, chute filled with water
2011-01-05 20:14:23 [INFO] <efess> blame that on a creeper
2011-01-05 20:14:32 [INFO] <efess> fixing
2011-01-05 20:14:45 [INFO] <nawf> there was a skeleton swimming down it
2011-01-05 20:15:27 [INFO] <nawf> halp
2011-01-05 20:15:36 [INFO] <efess> where
2011-01-05 20:15:40 [INFO] <nawf> down by spawner
2011-01-05 20:15:46 [INFO] <nawf> errr lava trap
2011-01-05 20:15:51 [INFO] <efess> LOL
2011-01-05 20:15:52 [INFO] <efess> omg
2011-01-05 20:15:52 [INFO] <nawf> damn spider, couldn't get my sword out
2011-01-05 20:15:53 [INFO] <efess> died
2011-01-05 20:15:57 [INFO] <nawf> rofl
2011-01-05 20:16:05 [INFO] <efess> fuck you night
2011-01-05 20:16:37 [INFO] <nawf> what killed you?
2011-01-05 20:16:40 [INFO] <efess> fell
2011-01-05 20:16:45 [INFO] <efess> 4 blocks
2011-01-05 20:16:45 [INFO] <efess> lol
2011-01-05 20:17:57 [INFO] <efess> ok so opening that hole
2011-01-05 20:18:05 [INFO] <efess> wasnn't the brightest idea
2011-01-05 20:18:16 [INFO] <nawf> do you know the way down?
2011-01-05 20:18:20 [INFO] <efess> yea
2011-01-05 20:18:37 [INFO] <nawf> its killing stuff here
2011-01-05 20:19:06 [INFO] <efess> haha
2011-01-05 20:19:06 [INFO] <nawf> trap is wrong though
2011-01-05 20:19:14 [INFO] <efess> how
2011-01-05 20:19:37 [INFO] <nawf> I think the lava needs to be one block higher
2011-01-05 20:19:40 [INFO] <nawf> its going to eat loot
2011-01-05 20:20:01 [INFO] <efess> you could try it
2011-01-05 20:20:13 [INFO] <nawf> naw, I'm checking online, I think your right
2011-01-05 20:20:30 [INFO] <nawf> I stuffed the chest with all the stuff
2011-01-05 20:20:31 [INFO] <efess> the loot falls at the bottom of the model
2011-01-05 20:20:35 [INFO] <nawf> oh
2011-01-05 20:20:40 [INFO] <nawf> yeah, I was wrong
2011-01-05 20:20:43 [INFO] <efess> and there's a glass ceiling
2011-01-05 20:20:44 [INFO] <nawf> l2minecraft
2011-01-05 20:20:54 [INFO] <efess> above the lava
2011-01-05 20:20:59 [INFO] <efess> so they can't swim ""up"" the lava
2011-01-05 20:21:04 [INFO] <efess> even though they try
2011-01-05 20:21:04 [INFO] <efess> lol
2011-01-05 20:21:57 [INFO] <efess> damn bugged items
2011-01-05 20:22:08 [INFO] <nawf> naw, I got them all, you just see it
2011-01-05 20:22:11 [INFO] <nawf> thats what happened
2011-01-05 20:22:12 [INFO] <efess> cool
2011-01-05 20:22:27 [INFO] <nawf> I threw your iron sword into the shaft
2011-01-05 20:22:30 [INFO] <nawf> should get it soon
2011-01-05 20:22:38 [INFO] <efess> LOL
2011-01-05 20:22:41 [INFO] <efess> LOLOLOL
2011-01-05 20:22:50 [INFO] <efess> that was awesome
2011-01-05 20:23:02 [INFO] <efess> fucking love this game
2011-01-05 20:24:16 [INFO] <efess> so.
2011-01-05 20:24:36 [INFO] <efess> gotta collect gravel
2011-01-05 20:24:49 [INFO] <nawf> gravel?
2011-01-05 20:25:03 [INFO] <efess> mean cobbelstone
2011-01-05 20:25:26 [INFO] <nawf> lol, chicken in trap
2011-01-05 20:25:30 [INFO] <efess> hehe
2011-01-05 20:25:42 [INFO] <efess> egg layer
2011-01-05 20:25:46 [INFO] <efess> trap serves dual purposes
2011-01-05 20:31:40 [INFO] <efess> lol ladders
2011-01-05 20:32:04 [INFO] <nawf> I built a direct way up
2011-01-05 20:33:22 [INFO] <efess> cool
2011-01-05 20:38:51 [INFO] <nawf> this will be where our minecart booster will be
2011-01-05 20:39:11 [INFO] <efess> yea we'll need a line here from our base
2011-01-05 20:39:21 [INFO] <nawf> I built the stairs with that in mind
2011-01-05 20:39:35 [INFO] <efess> oh that's why you didn't use half steps?
2011-01-05 20:39:50 [INFO] <nawf> yeah, method to my madness
2011-01-05 20:43:05 [INFO] <nawf> no mine
2011-01-05 20:43:09 [INFO] <efess> :mine mine mine
2011-01-05 20:43:19 [INFO] <efess> crafffttt
2011-01-05 20:43:42 [INFO] <nawf> lol random cactus farm
2011-01-05 20:43:46 [INFO] <efess> haha
2011-01-05 20:45:38 [INFO] <nawf> alright, I'm read to head up
2011-01-05 20:45:44 [INFO] <efess> k
2011-01-05 20:46:01 [INFO] <nawf> gtg soon
2011-01-05 20:46:05 [INFO] <efess> work?
2011-01-05 20:46:10 [INFO] <nawf> naw, bar in celebration
2011-01-05 20:46:19 [INFO] <nawf> marini wants to buy me a drink
2011-01-05 20:46:25 [INFO] <nawf> but the demo isn't over until 9
2011-01-05 20:46:25 [INFO] <efess> site works?
2011-01-05 20:46:40 [INFO] <nawf> so far, no panic calls, demo is right now with a division of sony
2011-01-05 20:46:51 [INFO] <efess> cool man
2011-01-05 20:46:58 [INFO] <nawf> did you see the new way up?
2011-01-05 20:47:06 [INFO] <efess> the spiral stairs?
2011-01-05 20:47:16 [INFO] <nawf> yeah, some of it
2011-01-05 20:47:19 [INFO] <efess> ya
2011-01-05 20:47:20 [INFO] <nawf> just making sure
2011-01-05 20:47:22 [INFO] <efess> didn't go all thew ay
2011-01-05 20:47:29 [INFO] <efess> jess asked if you got your couch yet
2011-01-05 20:47:33 [INFO] <nawf> yeah, today
2011-01-05 20:47:50 [INFO] <efess> got the feng shuei going on?
2011-01-05 20:47:56 [INFO] <nawf> soon
2011-01-05 20:49:48 [INFO] <nawf> its coming together nice
2011-01-05 20:49:55 [INFO] <nawf> I think its starting to look like I know what I'm doing
2011-01-05 20:53:06 [INFO] <nawf> shit spider
2011-01-05 20:53:46 [INFO] <nawf> I didn't bring a pickax
2011-01-05 20:53:57 [INFO] <efess> i'll get started on the half steps
2011-01-05 20:55:37 [INFO] <nawf> fuck
2011-01-05 20:55:46 [INFO] <nawf> there is a bug even holding down shift
2011-01-05 20:56:03 [INFO] <efess> ?
2011-01-05 20:56:09 [INFO] <nawf> I fell into the spawner
2011-01-05 20:56:38 [INFO] <efess> fuck
2011-01-05 20:56:39 [INFO] <efess> llol
2011-01-05 20:57:02 [INFO] <efess> roof is full
2011-01-05 20:57:19 [INFO] <efess> burn baby burn
2011-01-05 20:57:39 [INFO] <efess> shit
2011-01-05 20:58:17 [INFO] <nawf> what the fuck
2011-01-05 20:58:40 [INFO] <efess> ?
2011-01-05 20:59:15 [INFO] <nawf> fml
2011-01-05 20:59:19 [INFO] <efess> ?
2011-01-05 20:59:27 [INFO] <nawf> mobs in spawner keep blowing it up
2011-01-05 20:59:38 [INFO] <efess> oh creepers?
2011-01-05 21:00:03 [INFO] <nawf> yeah
2011-01-05 21:00:09 [INFO] <nawf> can you throw me some cobble?
2011-01-05 21:00:14 [INFO] <efess> I only have two
2011-01-05 21:00:22 [INFO] <efess> ill throw pickaxe
2011-01-05 21:01:01 [INFO] <efess> yea creeper blew hole in roof :\
2011-01-05 21:03:58 [INFO] <nawf> ok, patched
2011-01-05 21:04:13 [INFO] <efess> hmm.. any reason we don't just use torches up here?
2011-01-05 21:04:35 [INFO] <nawf> I think so
2011-01-05 21:04:36 [INFO] <nawf> lol
2011-01-05 21:04:39 [INFO] <nawf> heard that
2011-01-05 21:05:05 [INFO] <nawf> oh yeah, becaue the algo won't even check for light, we won't loose a spawn for light or something?
2011-01-05 21:05:07 [INFO] <nawf> :/
2011-01-05 21:05:09 [INFO] <nawf> I dunno
2011-01-05 21:06:54 [INFO] <nawf> we could just torch it too
2011-01-05 21:09:51 [INFO] <nawf> dont go up the ladder
2011-01-05 21:09:52 [INFO] <nawf> fuck
2011-01-05 21:09:56 [INFO] <efess> yea
2011-01-05 21:09:57 [INFO] <efess> mobs
2011-01-05 21:10:14 [INFO] <nawf> I brought the gunpower so we can blow this island up
2011-01-05 21:10:20 [INFO] <nawf> works awesome on dirt
2011-01-05 21:13:43 [INFO] <nawf> dude watching the mobs fall in is awesome
2011-01-05 21:13:47 [INFO] <efess> i knw
2011-01-05 21:13:48 [INFO] <efess> lol
2011-01-05 21:14:00 [INFO] <efess> rofl
2011-01-05 21:14:15 [INFO] <efess> that fucking ladder dude
2011-01-05 21:14:17 [INFO] <nawf> holy shit this is working better than my first two spanwers already
2011-01-05 21:15:35 [INFO] <efess> there's 4 mobs.. no 5 now
2011-01-05 21:15:38 [INFO] <efess> at the top of your ladder
2011-01-05 21:15:47 [INFO] <nawf> they are using the ladder?
2011-01-05 21:15:51 [INFO] <efess> ya
2011-01-05 21:15:51 [INFO] <efess> lol
2011-01-05 21:15:58 [INFO] <nawf> lol
2011-01-05 21:16:11 [INFO] <efess> where's yoru stairs down?
2011-01-05 21:16:21 [INFO] <efess> foudn it
2011-01-05 21:16:23 [INFO] <nawf> over at the end of the island away from the sp
2011-01-05 21:16:29 [INFO] <nawf> we have to kill that ladder
2011-01-05 21:16:33 [INFO] <efess> yup
2011-01-05 21:17:03 [INFO] <efess> did it kill any spiders yet?
2011-01-05 21:17:07 [INFO] <nawf> naw
2011-01-05 21:17:12 [INFO] <efess> ya they're up top
2011-01-05 21:17:17 [INFO] <efess> the ladder
2011-01-05 21:17:18 [INFO] <nawf> I'm going to suicide up the ladder
2011-01-05 21:17:23 [INFO] <efess> hahahah
2011-01-05 21:17:47 [INFO] <efess> great success
2011-01-05 21:17:50 [INFO] <nawf> one of us has to do it
2011-01-05 21:18:01 [INFO] <efess> I
2011-01-05 21:18:10 [INFO] <nawf> tell my mother I died a hero
2011-01-05 21:18:11 [INFO] <efess> I'd just mine that whole column
2011-01-05 21:18:24 [INFO] <efess> i'll do it
2011-01-05 21:18:33 [INFO] <nawf> naw, then they won't fall right
2011-01-05 21:18:39 [INFO] <efess> well i'll put it back
2011-01-05 21:18:41 [INFO] <efess> lol
2011-01-05 21:18:48 [INFO] <nawf> I think we can do most of it from the staircase
2011-01-05 21:19:00 [INFO] <nawf> get some glass
2011-01-05 21:19:07 [INFO] <nawf> there is some in the furhace down here
2011-01-05 21:19:14 [INFO] <nawf> or I will bring it to you
2011-01-05 21:19:17 [INFO] <efess> there's some up here
2011-01-05 21:19:27 [INFO] <efess> I got this
2011-01-05 21:20:07 [INFO] <nawf> its easy from the staircase
2011-01-05 21:22:12 [INFO] <nawf> dude, there isn't much left
2011-01-05 21:22:24 [INFO] <nawf> that was funny though
2011-01-05 21:22:31 [INFO] <nawf> I was like, that creeper is doing weird this
2011-01-05 21:22:33 [INFO] <nawf> shit
2011-01-05 21:23:19 [INFO] <efess> chicken coming down
2011-01-05 21:23:25 [INFO] <efess> lol.
2011-01-05 21:23:38 [INFO] <nawf> you can open it back up
2011-01-05 21:23:43 [INFO] <efess> k
2011-01-05 21:24:13 [INFO] <efess> rofl
2011-01-05 21:24:14 [INFO] <efess> rofl
2011-01-05 21:24:15 [INFO] <efess> rofl
2011-01-05 21:24:16 [INFO] <efess> rofl
2011-01-05 21:24:47 [INFO] <nawf> that was so awesome
2011-01-05 21:24:58 [INFO] <efess> like 4 of them hit me on the way down
2011-01-05 21:25:01 [INFO] <efess> as I was opening it up
2011-01-05 21:25:28 [INFO] <efess> its day now though
2011-01-05 21:25:33 [INFO] <nawf> oh
2011-01-05 21:25:57 [INFO] <efess> lol
2011-01-05 21:26:02 [INFO] <nawf> this is fucking awesome
2011-01-05 21:26:04 [INFO] <nawf> holy fuck
2011-01-05 21:26:16 [INFO] <efess> amazing
2011-01-05 21:26:34 [INFO] <nawf> damnit, I have to go to the bar
2011-01-05 21:26:37 [INFO] <nawf> ;)
2011-01-05 21:26:41 [INFO] <efess> nice
2011-01-05 21:26:50 [INFO] <efess> have fun
2011-01-05 21:27:00 [INFO] <nawf> I wasn to see it at night though
2011-01-05 21:27:08 [INFO] <efess> I know haha
2011-01-05 21:27:17 [INFO] <nawf> I'll shower and come back
2011-01-05 21:27:18 [INFO] <nawf> lol
2011-01-05 21:27:21 [INFO] <nawf> this is too funny
2011-01-05 21:27:27 [INFO] <efess> jess thinks i'm crazy
2011-01-05 21:27:29 [INFO] <efess> laughing
2011-01-05 21:29:00 [INFO] <nawf> must be night
2011-01-05 21:29:02 [INFO] <efess> YESS
2011-01-05 21:29:11 [INFO] <nawf> rrororroflflflffl
2011-01-05 21:29:19 [INFO] <efess> jess: ""you're fucking nuts""
2011-01-05 21:30:03 [INFO] <efess> everything went better than expected!
2011-01-05 21:31:52 [INFO] <efess> loooottttt
2011-01-05 21:32:40 [INFO] <nawf> fu chicken
2011-01-05 21:34:25 [INFO] <efess> love how that chicken is there
2011-01-05 21:36:25 [INFO] <efess> lololol
2011-01-05 21:42:11 [INFO] <efess> did you put this gravel here?
2011-01-05 21:42:22 [INFO] <nawf> where?
2011-01-05 21:42:28 [INFO] <nawf> on the ground? no
2011-01-05 21:42:52 [INFO] <nawf> aight, I gtg, see yah
2011-01-05 21:43:02 [INFO] <efess> alright l8r
2011-01-05 21:43:35 [INFO] <nawf> take my axe
2011-01-05 21:43:45 [INFO] <nawf> only have half a heart left, going to suicide before I die
2011-01-05 21:44:04 [INFO] <nawf> death by cactii
2011-01-05 21:44:12 [INFO] nawf lost connection: disconnect.quitting
2011-01-05 21:58:25 [INFO] efess lost connection: disconnect.quitting
2011-01-05 21:58:29 [INFO] efess [/192.168.0.198:2748] logged in with entity id 439337
2011-01-05 23:57:01 [INFO] efess lost connection: disconnect.quitting
2011-01-05 23:57:09 [INFO] efess [/192.168.0.198:4522] logged in with entity id 472203
2011-01-05 23:57:19 [INFO] efess lost connection: disconnect.quitting
2011-01-06 16:48:03 [INFO] nawf [/76.23.232.27:55039] logged in with entity id 472325
2011-01-06 16:56:30 [INFO] nawf lost connection: disconnect.quitting
2011-01-06 18:05:21 [INFO] nawf [/76.23.232.27:55091] logged in with entity id 477693
2011-01-06 18:32:01 [INFO] nawf lost connection: disconnect.quitting
2011-01-06 20:25:33 [INFO] nawf [/76.23.232.27:55110] logged in with entity id 486660
2011-01-06 21:57:42 [INFO] nawf lost connection: disconnect.quitting
2011-01-06 22:39:23 [INFO] nawf [/76.23.232.27:55043] logged in with entity id 516480
2011-01-06 22:58:33 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 18:50:53 [INFO] efess [/192.168.0.198:7082] logged in with entity id 523026
2011-01-07 19:55:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-07 20:18:53 [INFO] nawf [/76.23.232.27:55162] logged in with entity id 550153
2011-01-07 20:19:00 [INFO] <efess> what up dawg
2011-01-07 20:19:11 [INFO] <nawf> yo
2011-01-07 20:19:20 [INFO] <nawf> spiders get stuck in the trap sometimes
2011-01-07 20:19:25 [INFO] <efess> yea I fixd it
2011-01-07 20:19:28 [INFO] <nawf> oh
2011-01-07 20:19:34 [INFO] <nawf> I tried, failed
2011-01-07 20:19:35 [INFO] <efess> lol.
2011-01-07 20:19:54 [INFO] <efess> just collecting cobblestone
2011-01-07 20:20:00 [INFO] <nawf> and I changed the flow, drops kept getting stuck
2011-01-07 20:20:05 [INFO] <efess> ah
2011-01-07 20:20:08 [INFO] <efess> nice
2011-01-07 20:20:16 [INFO] <efess> and
2011-01-07 20:20:18 [INFO] <efess> diamond!
2011-01-07 20:20:21 [INFO] <nawf> sweet, more diamond, I found some over ahead of the spawn too
2011-01-07 20:20:26 [INFO] <efess> nicee
2011-01-07 20:20:31 [INFO] <nawf> I mean ahead like straight foward
2011-01-07 20:21:48 [INFO] <nawf> I'm digging out from the trap, looking for caves
2011-01-07 20:22:03 [INFO] <efess> cool, did you tnt?
2011-01-07 20:22:09 [INFO] <nawf> naw, not yet
2011-01-07 20:22:12 [INFO] <efess> ah
2011-01-07 20:22:22 [INFO] <nawf> we should though :D
2011-01-07 20:22:32 [INFO] <efess> need to collect tons of sand
2011-01-07 20:22:51 [INFO] <nawf> I'll go do that, there are some islands that need to go behind the spawner
2011-01-07 20:32:26 [INFO] <nawf> lol, creeper helped
2011-01-07 20:32:29 [INFO] <nawf> t
2011-01-07 20:32:57 [INFO] <efess> creeper love
2011-01-07 20:39:04 [INFO] <nawf> yes
2011-01-07 20:39:11 [INFO] <efess> wooooo
2011-01-07 20:39:15 [INFO] <efess> hahahaha
2011-01-07 20:39:26 [INFO] <efess> TNTTTT
2011-01-07 20:42:37 [INFO] <efess> :D
2011-01-07 20:42:56 [INFO] <efess> wooooo
2011-01-07 20:43:02 [INFO] <nawf> rofl
2011-01-07 20:43:43 [INFO] <efess> fucking awesome.
2011-01-07 20:46:41 [INFO] <nawf> did youdie?
2011-01-07 20:46:44 [INFO] <efess> nah
2011-01-07 20:47:06 [INFO] <efess> havin fun
2011-01-07 20:47:07 [INFO] <efess> haha
2011-01-07 20:47:33 [INFO] <efess> diamond!
2011-01-07 20:47:55 [INFO] <nawf> lol, mine got some too
2011-01-07 20:47:58 [INFO] <nawf> I mean exposed it
2011-01-07 20:48:21 [INFO] <efess> just 3
2011-01-07 20:48:33 [INFO] <efess> fuck
2011-01-07 20:48:38 [INFO] <efess> lava got one
2011-01-07 20:48:40 [INFO] <efess> inventory full
2011-01-07 20:49:14 [INFO] <nawf> I don't have an iron pick
2011-01-07 20:49:28 [INFO] <efess> k
2011-01-07 20:49:31 [INFO] <nawf> 4 over here
2011-01-07 20:50:08 [INFO] <nawf> or 5
2011-01-07 20:50:11 [INFO] <nawf> numberz hard
2011-01-07 20:50:31 [INFO] <efess> tnt for the winz
2011-01-07 20:50:32 [INFO] <nawf> so thats cool, 2,2,2,5
2011-01-07 20:54:51 [INFO] <nawf> I'm going to get rid of some of these feathers
2011-01-07 20:55:04 [INFO] <efess> I approve
2011-01-07 20:57:38 [INFO] <efess> pit!
2011-01-07 21:02:15 [INFO] <nawf> t
2011-01-07 21:07:01 [INFO] <efess> lol at ice
2011-01-07 21:17:03 [INFO] <nawf> why did we roof in cobble and then halfsteps?
2011-01-07 21:17:06 [INFO] <nawf> we are dumb
2011-01-07 21:17:22 [INFO] <efess> heh
2011-01-07 21:17:30 [INFO] <efess> pain in the ass doin gjust half steps
2011-01-07 21:17:32 [INFO] <efess> i would think
2011-01-07 21:17:34 [INFO] <efess> but yea
2011-01-07 21:17:51 [INFO] <nawf> naw, you do the 3 wide branches and just fill them
2011-01-07 21:18:37 [INFO] <efess> omg I need shampoo with bamboo extract
2011-01-07 21:18:40 [INFO] <efess> the power of bamboooo!
2011-01-07 21:19:35 [INFO] <nawf> I'll get the mistakes
2011-01-07 21:21:26 [INFO] <nawf> are you drunk?
2011-01-07 21:21:29 [INFO] <efess> hahaha
2011-01-07 21:21:30 [INFO] <efess> no
2011-01-07 21:21:33 [INFO] <efess> just fast
2011-01-07 21:23:08 [INFO] <efess> lol
2011-01-07 21:23:24 [INFO] <nawf> notch writes gud codez
2011-01-07 21:23:26 [INFO] <nawf> wtf
2011-01-07 21:23:27 [INFO] <efess> haha
2011-01-07 21:23:32 [INFO] <efess> gj notch
2011-01-07 21:23:43 [INFO] <efess> floatin gwater
2011-01-07 21:23:44 [INFO] <efess> woo
2011-01-07 21:24:33 [INFO] <nawf> I have no more blocks
2011-01-07 21:26:15 [INFO] <efess> psh
2011-01-07 21:26:15 [INFO] <nawf> lol, that worked
2011-01-07 21:26:26 [INFO] <efess> there
2011-01-07 21:26:27 [INFO] <efess> be brave
2011-01-07 21:28:05 [INFO] <nawf> there is a cave away from our base we shoud clear, I think its close enough to the spawner
2011-01-07 21:28:15 [INFO] <efess> the one down der?
2011-01-07 21:28:35 [INFO] <nawf> naw, its over by the small island I torched up
2011-01-07 21:31:00 [INFO] <nawf> damn
2011-01-07 21:31:04 [INFO] <nawf> almost drowned
2011-01-07 21:31:32 [INFO] <nawf> yeah, this is close enough
2011-01-07 21:34:36 [INFO] <efess> fuck
2011-01-07 21:34:37 [INFO] <efess> get my shit
2011-01-07 21:34:43 [INFO] <efess> there's a diamond shovel
2011-01-07 21:37:03 [INFO] <nawf> can you bring some wheat from the intermediate chest?
2011-01-07 21:37:13 [INFO] <efess> i'm at the islan
2011-01-07 21:37:21 [INFO] <nawf> yeah, the wheat is right there
2011-01-07 21:37:46 [INFO] <efess> no wheat here
2011-01-07 21:37:53 [INFO] <nawf> aw
2011-01-07 21:38:05 [INFO] <efess> i'll collect meat
2011-01-07 21:38:33 [INFO] <nawf> this cave looks large
2011-01-07 21:40:21 [INFO] <nawf> fuck
2011-01-07 21:40:29 [INFO] <nawf> I died now
2011-01-07 21:40:29 [INFO] <efess> wtf creeper in daylight
2011-01-07 21:44:15 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 21:44:17 [INFO] nawf [/76.23.232.27:55018] logged in with entity id 588238
2011-01-07 21:44:56 [INFO] <nawf> shit is this way
2011-01-07 21:44:59 [INFO] <efess> k
2011-01-07 21:45:21 [INFO] <efess> NICE
2011-01-07 21:45:25 [INFO] <efess> er cpas
2011-01-07 21:45:45 [INFO] <nawf> I put most of my shit in here too, so we didn't lose almost anything
2011-01-07 21:46:09 [INFO] <nawf> lots of dark deep rooms around this
2011-01-07 21:46:47 [INFO] <nawf> skele around there
2011-01-07 21:50:12 [INFO] <efess> this shit is big
2011-01-07 21:50:22 [INFO] <nawf> yeah, there is more over here too
2011-01-07 21:50:46 [INFO] <nawf> lol
2011-01-07 21:51:05 [INFO] <nawf> I ran into your torch path from a completely diff direction
2011-01-07 21:52:09 [INFO] <efess> FUCK OFF
2011-01-07 21:52:12 [INFO] <efess> died above lava
2011-01-07 21:52:29 [INFO] <nawf> tons of your stuff is on the bridge
2011-01-07 21:52:37 [INFO] <efess> ya
2011-01-07 21:53:26 [INFO] <nawf> I got a lot of it
2011-01-07 21:53:57 [INFO] <efess> ill bring more wood
2011-01-07 21:54:19 [INFO] <nawf> no diamond shovel though
2011-01-07 21:54:25 [INFO] <efess> good
2011-01-07 21:54:27 [INFO] <efess> ididn't bring it
2011-01-07 21:54:32 [INFO] <nawf> fuck man
2011-01-07 21:54:36 [INFO] <nawf> this is creeper ville
2011-01-07 21:54:41 [INFO] <nawf> we need food/arrows
2011-01-07 21:55:00 [INFO] <efess> got some pork
2011-01-07 21:55:16 [INFO] <nawf> dude, that area you died, I looked ahead and saw 4 creepers
2011-01-07 21:55:25 [INFO] <efess> yea it was a large area
2011-01-07 21:57:00 [INFO] <efess> fuick you spider
2011-01-07 21:57:11 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 22:00:32 [INFO] nawf [/76.23.232.27:55017] logged in with entity id 596832
2011-01-07 22:00:38 [INFO] <nawf> had to make brewdriver
2011-01-07 22:00:47 [INFO] <nawf> and I'm fucking surrounded by darkness
2011-01-07 22:00:52 [INFO] <efess> :o
2011-01-07 22:05:12 [INFO] <nawf> where is the sub-base?
2011-01-07 22:05:16 [INFO] <efess> not sure
2011-01-07 22:05:20 [INFO] <nawf> look
2011-01-07 22:05:26 [INFO] <efess> wooot
2011-01-07 22:07:11 [INFO] <nawf> I found it
2011-01-07 22:07:50 [INFO] <efess> got string or bow?
2011-01-07 22:08:58 [INFO] <nawf> yeah
2011-01-07 22:09:06 [INFO] <nawf> bow in chest
2011-01-07 22:09:11 [INFO] <efess> k
2011-01-07 22:09:37 [INFO] <nawf> put half the arrows in two
2011-01-07 22:09:40 [INFO] <nawf> too
2011-01-07 22:09:45 [INFO] efess tried command: got 64
2011-01-07 22:09:47 [INFO] <efess> got 64
2011-01-07 22:09:54 [INFO] <efess> lots of iron :D
2011-01-07 22:10:00 [INFO] <efess> shit like 10
2011-01-07 22:10:00 [INFO] <efess> lol
2011-01-07 22:10:34 [INFO] <nawf> oh you know what, can you fish underground?
2011-01-07 22:10:40 [INFO] <efess> probably :D
2011-01-07 22:10:45 [INFO] <nawf> thats what we need, poles so we can fish and not go get piggiez
2011-01-07 22:10:50 [INFO] <efess> no kidding
2011-01-07 22:10:53 [INFO] <efess> that's a great idea
2011-01-07 22:10:58 [INFO] <efess> I bet all you need is standing water
2011-01-07 22:11:34 [INFO] <nawf> yeah, looks like anywhere
2011-01-07 22:11:39 [INFO] <efess> got another string
2011-01-07 22:12:40 [INFO] <nawf> dayum, more cave
2011-01-07 22:13:39 [INFO] <nawf> spider!
2011-01-07 22:16:07 [INFO] <efess> lol
2011-01-07 22:16:24 [INFO] <nawf> thats teamwork right there
2011-01-07 22:16:44 [INFO] <efess> got no more pick
2011-01-07 22:16:52 [INFO] <nawf> I dropped some
2011-01-07 22:19:01 [INFO] <nawf> I breached
2011-01-07 22:20:27 [INFO] <nawf> holy shit
2011-01-07 22:20:42 [INFO] <nawf> we went far already
2011-01-07 22:21:15 [INFO] <efess> diamond down here
2011-01-07 22:21:17 [INFO] <efess> no pick
2011-01-07 22:21:38 [INFO] <nawf> woot
2011-01-07 22:21:53 [INFO] <nawf> omw
2011-01-07 22:22:15 [INFO] <efess> here
2011-01-07 22:22:30 [INFO] <nawf> oh shit
2011-01-07 22:22:35 [INFO] <nawf> I have no pick either
2011-01-07 22:22:38 [INFO] <nawf> I swore I had one
2011-01-07 22:22:41 [INFO] <efess> haha
2011-01-07 22:22:42 [INFO] <nawf> lol, trolllolololol
2011-01-07 22:23:33 [INFO] <efess> oh
2011-01-07 22:23:39 [INFO] <efess> subbase is right here
2011-01-07 22:23:40 [INFO] <efess> woo
2011-01-07 22:24:13 [INFO] <efess> got fishing rod
2011-01-07 22:24:28 [INFO] <nawf> nice, find a spider?
2011-01-07 22:24:34 [INFO] <efess> found a few earlier
2011-01-07 22:26:08 [INFO] <efess> come
2011-01-07 22:26:21 [INFO] <efess> lol weird
2011-01-07 22:26:28 [INFO] <efess> I don't understand it
2011-01-07 22:26:36 [INFO] <nawf> wait until it bobs and splashes
2011-01-07 22:26:46 [INFO] <efess> then click
2011-01-07 22:26:47 [INFO] <efess> ?
2011-01-07 22:26:51 [INFO] <nawf> yeah
2011-01-07 22:27:05 [INFO] <efess> wow this sucks
2011-01-07 22:27:08 [INFO] <efess> takes long
2011-01-07 22:27:53 [INFO] <efess> maybe needs more water
2011-01-07 22:27:54 [INFO] <efess> donno
2011-01-07 22:28:01 [INFO] <nawf> doesn't mention it on the page
2011-01-07 22:28:05 [INFO] <nawf> where the fuck are those zombies
2011-01-07 22:28:17 [INFO] <efess> spider too
2011-01-07 22:30:07 [INFO] <nawf> hugsssssssssssss
2011-01-07 22:32:36 [INFO] <efess> lol
2011-01-07 22:34:02 [INFO] <efess> lol
2011-01-07 22:35:01 [INFO] <efess> how many hearts?
2011-01-07 22:35:07 [INFO] <nawf> 7.5
2011-01-07 22:35:10 [INFO] <efess> k
2011-01-07 22:35:29 [INFO] <efess> diamond!
2011-01-07 22:36:33 [INFO] <efess> wow
2011-01-07 22:37:06 [INFO] <nawf> cave is good, we already have a stack of iron too
2011-01-07 22:38:56 [INFO] <nawf> be careful, there is a creepr around ther
2011-01-07 22:42:19 [INFO] <efess> omg
2011-01-07 22:42:20 [INFO] <efess> cave
2011-01-07 22:42:20 [INFO] <efess> big
2011-01-07 22:42:26 [INFO] <nawf> I'm in one too
2011-01-07 22:48:23 [INFO] <nawf> you trying to go to sub base?
2011-01-07 22:48:25 [INFO] <efess> ya
2011-01-07 22:48:27 [INFO] <nawf> up
2011-01-07 22:48:29 [INFO] <nawf> look up
2011-01-07 22:49:11 [INFO] <nawf> shit now I'm lost
2011-01-07 22:49:13 [INFO] <nawf> lol
2011-01-07 22:49:49 [INFO] <efess> shit shit
2011-01-07 22:49:50 [INFO] <efess> sthi
2011-01-07 22:50:04 [INFO] <nawf> where do these fucks come from
2011-01-07 22:50:10 [INFO] <nawf> there must be a dark room up high
2011-01-07 22:50:15 [INFO] <efess> got lots of health?
2011-01-07 22:50:33 [INFO] <efess> i'm carying diamonds
2011-01-07 22:50:36 [INFO] <efess> 1.5 hearts
2011-01-07 22:50:37 [INFO] <nawf> stay there
2011-01-07 22:50:38 [INFO] <nawf> lol
2011-01-07 22:50:54 [INFO] <efess> lol
2011-01-07 22:51:01 [INFO] <efess> lets just make a chest here
2011-01-07 22:51:10 [INFO] <nawf> ok
2011-01-07 22:51:18 [INFO] <nawf> I think we are like 3 feet away from the sub-base
2011-01-07 22:51:35 [INFO] <efess> yea
2011-01-07 22:51:39 [INFO] <efess> true
2011-01-07 22:51:41 [INFO] <nawf> yeah, its right up here
2011-01-07 22:52:16 [INFO] <nawf> we only have one cooked meat
2011-01-07 22:53:06 [INFO] <efess> lol fishing rod has health bar
2011-01-07 22:57:55 [INFO] <efess> fud!
2011-01-07 22:59:07 [INFO] <nawf> I'm going to get the wheat
2011-01-07 22:59:16 [INFO] <efess> got 5 pork
2011-01-07 22:59:19 [INFO] nawf tried command: spawn
2011-01-07 22:59:25 [INFO] <efess> and more coming
2011-01-07 22:59:57 [INFO] <nawf> wtf, where is the what
2011-01-07 23:01:59 [INFO] <efess> here pig piggy
2011-01-07 23:03:04 [INFO] <efess> lol I see diamondz
2011-01-07 23:03:07 [INFO] <efess> in a missing chunk
2011-01-07 23:07:26 [INFO] <nawf> bacon factory
2011-01-07 23:09:14 [INFO] <nawf> PUMPKINS
2011-01-07 23:09:19 [INFO] <efess> :D
2011-01-07 23:09:44 [INFO] <nawf> rofl
2011-01-07 23:09:48 [INFO] <efess> nice lol
2011-01-07 23:10:32 [INFO] <efess> you low on woodz?
2011-01-07 23:10:48 [INFO] <nawf> naw, I had over 70 on me
2011-01-07 23:11:00 [INFO] <nawf> planks that is
2011-01-07 23:11:11 [INFO] <efess> k
2011-01-07 23:17:30 [INFO] <nawf> I found a donut cave
2011-01-07 23:17:31 [INFO] <nawf> wtf
2011-01-07 23:19:20 [INFO] <nawf> lol, I found A diamond
2011-01-07 23:22:57 [INFO] <nawf> damn this cave is huge
2011-01-07 23:23:10 [INFO] <nawf> I took 4 steps out of our sub-base and I'm in a totally different cavern
2011-01-07 23:23:12 [INFO] <nawf> you too?
2011-01-07 23:23:16 [INFO] <efess> nah
2011-01-07 23:23:17 [INFO] <efess> same shit
2011-01-07 23:30:28 [INFO] <efess> at sub base
2011-01-07 23:30:55 [INFO] <nawf> I'm sofa king lost
2011-01-07 23:30:59 [INFO] <efess> haha
2011-01-07 23:33:24 [INFO] <efess> going to surface for more wood
2011-01-07 23:33:29 [INFO] <nawf> me too
2011-01-07 23:33:31 [INFO] <nawf> lol
2011-01-07 23:33:58 [INFO] <efess> making an emergency shaft?
2011-01-07 23:35:55 [INFO] <nawf> eyah
2011-01-07 23:38:49 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 23:43:07 [INFO] nawf [/76.23.232.27:55041] logged in with entity id 642529
2011-01-07 23:43:13 [INFO] <efess> another beerdriver?
2011-01-07 23:43:17 [INFO] <nawf> 7eah
2011-01-07 23:43:25 [INFO] <efess> I could use one
2011-01-07 23:43:43 [INFO] <nawf> found mon spawner
2011-01-07 23:43:49 [INFO] <efess> fuck ye
2011-01-07 23:44:34 [INFO] <nawf> man, its close to the surface
2011-01-07 23:45:36 [INFO] <efess> weee treees
2011-01-07 23:45:59 [INFO] <efess> got wood?
2011-01-07 23:46:01 [INFO] <nawf> no
2011-01-07 23:46:02 [INFO] <efess> muahaha.
2011-01-07 23:46:16 [INFO] <nawf> mob spawner is over here
2011-01-07 23:46:56 [INFO] <efess> wow
2011-01-07 23:47:59 [INFO] <nawf> zombies are being an asshole
2011-01-07 23:49:33 [INFO] <nawf> go go go go go
2011-01-07 23:49:36 [INFO] <nawf> I have no torches
2011-01-07 23:49:49 [INFO] <nawf> woo
2011-01-07 23:49:57 [INFO] <nawf> lol saddle
2011-01-07 23:50:42 [INFO] <nawf> noo
2011-01-07 23:50:46 [INFO] <nawf> not the bow
2011-01-07 23:51:12 [INFO] <efess> holy fuck
2011-01-07 23:51:14 [INFO] <efess> ing
2011-01-07 23:51:15 [INFO] <efess> asshole
2011-01-07 23:51:53 [INFO] <efess> wtf
2011-01-07 23:52:03 [INFO] <efess> fucking zombies
2011-01-07 23:52:09 [INFO] <efess> i'm already 1/2 health
2011-01-07 23:53:22 [INFO] <nawf> I got all your stuff
2011-01-07 23:53:30 [INFO] <efess> that's a lot of stuff
2011-01-07 23:53:37 [INFO] <nawf> I had the mob spawner chest
2011-01-07 23:54:43 [INFO] <nawf> rofl
2011-01-07 23:54:45 [INFO] <efess> lol
2011-01-07 23:54:59 [INFO] <nawf> twitchy
2011-01-07 23:56:25 [INFO] <efess> crawling with mobs
2011-01-07 23:56:28 [INFO] <nawf> sunrise to purdy
2011-01-07 23:56:32 [INFO] <nawf> so purdy
2011-01-07 23:56:45 [INFO] <efess> so are PIGS
2011-01-07 23:56:51 [INFO] <nawf> watch out
2011-01-07 23:56:53 [INFO] <nawf> creeper
2011-01-07 23:58:18 [INFO] <nawf> this is the way down
2011-01-07 23:58:26 [INFO] <nawf> I think I gave you all my pickaxes
2011-01-07 23:58:54 [INFO] <nawf> behind you
2011-01-07 23:59:19 [INFO] <nawf> dead
2011-01-08 00:01:27 [INFO] efess lost connection: disconnect.quitting
2011-01-08 00:01:30 [INFO] efess [/192.168.0.198:10193] logged in with entity id 662489
2011-01-08 00:02:01 [INFO] <nawf> the way back to the main cave is around here
2011-01-08 00:04:07 [INFO] <efess> foudn it
2011-01-08 00:06:02 [INFO] <efess> surface time
2011-01-08 00:06:04 [INFO] <efess> ?
2011-01-08 00:06:11 [INFO] <nawf> there is still more I think
2011-01-08 00:06:46 [INFO] <nawf> your standing on a new chest I made, lol
2011-01-08 00:06:59 [INFO] <efess> can you open it when I stand on ti?
2011-01-08 00:07:03 [INFO] <nawf> yeah
2011-01-08 00:07:05 [INFO] <efess> heh
2011-01-08 00:07:18 [INFO] <nawf> see those creepers were falling from someplace right outside our base
2011-01-08 00:07:29 [INFO] <efess> look up
2011-01-08 00:07:30 [INFO] <efess> lol
2011-01-08 00:16:16 [INFO] <efess> mother fucker
2011-01-08 00:16:31 [INFO] <nawf> err, I didn't see where you died
2011-01-08 00:16:35 [INFO] <efess> no prob
2011-01-08 00:16:36 [INFO] <efess> nothing big on me
2011-01-08 00:16:39 [INFO] <nawf> I do now
2011-01-08 00:16:57 [INFO] <nawf> I see where they are coming from too
2011-01-08 00:16:57 [INFO] <efess> coudln't switch to sword :\
2011-01-08 00:20:50 [INFO] <efess> did youp ick it all up?
2011-01-08 00:20:53 [INFO] <nawf> yeah
2011-01-08 00:20:54 [INFO] <efess> k
2011-01-08 00:21:04 [INFO] <efess> 'cause its all here lol.
2011-01-08 00:23:29 [INFO] <nawf> I think you saw glitched items
2011-01-08 00:23:33 [INFO] <efess> yea I did
2011-01-08 00:23:34 [INFO] <nawf> because there is no way I had two bows
2011-01-08 00:24:49 [INFO] <nawf> ah fuck
2011-01-08 00:24:52 [INFO] <nawf> I was going to seal this off
2011-01-08 00:26:37 [INFO] <nawf> dark areas over here
2011-01-08 00:27:15 [INFO] <nawf> friendz
2011-01-08 00:27:52 [INFO] <nawf> brb
2011-01-08 00:27:53 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 00:31:23 [INFO] nawf [/76.23.232.27:55070] logged in with entity id 675600
2011-01-08 00:35:43 [INFO] <nawf> cave is opening up over here
2011-01-08 00:36:42 [INFO] <nawf> spider spawner
2011-01-08 00:40:32 [INFO] <efess> foudn zombie spawner
2011-01-08 00:40:36 [INFO] <nawf> nice
2011-01-08 00:43:20 [INFO] <nawf> I wish there was better loot for spawners
2011-01-08 00:47:04 [INFO] <nawf> diamondz
2011-01-08 00:47:08 [INFO] <nawf> !!!
2011-01-08 00:47:09 [INFO] <nawf> just 3
2011-01-08 00:53:26 [INFO] <efess> man
2011-01-08 00:53:27 [INFO] <efess> scared me
2011-01-08 00:53:28 [INFO] <nawf> LOL
2011-01-08 00:53:29 [INFO] <efess> lol
2011-01-08 00:53:38 [INFO] <efess> just going to see where the fuck you were
2011-01-08 00:53:44 [INFO] <nawf> I was about 15 blocks away so I burrowed up to you
2011-01-08 00:53:45 [INFO] <efess> fucking opening up again, more diamonds
2011-01-08 00:53:50 [INFO] <nawf> I have 4 now
2011-01-08 00:53:52 [INFO] <efess> no space in inentory
2011-01-08 00:53:58 [INFO] <efess> need fud?
2011-01-08 00:54:04 [INFO] <nawf> sure
2011-01-08 00:54:08 [INFO] <nawf> what can we combine?
2011-01-08 00:54:21 [INFO] <efess> i have 2 chests
2011-01-08 00:54:21 [INFO] <nawf> redstone? gunpowder?
2011-01-08 00:54:29 [INFO] <efess> no gunpowder
2011-01-08 00:54:30 [INFO] <nawf> I have 2 also
2011-01-08 00:54:39 [INFO] <nawf> ROFL
2011-01-08 00:54:40 [INFO] <efess> lol
2011-01-08 00:54:51 [INFO] <nawf> wait, you need the space right?
2011-01-08 00:54:55 [INFO] <nawf> so give to me
2011-01-08 00:55:29 [INFO] <efess> sub base close or no?
2011-01-08 00:55:38 [INFO] <nawf> I don't think so, I was in a branch myself
2011-01-08 00:55:54 [INFO] <nawf> dayum, we may need to go up
2011-01-08 00:56:08 [INFO] <nawf> diamonds
2011-01-08 00:57:13 [INFO] <nawf> how many diamonds do you have?
2011-01-08 00:57:16 [INFO] <efess> zero
2011-01-08 00:57:19 [INFO] <nawf> I have 9
2011-01-08 00:57:44 [INFO] <nawf> here, we should split them, so I don't lose all 9 just in case
2011-01-08 00:57:53 [INFO] <efess> k
2011-01-08 00:58:08 [INFO] <efess> moar!
2011-01-08 00:58:57 [INFO] <nawf> nice!
2011-01-08 01:08:46 [INFO] <efess> woooooo
2011-01-08 01:08:48 [INFO] <nawf> lol
2011-01-08 01:08:55 [INFO] <nawf> how did that happen?
2011-01-08 01:08:57 [INFO] <efess> no clue
2011-01-08 01:08:58 [INFO] <efess> lol
2011-01-08 01:09:07 [INFO] <nawf> soo many buckets
2011-01-08 01:09:24 [INFO] <efess> so much IRON
2011-01-08 01:09:42 [INFO] <nawf> yeah, this was an awesome haul
2011-01-08 01:11:20 [INFO] <efess> ironnnzzzz
2011-01-08 01:11:37 [INFO] <nawf> fuck
2011-01-08 01:11:41 [INFO] <nawf> thats awesome
2011-01-08 01:12:03 [INFO] <efess> I'm going to get some sleep
2011-01-08 01:12:04 [INFO] <efess> im beat
2011-01-08 01:12:25 [INFO] <efess> today was a good splunk
2011-01-08 01:12:25 [INFO] <efess> lol
2011-01-08 01:12:29 [INFO] <nawf> yeah, me too, damn 1:11
2011-01-08 01:12:34 [INFO] <efess> yea
2011-01-08 01:12:39 [INFO] <nawf> we need to haul this and see what we have to work with
2011-01-08 01:12:45 [INFO] <efess> trackz.
2011-01-08 01:12:53 [INFO] <nawf> because we have 3 chests full of misc shit now
2011-01-08 01:12:58 [INFO] <efess> yea haha
2011-01-08 01:13:14 [INFO] <nawf> well, our base, the spawner, above the spanwer, and this
2011-01-08 01:13:35 [INFO] <efess> above the spawner isn't much
2011-01-08 01:13:36 [INFO] <nawf> aight, do you know when you'll likely be on?
2011-01-08 01:13:45 [INFO] <efess> tomorrow? off and on
2011-01-08 01:13:51 [INFO] <efess> probably mornig
2011-01-08 01:13:59 [INFO] <nawf> gotcha, well ping me on skype, I have no plans
2011-01-08 01:14:03 [INFO] <efess> aight
2011-01-08 01:14:06 [INFO] <efess> l8r
2011-01-08 01:14:09 [INFO] <nawf> prob be cleaning, painting bathroom
2011-01-08 01:14:10 [INFO] <nawf> later
2011-01-08 01:14:13 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 01:14:13 [INFO] efess lost connection: disconnect.quitting
2011-01-08 10:13:43 [INFO] efess [/192.168.0.198:11934] logged in with entity id 726916
2011-01-08 10:15:35 [INFO] efess lost connection: disconnect.quitting
2011-01-08 11:22:13 [INFO] nawf [/76.23.232.27:55030] logged in with entity id 727990
2011-01-08 11:58:54 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 11:59:00 [INFO] nawf [/76.23.232.27:55045] logged in with entity id 742092
2011-01-08 12:10:44 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 12:24:43 [INFO] Disconnecting /76.23.232.27:55097: Took too long to log in
2011-01-08 14:10:38 [INFO] efess [/192.168.0.198:14385] logged in with entity id 748833
2011-01-08 14:15:49 [INFO] nawf [/76.23.232.27:55091] logged in with entity id 751595
2011-01-08 14:15:52 [INFO] <efess> sup
2011-01-08 14:15:55 [INFO] <nawf> yo
2011-01-08 14:16:14 [INFO] <nawf> I'm trying to think how we should build the rail line to the spawner
2011-01-08 14:16:34 [INFO] <efess> I think it should be at diamond level
2011-01-08 14:16:55 [INFO] <efess> the more we mine at that level the better
2011-01-08 14:16:59 [INFO] <nawf> yeah
2011-01-08 14:19:37 [INFO] <nawf> so I built one tunnel already, just to see if I could use xyz coords to build things
2011-01-08 14:19:44 [INFO] <nawf> worked great, never tried that before
2011-01-08 14:19:48 [INFO] <efess> nice
2011-01-08 14:19:53 [INFO] <nawf> where are you?
2011-01-08 14:20:04 [INFO] <efess> getting some diamond I left
2011-01-08 14:20:15 [INFO] <efess> and seeing where my old tunnel goes
2011-01-08 14:20:43 [INFO] <efess> what x coord were you planning on using
2011-01-08 14:20:50 [INFO] <nawf> 0
2011-01-08 14:21:02 [INFO] <efess> k
2011-01-08 14:22:19 [INFO] <nawf> I think I built it at diamon level
2011-01-08 14:22:57 [INFO] <efess> I guess Y is the level
2011-01-08 14:24:03 [INFO] <efess> just one diamond :(
2011-01-08 14:24:06 [INFO] <nawf> I'm at level 16
2011-01-08 14:24:30 [INFO] <efess> my Y says 12
2011-01-08 14:24:35 [INFO] <efess> and i'm at lava lvl
2011-01-08 14:24:38 [INFO] <efess> so that sounds good
2011-01-08 14:25:03 [INFO] <nawf> wait, its level 15, didn't subtract me
2011-01-08 14:25:59 [INFO] <nawf> we just have to get this tunnel to the base
2011-01-08 14:26:19 [INFO] efess lost connection: disconnect.quitting
2011-01-08 14:26:22 [INFO] efess [/192.168.0.198:14494] logged in with entity id 757861
2011-01-08 14:27:37 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 14:27:40 [INFO] nawf [/76.23.232.27:55087] logged in with entity id 758642
2011-01-08 14:27:44 [INFO] <efess> what part are you tunnelling, from the spawner or from our base?
2011-01-08 14:27:53 [INFO] <nawf> from the spawner
2011-01-08 14:27:56 [INFO] <nawf> where are you now?
2011-01-08 14:28:06 [INFO] <efess> at our cave base
2011-01-08 14:28:10 [INFO] <efess> by our base
2011-01-08 14:28:21 [INFO] <efess> z= -135
2011-01-08 14:28:26 [INFO] <efess> y=16
2011-01-08 14:30:49 [INFO] <nawf> t'
2011-01-08 14:32:01 [INFO] <efess> lol
2011-01-08 14:33:07 [INFO] <efess> where you at
2011-01-08 14:33:18 [INFO] <efess> found your stairway going up
2011-01-08 14:33:35 [INFO] <nawf> from the long tunnel?
2011-01-08 14:33:39 [INFO] <efess> ya
2011-01-08 14:33:44 [INFO] <nawf> ok, I'll head there
2011-01-08 14:34:03 [INFO] <efess> was at the right level
2011-01-08 14:34:17 [INFO] <efess> but I was breaking blocks 0 - 1
2011-01-08 14:34:21 [INFO] <efess> you were -1 - 0
2011-01-08 14:34:21 [INFO] <nawf> now we just have to keep it going until our base and then make a left
2011-01-08 14:35:05 [INFO] <nawf> oh lol
2011-01-08 14:35:11 [INFO] <efess> almost
2011-01-08 14:35:15 [INFO] <efess> pretty good for x/y's
2011-01-08 14:35:15 [INFO] <nawf> state job
2011-01-08 14:35:37 [INFO] <nawf> so you already got from the base?
2011-01-08 14:35:42 [INFO] <efess> sorta
2011-01-08 14:35:55 [INFO] <efess> goes to the cave base
2011-01-08 14:36:02 [INFO] <nawf> I don't remember that one
2011-01-08 14:36:24 [INFO] <nawf> oh right
2011-01-08 14:38:36 [INFO] <efess> so this needs to go a little further
2011-01-08 14:38:41 [INFO] <efess> than take a left
2011-01-08 14:39:12 [INFO] <efess> well
2011-01-08 14:39:16 [INFO] <efess> dig two more blocks up
2011-01-08 14:39:46 [INFO] <nawf> here, take the diamond if your going to dig, I made one
2011-01-08 14:40:01 [INFO] <efess> nice
2011-01-08 14:40:09 [INFO] <nawf> I don't know where I am really, bad sense of direction
2011-01-08 14:40:21 [INFO] <efess> heh
2011-01-08 14:40:29 [INFO] <efess> well I think we need to figure out where to go down
2011-01-08 14:40:30 [INFO] <efess> from our base
2011-01-08 14:40:35 [INFO] <efess> than link this to it
2011-01-08 14:40:44 [INFO] <nawf> yeah, let me go up there
2011-01-08 14:43:55 [INFO] <efess> where am i
2011-01-08 14:44:17 [INFO] <nawf> your using your bow
2011-01-08 14:44:31 [INFO] <nawf> yes bow mining
2011-01-08 14:44:32 [INFO] <efess> its very durable
2011-01-08 14:44:49 [INFO] <efess> i'm goin gto start mining w/ tnt
2011-01-08 14:44:55 [INFO] <efess> using tnt as a picka xe
2011-01-08 14:44:58 [INFO] <nawf> lol
2011-01-08 14:46:42 [INFO] <nawf> so this cave probably connects over there
2011-01-08 14:47:03 [INFO] <nawf> did you remember the xyz from the path?
2011-01-08 14:47:31 [INFO] <efess> I think the Z was right here
2011-01-08 14:47:32 [INFO] <efess> not sure
2011-01-08 14:47:35 [INFO] <efess> let me go look
2011-01-08 14:47:36 [INFO] <nawf> or do we go down from here
2011-01-08 14:47:46 [INFO] <efess> we could do either
2011-01-08 14:47:59 [INFO] <efess> we could continue this stairway all the way down
2011-01-08 14:48:08 [INFO] <nawf> true, but we can't track that
2011-01-08 14:48:13 [INFO] <efess> true
2011-01-08 14:48:28 [INFO] <nawf> well we need to pick a spot for the station
2011-01-08 14:48:34 [INFO] <nawf> like where the start of our track is
2011-01-08 14:48:44 [INFO] <efess> I say we clean this up down here
2011-01-08 14:49:25 [INFO] <efess> i'll dig down
2011-01-08 15:06:39 [INFO] <efess> done
2011-01-08 15:10:01 [INFO] <efess> sweet
2011-01-08 15:12:20 [INFO] <nawf> stfu chicken!
2011-01-08 15:12:48 [INFO] <efess> did you see the minecraft music creater ama on reddit?
2011-01-08 15:12:53 [INFO] <nawf> naw
2011-01-08 15:13:11 [INFO] <efess> oh was interesting
2011-01-08 15:13:21 [INFO] <efess> Guess deadmau5 is going to work on some mindcraft music
2011-01-08 15:13:29 [INFO] <nawf> nice
2011-01-08 15:13:39 [INFO] <nawf> did you see when deadmau dropped his server into lava?
2011-01-08 15:13:45 [INFO] <efess> yea haha
2011-01-08 15:20:42 [INFO] <nawf> egg
2011-01-08 15:21:12 [INFO] <efess> half steps around the track?
2011-01-08 15:21:32 [INFO] <efess> that's cool
2011-01-08 15:22:00 [INFO] <efess> be even cooler if we continue it if we do something to the south
2011-01-08 15:22:17 [INFO] <nawf> we could outlaw slavery
2011-01-08 15:36:43 [INFO] <efess> brb
2011-01-08 15:37:02 [INFO] <efess> gotta install a curtain rod
2011-01-08 15:37:05 [INFO] <nawf> lol
2011-01-08 15:37:39 [INFO] <efess> minecart track is laid, just need boosters. I don't know your vision for the spawner track though sc
2011-01-08 15:37:50 [INFO] <efess> so I left the track in the chest here
2011-01-08 15:37:54 [INFO] <nawf> I don't know either, we keep mining it out more
2011-01-08 15:58:45 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 16:41:42 [INFO] nawf [/76.23.232.27:55104] logged in with entity id 837002
2011-01-08 16:47:44 [INFO] <efess> yay curtains are up
2011-01-08 16:47:54 [INFO] <nawf> I did spackling
2011-01-08 16:47:58 [INFO] <nawf> curtains are later
2011-01-08 16:48:14 [INFO] <efess> had to move a picture... removed nails, pulled up some paint..
2011-01-08 16:48:17 [INFO] <efess> will need to spackle too
2011-01-08 16:48:39 [INFO] <nawf> so I just build a big stair
2011-01-08 16:48:41 [INFO] <nawf> dunno
2011-01-08 16:48:45 [INFO] <efess> lol
2011-01-08 16:49:08 [INFO] <nawf> I gotta go drop some cobblestone off
2011-01-08 16:49:10 [INFO] <efess> i'm goin to build a booster here
2011-01-08 16:49:34 [INFO] <efess> we'll have the cart go to the top right?
2011-01-08 16:49:36 [INFO] <nawf> need me to take some of yours up?  I was going to put it in the chest by the ginder
2011-01-08 16:49:55 [INFO] <nawf> yeah, but I don't know where, around the spiral is cool, I don't know if we can boost it enough thou
2011-01-08 16:50:07 [INFO] <efess> well i'll install this booster which will give you an idea
2011-01-08 16:50:08 [INFO] <efess> :)
2011-01-08 16:52:12 [INFO] <nawf> we have so much iron, there is a random stack of 64 in every chest
2011-01-08 16:52:18 [INFO] <efess> ya lol
2011-01-08 16:52:29 [INFO] <efess> I can't believe how many tracks I was able to make
2011-01-08 16:54:50 [INFO] <nawf> rfol
2011-01-08 16:54:58 [INFO] <efess> wt
2011-01-08 16:55:03 [INFO] <nawf> damn, I almost pushed a pig all the way down here
2011-01-08 16:55:08 [INFO] <efess> I saw it fall
2011-01-08 16:55:14 [INFO] <nawf> bastard pig
2011-01-08 16:57:17 [INFO] <nawf> aw fuck
2011-01-08 17:04:21 [INFO] <efess> needs more boost
2011-01-08 17:04:39 [INFO] <nawf> rofl
2011-01-08 17:04:39 [INFO] <efess> lolol
2011-01-08 17:05:14 [INFO] <nawf> why not put another booster here?
2011-01-08 17:05:18 [INFO] <nawf> or something
2011-01-08 17:05:23 [INFO] <efess> well if you make the booster longer
2011-01-08 17:05:28 [INFO] <efess> I think it'll make it to our base
2011-01-08 17:05:31 [INFO] <nawf> true
2011-01-08 17:05:38 [INFO] <efess> what about double track
2011-01-08 17:05:58 [INFO] <nawf> I don't know what that means
2011-01-08 17:06:08 [INFO] <efess> one track for inbound, another for outbound
2011-01-08 17:06:14 [INFO] <nawf> we could
2011-01-08 17:06:21 [INFO] <nawf> we have enough and the hole is wide enough
2011-01-08 17:06:34 [INFO] <efess> i'm just thinking, that was a pita that I stopped you
2011-01-08 17:06:59 [INFO] <efess> yea lets do it, seems track is pretty cheap
2011-01-08 17:07:09 [INFO] <nawf> yeah, we have tons of shit
2011-01-08 17:09:46 [INFO] <nawf> wait, why do we have a water collector for loot?  its all going to fall there anyway
2011-01-08 17:09:56 [INFO] <efess> yea, good question.
2011-01-08 17:13:12 [WARNING] efess moved wrongly!
2011-01-08 17:13:15 [INFO] <efess> almost
2011-01-08 17:13:28 [INFO] <efess> another booster at our base should be fine.
2011-01-08 17:13:49 [INFO] <nawf> yeah, we need a boost to get here too
2011-01-08 17:13:53 [INFO] <efess> yup
2011-01-08 17:22:08 [INFO] <efess> I see water kills tracks... damn
2011-01-08 17:22:15 [INFO] <nawf> yeah
2011-01-08 17:22:37 [INFO] <efess> good to know if I have to redo a booster
2011-01-08 17:22:56 [INFO] <efess> I just laid two sets of tracks all the way up
2011-01-08 17:22:59 [INFO] <efess> hit water and undid everything
2011-01-08 17:23:01 [INFO] <efess> lol
2011-01-08 17:23:03 [INFO] <nawf> lol
2011-01-08 17:23:09 [INFO] <nawf> cntrl+z
2011-01-08 17:32:27 [INFO] <efess> try it
2011-01-08 17:32:33 [INFO] <nawf> ok
2011-01-08 17:32:47 [INFO] <nawf> booster is broke
2011-01-08 17:32:56 [INFO] <efess> silly booster
2011-01-08 17:32:57 [INFO] <nawf> oh wait
2011-01-08 17:33:03 [INFO] <nawf> no its goo
2011-01-08 17:33:12 [INFO] <nawf> dun dun da daaaa
2011-01-08 17:33:14 [INFO] <nawf> dun dun daaaaa
2011-01-08 17:33:15 [INFO] <efess> is it trackless on the right or the left
2011-01-08 17:33:18 [INFO] <nawf> dun dun da da
2011-01-08 17:33:24 [INFO] <nawf> dun dun DAA DAAAA DAAAAAA
2011-01-08 17:33:25 [INFO] <efess> LOL
2011-01-08 17:33:32 [INFO] <efess> are you on the right or the left track
2011-01-08 17:33:35 [INFO] <nawf> right
2011-01-08 17:33:44 [INFO] <efess> wierd, on my screen you were on the left
2011-01-08 17:33:45 [INFO] <efess> lol
2011-01-08 17:33:55 [INFO] <nawf> that worked
2011-01-08 17:33:56 [INFO] <efess> i didn't test that booster
2011-01-08 17:33:58 [INFO] <efess> nice
2011-01-08 17:34:20 [INFO] <nawf> thats a cool booster design
2011-01-08 17:34:31 [INFO] <efess> ya I like it
2011-01-08 17:36:19 [INFO] <efess> there was rage meme pic
2011-01-08 17:36:30 [INFO] <efess> first time you find red stone
2011-01-08 17:36:33 [INFO] <efess> you're like HOLY SHIT
2011-01-08 17:36:43 [INFO] <efess> then after a while.. fucking redstone
2011-01-08 17:36:54 [INFO] <nawf> yeah
2011-01-08 17:40:24 [INFO] <efess> cool!
2011-01-08 17:40:44 [INFO] <nawf> Im just doing ""something"" I don't know what yet, lots to dig out
2011-01-08 17:40:49 [INFO] <nawf> like underground forst thing?
2011-01-08 17:41:02 [INFO] <efess> yea!
2011-01-08 17:41:15 [INFO] <efess> underground forests are awesome
2011-01-08 17:41:25 [INFO] <nawf> we have ""the tree""
2011-01-08 17:41:27 [INFO] <efess> Are you going to the lanparty this weekend?
2011-01-08 17:41:29 [INFO] <nawf> its a start
2011-01-08 17:41:33 [INFO] <nawf> next?
2011-01-08 17:41:39 [INFO] <efess> this
2011-01-08 17:41:41 [INFO] <efess> well
2011-01-08 17:41:47 [INFO] <efess> I guess next
2011-01-08 17:42:03 [INFO] <nawf> naw, got plans to meet up with an old boss and marini, play games
2011-01-08 17:42:05 [INFO] <efess> if we're in a weekend, isn't the following weekend
2011-01-08 17:42:09 [INFO] <efess> considered ""this weekend""
2011-01-08 17:42:21 [INFO] <efess> k
2011-01-08 17:43:06 [INFO] <efess> taly ho!
2011-01-08 17:43:30 [INFO] <efess> did you ever play transport tycoon?
2011-01-08 17:43:33 [INFO] <nawf> naw
2011-01-08 17:43:36 [INFO] <efess> oh man
2011-01-08 17:43:41 [INFO] <efess> its like sim city
2011-01-08 17:43:49 [INFO] <efess> only all about trains
2011-01-08 17:43:57 [INFO] <efess> moving goods/ people between towns
2011-01-08 17:44:23 [INFO] <nawf> that sounds cool
2011-01-08 17:52:22 [INFO] <efess> you're sweet entrance tunnel is now disproportionat
2011-01-08 17:59:48 [INFO] <efess> lol
2011-01-08 17:59:58 [INFO] <efess> I just rode the track through a missing chunk here
2011-01-08 18:00:02 [INFO] <efess> and I see some diamond
2011-01-08 18:00:03 [INFO] <efess> woooo
2011-01-08 18:00:46 [INFO] efess lost connection: disconnect.quitting
2011-01-08 18:00:50 [INFO] efess [/192.168.0.198:15861] logged in with entity id 887800
2011-01-08 18:01:36 [INFO] <efess> got an iron pick?
2011-01-08 18:01:40 [INFO] <nawf> naw
2011-01-08 18:02:02 [INFO] <efess> this is sweet
2011-01-08 18:02:20 [INFO] <nawf> I want to get grass down here
2011-01-08 18:02:24 [INFO] <efess> yea
2011-01-08 18:02:27 [INFO] <efess> just need light
2011-01-08 18:02:33 [INFO] <nawf> naw, need connecting grass
2011-01-08 18:02:38 [INFO] <efess> oh I see
2011-01-08 18:02:48 [INFO] <efess> so..
2011-01-08 18:02:56 [INFO] <efess> you have to lead it from the surface?
2011-01-08 18:03:02 [INFO] <nawf> yeah
2011-01-08 18:03:22 [INFO] <nawf> cause if we blow up of the shit over here we can do like rolling hills or something
2011-01-08 18:03:34 [INFO] <efess> ya
2011-01-08 18:03:50 [INFO] <efess> all this shit should be blown up
2011-01-08 18:04:00 [INFO] <efess> 'cause its directly under the grinder
2011-01-08 18:07:32 [WARNING] efess moved wrongly!
2011-01-08 18:07:50 [WARNING] efess moved wrongly!
2011-01-08 18:08:53 [INFO] <efess> brb fud
2011-01-08 18:30:01 [INFO] <nawf> just idling, have to get some more work done around the apartment
2011-01-08 18:30:06 [INFO] <efess> aight
2011-01-08 18:30:14 [INFO] <efess> i've only got another hour or so
2011-01-08 18:30:39 [INFO] <nawf> wanna see if the grass is working too
2011-01-08 18:31:04 [INFO] <nawf> I heard a shot
2011-01-08 18:32:27 [INFO] <nawf> prog take forever
2011-01-08 20:20:00 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 22:11:34 [INFO] Disconnecting nawf [/76.23.232.27:55011]: Took too long to log in
2011-01-08 22:11:42 [INFO] nawf [/76.23.232.27:55011] logged in with entity id 1005409
2011-01-08 22:12:56 [INFO] <nawf> wtf
2011-01-08 22:13:08 [INFO] <nawf> there is an efess in a hole
2011-01-09 00:03:11 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 03:10:06 [INFO] efess lost connection: disconnect.timeout
2011-01-09 08:18:58 [INFO] efess [/192.168.0.198:21829] logged in with entity id 1089942
2011-01-09 08:19:07 [INFO] efess [/192.168.0.198:21834] logged in with entity id 1090110
2011-01-09 08:24:05 [INFO] efess lost connection: disconnect.quitting
2011-01-09 10:37:26 [INFO] nawf [/76.23.232.27:55052] logged in with entity id 1092055
2011-01-09 12:09:59 [INFO] <nawf> t
2011-01-09 12:28:05 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 13:06:40 [INFO] nawf [/76.23.232.27:55060] logged in with entity id 1125645
2011-01-09 15:13:49 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 15:13:52 [INFO] nawf [/76.23.232.27:55014] logged in with entity id 1164494
2011-01-09 15:59:57 [INFO] efess [/192.168.0.198:23133] logged in with entity id 1177503
2011-01-09 16:46:01 [INFO] <nawf> yo
2011-01-09 16:46:06 [INFO] <efess> hey dude
2011-01-09 16:46:27 [INFO] <efess> I saw some awesome station videos on youtube
2011-01-09 16:46:47 [INFO] <efess> i'm going to experiement with some setup here
2011-01-09 16:46:54 [INFO] <efess> butchering the station you build though :o
2011-01-09 16:46:58 [INFO] <nawf> ok, I'm just building, tunneling out
2011-01-09 16:47:06 [INFO] <nawf> we can build it again!
2011-01-09 16:47:09 [INFO] <efess> ya
2011-01-09 16:47:09 [INFO] <efess> !~
2011-01-09 16:47:22 [INFO] <nawf> so I had to move the colleciton area, skeletons can shoot you
2011-01-09 16:47:31 [INFO] <efess> ya
2011-01-09 16:47:36 [INFO] <efess> did you see I died over the night
2011-01-09 16:47:42 [INFO] <nawf> and be careful, this place isn't safe, mobs are spawning outside the area
2011-01-09 16:47:46 [INFO] <efess> yea I saw
2011-01-09 16:48:05 [INFO] <efess> I was idling besides the death chute down on the spiral
2011-01-09 16:48:12 [INFO] <efess> somehow a creeper was able to blow it up
2011-01-09 16:48:12 [INFO] <nawf> yeah, did you see my sign?
2011-01-09 16:48:15 [INFO] <efess> no
2011-01-09 16:48:21 [INFO] <nawf> damn creeper
2011-01-09 16:48:26 [INFO] <nawf> I put a sign in front of your face
2011-01-09 16:48:32 [INFO] <efess> oh ahah
2011-01-09 16:48:36 [INFO] <efess> I didn't read it
2011-01-09 16:48:39 [INFO] <nawf> we have so much tnt
2011-01-09 17:50:01 [INFO] <nawf> bathroom is done
2011-01-09 17:50:43 [INFO] <efess> BATHROOM HUH
2011-01-09 17:50:46 [INFO] <efess> er
2011-01-09 17:51:20 [INFO] <nawf> yeah, painted, new furniture, new wall shit, only unhappy with the rugs, well, I think they are ok
2011-01-09 17:51:37 [INFO] <efess> Thought you meant minecraft
2011-01-09 17:51:38 [INFO] <efess> lulz.
2011-01-09 17:52:21 [INFO] <efess> silly zombie in our base
2011-01-09 17:53:28 [INFO] <nawf> I'm about to set off 64 tnt, think your server can handle it?
2011-01-09 17:53:34 [INFO] <nawf> want me to wait for you?
2011-01-09 17:53:37 [INFO] <efess> yea
2011-01-09 17:53:39 [INFO] <efess> b there in a sec
2011-01-09 17:54:32 [INFO] <efess> minecart subways rock
2011-01-09 17:54:47 [INFO] <nawf> no skin?
2011-01-09 17:54:52 [INFO] <efess> donno
2011-01-09 17:54:53 [INFO] <efess> lol
2011-01-09 17:54:56 [INFO] <efess> its here
2011-01-09 17:55:00 [INFO] <nawf> yeah, your on default
2011-01-09 17:55:07 [INFO] <efess> so are you :o
2011-01-09 17:55:10 [INFO] <efess> grass is coming
2011-01-09 17:55:10 [INFO] <nawf> lol
2011-01-09 17:55:13 [INFO] <efess> nie
2011-01-09 17:55:33 [INFO] <efess> :D
2011-01-09 17:55:36 [INFO] <nawf> :D
2011-01-09 17:55:40 [INFO] <nawf> ready to run?
2011-01-09 17:55:42 [INFO] <efess> doo it
2011-01-09 17:55:52 [INFO] <efess> :D
2011-01-09 17:55:53 [INFO] <efess> :D
2011-01-09 17:56:54 [INFO] <nawf> we only have 150 tnt left
2011-01-09 17:56:55 [INFO] <nawf> :D
2011-01-09 17:57:18 [INFO] <efess> no diamond :(
2011-01-09 17:57:25 [INFO] <nawf> I did 20 tnt before, got 2
2011-01-09 17:57:30 [INFO] <efess> sweet
2011-01-09 17:57:30 [INFO] <efess> hehe
2011-01-09 17:57:37 [INFO] <efess> k dinner
2011-01-09 17:57:39 [INFO] <efess> brb
2011-01-09 18:08:46 [INFO] <nawf> trying to move all the shit in ""the vault""
2011-01-09 18:08:51 [INFO] <nawf> err, to the vault
2011-01-09 18:08:57 [INFO] <efess> the mother fuckin vault.
2011-01-09 18:09:07 [INFO] <nawf> this could be for transfer goods
2011-01-09 19:18:33 [INFO] <efess> I guess Jess thought my phone was dirty
2011-01-09 21:22:55 [INFO] <nawf> why was your phone dirty?
2011-01-09 21:23:11 [INFO] <efess> well if it was, it certainly isn't anymore
2011-01-09 21:27:18 [INFO] <efess> it went through the washer
2011-01-09 21:27:32 [INFO] <nawf> that was nice of her to clean your phone
2011-01-09 21:27:39 [INFO] <efess> I know, without even asking too
2011-01-09 21:36:46 [INFO] <nawf> hmm, where should all this tnt go...
2011-01-09 21:36:59 [INFO] <efess> should be used!
2011-01-09 21:37:17 [INFO] <nawf> we only have 220
2011-01-09 21:37:22 [INFO] <efess> shit we need moar
2011-01-09 21:39:05 [INFO] <nawf> think the server can handle 220 tnt?
2011-01-09 21:39:14 [INFO] <efess> I'd do a backup first
2011-01-09 21:39:14 [INFO] <efess> lol
2011-01-09 21:42:50 [INFO] <nawf> ready to do a backup?
2011-01-09 21:42:52 [INFO] <nawf> :D:D:D:D:D
2011-01-09 21:43:18 [INFO] <efess> haha
2011-01-09 21:43:25 [INFO] <efess> hold on
2011-01-09 21:45:57 [INFO] <efess> got some torches?
2011-01-09 21:46:29 [INFO] <efess> thanks
2011-01-09 21:46:41 [INFO] <efess> oh god
2011-01-09 21:47:00 [INFO] <efess> do ittt
2011-01-09 21:47:23 [INFO] <efess> lolololol
2011-01-09 21:47:25 [INFO] <nawf> lllaaaagggggg
2011-01-09 21:47:33 [INFO] <efess> LOLOLOL
2011-01-09 21:47:35 [INFO] <efess> wooooo
2011-01-09 21:48:30 [INFO] <efess> diamond!
2011-01-09 21:52:24 [INFO] <efess> hey come to the base
2011-01-09 21:52:28 [INFO] <efess> go on the right track
2011-01-09 21:52:35 [INFO] <nawf> is ther ea cart?
2011-01-09 21:52:43 [WARNING] efess moved wrongly!
2011-01-09 21:52:53 [INFO] <efess> ill give you one
2011-01-09 21:54:13 [WARNING] efess moved wrongly!
2011-01-09 21:54:55 [INFO] <efess> hahaha
2011-01-09 21:54:59 [INFO] <nawf> lol
2011-01-09 21:55:02 [INFO] <nawf> thats cool
2011-01-09 21:56:10 [INFO] <efess> the wood one is a ""cart collector""
2011-01-09 21:56:12 [INFO] <nawf> thats pretty sweet
2011-01-09 21:56:22 [INFO] <efess> the stone plate only activates when there's a rider
2011-01-09 22:31:42 [WARNING] efess moved wrongly!
2011-01-09 22:32:40 [WARNING] efess moved wrongly!
2011-01-09 23:17:31 [INFO] efess lost connection: disconnect.quitting
2011-01-09 23:17:34 [INFO] efess [/192.168.0.198:29304] logged in with entity id 1539197
2011-01-09 23:17:55 [INFO] efess lost connection: disconnect.quitting
2011-01-10 09:04:43 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 17:36:13 [INFO] nawf [/76.23.232.27:55082] logged in with entity id 1696214
2011-01-10 17:53:38 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 17:53:41 [INFO] nawf [/76.23.232.27:55050] logged in with entity id 1701982
2011-01-10 18:11:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 18:23:12 [INFO] efess [/192.168.0.198:33925] logged in with entity id 1709243
2011-01-10 20:14:14 [INFO] nawf [/76.23.232.27:55027] logged in with entity id 1760392
2011-01-10 20:14:27 [INFO] <efess> the... addiction....
2011-01-10 20:14:43 [INFO] <nawf> lol
2011-01-10 20:15:57 [INFO] <efess> saw you got tons of sheep now
2011-01-10 20:16:01 [INFO] <efess> sheep grinder? :)
2011-01-10 20:16:23 [INFO] <nawf> I don't know what you would build with the wool
2011-01-10 20:16:31 [INFO] <efess> a fuckin wool mountani
2011-01-10 20:19:58 [INFO] <efess> yo
2011-01-10 20:20:00 [INFO] <nawf> lol
2011-01-10 20:20:11 [INFO] <efess> so
2011-01-10 20:20:14 [INFO] <efess> i'm makin this wider
2011-01-10 20:20:16 [INFO] <efess> by a block
2011-01-10 20:20:19 [INFO] <nawf> ok
2011-01-10 20:22:07 [INFO] <nawf> I just need the dirt and gravel for the river/lake/thing
2011-01-10 20:37:37 [INFO] <efess> fishinglake
2011-01-10 20:39:31 [WARNING] Time ran backwards! Did the system time change?
2011-01-10 20:39:53 [INFO] <efess> damn boosters
2011-01-10 20:39:56 [INFO] <efess> unreliable
2011-01-10 20:40:30 [INFO] <nawf> yeah, I couldn't go all the way up once
2011-01-10 20:40:46 [INFO] <efess> I put a booster at the top
2011-01-10 20:40:48 [INFO] <efess> to try to fix it
2011-01-10 20:46:54 [INFO] <efess> ok water sucks
2011-01-10 20:46:56 [INFO] <efess> lol
2011-01-10 21:58:18 [INFO] <nawf> TNT TIME!
2011-01-10 21:58:24 [INFO] <efess> moar?
2011-01-10 21:58:31 [INFO] <nawf> THERE IS ALWAYS MOAR
2011-01-10 21:58:34 [INFO] <efess> haha
2011-01-10 21:59:32 [INFO] <efess> wooo
2011-01-10 22:00:43 [INFO] <efess> lol chunk error
2011-01-10 22:00:55 [INFO] efess lost connection: disconnect.quitting
2011-01-10 22:00:58 [INFO] efess [/192.168.0.198:35476] logged in with entity id 1854670
2011-01-10 22:01:23 [INFO] <nawf> need torches?
2011-01-10 22:01:26 [INFO] <efess> nah
2011-01-10 22:01:57 [INFO] <efess> how many?
2011-01-10 22:02:01 [INFO] <nawf> 64
2011-01-10 22:02:03 [INFO] <efess> woo
2011-01-10 22:02:06 [INFO] <nawf> stuffed in the hole
2011-01-10 22:02:09 [INFO] <nawf> ready!
2011-01-10 22:02:11 [INFO] <efess> tnt in your hole?
2011-01-10 22:02:26 [INFO] <nawf> lol
2011-01-10 22:03:34 [INFO] <efess> need moar
2011-01-10 22:04:41 [INFO] <efess> how'd you fill the lake?
2011-01-10 22:04:43 [INFO] <nawf> trying to get around the spawner, next I'll go along the other wall
2011-01-10 22:04:56 [INFO] <efess> oh its all flowing down
2011-01-10 22:04:59 [INFO] <nawf> 1 layer deep infinite water pool
2011-01-10 22:05:09 [INFO] <nawf> then destroy the dirt
2011-01-10 22:05:47 [INFO] <efess> john the gardener
2011-01-10 22:06:37 [INFO] <efess> we're going to have to expand on the spawner
2011-01-10 22:06:50 [INFO] <nawf> yeah, we have tons of cobble stone
2011-01-10 22:06:50 [INFO] <efess> we have a chest full of cobbleston
2011-01-10 22:07:05 [INFO] <nawf> and I need to hollow out more
2011-01-10 22:07:20 [INFO] <efess> gotta make those rolling hills
2011-01-10 22:07:28 [INFO] <efess> and I want a ski slope on the far wall
2011-01-10 22:07:28 [INFO] <efess> :D
2011-01-10 22:07:30 [INFO] <nawf> yeah
2011-01-10 22:07:42 [INFO] <nawf> I want to actually make the river to all the way to our base
2011-01-10 22:07:50 [INFO] <nawf> so we can boat it
2011-01-10 22:07:53 [INFO] <efess> nice
2011-01-10 22:07:56 [INFO] <nawf> that would be cool
2011-01-10 22:07:59 [INFO] <efess> we know how to make docks
2011-01-10 22:08:45 [INFO] <efess> I wanna make a minecart dispenser
2011-01-10 22:08:46 [INFO] <efess> at the base
2011-01-10 22:08:50 [INFO] <efess> lol
2011-01-10 22:09:07 [INFO] <nawf> I broke it
2011-01-10 22:09:08 [INFO] <nawf> lol
2011-01-10 22:09:42 [INFO] <efess> lulz.
2011-01-10 22:25:59 [INFO] <efess> still there?
2011-01-10 22:26:07 [INFO] <nawf> yeah, for a little bit longer
2011-01-10 22:26:14 [INFO] <efess> aight i'm hittin the hay
2011-01-10 22:26:18 [INFO] <efess> later man
2011-01-10 22:26:22 [INFO] <nawf> later
2011-01-10 22:26:47 [INFO] <efess> btw I don't know wtf to do about the stairs
2011-01-10 22:26:52 [INFO] <efess> at the station here
2011-01-10 22:26:53 [INFO] <efess> bah
2011-01-10 22:27:05 [INFO] efess lost connection: disconnect.quitting
2011-01-11 09:11:02 [INFO] nawf lost connection: disconnect.quitting
2011-01-11 20:34:58 [INFO] Disconnecting /76.23.232.27:55086: Took too long to log in
2011-01-11 20:35:24 [INFO] nawf [/76.23.232.27:55008] logged in with entity id 2052482
2011-01-11 20:35:40 [INFO] <nawf> help
2011-01-11 20:35:45 [INFO] <nawf> is ther ea command list?
2011-01-11 22:22:23 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 06:11:49 [INFO] Disconnecting efess [/192.168.0.198:55981]: Took too long to log in
2011-01-12 06:11:57 [INFO] efess [/192.168.0.198:55983] logged in with entity id 2103780
2011-01-12 08:30:13 [WARNING] efess moved wrongly!
2011-01-12 10:50:34 [INFO] efess lost connection: disconnect.quitting
2011-01-12 11:10:13 [INFO] efess [/192.168.0.198:59037] logged in with entity id 2262297
2011-01-12 12:18:47 [INFO] nawf [/76.23.232.27:55115] logged in with entity id 2287357
2011-01-12 12:29:38 [INFO] <efess> sily brits
2011-01-12 12:33:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 12:34:22 [INFO] nawf [/76.23.232.27:55402] logged in with entity id 2299581
2011-01-12 14:21:55 [INFO] efess lost connection: disconnect.quitting
2011-01-12 14:28:03 [INFO] efess [/192.168.0.198:61203] logged in with entity id 2389521
2011-01-12 14:36:34 [INFO] efess lost connection: disconnect.quitting
2011-01-12 14:37:11 [INFO] efess [/192.168.0.198:61309] logged in with entity id 2398273
2011-01-12 14:59:49 [INFO] efess lost connection: disconnect.quitting
2011-01-12 15:54:43 [INFO] efess [/192.168.0.198:61956] logged in with entity id 2429307
2011-01-12 15:57:02 [INFO] efess lost connection: disconnect.genericReason
2011-01-12 15:57:36 [INFO] efess [/192.168.0.198:61974] logged in with entity id 2431740
2011-01-12 16:07:29 [INFO] efess lost connection: disconnect.quitting
2011-01-12 17:03:37 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 17:04:51 [INFO] nawf [/76.23.232.27:55199] logged in with entity id 2454614
2011-01-12 17:07:17 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 17:17:20 [INFO] efess [/192.168.0.198:62523] logged in with entity id 2455674
2011-01-12 17:24:58 [INFO] <efess> eroding island
2011-01-12 17:32:04 [INFO] efess lost connection: disconnect.quitting
2011-01-12 17:34:15 [INFO] nawf [/76.23.232.27:55050] logged in with entity id 2463250
2011-01-12 17:37:14 [INFO] AngryRhetoric [/24.147.183.4:52862] logged in with entity id 2464345
2011-01-12 17:37:41 [INFO] <AngryRhetoric> anyone online?
2011-01-12 17:37:44 [INFO] <nawf> yeah
2011-01-12 17:37:52 [INFO] <nawf> whats up
2011-01-12 17:37:58 [INFO] <AngryRhetoric> this john? heh not too much
2011-01-12 17:38:03 [INFO] <nawf> yeah, thats me
2011-01-12 17:38:05 [INFO] <nawf> joe is efess
2011-01-12 17:38:13 [INFO] <AngryRhetoric> ahh ok cool
2011-01-12 17:38:22 [INFO] <AngryRhetoric> thanks for  the invite
2011-01-12 17:38:26 [INFO] <nawf> yeah np
2011-01-12 17:38:32 [INFO] <nawf> its cool to have you on board
2011-01-12 17:38:58 [INFO] <AngryRhetoric> whoa i just dug a cube of dirt and it got replaced immediately
2011-01-12 17:39:08 [INFO] <nawf> yeah, can' change shit around the spawner
2011-01-12 17:39:20 [INFO] <AngryRhetoric> really? like in a radius? cool
2011-01-12 17:39:26 [INFO] <AngryRhetoric> i see you in the distance
2011-01-12 17:39:48 [INFO] <AngryRhetoric> sweeet
2011-01-12 17:39:58 [INFO] <nawf> yeah, this is the ""main base"" up here
2011-01-12 17:40:05 [INFO] <AngryRhetoric> very cool
2011-01-12 17:40:23 [INFO] <AngryRhetoric> hah FUD
2011-01-12 17:40:38 [INFO] <AngryRhetoric> hey how the heck do you eat eggs? i couldn't figure that one out
2011-01-12 17:40:52 [INFO] <nawf> can't yet, you can throw them though and 1/8 chance they'll turn into chickens
2011-01-12 17:40:58 [INFO] <AngryRhetoric> coOOol
2011-01-12 17:41:20 [INFO] <AngryRhetoric> how about saddles, are those usable?
2011-01-12 17:41:33 [INFO] <nawf> kinda, you can put them on pigs and ride them, but they still walk randomly
2011-01-12 17:41:53 [INFO] <nawf> the wheat farm/garden is over here
2011-01-12 17:41:55 [INFO] <AngryRhetoric> that's no fun, i wanted to ride a spider lik ethe skeletons do
2011-01-12 17:42:31 [INFO] <nawf> fud
2011-01-12 17:42:34 [INFO] <AngryRhetoric> ahhHh
2011-01-12 17:42:41 [INFO] <AngryRhetoric> i never mastered growing crops
2011-01-12 17:42:51 [INFO] <nawf> there is a water path underneath you
2011-01-12 17:43:17 [INFO] <nawf> check this out, harvest time!
2011-01-12 17:43:23 [INFO] <AngryRhetoric> oh o
2011-01-12 17:43:28 [INFO] <AngryRhetoric> haha whoa
2011-01-12 17:43:42 [INFO] <nawf> it will all flow there
2011-01-12 17:43:43 [INFO] <AngryRhetoric> lol
2011-01-12 17:43:47 [INFO] <nawf> or not
2011-01-12 17:43:49 [INFO] <nawf> lol
2011-01-12 17:45:06 [INFO] <nawf> yeah, it gets dangerous at night over on the edges, we kinda ""moved on"" from this area
2011-01-12 17:45:31 [INFO] <AngryRhetoric> really? you should tunnel in between the diff areas if you haven't already
2011-01-12 17:45:36 [INFO] <AngryRhetoric> is this on hard diff?
2011-01-12 17:45:40 [INFO] <nawf> yeah, by default its hard
2011-01-12 17:45:46 [INFO] <AngryRhetoric> ahh
2011-01-12 17:45:47 [INFO] <nawf> oh, we are, let me tell you we are
2011-01-12 17:46:01 [INFO] <AngryRhetoric> i got pretty good at that so i can help lol
2011-01-12 17:46:20 [INFO] <nawf> you haven't seen the train station yet
2011-01-12 17:46:22 [INFO] <nawf> :D
2011-01-12 17:46:27 [INFO] <AngryRhetoric> GO ON
2011-01-12 17:46:31 [INFO] <AngryRhetoric> night time
2011-01-12 17:46:46 [INFO] <nawf> its over here
2011-01-12 17:47:13 [INFO] <AngryRhetoric> haha shit
2011-01-12 17:47:19 [INFO] <nawf> get on it
2011-01-12 17:47:23 [INFO] <nawf> err in it
2011-01-12 17:47:30 [INFO] <nawf> oh wtf
2011-01-12 17:47:34 [INFO] <AngryRhetoric> its gone now
2011-01-12 17:48:00 [INFO] <nawf> you have to right click
2011-01-12 17:48:04 [INFO] <AngryRhetoric> ah
2011-01-12 17:48:16 [INFO] <nawf> wait for it
2011-01-12 17:48:24 [INFO] <AngryRhetoric> its crooked
2011-01-12 17:49:06 [INFO] <AngryRhetoric> daam
2011-01-12 17:49:22 [INFO] <AngryRhetoric> you guys have been busy
2011-01-12 17:50:20 [INFO] <nawf> I'm coming
2011-01-12 17:50:36 [INFO] <nawf> your under the mob spawner
2011-01-12 17:50:41 [INFO] <nawf> well unless you moved
2011-01-12 17:50:44 [INFO] <AngryRhetoric> here comes one now
2011-01-12 17:51:12 [INFO] <nawf> they fall from a platform up above
2011-01-12 17:51:21 [INFO] <nawf> come stand here, its awesome
2011-01-12 17:51:22 [INFO] <AngryRhetoric> there's a pile down below
2011-01-12 17:51:34 [INFO] <nawf> yeah, we basically have infinite arrows
2011-01-12 17:51:43 [INFO] <AngryRhetoric> how many moss blocks did you need to get them to spawn in there?
2011-01-12 17:51:47 [INFO] <nawf> and then we hooked this up to the spawner
2011-01-12 17:51:53 [INFO] <nawf> well a mob spawner in the other room
2011-01-12 17:52:21 [INFO] <nawf> I'll show you
2011-01-12 17:52:23 [INFO] <AngryRhetoric> looks like only one row
2011-01-12 17:52:30 [INFO] <nawf> well thats just the zombie spawner
2011-01-12 17:52:38 [INFO] <nawf> upstairs there is a platform river system thing
2011-01-12 17:52:40 [INFO] <AngryRhetoric> hah
2011-01-12 17:53:33 [INFO] <nawf> we are rearranging this whole entry to the surface now
2011-01-12 17:53:42 [INFO] <nawf> well I am, had to get dirt down here for grass
2011-01-12 17:53:53 [INFO] <AngryRhetoric> adds a nice touch to a cave lol
2011-01-12 17:54:03 [INFO] <nawf> damnit, chunk error
2011-01-12 17:54:06 [INFO] <nawf> hold on one sec
2011-01-12 17:54:07 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 17:54:10 [INFO] nawf [/76.23.232.27:55047] logged in with entity id 2474944
2011-01-12 17:54:24 [INFO] <nawf> see this is the death chute
2011-01-12 17:55:15 [INFO] <AngryRhetoric> great wall of china over there?
2011-01-12 17:55:18 [INFO] <nawf> so basically there is dark space in there with channels that all flow to the death chute
2011-01-12 17:55:29 [INFO] <nawf> so mobs spawn, they get pulled in
2011-01-12 17:55:52 [INFO] <nawf> one of the projects is to flatten this island so we can double the size of it
2011-01-12 17:55:59 [INFO] <nawf> thats what I was going when you logged in
2011-01-12 17:56:12 [INFO] <AngryRhetoric> what's on top look like? open?
2011-01-12 17:56:17 [INFO] <nawf> just half blocks
2011-01-12 17:57:07 [INFO] <AngryRhetoric> LOL
2011-01-12 17:57:19 [INFO] <nawf> and we are doubling it soon too!
2011-01-12 17:57:24 [INFO] <AngryRhetoric> whoa it looked like you were launching arrows at me
2011-01-12 17:57:31 [INFO] <nawf> yeah
2011-01-12 17:57:32 [INFO] <nawf> I was
2011-01-12 17:57:50 [INFO] <AngryRhetoric> oh heh it still showed as an artifact
2011-01-12 17:57:54 [INFO] <nawf> we have almost a whole double chest of arrows from this mob grinder
2011-01-12 17:58:05 [INFO] <nawf> yeah, multiplayer is buggy, if there are bug empty cubes those are chunk errors
2011-01-12 17:58:06 [INFO] <AngryRhetoric> i believe it
2011-01-12 17:58:15 [INFO] <nawf> just logout and log back in
2011-01-12 17:58:20 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-12 17:58:23 [INFO] AngryRhetoric [/24.147.183.4:53758] logged in with entity id 2476521
2011-01-12 17:58:25 [INFO] <nawf> I think there is an update for that today
2011-01-12 17:58:34 [INFO] <AngryRhetoric> the arrows have landed
2011-01-12 17:58:56 [INFO] <AngryRhetoric> brb
2011-01-12 17:58:58 [INFO] <nawf> np
2011-01-12 18:06:57 [INFO] efess [/192.168.0.198:62824] logged in with entity id 2479794
2011-01-12 18:07:21 [INFO] <nawf> yo
2011-01-12 18:07:32 [INFO] <efess> Hey
2011-01-12 18:07:41 [INFO] <nawf> kevin is here too, I think he's afk though
2011-01-12 18:07:49 [INFO] <efess> cool
2011-01-12 18:07:57 [INFO] <AngryRhetoric> hey i'm back
2011-01-12 18:08:01 [INFO] <efess> hey kevin
2011-01-12 18:08:07 [INFO] <AngryRhetoric> sup joe
2011-01-12 18:08:14 [INFO] <AngryRhetoric> quite the place you got here
2011-01-12 18:08:29 [INFO] <efess> yea, must expand though :D
2011-01-12 18:08:41 [INFO] <AngryRhetoric> hahaha
2011-01-12 18:08:42 [INFO] <nawf> we have big plans
2011-01-12 18:09:13 [INFO] <efess> I moved a bunch more cobblestone
2011-01-12 18:09:25 [INFO] <nawf> yeah, I saw, I'm island flattening
2011-01-12 18:09:28 [INFO] <efess> operation kill island?
2011-01-12 18:09:32 [INFO] <AngryRhetoric> lol
2011-01-12 18:09:42 [INFO] <AngryRhetoric> the island will never see it coming
2011-01-12 18:10:17 [INFO] <nawf> yeah, wuzzah island
2011-01-12 18:10:39 [INFO] <AngryRhetoric> spider near you john
2011-01-12 18:11:04 [INFO] <nawf> unlimited arrows!
2011-01-12 18:11:20 [INFO] <efess> haha we need to throw them away
2011-01-12 18:11:33 [INFO] <efess> too bad we can't have some kind of separater
2011-01-12 18:12:02 [INFO] <nawf> the only thing that works if you idle with yout inventory filled with only the items you want to get
2011-01-12 18:12:21 [INFO] <nawf> so like 20 stacks of one gunpowder
2011-01-12 18:12:57 [INFO] <AngryRhetoric> not a bad idea
2011-01-12 18:13:38 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-12 18:14:01 [INFO] /24.147.183.4:54366 lost connection
2011-01-12 18:14:04 [INFO] <nawf> he was intimidated by our awesome
2011-01-12 18:14:08 [INFO] <nawf> ;)
2011-01-12 18:14:20 [INFO] <efess> I'd be blown away too
2011-01-12 18:14:31 [INFO] <nawf> I had him sit in a minecart ready to go
2011-01-12 18:14:36 [INFO] Disconnecting /24.147.183.4:54383: Took too long to log in
2011-01-12 18:14:37 [INFO] <nawf> have a seat... lol
2011-01-12 18:15:02 [INFO] <efess> btw I fixed the incomming so the booster won't take the cart
2011-01-12 18:15:06 [INFO] <efess> until you get out
2011-01-12 18:15:18 [INFO] <nawf> I think I saw that
2011-01-12 18:15:19 [INFO] <efess> works alright, but getting out pushes the minecart out of position
2011-01-12 18:15:29 [INFO] <efess> which can fuck up the booster
2011-01-12 18:15:35 [INFO] <efess> what a pain in the ass
2011-01-12 18:15:44 [INFO] <nawf> we fucked it up before, pushed a cart into the booster by accident
2011-01-12 18:15:54 [INFO] <nawf> well I did, it was a pita to fix because the carts kept moving
2011-01-12 18:15:54 [INFO] <efess> yea that too
2011-01-12 18:16:31 [INFO] <efess> the wiring was a pita, but at least its stable
2011-01-12 18:16:58 [INFO] <efess> are you tnt'ing or just mining this
2011-01-12 18:17:13 [INFO] <nawf> I was tnting, but doing just straight cobble isn't worth it
2011-01-12 18:17:19 [INFO] <nawf> only when its dirt or your chaining tnt
2011-01-12 18:22:26 [INFO] <nawf> need some tools?
2011-01-12 18:22:31 [INFO] <efess> yea
2011-01-12 18:22:42 [INFO] <nawf> going to make them out of the leftover iron here
2011-01-12 18:22:45 [INFO] <nawf> do we have enough?
2011-01-12 18:22:48 [INFO] <efess> ya
2011-01-12 18:23:52 [INFO] <efess> thx
2011-01-12 18:30:18 [INFO] AngryRhetoric [/24.147.183.4:55106] logged in with entity id 2491578
2011-01-12 18:30:25 [INFO] <AngryRhetoric> minecraft went down! lol
2011-01-12 18:30:50 [INFO] <AngryRhetoric> got booted and then couldn't authenticate
2011-01-12 18:30:58 [INFO] <efess> weird
2011-01-12 18:31:06 [INFO] <AngryRhetoric> nice skin
2011-01-12 18:31:10 [INFO] <efess> hehe
2011-01-12 18:37:28 [INFO] <efess> man
2011-01-12 18:37:41 [INFO] <efess> I always have 3 inventory slots wasted
2011-01-12 18:37:46 [INFO] <efess> on a few feathers, arrows and string
2011-01-12 18:37:52 [INFO] <nawf> heh
2011-01-12 18:38:04 [INFO] <nawf> need a trash can down there
2011-01-12 18:38:08 [INFO] <AngryRhetoric> haha
2011-01-12 18:38:13 [INFO] <efess> lava pit
2011-01-12 18:38:16 [INFO] <AngryRhetoric> plunder filter
2011-01-12 18:38:24 [INFO] <nawf> or maybe move the shit dump so you don't HAVE to walk over it to get to the vault
2011-01-12 18:38:35 [INFO] <efess> yea :P
2011-01-12 18:38:53 [INFO] <efess> like a shower stall
2011-01-12 18:38:56 [INFO] <efess> a shower of drops
2011-01-12 18:39:07 [INFO] <nawf> that place grew because I just had to put the shit someplace and needed to idle without dying
2011-01-12 18:40:24 [INFO] <nawf> lol, uphill water
2011-01-12 18:42:19 [INFO] <AngryRhetoric> the cow doesn't know what to do
2011-01-12 18:42:57 [INFO] <efess> what island?
2011-01-12 18:43:09 [INFO] <AngryRhetoric> just some water and that's it
2011-01-12 18:43:31 [INFO] <efess> a random staircase
2011-01-12 18:43:57 [INFO] <nawf> no mobs spawning in there
2011-01-12 18:46:42 [INFO] <nawf> ok, I'm going to take a break for a bit, I'll just idle, then we build!
2011-01-12 18:46:54 [INFO] <efess> to the vault!
2011-01-12 18:47:04 [INFO] <AngryRhetoric> are there any extra pick axes and supplies? if not i can make them
2011-01-12 18:47:04 [INFO] <nawf> vault?
2011-01-12 18:47:16 [INFO] <efess> you probably have to make them
2011-01-12 18:47:19 [INFO] <nawf> I think there is wood in the vault, not sure, I think we are running out
2011-01-12 18:47:29 [INFO] <AngryRhetoric> no problem
2011-01-12 18:47:35 [INFO] <nawf> oh wiat, I'm dropping off iron tools here as you say that
2011-01-12 18:47:36 [INFO] <nawf> lol
2011-01-12 18:48:03 [INFO] <efess> so I say we leave the wood wall
2011-01-12 18:48:17 [INFO] <efess> takin git down won't do anything
2011-01-12 18:48:30 [INFO] <nawf> yeah, we can always light it all on fire anyway
2011-01-12 18:48:34 [INFO] <efess> ;D
2011-01-12 18:49:36 [INFO] <nawf> lol
2011-01-12 18:49:51 [INFO] <efess> ow
2011-01-12 18:50:09 [INFO] <efess> ya
2011-01-12 18:50:09 [INFO] <efess> lol
2011-01-12 18:50:17 [INFO] <efess> crazy spiders
2011-01-12 18:53:41 [INFO] <nawf> wait
2011-01-12 18:53:45 [INFO] <efess> ?
2011-01-12 18:53:53 [INFO] <nawf> a channel starts where you have that wall I think
2011-01-12 18:53:59 [INFO] <nawf> oh no
2011-01-12 18:54:00 [INFO] <nawf> nrm
2011-01-12 18:54:01 [INFO] <efess> no we'll use the channel
2011-01-12 18:54:02 [INFO] <efess> ya
2011-01-12 18:54:15 [INFO] <nawf> they start on the 7-8 blocks of the main right?
2011-01-12 18:54:21 [INFO] <nawf> like there right?
2011-01-12 18:54:22 [INFO] <efess> that's what I was going to check
2011-01-12 18:54:32 [INFO] <efess> i'll go at the end and look
2011-01-12 18:54:53 [INFO] <nawf> yeah, its either that or the 1-2 of the next
2011-01-12 18:54:58 [INFO] <nawf> I think
2011-01-12 18:54:59 [INFO] <nawf> brb
2011-01-12 18:55:12 [INFO] <efess> so each spawning platform
2011-01-12 18:55:17 [INFO] <efess> is 5 blocks wide
2011-01-12 18:55:28 [INFO] <efess> than there's the block wall from the previous channel
2011-01-12 18:56:58 [INFO] <nawf> ok
2011-01-12 18:57:03 [INFO] <efess> off by one
2011-01-12 18:57:05 [INFO] <nawf> shit
2011-01-12 18:57:53 [INFO] <nawf> I don't have my test bucket
2011-01-12 19:00:06 [INFO] <nawf> ok so here is the outer wall?
2011-01-12 19:00:10 [INFO] <efess> sure
2011-01-12 19:00:32 [INFO] <nawf> I'll give it two spaces on the end
2011-01-12 19:00:55 [INFO] <AngryRhetoric> ooh the train killed me
2011-01-12 19:01:02 [INFO] <efess> how?
2011-01-12 19:01:25 [INFO] <nawf> did you get off in a two high area?
2011-01-12 19:01:27 [INFO] <nawf> suffocated?
2011-01-12 19:02:21 [INFO] <nawf> lol, aggroing the mobs rocks
2011-01-12 19:02:42 [INFO] <efess> rofl
2011-01-12 19:02:42 [INFO] <efess> rofl
2011-01-12 19:02:46 [INFO] <efess> did you see that
2011-01-12 19:02:50 [INFO] <nawf> yeah
2011-01-12 19:03:01 [INFO] <nawf> did water protect the cobble?
2011-01-12 19:03:02 [INFO] <efess> it didn't fuck up anything
2011-01-12 19:03:03 [INFO] <efess> yea
2011-01-12 19:03:04 [INFO] <efess> lol
2011-01-12 19:03:20 [INFO] <efess> i was like shit shit shit
2011-01-12 19:03:26 [INFO] <efess> than went to fix it, and it was fine
2011-01-12 19:03:34 [INFO] <nawf> yeah, I got ready to jump in too
2011-01-12 19:03:47 [INFO] <nawf> CONTAINMENT BREACH, CONTAINMENT BREACH
2011-01-12 19:04:38 [INFO] <nawf> bye bye
2011-01-12 19:08:51 [INFO] <nawf> hrm
2011-01-12 19:08:58 [INFO] <nawf> so here we'll only have a wall 1 high?
2011-01-12 19:09:15 [INFO] <efess> what do you meen?
2011-01-12 19:09:20 [INFO] <efess> glass wall?
2011-01-12 19:09:29 [INFO] <nawf> like here, we don't have a 2 high wall
2011-01-12 19:09:40 [INFO] <nawf> ot we can open up some of the wood
2011-01-12 19:09:42 [INFO] <nawf> or
2011-01-12 19:09:49 [INFO] <efess> I think this is supposed to be down one block, and yea we need to open up the wood
2011-01-12 19:10:05 [INFO] <efess> fkr
2011-01-12 19:10:06 [INFO] <nawf> lol
2011-01-12 19:10:12 [INFO] <efess> no its right
2011-01-12 19:11:48 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-12 19:11:52 [INFO] AngryRhetoric [/24.147.183.4:50390] logged in with entity id 2516120
2011-01-12 19:14:24 [INFO] <efess> creeper in the walkway
2011-01-12 19:14:25 [INFO] <efess> lol
2011-01-12 19:17:04 [INFO] <nawf> aw shit
2011-01-12 19:17:08 [INFO] <efess> haha
2011-01-12 19:17:14 [INFO] <nawf> did it wrong?
2011-01-12 19:17:20 [INFO] <efess> one too high
2011-01-12 19:21:21 [INFO] <AngryRhetoric> the server's doin funky things, there's a whole gap in the map lol
2011-01-12 19:21:29 [INFO] <nawf> yeah, chunk error
2011-01-12 19:21:38 [INFO] <AngryRhetoric> mm chunk errors
2011-01-12 19:21:42 [INFO] <AngryRhetoric> chocolate chunk errors
2011-01-12 19:21:45 [INFO] <efess> look for diamonds :)
2011-01-12 19:21:46 [INFO] <nawf> sometimes you can put a torch by the error and it fixes it
2011-01-12 19:21:55 [INFO] <AngryRhetoric> i see gold
2011-01-12 19:22:10 [INFO] <AngryRhetoric> i lost the torch into the chunk error
2011-01-12 19:22:20 [INFO] <efess> I have to reconnect when that happens
2011-01-12 19:22:32 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-12 19:23:05 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:50792]: Took too long to log in
2011-01-12 19:23:18 [INFO] AngryRhetoric [/24.147.183.4:50822] logged in with entity id 2525774
2011-01-12 19:25:26 [INFO] <nawf> I have to get out from this computer, my neck is killing me
2011-01-12 19:25:44 [INFO] <efess> laptop?
2011-01-12 19:25:57 [INFO] <nawf> naw, desktop, just a lot of hours
2011-01-12 19:26:01 [INFO] <efess> ya
2011-01-12 19:26:06 [INFO] <efess> gotta take breaks
2011-01-12 19:26:13 [INFO] <efess> do you still run?
2011-01-12 19:26:16 [INFO] <nawf> I may be on a new project soon too, lol, 5 projects in 4 months
2011-01-12 19:26:28 [INFO] <efess> nice
2011-01-12 19:26:29 [INFO] <nawf> once or twice a week, its shitty running inthe cold
2011-01-12 19:26:32 [INFO] <efess> must be doing something right
2011-01-12 19:26:44 [INFO] <nawf> yeah, that demo at CES did real well too
2011-01-12 19:26:54 [INFO] <efess> cool
2011-01-12 19:26:56 [INFO] <nawf> in fact I was talking to the boss, if all the potential sales comes through
2011-01-12 19:26:58 [INFO] <nawf> we are fucked
2011-01-12 19:27:03 [INFO] <efess> hahah
2011-01-12 19:27:04 [INFO] <nawf> because we don't have enough people
2011-01-12 19:27:06 [INFO] <efess> hire more people
2011-01-12 19:27:26 [INFO] <nawf> ok, brb
2011-01-12 19:27:30 [INFO] <efess> kw
2011-01-12 19:27:33 [INFO] <AngryRhetoric> need any dba's?? haha jk
2011-01-12 19:27:54 [INFO] <nawf> heh, not piss poor staty ones that for sure
2011-01-12 19:27:56 [INFO] <nawf> ;)
2011-01-12 19:27:59 [INFO] <nawf> we need moar joel
2011-01-12 19:28:02 [INFO] <nawf> ;)
2011-01-12 19:28:04 [INFO] <AngryRhetoric> LOL
2011-01-12 19:28:10 [INFO] <AngryRhetoric> yeah i'm not groady enough for you
2011-01-12 19:28:13 [INFO] <AngryRhetoric> i understand
2011-01-12 19:28:15 [INFO] <efess> lol
2011-01-12 19:28:17 [INFO] <nawf> seriously kevin, you should see some of these schemas...
2011-01-12 19:28:28 [INFO] <nawf> we do need a real dba, I'm a halt dba and these things look horrible
2011-01-12 19:28:29 [INFO] <AngryRhetoric> haha i assume you use that term loosely ;)
2011-01-12 19:28:35 [INFO] <nawf> coppola would die
2011-01-12 19:28:39 [INFO] <AngryRhetoric> hahaha
2011-01-12 19:28:45 [INFO] <nawf> pour gas on himself and light it
2011-01-12 19:28:53 [INFO] <nawf> anyway, I'll ttyl
2011-01-12 19:28:57 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 19:51:52 [INFO] <AngryRhetoric> nice is this for more monsters?
2011-01-12 19:51:55 [INFO] <efess> yea
2011-01-12 19:52:01 [INFO] <efess> its the 2nd half
2011-01-12 19:52:41 [INFO] <efess> :D
2011-01-12 19:53:02 [INFO] <AngryRhetoric> pretty slick
2011-01-12 19:53:18 [INFO] <efess> brb
2011-01-12 19:53:20 [INFO] efess lost connection: disconnect.quitting
2011-01-12 19:57:35 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-12 19:57:39 [INFO] AngryRhetoric [/24.147.183.4:52111] logged in with entity id 2540032
2011-01-12 20:01:46 [INFO] efess [/192.168.0.198:63565] logged in with entity id 2541540
2011-01-12 20:03:00 [INFO] <efess> oh there's an infinite pool at the first level
2011-01-12 20:03:11 [INFO] <AngryRhetoric> i was using that before :)
2011-01-12 20:03:15 [INFO] <efess> ah
2011-01-12 20:03:19 [INFO] <AngryRhetoric> made more buckets
2011-01-12 20:11:07 [INFO] <AngryRhetoric> i just realized you guys can't store all the stuff you're getting already from the mob spawner haha
2011-01-12 20:11:13 [INFO] <efess> lol
2011-01-12 20:11:18 [INFO] <efess> why we need to throw shit away
2011-01-12 20:13:04 [INFO] nawf [/76.23.232.27:55249] logged in with entity id 2548083
2011-01-12 20:14:10 [INFO] <nawf> I'm going to change my usename to slightlyannoyedrhetoric
2011-01-12 20:14:50 [INFO] <efess> and mine to reasonablerhetoric
2011-01-12 20:15:24 [INFO] <nawf> is he afk?
2011-01-12 20:15:27 [INFO] <efess> I geuss
2011-01-12 20:15:28 [INFO] <efess> hehe
2011-01-12 20:15:31 [INFO] <nawf> ENCASE HIM IN OBSIDIAN
2011-01-12 20:15:36 [INFO] <efess> lol
2011-01-12 20:15:51 [INFO] <nawf> shit
2011-01-12 20:16:10 [INFO] <efess> good on health?
2011-01-12 20:16:16 [INFO] <nawf> naw, fell, shift is fallable
2011-01-12 20:16:25 [INFO] <efess> got a pork here if you need it
2011-01-12 20:16:40 [INFO] <nawf> I'll go get the wheat and the rest of the cobble
2011-01-12 20:16:46 [INFO] <AngryRhetoric> i got some
2011-01-12 20:16:46 [INFO] <efess> i got the rest of the cobble
2011-01-12 20:17:00 [INFO] <efess> well from the base anyway
2011-01-12 20:17:04 [INFO] <nawf> sweet
2011-01-12 20:17:22 [INFO] <nawf> this stairway is awesome
2011-01-12 20:17:39 [INFO] <efess> random stairway
2011-01-12 20:17:49 [INFO] <AngryRhetoric> which stairway
2011-01-12 20:17:54 [INFO] <nawf> the one you just took
2011-01-12 20:18:04 [INFO] <nawf> got wheats?
2011-01-12 20:18:04 [INFO] <AngryRhetoric> oh heh thx
2011-01-12 20:18:10 [INFO] <AngryRhetoric> need cobblestone?
2011-01-12 20:18:15 [INFO] <nawf> well probably
2011-01-12 20:18:20 [INFO] <nawf> I just need fud
2011-01-12 20:18:22 [INFO] <nawf> I keep falling
2011-01-12 20:18:26 [INFO] <AngryRhetoric> i have ham ithink
2011-01-12 20:18:40 [INFO] <nawf> woo thanks
2011-01-12 20:18:43 [INFO] <efess> np
2011-01-12 20:19:28 [INFO] <nawf> did joe give you the blueprint?
2011-01-12 20:19:44 [INFO] <AngryRhetoric> lol no i'm just basing it off the rest of it
2011-01-12 20:19:51 [INFO] <efess> yea its pretty simple
2011-01-12 20:19:53 [INFO] <nawf> yeah, I'm just kidding
2011-01-12 20:20:01 [INFO] <AngryRhetoric> mimicing the other side essentially, pretty cool
2011-01-12 20:20:20 [INFO] <nawf> we'll have double infinite arrows
2011-01-12 20:21:55 [INFO] <nawf> is the end another channel?
2011-01-12 20:21:58 [INFO] <nawf> or just the end?
2011-01-12 20:22:01 [INFO] <efess> jsut the end
2011-01-12 20:25:20 [INFO] <AngryRhetoric> does that need to be filled in underneath that john?
2011-01-12 20:25:30 [INFO] <nawf> yeah, should be two out then wall
2011-01-12 20:25:36 [INFO] <nawf> s
2011-01-12 20:26:02 [INFO] <nawf> shit
2011-01-12 20:26:15 [INFO] <AngryRhetoric> its ok its not wood like the other wall?
2011-01-12 20:26:23 [INFO] <nawf> hrm, do we want to do wood again?
2011-01-12 20:26:35 [INFO] <AngryRhetoric> have to harvest it i bet
2011-01-12 20:26:35 [INFO] <nawf> oh no, we built that so we could see what we did later
2011-01-12 20:26:36 [INFO] <efess> depends if we'll want to expand it
2011-01-12 20:26:50 [INFO] <efess> I say ef it
2011-01-12 20:26:53 [INFO] <AngryRhetoric> hah
2011-01-12 20:26:54 [INFO] <efess> do cobblestone
2011-01-12 20:27:02 [INFO] <AngryRhetoric> i have a ton of cobble stone
2011-01-12 20:27:02 [INFO] <efess> if we want to expand it we don't have to take down the whole wall
2011-01-12 20:27:11 [INFO] <nawf> well it will still be ok, because we can build on of it
2011-01-12 20:27:27 [INFO] <AngryRhetoric> well what about the old wall, you didn't need to take that down
2011-01-12 20:27:37 [INFO] <efess> ya
2011-01-12 20:27:47 [INFO] <nawf> yeah, well for mirroring we didn't, be if we go out to 6 channels wide, 5 long we will
2011-01-12 20:28:07 [INFO] <nawf> or we could go higher too
2011-01-12 20:28:40 [INFO] <AngryRhetoric> ah 5th channel right near wall
2011-01-12 20:29:31 [INFO] <nawf> right joe?
2011-01-12 20:29:37 [INFO] <efess> sure w/e
2011-01-12 20:29:41 [INFO] <efess> :P
2011-01-12 20:29:53 [INFO] <nawf> true, eventually we get to the point we just can't use all the drops
2011-01-12 20:30:14 [INFO] <AngryRhetoric> yeah and i'm guessing twice the existing capacity for 3 people is about it haha
2011-01-12 20:30:25 [INFO] <nawf> shit
2011-01-12 20:30:29 [INFO] <nawf> its higher
2011-01-12 20:30:36 [INFO] <AngryRhetoric> hah one down
2011-01-12 20:30:43 [INFO] <nawf> wait wtf
2011-01-12 20:30:49 [INFO] <AngryRhetoric> if i fill in over here it won't be hard to trim
2011-01-12 20:31:03 [INFO] <nawf> 3 block floor, seems right
2011-01-12 20:31:30 [INFO] <efess> remember, roof will be just half steps this time
2011-01-12 20:31:30 [INFO] <efess> :)
2011-01-12 20:31:45 [INFO] <nawf> oh yeah
2011-01-12 20:31:47 [INFO] <nawf> fml
2011-01-12 20:31:54 [INFO] <AngryRhetoric> lol
2011-01-12 20:31:54 [INFO] <efess> well what you have is fine
2011-01-12 20:32:08 [INFO] <nawf> I'll start half stepping
2011-01-12 20:32:39 [INFO] <nawf> lol, we still have a case of cobble
2011-01-12 20:36:49 [INFO] <AngryRhetoric> i broke into some of that case i think
2011-01-12 20:37:16 [INFO] <nawf> oh no, we have a little less than a full case
2011-01-12 20:37:21 [INFO] <AngryRhetoric> hahaha
2011-01-12 20:37:43 [INFO] <nawf> well the roofs will match at least
2011-01-12 20:37:59 [INFO] <AngryRhetoric> thats good
2011-01-12 20:38:08 [INFO] <nawf> I have tons of halfs if you guys need some for the roof
2011-01-12 20:38:21 [INFO] <AngryRhetoric> we need to add a third stream over here right?
2011-01-12 20:38:46 [INFO] <efess> over here?
2011-01-12 20:38:53 [INFO] <efess> well we didn't in the other half
2011-01-12 20:38:55 [INFO] <AngryRhetoric> yeah a 5th stream by the way? or no
2011-01-12 20:38:57 [INFO] <AngryRhetoric> ah ok
2011-01-12 20:39:01 [INFO] <AngryRhetoric> that's easier
2011-01-12 20:39:06 [INFO] <efess> but if you think we should by all means :)
2011-01-12 20:39:20 [INFO] <efess> John i'm moving this wall over one block to match up with the other half
2011-01-12 20:39:31 [INFO] <nawf> NO
2011-01-12 20:39:33 [INFO] <nawf> NEVER
2011-01-12 20:39:35 [INFO] <AngryRhetoric> haha
2011-01-12 20:39:37 [INFO] <efess> get over it
2011-01-12 20:39:41 [INFO] <nawf> nooooooooo
2011-01-12 20:39:47 [INFO] <AngryRhetoric> i'll go find some tnt
2011-01-12 20:39:53 [INFO] <efess> :D
2011-01-12 20:44:24 [INFO] <AngryRhetoric> i'm going to the cobblestone vault
2011-01-12 20:44:31 [INFO] <AngryRhetoric> ifa nyone needs anything
2011-01-12 20:44:47 [INFO] <nawf> nope
2011-01-12 20:45:05 [INFO] <nawf> actually I require one chicken
2011-01-12 20:45:08 [INFO] <efess> :D
2011-01-12 20:45:10 [INFO] <AngryRhetoric> hah
2011-01-12 20:45:14 [INFO] <efess> I need cobble
2011-01-12 20:45:22 [INFO] <efess> there some lef tin the chest by the stairs?
2011-01-12 20:45:27 [INFO] <nawf> yeah, tons
2011-01-12 20:45:39 [INFO] <AngryRhetoric> i've been going to the one near the railroad
2011-01-12 20:46:00 [INFO] <nawf> by the botton of the death chute?
2011-01-12 20:46:08 [INFO] <AngryRhetoric> yes
2011-01-12 20:46:18 [INFO] <efess> the bottom of this thing looks badass
2011-01-12 20:46:37 [INFO] <nawf> we should torch all the edges
2011-01-12 20:47:34 [INFO] <AngryRhetoric> who needs cobble
2011-01-12 20:47:38 [INFO] <efess> im set now
2011-01-12 20:47:50 [INFO] <nawf> me too, I have a full inventory of half blocks ;)
2011-01-12 20:48:38 [INFO] <nawf> skele in the main river
2011-01-12 20:48:46 [INFO] <AngryRhetoric> yeah he hit me
2011-01-12 20:50:29 [INFO] <efess> well this is a walkway
2011-01-12 20:50:38 [INFO] <efess> hey
2011-01-12 20:50:46 [INFO] <efess> lol
2011-01-12 20:50:50 [INFO] <nawf> lol, your walkway is wrong
2011-01-12 20:51:01 [INFO] <efess> what
2011-01-12 20:51:05 [INFO] <nawf> I'm just joking
2011-01-12 20:51:08 [INFO] <efess> hah
2011-01-12 20:51:11 [INFO] <nawf> angry, you acceidently the walkway
2011-01-12 20:51:18 [INFO] <AngryRhetoric> oh sorry
2011-01-12 20:51:21 [INFO] <efess> np :P
2011-01-12 20:51:26 [INFO] <AngryRhetoric> one too many
2011-01-12 20:51:29 [INFO] <AngryRhetoric> cobblestones that is
2011-01-12 20:51:33 [INFO] <efess> check in the other one
2011-01-12 20:51:40 [INFO] <nawf> IM JUST BUILDING CRAZY
2011-01-12 20:51:43 [INFO] <efess> :P
2011-01-12 20:52:09 [INFO] <AngryRhetoric> ohh i see what you're doing haha walkway
2011-01-12 20:52:15 [INFO] <efess> :)
2011-01-12 20:52:28 [INFO] <nawf> yeah, so if shit gets broke or something
2011-01-12 20:52:41 [INFO] <efess> or to observe the murders
2011-01-12 20:52:45 [INFO] <nawf> yes
2011-01-12 20:53:00 [INFO] <nawf> zombie, I'm out of arrows
2011-01-12 20:53:10 [INFO] <nawf> shit, there are everywhere
2011-01-12 20:53:21 [INFO] <AngryRhetoric> i can add torches
2011-01-12 20:53:26 [INFO] <nawf> yeah kevn, once the roof starts coming together this shit gets dangerous
2011-01-12 20:53:41 [INFO] <AngryRhetoric> yeah i bet
2011-01-12 20:55:12 [INFO] <AngryRhetoric> how're you making half stone up here, or you made it already
2011-01-12 20:55:34 [INFO] <nawf> have it already, there is a craft bench by the walkway over to the ""mainland
2011-01-12 20:55:39 [INFO] <nawf> to the random dali stairway
2011-01-12 20:55:57 [INFO] <AngryRhetoric> i'll just make a new one
2011-01-12 20:58:04 [INFO] <AngryRhetoric> you want me to de-torch down there?
2011-01-12 20:58:20 [INFO] <nawf> yeah, clean up the infinite water pool if your down there
2011-01-12 20:58:30 [INFO] <efess> also the other end
2011-01-12 20:58:35 [INFO] <efess> needs a walkway
2011-01-12 20:58:41 [INFO] <efess> and need a row of glass on top of it
2011-01-12 20:58:55 [INFO] <nawf> sand is in the vault I think
2011-01-12 20:59:00 [INFO] <AngryRhetoric> ok
2011-01-12 20:59:04 [INFO] <AngryRhetoric> here's half stone then
2011-01-12 20:59:07 [INFO] <nawf> shit we shouldn't finish roofing over there then
2011-01-12 20:59:19 [INFO] <efess> no there's enough room
2011-01-12 20:59:32 [INFO] <nawf> no, it its pitch dark he'll die
2011-01-12 20:59:44 [INFO] <nawf> mobs everywhere
2011-01-12 20:59:44 [INFO] <efess> its torched
2011-01-12 20:59:49 [INFO] <nawf> oh
2011-01-12 20:59:58 [INFO] <nawf> fine, send kevin to his doom
2011-01-12 21:00:11 [INFO] <efess> the channels will save him!
2011-01-12 21:00:34 [INFO] <efess> omg jess just registered us on bed bath and beyond
2011-01-12 21:00:47 [INFO] <nawf> I am not buying you any shit you register for
2011-01-12 21:00:51 [INFO] <efess> good
2011-01-12 21:01:10 [INFO] <efess> she's acting like she has a shopping spree
2011-01-12 21:01:17 [INFO] <efess> omg platters
2011-01-12 21:01:18 [INFO] <efess> wooo
2011-01-12 21:01:19 [INFO] <nawf> YES
2011-01-12 21:01:34 [INFO] <nawf> to tell you the truth, I need platters
2011-01-12 21:01:34 [INFO] <AngryRhetoric> haha
2011-01-12 21:01:51 [INFO] <efess> you can have ours
2011-01-12 21:02:05 [INFO] <nawf> is there sand at the main base?
2011-01-12 21:02:08 [INFO] <AngryRhetoric> walkway and glass above the walkways on the sides?
2011-01-12 21:02:10 [INFO] <AngryRhetoric> yes
2011-01-12 21:02:19 [INFO] <AngryRhetoric> i see
2011-01-12 21:02:58 [INFO] <nawf> kev do you have enough glass?
2011-01-12 21:03:03 [INFO] <AngryRhetoric> i've got none
2011-01-12 21:03:05 [INFO] <nawf> there is some cooking down here too
2011-01-12 21:03:09 [INFO] <nawf> well there is 41
2011-01-12 21:03:28 [INFO] <nawf> I'll go get some from the vault
2011-01-12 21:03:42 [INFO] <AngryRhetoric> ok
2011-01-12 21:06:11 [INFO] <AngryRhetoric> how about the stair case going up and in? that should have glass around it i guess
2011-01-12 21:06:25 [INFO] <efess> the haggard one?
2011-01-12 21:06:34 [INFO] <AngryRhetoric> hah eh yeah near the stairway down to base
2011-01-12 21:06:41 [INFO] <nawf> well we have the ladders
2011-01-12 21:06:51 [INFO] <efess> yea, the cobblestone staircase should be destroyed
2011-01-12 21:07:57 [INFO] <nawf> oooo, real stairs
2011-01-12 21:08:01 [INFO] <AngryRhetoric> you like?
2011-01-12 21:08:04 [INFO] <nawf> yeah
2011-01-12 21:08:24 [INFO] <nawf> run for your lief
2011-01-12 21:08:41 [INFO] <efess> i;ll agro them
2011-01-12 21:08:42 [INFO] <efess> lol
2011-01-12 21:10:16 [INFO] <AngryRhetoric> gettin rough in there
2011-01-12 21:10:59 [INFO] <nawf> lol
2011-01-12 21:11:08 [INFO] <nawf> not enough glass to finish walkway
2011-01-12 21:11:09 [INFO] <nawf> damn
2011-01-12 21:11:24 [INFO] <AngryRhetoric> come sunrise we can get more sand
2011-01-12 21:11:28 [INFO] <efess> man we pounded out this 2nd half
2011-01-12 21:11:40 [INFO] <AngryRhetoric> yeah that went fast
2011-01-12 21:11:48 [INFO] <efess> took us like 3 days for the first
2011-01-12 21:11:59 [INFO] <efess> but we didn't have much cobble
2011-01-12 21:12:37 [INFO] <AngryRhetoric> nice sign here wuzzah island
2011-01-12 21:13:01 [INFO] <nawf> aight, I have 4 furnaces with glass going
2011-01-12 21:13:11 [INFO] <nawf> we'll just have to pound some light holes when I go in there
2011-01-12 21:13:12 [INFO] <AngryRhetoric> oh so we had plenty o' sand
2011-01-12 21:13:19 [INFO] <nawf> yeah, I got tons for the tnt
2011-01-12 21:13:36 [INFO] <nawf> there is an island further past the mob ginder that is also a wuzzah island
2011-01-12 21:13:44 [INFO] <efess> lol
2011-01-12 21:14:16 [INFO] <nawf> brb
2011-01-12 21:17:36 [INFO] <nawf> I was probably going to destroy all that dirt
2011-01-12 21:17:45 [INFO] <AngryRhetoric> heh i'm just making it smooth staasr
2011-01-12 21:17:48 [INFO] <AngryRhetoric> *stairs
2011-01-12 21:17:49 [INFO] <nawf> so smooth
2011-01-12 21:18:00 [INFO] <AngryRhetoric> lectric smooth
2011-01-12 21:18:11 [INFO] <nawf> joe did you leave light holes
2011-01-12 21:18:16 [INFO] <efess> nope!
2011-01-12 21:18:18 [INFO] <AngryRhetoric> that sounds personal
2011-01-12 21:20:41 [INFO] <nawf> ok, glass done
2011-01-12 21:20:48 [INFO] <nawf> there was a zombie under the spawner
2011-01-12 21:23:34 [INFO] <AngryRhetoric> you could land planes up here
2011-01-12 21:23:41 [INFO] <nawf> thats in the next update
2011-01-12 21:23:46 [INFO] <AngryRhetoric> hah
2011-01-12 21:24:13 [INFO] <AngryRhetoric> we should build something up here
2011-01-12 21:24:19 [INFO] <nawf> can't
2011-01-12 21:24:23 [INFO] <AngryRhetoric> why
2011-01-12 21:24:24 [INFO] <AngryRhetoric> oh
2011-01-12 21:24:28 [INFO] <efess> the whole reason for half steps is so nothing spawns
2011-01-12 21:24:29 [INFO] <AngryRhetoric> radius
2011-01-12 21:24:37 [INFO] <nawf> the reason the spawner is out here is so the mobs don't have anything to spawn in
2011-01-12 21:24:50 [INFO] <nawf> they won't spawn on air, halfs, water or ice
2011-01-12 21:24:54 [INFO] <AngryRhetoric> ah ok
2011-01-12 21:24:55 [INFO] <efess> yea, you should read the sciense of mob spawning
2011-01-12 21:24:59 [INFO] <AngryRhetoric> lol
2011-01-12 21:25:00 [INFO] <efess> science*
2011-01-12 21:25:01 [INFO] <nawf> google mob spawning science if you want to see it
2011-01-12 21:25:04 [INFO] <efess> :D
2011-01-12 21:25:09 [INFO] <efess> its a cool read
2011-01-12 21:25:17 [INFO] <AngryRhetoric> is it on the minecraft wiki?
2011-01-12 21:25:20 [INFO] <nawf> we built this with science
2011-01-12 21:25:24 [INFO] <AngryRhetoric> YESSSs
2011-01-12 21:25:27 [INFO] <nawf> naw, the official forums
2011-01-12 21:25:28 [INFO] <efess> for science!
2011-01-12 21:25:37 [INFO] <AngryRhetoric> mob spawning for science
2011-01-12 21:25:45 [INFO] <AngryRhetoric> that would make a good t-shirt
2011-01-12 21:26:44 [INFO] <nawf> anybody got any stickssssss?
2011-01-12 21:26:49 [INFO] <AngryRhetoric> sounds messy up there
2011-01-12 21:26:55 [INFO] <AngryRhetoric> i have some
2011-01-12 21:26:56 [INFO] <efess> i got wood
2011-01-12 21:26:57 [INFO] <efess> ;)
2011-01-12 21:27:07 [INFO] <nawf> I take off my robe and wizard hat
2011-01-12 21:28:30 [INFO] <efess> lol
2011-01-12 21:28:34 [INFO] <AngryRhetoric> uh
2011-01-12 21:28:39 [INFO] <nawf> wtf
2011-01-12 21:28:44 [INFO] <nawf> let me put up ladderssss
2011-01-12 21:30:08 [INFO] <efess> ...d ark in here :o
2011-01-12 21:30:19 [INFO] <efess> lots of noises...
2011-01-12 21:31:57 [INFO] <nawf> you still in there joe?
2011-01-12 21:31:59 [INFO] <efess> ya
2011-01-12 21:32:04 [INFO] <nawf> your nuts
2011-01-12 21:32:11 [INFO] <efess> breaking down the wall
2011-01-12 21:34:30 [INFO] <AngryRhetoric> don't you have to seal up the hole?
2011-01-12 21:34:37 [INFO] <nawf> naw, this is a good path out
2011-01-12 21:34:47 [INFO] <AngryRhetoric> i mean in the mob spawner
2011-01-12 21:35:01 [INFO] <nawf> oh shit
2011-01-12 21:35:24 [INFO] <efess> lol
2011-01-12 21:35:29 [INFO] <efess> i'm right above the pit
2011-01-12 21:35:32 [INFO] <nawf> good catch, our mob spawner would have been leaking
2011-01-12 21:35:33 [INFO] <efess> watching them fall
2011-01-12 21:36:10 [INFO] <efess> fuck
2011-01-12 21:36:12 [INFO] <efess> there's a lot of mobs
2011-01-12 21:36:13 [INFO] <efess> lol
2011-01-12 21:36:18 [INFO] <efess> holy shit
2011-01-12 21:36:48 [INFO] <nawf> lol, wood blocks are falling
2011-01-12 21:36:52 [INFO] <efess> lol
2011-01-12 21:38:15 [INFO] <AngryRhetoric> looks like fun in there
2011-01-12 21:38:28 [INFO] <efess> a lot cooler w/o the wall
2011-01-12 21:38:28 [INFO] <efess> :D
2011-01-12 21:38:30 [INFO] <AngryRhetoric> is there too much light coming from the ladder over there?
2011-01-12 21:38:39 [INFO] <efess> not too much but it should be sealed
2011-01-12 21:38:44 [INFO] <AngryRhetoric> you could put a folding wall in place
2011-01-12 21:38:45 [INFO] <nawf> prob, joe has to come out eventually
2011-01-12 21:38:48 [INFO] <AngryRhetoric> no light but still access
2011-01-12 21:38:56 [INFO] <nawf> naw, doors transfer light don't they?
2011-01-12 21:39:13 [INFO] <AngryRhetoric> i don't mean a door
2011-01-12 21:39:18 [INFO] <AngryRhetoric> an overlapping wall
2011-01-12 21:39:34 [INFO] <nawf> ohhhhhhh, hmmm, will the mobs leak? escape their death?
2011-01-12 21:39:37 [INFO] <efess> we can have a platform
2011-01-12 21:39:40 [INFO] <AngryRhetoric> i'll show you
2011-01-12 21:39:54 [INFO] <nawf> that would be cool, I didn't know you could do that
2011-01-12 21:41:23 [INFO] <nawf> holy shit
2011-01-12 21:41:25 [INFO] <nawf> FUCK
2011-01-12 21:41:28 [INFO] <nawf> its awesome down here
2011-01-12 21:41:36 [INFO] <AngryRhetoric> skeleton spawned or got into the walkway
2011-01-12 21:41:43 [INFO] <efess> yea that happens
2011-01-12 21:43:32 [INFO] <efess> lol my minimap is just.. gray
2011-01-12 21:43:42 [INFO] <efess> from the spawner
2011-01-12 21:46:10 [INFO] <nawf> yes
2011-01-12 21:46:29 [INFO] <AngryRhetoric> how's the body count
2011-01-12 21:46:37 [INFO] <nawf> hiroshima like
2011-01-12 21:46:39 [INFO] <efess> dropping like flies
2011-01-12 21:46:43 [INFO] <AngryRhetoric> haha
2011-01-12 21:46:58 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 21:47:01 [INFO] nawf [/76.23.232.27:55012] logged in with entity id 2591152
2011-01-12 21:47:26 [INFO] <nawf> STRING
2011-01-12 21:47:37 [INFO] <AngryRhetoric> YEAHHHHH
2011-01-12 21:48:02 [INFO] <efess> wtf feathers
2011-01-12 21:48:24 [INFO] <nawf> lol
2011-01-12 21:48:43 [INFO] <AngryRhetoric> nice
2011-01-12 21:49:06 [INFO] <AngryRhetoric> this seems cyclical
2011-01-12 21:49:18 [INFO] <efess> lol.
2011-01-12 21:49:27 [INFO] <AngryRhetoric> hey look at all the feathers we're getting
2011-01-12 21:49:29 [INFO] <AngryRhetoric> again
2011-01-12 21:50:01 [INFO] <AngryRhetoric> alright i'm out for tonight
2011-01-12 21:50:04 [INFO] <AngryRhetoric> glad i could play though
2011-01-12 21:50:12 [INFO] <efess> cool thx for hte help
2011-01-12 21:50:16 [INFO] <nawf> yeah, that was awesome
2011-01-12 21:50:22 [INFO] <AngryRhetoric> np yeah we got that cranked out in no time
2011-01-12 21:50:25 [INFO] <efess> :D
2011-01-12 21:50:28 [INFO] <AngryRhetoric> later
2011-01-12 21:50:31 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-12 21:50:31 [INFO] <efess> night
2011-01-12 21:50:39 [INFO] <nawf> there, now we have a cactus garbage can
2011-01-12 21:50:42 [INFO] <nawf> much safer
2011-01-12 21:50:54 [INFO] <efess> perfect
2011-01-12 21:51:06 [INFO] <efess> what if you put a half blcok
2011-01-12 21:51:07 [INFO] <nawf> we should still move this place so we keep non-mob stuff out of here
2011-01-12 21:51:08 [INFO] <efess> in front
2011-01-12 21:52:12 [INFO] <nawf> like maybe we can divert the flow
2011-01-12 21:52:39 [INFO] <efess> tjere
2011-01-12 21:52:49 [INFO] <nawf> oic
2011-01-12 21:52:58 [INFO] <efess> can't accidentally fall and fuck up
2011-01-12 21:53:21 [INFO] <efess> mm smooth
2011-01-12 21:53:39 [INFO] <nawf> I have an idea
2011-01-12 21:53:58 [INFO] <nawf> well, we just need to move the drops so they aren't in the way
2011-01-12 21:54:04 [INFO] <efess> YES
2011-01-12 21:54:13 [INFO] <nawf> maybe behind the cactus?
2011-01-12 21:54:34 [INFO] <efess> should we expand this and have the minecarts land here?
2011-01-12 21:54:52 [INFO] <nawf> hmm, or reverse the water flow
2011-01-12 21:55:10 [INFO] <nawf> and have the minecarts go underthe stairs?
2011-01-12 21:55:13 [INFO] <nawf> maybe remove the stairs?
2011-01-12 21:55:13 [INFO] <efess> yea
2011-01-12 21:55:25 [INFO] <efess> underground is best
2011-01-12 21:55:25 [INFO] <nawf> remove or under?
2011-01-12 21:55:29 [INFO] <nawf> ok
2011-01-12 21:55:32 [INFO] <efess> to keep it vautish
2011-01-12 21:55:36 [INFO] <efess> vaultish*
2011-01-12 21:55:56 [INFO] <nawf> ROFL DIAMONDS
2011-01-12 21:55:58 [INFO] <nawf> good idea
2011-01-12 21:56:01 [INFO] <efess> really?
2011-01-12 21:56:11 [INFO] <efess> LOL
2011-01-12 21:56:20 [INFO] <efess> nice
2011-01-12 21:56:43 [INFO] <nawf> I mined the shit out of the area for the garden
2011-01-12 21:56:45 [INFO] <nawf> nothing
2011-01-12 21:56:49 [INFO] <efess> lol
2011-01-12 21:56:53 [INFO] <nawf> to to stairs, diamonds first thing
2011-01-12 21:56:56 [INFO] <efess> yup
2011-01-12 21:57:02 [INFO] <efess> that's how it works
2011-01-12 21:57:18 [INFO] <nawf> oh, you know what, this will look cool with the rounded roof
2011-01-12 21:57:45 [INFO] <nawf> is this your diamond pick?
2011-01-12 21:58:01 [INFO] <efess> nah
2011-01-12 22:01:04 [INFO] <nawf> no invisible mobs in here
2011-01-12 22:01:08 [INFO] <efess> nope
2011-01-12 22:05:00 [INFO] <nawf> shit, I broke something
2011-01-12 22:05:05 [INFO] <efess> ?
2011-01-12 22:05:09 [INFO] <efess> oh fuck it
2011-01-12 22:05:14 [INFO] <nawf> hit that block and redstone came down
2011-01-12 22:05:18 [INFO] <efess> that's fine
2011-01-12 22:05:25 [INFO] <efess> going to move it anyway
2011-01-12 22:05:28 [INFO] <nawf> oh ok
2011-01-12 22:07:14 [INFO] <nawf> so the collector is back here?
2011-01-12 22:07:24 [INFO] <efess> ya
2011-01-12 22:08:20 [INFO] <efess> funny constantly hearing mobs dying
2011-01-12 22:08:42 [INFO] <nawf> this must be what heaven sounds like
2011-01-12 22:08:54 [INFO] <efess> lol
2011-01-12 22:09:01 [INFO] <nawf> oo
2011-01-12 22:11:53 [INFO] <efess> wtf is a garlic roaster
2011-01-12 22:12:02 [INFO] <nawf> aluminum foil
2011-01-12 22:12:07 [INFO] <efess> skillet
2011-01-12 22:12:08 [INFO] <efess> done
2011-01-12 22:17:45 [WARNING] efess moved wrongly!
2011-01-12 22:22:28 [WARNING] efess moved wrongly!
2011-01-12 22:23:38 [WARNING] efess moved wrongly!
2011-01-12 22:23:48 [INFO] <nawf> does the turn kill it?
2011-01-12 22:23:57 [INFO] <efess> nah booster wasn't working right
2011-01-12 22:23:58 [INFO] <nawf> we can move it over
2011-01-12 22:24:00 [INFO] <nawf> move those chests
2011-01-12 22:24:06 [INFO] <efess> it should be fine
2011-01-12 22:24:09 [INFO] <nawf> keep it straight
2011-01-12 22:24:10 [INFO] <efess> curves don't affect it too much
2011-01-12 22:24:10 [INFO] <nawf> ok
2011-01-12 22:25:19 [WARNING] efess moved wrongly!
2011-01-12 22:26:46 [INFO] <efess> is it going to flow to here?
2011-01-12 22:26:53 [INFO] <nawf> YEAH
2011-01-12 22:26:57 [INFO] <nawf> oops
2011-01-12 22:26:57 [INFO] <efess> WOOOT
2011-01-12 22:27:02 [INFO] <nawf> need it to change?
2011-01-12 22:27:06 [INFO] <efess> nope
2011-01-12 22:27:06 [INFO] <nawf> for the tracks of something
2011-01-12 22:27:09 [INFO] <nawf> or
2011-01-12 22:28:40 [INFO] <nawf> fucking chicken
2011-01-12 22:29:07 [INFO] <nawf> so much death
2011-01-12 22:29:38 [WARNING] efess moved wrongly!
2011-01-12 22:29:51 [INFO] <efess> ya its fine
2011-01-12 22:30:03 [INFO] <efess> lol
2011-01-12 22:30:54 [INFO] <efess> chicken in your minecart
2011-01-12 22:30:55 [INFO] <efess> lol
2011-01-12 22:30:58 [WARNING] efess moved wrongly!
2011-01-12 22:31:04 [INFO] <nawf> I was trying to push him there
2011-01-12 22:31:08 [INFO] <nawf> fucker did it on its own
2011-01-12 22:31:12 [INFO] <efess> lol
2011-01-12 22:31:26 [INFO] <efess> alright dude
2011-01-12 22:31:28 [INFO] <efess> i'm headin to bed
2011-01-12 22:31:36 [INFO] <efess> gg!
2011-01-12 22:31:39 [INFO] <nawf> yeah, I'm feeling accomplished enough to leave too
2011-01-12 22:31:40 [INFO] <nawf> gg
2011-01-12 22:31:44 [INFO] efess lost connection: disconnect.quitting
2011-01-12 22:31:46 [INFO] <nawf> tomorrow we dig
2011-01-13 12:54:12 [INFO] Starting minecraft server version Beta 1.2
2011-01-13 12:54:12 [INFO] Loading properties
2011-01-13 12:54:12 [INFO] Starting Minecraft server on *:25565
2011-01-13 12:54:12 [INFO] Preparing level ""world""
2011-01-13 12:54:12 [INFO] Preparing start region
2011-01-13 12:54:13 [INFO] Preparing spawn area: 32%
2011-01-13 12:54:15 [INFO] Preparing spawn area: 85%
2011-01-13 12:54:15 [INFO] Done! For help, type ""help"" or ""?""
2011-01-13 12:54:18 [INFO] To run the server without a gui, start it like this:
2011-01-13 12:54:18 [INFO]    java -Xmx1024M -Xms1024M -jar minecraft_server.jar nogui
2011-01-13 12:54:18 [INFO] Console commands:
2011-01-13 12:54:18 [INFO]    help  or  ?               shows this message
2011-01-13 12:54:18 [INFO]    kick <player>             removes a player from the server
2011-01-13 12:54:18 [INFO]    ban <player>              bans a player from the server
2011-01-13 12:54:18 [INFO]    pardon <player>           pardons a banned player so that they can connect again
2011-01-13 12:54:18 [INFO]    ban-ip <ip>               bans an IP address from the server
2011-01-13 12:54:18 [INFO]    pardon-ip <ip>            pardons a banned IP address so that they can connect again
2011-01-13 12:54:18 [INFO]    op <player>               turns a player into an op
2011-01-13 12:54:18 [INFO]    deop <player>             removes op status from a player
2011-01-13 12:54:18 [INFO]    tp <player1> <player2>    moves one player to the same location as another player
2011-01-13 12:54:18 [INFO]    give <player> <id> [num]  gives a player a resource
2011-01-13 12:54:18 [INFO]    tell <player> <message>   sends a private message to a player
2011-01-13 12:54:18 [INFO]    stop                      gracefully stops the server
2011-01-13 12:54:18 [INFO]    save-all                  forces a server-wide level save
2011-01-13 12:54:18 [INFO]    save-off                  disables terrain saving (useful for backup scripts)
2011-01-13 12:54:18 [INFO]    save-on                   re-enables terrain saving
2011-01-13 12:54:18 [INFO]    list                      lists all currently connected players
2011-01-13 12:54:18 [INFO]    say <message>             broadcasts a message to all players
2011-01-13 12:54:50 [INFO] nawf [/76.23.232.27:55010] logged in with entity id 21
2011-01-13 12:54:51 [INFO] nawf lost connection: disconnect.endOfStream
2011-01-13 12:54:51 [INFO] nawf lost connection: disconnect.endOfStream
2011-01-13 12:54:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 12:54:56 [INFO] nawf [/76.23.232.27:55010] logged in with entity id 199
2011-01-13 12:54:56 [INFO] nawf lost connection: disconnect.endOfStream
2011-01-13 12:54:56 [INFO] nawf lost connection: disconnect.endOfStream
2011-01-13 12:54:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 12:56:44 [INFO] nawf [/76.23.232.27:55091] logged in with entity id 380
2011-01-13 13:07:56 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 13:10:56 [INFO] nawf [/76.23.232.27:55081] logged in with entity id 10752
2011-01-13 13:38:37 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 13:53:15 [INFO] nawf [/76.23.232.27:55303] logged in with entity id 29544
2011-01-13 13:58:25 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 14:01:42 [INFO] nawf [/76.23.232.27:55220] logged in with entity id 32774
2011-01-13 14:03:43 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 16:20:26 [INFO] nawf [/76.23.232.27:55076] logged in with entity id 33853
2011-01-13 17:58:56 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 18:06:58 [INFO] nawf [/76.23.232.27:55037] logged in with entity id 96470
2011-01-13 18:20:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 18:21:55 [INFO] nawf [/76.23.232.27:55044] logged in with entity id 106984
2011-01-13 18:23:25 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 18:23:44 [INFO] nawf [/76.23.232.27:55034] logged in with entity id 107975
2011-01-13 18:45:02 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 18:47:33 [INFO] nawf [/76.23.232.27:55126] logged in with entity id 124037
2011-01-13 19:00:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 19:18:25 [INFO] nawf [/76.23.232.27:55011] logged in with entity id 133683
2011-01-13 19:53:15 [INFO] <nawf> t
2011-01-13 20:22:50 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 20:22:53 [INFO] nawf [/76.23.232.27:55033] logged in with entity id 171165
2011-01-13 20:24:54 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 20:47:27 [INFO] nawf [/76.23.232.27:55321] logged in with entity id 172737
2011-01-13 21:39:21 [INFO] nawf lost connection: disconnect.quitting
2011-01-13 22:22:29 [INFO] nawf [/76.23.232.27:55056] logged in with entity id 219844
2011-01-14 07:33:44 [INFO] nawf lost connection: disconnect.genericReason
2011-01-07 07:49:56 [INFO] Starting minecraft server version Beta 1.2
2011-01-07 07:49:56 [INFO] Loading properties
2011-01-07 07:49:56 [INFO] Starting Minecraft server on *:25565
2011-01-07 07:49:56 [INFO] Preparing level ""world""
2011-01-07 07:49:56 [INFO] Preparing start region
2011-01-07 07:49:57 [INFO] Preparing spawn area: 24%
2011-01-07 07:49:58 [INFO] Preparing spawn area: 77%
2011-01-07 07:49:59 [INFO] Done! For help, type ""help"" or ""?""
2011-01-07 07:50:50 [INFO] /206.251.36.137:49346 lost connection
2011-01-07 08:25:35 [INFO] nawf [/76.23.232.27:55186] logged in with entity id 75
2011-01-07 12:40:40 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 12:46:52 [INFO] Starting minecraft server version Beta 1.2_01
2011-01-07 12:46:52 [INFO] Loading properties
2011-01-07 12:46:52 [INFO] Starting Minecraft server on *:25565
2011-01-07 12:46:52 [INFO] Preparing level ""world""
2011-01-07 12:46:52 [INFO] Preparing start region
2011-01-07 12:46:53 [INFO] Preparing spawn area: 24%
2011-01-07 12:46:54 [INFO] Preparing spawn area: 57%
2011-01-07 12:46:55 [INFO] Done! For help, type ""help"" or ""?""
2011-01-07 16:22:26 [INFO] /206.251.36.137:56936 lost connection
2011-01-07 21:13:14 [INFO] efess [/24.177.10.101:1290] lost connection
2011-01-07 21:13:17 [INFO] efess [/24.177.10.101:1294] logged in with entity id 101
2011-01-07 21:23:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-07 21:26:15 [INFO] efess lost connection: disconnect.quitting
2011-01-07 21:26:18 [INFO] efess [/24.177.10.101:1309] logged in with entity id 21616
2011-01-07 21:38:42 [INFO] efess lost connection: disconnect.quitting
2011-01-07 21:40:19 [INFO] nawf [/69.119.2.8:17536] logged in with entity id 36295
2011-01-07 21:42:52 [INFO] <nawf> yo
2011-01-07 21:47:17 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 21:48:42 [INFO] nawf [/69.119.2.8:17546] logged in with entity id 46418
2011-01-07 21:48:46 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 21:58:14 [INFO] nawf [/69.119.2.8:17599] logged in with entity id 46807
2011-01-07 22:01:05 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 22:57:28 [INFO] nawf [/69.119.2.8:17778] logged in with entity id 49127
2011-01-07 23:17:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-07 23:22:13 [INFO] nawf lost connection: disconnect.quitting
2011-01-07 23:45:37 [INFO] efess [/24.177.10.101:1697] logged in with entity id 73161
2011-01-07 23:46:59 [INFO] efess lost connection: disconnect.quitting
2011-01-08 00:04:20 [INFO] nawf [/69.119.2.8:17962] logged in with entity id 74068
2011-01-08 00:05:14 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 00:06:20 [INFO] nawf [/69.119.2.8:17966] logged in with entity id 74702
2011-01-08 00:14:10 [INFO] nawf lost connection: disconnect.quitting
2011-01-08 00:37:47 [INFO] efess [/24.177.10.101:1764] logged in with entity id 81284
2011-01-08 00:38:02 [INFO] efess tried command: UI MAP ON
2011-01-08 00:41:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 01:05:18 [INFO] efess lost connection: disconnect.quitting
2011-01-08 01:34:08 [INFO] efess [/24.177.10.101:2148] logged in with entity id 124235
2011-01-08 01:54:49 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 02:05:58 [INFO] efess lost connection: disconnect.quitting
2011-01-08 10:20:08 [INFO] efess [/24.177.10.101:4029] lost connection
2011-01-08 10:20:40 [INFO] Disconnecting /24.177.10.101:4034: Took too long to log in
2011-01-08 10:21:00 [INFO] efess [/24.177.10.101:4042] logged in with entity id 160483
2011-01-08 10:21:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 10:21:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 10:21:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 10:23:30 [INFO] efess lost connection: disconnect.quitting
2011-01-08 10:33:04 [INFO] /24.177.10.101:4632 lost connection
2011-01-08 10:33:22 [INFO] efess [/24.177.10.101:4638] logged in with entity id 162170
2011-01-08 10:47:02 [INFO] efess lost connection: disconnect.quitting
2011-01-08 10:47:37 [INFO] Disconnecting /24.177.10.101:4738: Took too long to log in
2011-01-08 10:47:55 [INFO] efess [/24.177.10.101:4745] logged in with entity id 169838
2011-01-08 11:24:50 [INFO] efess tried command: help
2011-01-08 11:26:21 [INFO] efess lost connection: disconnect.quitting
2011-01-08 13:44:18 [INFO] efess [/24.177.10.101:7008] logged in with entity id 219462
2011-01-08 13:44:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 13:54:23 [INFO] efess lost connection: disconnect.quitting
2011-01-08 13:57:20 [INFO] /24.177.10.101:7254 lost connection
2011-01-08 13:57:28 [INFO] efess [/24.177.10.101:7255] logged in with entity id 227090
2011-01-08 13:57:32 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 14:02:57 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 14:17:18 [INFO] efess lost connection: disconnect.genericReason
2011-01-08 14:23:54 [INFO] efess [/24.177.10.101:7699] logged in with entity id 247542
2011-01-08 14:23:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 14:24:25 [INFO] efess lost connection: disconnect.quitting
2011-01-08 15:01:09 [INFO] efess [/24.177.10.101:1240] logged in with entity id 248004
2011-01-08 15:01:20 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 15:22:16 [INFO] efess lost connection: disconnect.quitting
2011-01-08 15:23:03 [INFO] efess [/24.177.10.101:1451] lost connection
2011-01-08 15:23:08 [INFO] efess [/24.177.10.101:1454] logged in with entity id 282112
2011-01-08 15:23:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 15:23:18 [INFO] efess lost connection: disconnect.genericReason
2011-01-08 15:23:42 [INFO] efess [/24.177.10.101:1461] logged in with entity id 282747
2011-01-08 15:23:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 16:07:43 [INFO] efess lost connection: disconnect.quitting
2011-01-08 16:10:27 [INFO] efess [/24.177.10.101:1908] logged in with entity id 299748
2011-01-08 16:13:38 [INFO] efess lost connection: disconnect.quitting
2011-01-08 16:18:10 [INFO] efess [/24.177.10.101:1957] lost connection
2011-01-08 16:18:22 [INFO] efess [/24.177.10.101:1960] logged in with entity id 302066
2011-01-08 16:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 16:29:06 [INFO] efess lost connection: disconnect.genericReason
2011-01-08 18:33:14 [INFO] efess [/24.177.10.101:3606] logged in with entity id 312373
2011-01-08 18:33:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 18:33:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 19:12:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 19:26:18 [INFO] efess lost connection: disconnect.quitting
2011-01-08 21:43:38 [INFO] efess [/24.177.10.101:5210] logged in with entity id 357619
2011-01-08 22:29:01 [INFO] efess lost connection: disconnect.genericReason
2011-01-08 22:29:50 [INFO] Disconnecting /24.177.10.101:5543: Took too long to log in
2011-01-08 22:35:30 [INFO] Disconnecting /24.177.10.101:5592: Took too long to log in
2011-01-08 22:35:47 [INFO] efess [/24.177.10.101:5597] logged in with entity id 396680
2011-01-08 22:35:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-08 22:39:47 [INFO] efess lost connection: disconnect.quitting
2011-01-09 00:34:10 [INFO] nawf [/76.23.232.27:55100] logged in with entity id 399333
2011-01-09 00:45:58 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 01:00:15 [INFO] nawf [/76.23.232.27:55027] logged in with entity id 407826
2011-01-09 01:00:20 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 01:07:05 [INFO] efess [/24.177.10.101:10095] logged in with entity id 413514
2011-01-09 01:07:06 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 01:09:27 [INFO] nawf [/76.23.232.27:55087] logged in with entity id 415331
2011-01-09 01:10:20 [INFO] <efess> !
2011-01-09 01:15:30 [INFO] <nawf> are you still at the lan?
2011-01-09 01:15:33 [INFO] <efess> ya
2011-01-09 01:15:35 [INFO] <efess> you?
2011-01-09 01:15:38 [INFO] <nawf> naw
2011-01-09 01:15:42 [INFO] <nawf> I left last night
2011-01-09 01:15:46 [INFO] <efess> ah
2011-01-09 01:16:03 [INFO] <efess> they're all playing l4d2
2011-01-09 01:16:06 [INFO] <nawf> it was ok, nobody was playing any good games
2011-01-09 01:16:11 [INFO] <nawf> yeah, that shit gets old
2011-01-09 01:16:13 [INFO] <efess> just cs?
2011-01-09 01:16:26 [INFO] <efess> I saw cs on steam
2011-01-09 01:16:26 [INFO] <nawf> naw, l4d2 too
2011-01-09 01:16:29 [INFO] <efess> ah
2011-01-09 01:26:13 [INFO] <nawf> ahh, 320 tnt
2011-01-09 01:27:08 [INFO] <efess> got another 148
2011-01-09 01:30:10 [INFO] <nawf> rofl
2011-01-09 01:31:11 [INFO] <nawf> you line the right wall, I'll do the left
2011-01-09 01:31:18 [INFO] <efess> lol
2011-01-09 01:31:19 [INFO] <nawf> how much tnt do you have?
2011-01-09 01:31:22 [INFO] <efess> 148
2011-01-09 01:31:44 [INFO] <efess> you want to widen this whole thing?
2011-01-09 01:31:55 [INFO] <nawf> hmm
2011-01-09 01:32:09 [INFO] <efess> need bacon
2011-01-09 01:32:11 [INFO] <nawf> well it needs to go longer too
2011-01-09 01:34:26 [INFO] <efess> lol tnt dispenser
2011-01-09 01:34:40 [INFO] <nawf> can I have one of those tnt stacks back?
2011-01-09 01:34:46 [INFO] <efess> yes!
2011-01-09 01:34:51 [INFO] <nawf> so I filled the ""path"" that I did
2011-01-09 01:35:03 [INFO] <nawf> so now the rest can just make this big part a little wider and deeper
2011-01-09 01:35:18 [INFO] <efess> well it can't go much deeper
2011-01-09 01:35:30 [INFO] <nawf> well if we do one wall it should get it a little deeper too
2011-01-09 01:36:43 [INFO] <nawf> brb
2011-01-09 01:36:45 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 01:40:27 [INFO] nawf [/76.23.232.27:55016] logged in with entity id 445133
2011-01-09 01:42:10 [INFO] <efess> holy shit
2011-01-09 01:42:56 [INFO] <nawf> yes
2011-01-09 01:45:07 [INFO] <efess> boom?
2011-01-09 01:45:23 [INFO] <efess> rofl
2011-01-09 01:45:25 [INFO] <efess> zombie in lava
2011-01-09 01:50:24 [INFO] <efess> lol
2011-01-09 01:50:26 [INFO] <nawf> newb
2011-01-09 01:51:15 [INFO] <efess> I love how we always manage to find previously explorered caves
2011-01-09 01:51:17 [INFO] <nawf> good river channel
2011-01-09 01:51:21 [INFO] <nawf> heh, yeah
2011-01-09 01:51:28 [INFO] <nawf> there is water and mobs over to the left someplace
2011-01-09 01:51:52 [INFO] <efess> nice... LAVA channel *fills with lava*
2011-01-09 01:53:06 [INFO] <efess> well I gtg call the women than sleep on floor
2011-01-09 01:53:09 [INFO] <nawf> so from here we have 100 blocks ""up"" the tunnel and about 20 blocks right
2011-01-09 01:53:16 [INFO] <nawf> and we are at the base
2011-01-09 01:53:22 [INFO] <efess> oh really? wow nice
2011-01-09 01:53:30 [INFO] <nawf> aight,
2011-01-09 01:53:34 [INFO] <nawf> yeah, I made a map
2011-01-09 01:53:41 [INFO] <nawf> and plotted out my ""seed channel""
2011-01-09 01:53:53 [INFO] <efess> seed channel?
2011-01-09 01:54:06 [INFO] <nawf> yeah, so I knew were to place the tnt on the way back to the base
2011-01-09 01:54:10 [INFO] <nawf> and so I had a spot
2011-01-09 01:54:11 [INFO] <efess> ahh
2011-01-09 01:54:12 [INFO] <efess> ya
2011-01-09 01:54:18 [INFO] <efess> alright man
2011-01-09 01:54:20 [INFO] <efess> l8r
2011-01-09 01:54:25 [INFO] efess lost connection: disconnect.quitting
2011-01-09 01:54:26 [INFO] <nawf> see yah, later, have fun on the floor
2011-01-09 01:58:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 10:26:08 [INFO] efess [/24.177.10.101:16777] logged in with entity id 477318
2011-01-09 10:37:12 [INFO] nawf [/76.23.232.27:55025] logged in with entity id 492530
2011-01-09 10:37:18 [INFO] <efess> what up son
2011-01-09 10:37:30 [INFO] <nawf> coffee and minecraft ooooo yeeeaaahh
2011-01-09 10:37:42 [INFO] <efess> same here, what a perfect morning.
2011-01-09 10:42:46 [INFO] <nawf> holy shit, gold picks are faster
2011-01-09 10:42:51 [INFO] <efess> ya they are
2011-01-09 10:42:51 [INFO] <nawf> than diamond
2011-01-09 10:43:02 [INFO] <efess> they only do 33 I think
2011-01-09 10:43:35 [INFO] <nawf> should we use them or save the gold for laterns?  assuming its an item
2011-01-09 10:43:52 [INFO] <efess> I'd say save them
2011-01-09 10:44:00 [INFO] <nawf> yeah, I just wanted to try it
2011-01-09 10:44:03 [INFO] <efess> they have to be good for something eventualy
2011-01-09 10:44:13 [INFO] <nawf> yeah, especially because they are rare
2011-01-09 10:45:04 [INFO] efess lost connection: disconnect.genericReason
2011-01-09 10:45:46 [INFO] Disconnecting /24.177.10.101:16998: Took too long to log in
2011-01-09 10:46:02 [INFO] efess [/24.177.10.101:17016] logged in with entity id 499814
2011-01-09 10:46:19 [INFO] <efess> so minecraft now crashes w/o warning w/o an error
2011-01-09 10:46:30 [INFO] <nawf> huh, for you?
2011-01-09 10:46:34 [INFO] <efess> ya
2011-01-09 10:52:15 [INFO] <efess> who needs to splunk when you can just
2011-01-09 10:52:18 [INFO] <efess> create your own caves
2011-01-09 10:52:35 [INFO] <nawf> heh, wish we found more diamone this way though
2011-01-09 10:52:42 [INFO] <nawf> I almost feel cheated
2011-01-09 10:52:50 [INFO] <efess> yea we probably blew up 50% of whatever shit was in there
2011-01-09 10:53:22 [INFO] <efess> but then again I think I heard someone say that diamond only blows up
2011-01-09 10:53:27 [INFO] <efess> when TNT is adjacent to it
2011-01-09 10:53:30 [INFO] <nawf> yeah
2011-01-09 10:53:44 [INFO] <efess> but yea the way we do it .. nevermind
2011-01-09 10:56:48 [INFO] <efess> its crazy how this all renders w/o issue
2011-01-09 10:56:55 [INFO] <nawf> we need to build a castle or something
2011-01-09 10:57:00 [INFO] <nawf> yeah, feels smoother too
2011-01-09 10:57:02 [INFO] <efess> got about 600 sources of light
2011-01-09 10:57:11 [INFO] <nawf> holy fuck
2011-01-09 10:57:18 [INFO] <nawf> my fps is 446
2011-01-09 10:57:23 [INFO] <efess> lol
2011-01-09 10:57:25 [INFO] efess tried command: fps
2011-01-09 10:57:33 [INFO] <efess> 116 here
2011-01-09 10:57:42 [INFO] <nawf> 561!
2011-01-09 10:57:54 [INFO] <efess> I need to upgrade for minecraft
2011-01-09 10:57:55 [INFO] <efess> lol
2011-01-09 10:57:57 [INFO] <nawf> lol
2011-01-09 10:58:16 [INFO] <nawf> so what I think I'm going to do is make the river tgo around
2011-01-09 10:58:22 [INFO] <nawf> this block here as like an island
2011-01-09 10:58:57 [INFO] <nawf> I think because I just kinda free wheel this
2011-01-09 10:59:50 [INFO] <nawf> so at this iron is the water level for now
2011-01-09 10:59:58 [INFO] <nawf> well I mean the block below
2011-01-09 11:00:20 [INFO] <efess> k
2011-01-09 11:00:30 [INFO] <efess> you're not going to make it ""flowing"" right?
2011-01-09 11:00:54 [INFO] <nawf> maybe in some parts, but boating against it will be a pain if I do
2011-01-09 11:01:49 [INFO] <nawf> we could almost turn off the zombie spawener
2011-01-09 11:01:56 [INFO] <efess> I was just showing someone it
2011-01-09 11:02:06 [INFO] <nawf> ah, I was showing b the big mob spawner
2011-01-09 11:02:06 [INFO] <efess> minecraft is interesting to people who never play it
2011-01-09 11:02:08 [INFO] <nawf> I tied
2011-01-09 11:02:12 [INFO] <nawf> I died
2011-01-09 11:02:14 [INFO] <efess> lol
2011-01-09 11:02:17 [INFO] <efess> fall?
2011-01-09 11:02:21 [INFO] <nawf> naw, mobs
2011-01-09 11:02:26 [INFO] <efess> oh inside it?
2011-01-09 11:02:34 [INFO] <nawf> well right in the entranceway
2011-01-09 11:02:40 [INFO] <efess> yea its hard because the catwalk spawns mosnters too
2011-01-09 11:02:52 [INFO] <nawf> yeah, lost like half an inventory of sand
2011-01-09 11:02:54 [INFO] <efess> and spiders are like walls can't stop me
2011-01-09 11:02:54 [INFO] <nawf> :(
2011-01-09 11:02:59 [INFO] <nawf> fuck them
2011-01-09 11:03:14 [INFO] <efess> so you need to harvest tons of dirt huh
2011-01-09 11:03:46 [INFO] <nawf> yeah, I was thinking of flattening around the wheat garden
2011-01-09 11:03:49 [INFO] <nawf> make it all level
2011-01-09 11:03:56 [INFO] <efess> k
2011-01-09 11:04:03 [INFO] <nawf> or finding a mountain we wanted to remove
2011-01-09 11:04:10 [INFO] <nawf> shave a little off the top
2011-01-09 11:05:07 [INFO] <efess> you still use stone tools?
2011-01-09 11:05:14 [INFO] <nawf> yeah and some iron
2011-01-09 11:05:25 [INFO] <efess> ah. Use diamond, we have 30
2011-01-09 11:05:30 [INFO] <efess> I just found 6 yesterday
2011-01-09 11:05:36 [INFO] <nawf> alright
2011-01-09 11:06:24 [INFO] <nawf> I'm going to take a break, clean some aprtment
2011-01-09 11:06:31 [INFO] <efess> k
2011-01-09 11:06:34 [INFO] <nawf> then moar tnt to clean around the island
2011-01-09 11:06:40 [INFO] <nawf> becaus maor
2011-01-09 11:06:52 [INFO] <efess> maybe we'll play some games here at the lanparty
2011-01-09 11:06:52 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 11:29:41 [INFO] nawf [/76.23.232.27:55014] logged in with entity id 528239
2011-01-09 11:39:51 [INFO] <nawf> I think mobs spawn on halfstone now :(
2011-01-09 11:40:01 [INFO] <efess> naww!
2011-01-09 11:40:41 [INFO] <efess> let me look
2011-01-09 11:43:02 [INFO] <efess> dpesm
2011-01-09 11:43:06 [INFO] <efess> doesn't look like it
2011-01-09 11:43:18 [INFO] <nawf> hrm, ok
2011-01-09 11:50:16 [INFO] <nawf> I'm going to fill the former sand island with water
2011-01-09 11:50:21 [INFO] <efess> do it
2011-01-09 11:50:22 [INFO] <nawf> its pretty much done
2011-01-09 11:50:27 [INFO] <nawf> and there are mobs in it
2011-01-09 11:50:34 [INFO] <efess> notch needs to fix the refreezing of water
2011-01-09 11:50:49 [INFO] <nawf> that worked at one point?
2011-01-09 11:53:59 [INFO] efess lost connection: disconnect.quitting
2011-01-09 11:54:31 [INFO] Disconnecting /24.177.10.101:17848: Took too long to log in
2011-01-09 11:55:04 [INFO] Disconnecting /24.177.10.101:17853: Took too long to log in
2011-01-09 11:55:28 [INFO] efess [/24.177.10.101:17861] logged in with entity id 552676
2011-01-09 11:57:48 [INFO] <efess> yea it did work
2011-01-09 11:58:03 [INFO] <efess> and the environment used to ""snow"" too
2011-01-09 11:58:09 [INFO] <nawf> oh right
2011-01-09 11:58:21 [INFO] <efess> and show would show up on grass
2011-01-09 11:58:26 [INFO] <efess> if you created snowballs
2011-01-09 12:11:42 [INFO] <efess> aight man, gonna pack up and head out
2011-01-09 12:11:52 [INFO] <efess> ttyl
2011-01-09 12:11:54 [INFO] <nawf> see yah
2011-01-09 12:12:04 [INFO] efess lost connection: disconnect.quitting
2011-01-09 12:12:57 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 12:42:43 [INFO] Disconnecting nawf [/76.23.232.27:55109]: Took too long to log in
2011-01-09 12:42:53 [INFO] nawf [/76.23.232.27:55005] logged in with entity id 568064
2011-01-09 12:42:57 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 13:21:54 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 13:39:11 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 14:46:38 [INFO] nawf [/76.23.232.27:55053] logged in with entity id 610020
2011-01-09 14:46:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 15:10:21 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 17:15:43 [INFO] nawf [/76.23.232.27:55093] logged in with entity id 624807
2011-01-09 17:15:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 17:29:10 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 18:51:10 [INFO] nawf [/76.23.232.27:55106] logged in with entity id 634495
2011-01-09 18:51:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 18:51:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 19:22:58 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 19:42:51 [INFO] nawf [/76.23.232.27:55104] logged in with entity id 663315
2011-01-09 19:51:31 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 22:16:40 [INFO] nawf [/76.23.232.27:55116] logged in with entity id 674088
2011-01-09 22:16:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 22:16:44 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 22:16:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 22:36:57 [INFO] nawf lost connection: disconnect.quitting
2011-01-09 23:03:48 [INFO] nawf [/76.23.232.27:55094] logged in with entity id 705695
2011-01-09 23:04:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-09 23:55:39 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 02:14:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 09:52:46 [INFO] nawf [/76.23.232.27:55238] logged in with entity id 733131
2011-01-10 09:52:48 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 09:52:52 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 12:00:48 [INFO] nawf lost connection: disconnect.genericReason
2011-01-10 13:01:50 [INFO] nawf [/76.23.232.27:55080] logged in with entity id 739987
2011-01-10 13:01:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 16:51:18 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 16:51:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 16:53:09 [INFO] nawf [/76.23.232.27:55034] logged in with entity id 764876
2011-01-10 16:53:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 17:24:04 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 17:33:50 [INFO] nawf [/76.23.232.27:55010] logged in with entity id 776025
2011-01-10 17:33:55 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 17:45:36 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 18:16:43 [INFO] nawf [/76.23.232.27:55100] logged in with entity id 801936
2011-01-10 18:16:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 18:16:48 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 18:35:03 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 19:06:56 [INFO] nawf [/76.23.232.27:55153] logged in with entity id 814852
2011-01-10 19:06:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 19:07:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 19:37:20 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 19:39:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 19:39:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 19:47:02 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 20:21:21 [INFO] /69.119.7.235:5053 lost connection
2011-01-10 20:21:56 [INFO] Disconnecting /69.119.7.235:5061: Took too long to log in
2011-01-10 20:22:24 [INFO] efess [/69.119.7.235:5066] logged in with entity id 847646
2011-01-10 20:22:27 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 20:25:03 [INFO] efess lost connection: disconnect.quitting
2011-01-10 20:30:48 [INFO] /76.23.232.27:55019 lost connection
2011-01-10 20:31:21 [INFO] Disconnecting /76.23.232.27:55007: Took too long to log in
2011-01-10 20:44:03 [INFO] Disconnecting /69.119.7.235:5642: Took too long to log in
2011-01-10 20:44:21 [INFO] /69.119.7.235:5649 lost connection
2011-01-10 20:49:29 [INFO] Disconnecting /76.23.232.27:55103: Took too long to log in
2011-01-10 20:56:36 [INFO] Disconnecting /76.23.232.27:55382: Took too long to log in
2011-01-10 21:04:43 [INFO] nawf [/76.23.232.27:55054] logged in with entity id 849435
2011-01-10 21:04:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 21:06:05 [INFO] nawf lost connection: disconnect.quitting
2011-01-10 21:09:32 [INFO] /69.119.7.235:5971 lost connection
2011-01-10 21:15:54 [INFO] efess [/69.119.7.235:6316] lost connection
2011-01-10 21:16:08 [INFO] efess [/69.119.7.235:6318] lost connection
2011-01-10 21:16:11 [INFO] /69.119.7.235:6320 lost connection
2011-01-10 21:16:47 [INFO] Disconnecting /69.119.7.235:6325: Took too long to log in
2011-01-10 21:17:12 [INFO] efess [/69.119.7.235:6331] logged in with entity id 850385
2011-01-10 21:17:25 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 21:57:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 22:10:05 [INFO] efess lost connection: disconnect.quitting
2011-01-10 23:05:14 [INFO] nawf [/76.23.232.27:55045] logged in with entity id 944221
2011-01-10 23:05:27 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-10 23:51:31 [INFO] nawf lost connection: disconnect.quitting
2011-01-11 07:07:32 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 12:30:35 [INFO] nawf [/76.23.232.27:55040] logged in with entity id 975794
2011-01-11 12:30:40 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 12:30:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 12:30:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 12:31:41 [INFO] nawf lost connection: disconnect.quitting
2011-01-11 12:31:54 [INFO] nawf [/76.23.232.27:55041] logged in with entity id 976565
2011-01-11 12:32:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 12:32:20 [INFO] nawf lost connection: disconnect.quitting
2011-01-11 14:01:14 [INFO] /76.23.232.27:55121 lost connection
2011-01-11 14:01:23 [INFO] /76.23.232.27:55041 lost connection
2011-01-11 16:25:27 [INFO] nawf [/76.23.232.27:55171] logged in with entity id 977049
2011-01-11 16:25:33 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 16:25:37 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 16:38:07 [INFO] nawf lost connection: disconnect.quitting
2011-01-11 16:38:25 [INFO] /76.23.232.27:55214 lost connection
2011-01-11 17:05:43 [INFO] /76.23.232.27:55368 lost connection
2011-01-11 17:05:48 [INFO] /76.23.232.27:55090 lost connection
2011-01-11 17:40:58 [INFO] /76.23.232.27:55093 lost connection
2011-01-11 17:52:53 [INFO] nawf [/76.23.232.27:55022] logged in with entity id 986002
2011-01-11 17:52:56 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 19:24:49 [INFO] /24.147.183.4:50780 lost connection
2011-01-11 19:25:33 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:50815]: Took too long to log in
2011-01-11 19:26:58 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:50919]: Took too long to log in
2011-01-11 19:28:04 [INFO] /24.147.183.4:50965 lost connection
2011-01-11 19:29:02 [INFO] /24.147.183.4:51024 lost connection
2011-01-11 19:29:09 [INFO] /24.147.183.4:51030 lost connection
2011-01-11 19:29:30 [INFO] /24.147.183.4:51046 lost connection
2011-01-11 19:29:52 [INFO] /24.147.183.4:51060 lost connection
2011-01-11 19:29:58 [INFO] /24.147.183.4:51066 lost connection
2011-01-11 19:30:20 [INFO] /24.147.183.4:51081 lost connection
2011-01-11 19:30:25 [INFO] /24.147.183.4:51084 lost connection
2011-01-11 19:31:23 [INFO] /24.147.183.4:51112 lost connection
2011-01-11 19:32:25 [INFO] /24.147.183.4:51150 lost connection
2011-01-11 19:32:35 [INFO] /24.147.183.4:51170 lost connection
2011-01-11 19:32:41 [INFO] /24.147.183.4:51178 lost connection
2011-01-11 19:33:45 [INFO] /24.147.183.4:51208 lost connection
2011-01-11 19:34:52 [INFO] /24.147.183.4:51252 lost connection
2011-01-11 19:35:31 [INFO] /24.147.183.4:51279 lost connection
2011-01-11 19:36:06 [INFO] /24.147.183.4:51299 lost connection
2011-01-11 19:37:16 [INFO] /24.147.183.4:51348 lost connection
2011-01-11 19:37:59 [INFO] /24.147.183.4:51380 lost connection
2011-01-11 19:38:41 [INFO] AngryRhetoric [/24.147.183.4:51425] logged in with entity id 1077445
2011-01-11 19:38:46 [INFO] <nawf> woo
2011-01-11 19:38:57 [INFO] <AngryRhetoric> Dude, i had to type in the IP
2011-01-11 19:39:01 [INFO] <AngryRhetoric> instead of the name
2011-01-11 19:39:06 [INFO] <AngryRhetoric> worked like a charm
2011-01-11 19:39:10 [INFO] <nawf> oh no shit
2011-01-11 19:39:24 [INFO] <AngryRhetoric> wierd huh?
2011-01-11 19:39:40 [INFO] <AngryRhetoric> whoa bones
2011-01-11 19:40:12 [INFO] <AngryRhetoric> you guys have been busy!
2011-01-11 19:41:28 [INFO] <nawf> heh, little here, little there
2011-01-11 19:43:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 19:43:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-11 19:43:20 [INFO] <nawf> did you hit the tnt?
2011-01-11 19:43:46 [INFO] <AngryRhetoric> hit it?
2011-01-11 19:44:00 [INFO] <nawf> my tnt exploded prematurely
2011-01-11 19:44:05 [INFO] <nawf> I'm blaming you
2011-01-11 19:44:09 [INFO] <nawf> although I think the lava set it off
2011-01-11 19:44:13 [INFO] <AngryRhetoric> i don't think i'm even near it but that seems fair ;-)
2011-01-11 19:44:37 [INFO] <nawf> yeah, it was the lava
2011-01-11 19:47:47 [INFO] <nawf> well that was shitty
2011-01-11 19:47:51 [INFO] <nawf> I lost all my stuff
2011-01-11 19:48:19 [INFO] <AngryRhetoric> oh shit
2011-01-11 19:48:27 [INFO] <AngryRhetoric> that sucks, were you still near the lava?
2011-01-11 19:48:36 [INFO] <nawf> naw, the lava must have lit the tnt on fire
2011-01-11 19:48:40 [INFO] <nawf> hence premature boom
2011-01-11 19:48:42 [INFO] <nawf> lesson learned
2011-01-11 19:48:59 [INFO] <AngryRhetoric> hah
2011-01-11 19:49:11 [INFO] <nawf> I think most of my inventory was bs anyway, dirt, cobble
2011-01-11 19:49:13 [INFO] <nawf> we have plenty of that
2011-01-11 19:50:32 [INFO] <AngryRhetoric> done anything with dyes yet?
2011-01-11 19:50:47 [INFO] <nawf> turned a sheep red
2011-01-11 19:51:32 [INFO] <AngryRhetoric> hah
2011-01-11 19:51:36 [INFO] <AngryRhetoric> he probably deserved it
2011-01-11 19:51:55 [INFO] <nawf> yeah, he was sitting in a minecart
2011-01-11 19:55:54 [INFO] <AngryRhetoric> i thought arrows set off dynamite
2011-01-11 19:55:59 [INFO] <nawf> naw
2011-01-11 19:56:04 [INFO] <nawf> maybe flaming ones
2011-01-11 19:56:19 [INFO] <AngryRhetoric> how do you make those
2011-01-11 19:56:26 [INFO] <nawf> shoot arrows through lava
2011-01-11 20:00:24 [INFO] <AngryRhetoric> huh hmm
2011-01-11 20:20:46 [INFO] <nawf> brb
2011-01-11 20:25:26 [INFO] <AngryRhetoric> ok
2011-01-11 20:25:33 [INFO] <AngryRhetoric> yarrr
2011-01-11 20:31:32 [INFO] <AngryRhetoric> mmm chunk errors
2011-01-11 20:32:02 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-11 20:32:25 [INFO] /24.147.183.4:53498 lost connection
2011-01-11 20:32:52 [INFO] /24.147.183.4:53519 lost connection
2011-01-11 20:37:59 [INFO] /24.147.183.4:53720 lost connection
2011-01-11 20:38:27 [INFO] AngryRhetoric [/24.147.183.4:53748] logged in with entity id 1153700
2011-01-11 20:41:14 [INFO] <nawf> steal your pork
2011-01-11 20:41:19 [INFO] <AngryRhetoric> haha i brought more
2011-01-11 20:41:25 [INFO] <nawf> nice
2011-01-11 20:41:27 [INFO] <AngryRhetoric> porkinses
2011-01-11 20:41:48 [INFO] <AngryRhetoric> what's the next big thing to make?
2011-01-11 20:41:55 [INFO] <AngryRhetoric> we should BUILD something lol
2011-01-11 20:42:28 [INFO] <nawf> prob a sweet castle
2011-01-11 20:42:34 [INFO] <nawf> we have so much cobble
2011-01-11 20:42:40 [INFO] <AngryRhetoric> haha yeah that's not a bad idea
2011-01-11 20:42:58 [INFO] <AngryRhetoric> that was the last thing imade in my single player map
2011-01-11 20:43:12 [INFO] <nawf> sweet, I'm just obscessed with my river
2011-01-11 20:43:14 [INFO] <nawf> atm
2011-01-11 20:43:26 [INFO] <nawf> I want it to go all the way to the base
2011-01-11 20:43:32 [INFO] <AngryRhetoric> where's the river?
2011-01-11 20:43:47 [INFO] <nawf> outside here, the start of it anyway, we blasted a huge channel just filling it in
2011-01-11 20:43:52 [INFO] <nawf> decorating with dirt and stuff
2011-01-11 20:44:01 [INFO] <nawf> well chinese food just came, I'll be back on later
2011-01-11 20:44:08 [INFO] <AngryRhetoric> ok
2011-01-11 22:59:16 [INFO] nawf lost connection: disconnect.quitting
2011-01-11 23:40:47 [INFO] <AngryRhetoric> i was afraid you entombed me in obsidian haha
2011-01-11 23:41:07 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-11 23:41:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 01:43:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 18:19:01 [INFO] /76.23.232.27:55154 lost connection
2011-01-12 18:19:32 [INFO] /76.23.232.27:55157 lost connection
2011-01-12 18:19:57 [INFO] /76.23.232.27:55460 lost connection
2011-01-12 18:21:04 [INFO] /76.23.232.27:55041 lost connection
2011-01-12 18:45:00 [INFO] /76.23.232.27:55064 lost connection
2011-01-12 18:45:38 [INFO] Disconnecting nawf [/76.23.232.27:55006]: Took too long to log in
2011-01-12 18:46:44 [INFO] Disconnecting nawf [/76.23.232.27:55058]: Took too long to log in
2011-01-12 18:52:18 [INFO] Disconnecting nawf [/76.23.232.27:55041]: Took too long to log in
2011-01-12 18:55:55 [INFO] nawf [/76.23.232.27:55111] logged in with entity id 1191992
2011-01-12 18:55:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 18:56:01 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 18:56:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 18:57:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 19:43:28 [INFO] nawf lost connection: disconnect.quitting
2011-01-12 21:22:58 [INFO] /76.23.232.27:55026 lost connection
2011-01-12 21:23:24 [INFO] /76.23.232.27:55068 lost connection
2011-01-12 21:23:51 [INFO] /76.23.232.27:55061 lost connection
2011-01-12 21:24:08 [INFO] nawf [/76.23.232.27:55309] logged in with entity id 1233257
2011-01-12 21:24:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-12 22:53:29 [INFO] nawf lost connection: disconnect.genericReason
2011-01-13 00:17:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 14:40:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 17:25:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 17:27:56 [INFO] /76.23.232.27:55033 lost connection
2011-01-13 17:28:20 [INFO] /76.23.232.27:55025 lost connection
2011-01-13 17:29:38 [INFO] /76.23.232.27:55028 lost connection
2011-01-13 17:30:37 [INFO] /76.23.232.27:55000 lost connection
2011-01-13 17:31:08 [INFO] /76.23.232.27:55031 lost connection
2011-01-13 17:31:16 [INFO] /76.23.232.27:55108 lost connection
2011-01-13 17:33:04 [INFO] /76.23.232.27:55038 lost connection
2011-01-13 17:33:49 [INFO] /76.23.232.27:55085 lost connection
2011-01-13 23:04:27 [INFO] nawf [/76.23.232.27:55003] logged in with entity id 1441501
2011-01-13 23:04:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 23:04:57 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-13 23:31:34 [INFO] nawf lost connection: disconnect.quitting
2011-01-14 06:17:26 [INFO] /69.119.7.235:12347 lost connection
2011-01-14 06:18:03 [INFO] efess [/69.119.7.235:12416] logged in with entity id 1565512
2011-01-14 06:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-14 06:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-14 06:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-14 06:19:49 [INFO] efess lost connection: disconnect.quitting
2011-01-14 06:57:41 [INFO] efess [/69.119.7.235:13255] logged in with entity id 1567435
2011-01-14 07:13:44 [INFO] efess lost connection: disconnect.quitting
2011-01-14 08:31:49 [INFO] efess [/69.119.7.235:14324] logged in with entity id 1627030
2011-01-14 08:31:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-14 08:31:55 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-14 10:56:08 [INFO] efess lost connection: disconnect.quitting
2011-01-14 10:58:04 [INFO] efess [/69.119.7.235:15942] logged in with entity id 1661464
2011-01-14 11:13:57 [INFO] efess lost connection: disconnect.quitting
2011-01-14 13:07:59 [INFO] efess [/69.119.7.235:17125] logged in with entity id 1743736
2011-01-14 13:08:45 [INFO] efess lost connection: disconnect.quitting
2011-01-14 13:08:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-14 13:08:49 [INFO] efess [/69.119.7.235:17143] logged in with entity id 1743975
2011-01-14 13:46:48 [INFO] efess [/69.119.7.235:19417] logged in with entity id 1750464
2011-01-14 14:28:22 [INFO] efess lost connection: disconnect.quitting
2011-01-21 14:37:09 [INFO] Starting minecraft server version Beta 1.2_01
2011-01-21 14:37:09 [INFO] Loading properties
2011-01-21 14:37:09 [INFO] Starting Minecraft server on *:25565
2011-01-21 14:37:09 [INFO] Preparing level ""world""
2011-01-21 14:37:09 [INFO] Preparing start region
2011-01-21 14:37:10 [INFO] Preparing spawn area: 28%
2011-01-21 14:37:11 [INFO] Preparing spawn area: 81%
2011-01-21 14:37:11 [INFO] Done! For help, type ""help"" or ""?""
2011-01-21 14:38:25 [INFO] efess [/69.119.7.235:20281] logged in with entity id 91
2011-01-21 14:42:41 [INFO] efess lost connection: disconnect.quitting
2011-01-21 14:43:05 [INFO] /69.119.7.235:20343 lost connection
2011-01-21 14:43:58 [INFO] Disconnecting efess [/69.119.7.235:20357]: Took too long to log in
2011-01-21 14:44:46 [INFO] Disconnecting efess [/69.119.7.235:20363]: Took too long to log in
2011-01-21 14:48:10 [INFO] efess [/69.119.7.235:20392] logged in with entity id 3299
2011-01-21 15:41:14 [INFO] efess lost connection: disconnect.genericReason
2011-01-21 15:42:58 [INFO] /69.119.7.235:20876 lost connection
2011-01-21 15:44:44 [INFO] efess [/69.119.7.235:20887] logged in with entity id 378983
2011-01-21 16:02:36 [INFO] efess lost connection: disconnect.genericReason
2011-01-21 16:08:43 [INFO] /69.119.7.235:21069 lost connection
2011-01-21 16:11:39 [INFO] /69.119.7.235:21089 lost connection
2011-01-21 16:13:50 [INFO] /69.119.7.235:21108 lost connection
2011-01-21 16:14:25 [INFO] /69.119.7.235:21113 lost connection
2011-01-21 16:14:54 [INFO] /69.119.7.235:21128 lost connection
2011-01-21 16:16:04 [INFO] Disconnecting efess [/69.119.7.235:21137]: Took too long to log in
2011-01-21 20:00:47 [INFO] AngryRhetoric [/24.147.183.4:51887] logged in with entity id 538466
2011-01-21 20:00:58 [INFO] <AngryRhetoric> anyone on?
2011-01-21 22:16:16 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-22 09:25:32 [INFO] efess [/69.119.7.235:21533] logged in with entity id 675332
2011-01-22 09:25:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-22 09:57:57 [INFO] efess lost connection: disconnect.quitting
2011-01-22 11:49:18 [INFO] nawf [/76.23.232.27:55017] logged in with entity id 779287
2011-01-22 12:11:48 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 12:58:20 [INFO] nawf [/76.23.232.27:55045] logged in with entity id 818202
2011-01-22 13:29:19 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 13:35:05 [INFO] nawf [/76.23.232.27:55004] logged in with entity id 858386
2011-01-22 14:32:17 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 15:51:50 [INFO] nawf [/76.23.232.27:55105] logged in with entity id 894393
2011-01-22 16:11:35 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 17:09:13 [INFO] efess [/69.119.7.235:26257] logged in with entity id 905928
2011-01-22 17:11:40 [INFO] efess lost connection: disconnect.quitting
2011-01-22 17:14:24 [INFO] efess [/69.119.7.235:26322] logged in with entity id 907984
2011-01-22 18:03:09 [INFO] nawf [/76.23.232.27:55068] logged in with entity id 969428
2011-01-22 18:03:13 [INFO] <efess> what up
2011-01-22 18:03:16 [INFO] <nawf> yo
2011-01-22 18:03:27 [INFO] <efess> doing a lil splunkin
2011-01-22 18:03:35 [INFO] <nawf> yo I think we should build the castle right next to the spawn base
2011-01-22 18:03:39 [INFO] <nawf> in our garden there
2011-01-22 18:03:51 [INFO] <efess> Ya I agree
2011-01-22 18:04:28 [INFO] <efess> wow so when gravel falls into lava, only a few of them will burn
2011-01-22 18:04:34 [INFO] <efess> than it will fill the lava
2011-01-22 18:04:51 [INFO] <nawf> yeah, thats how I usually clear lava
2011-01-22 18:04:55 [INFO] <nawf> sand works too
2011-01-22 18:05:08 [INFO] <nawf> I wish it turned into glass though
2011-01-22 18:05:12 [INFO] <efess> ya
2011-01-22 18:06:33 [INFO] <efess> nice 4 diamond
2011-01-22 18:06:40 [INFO] <nawf> sweet
2011-01-22 18:13:20 [INFO] <nawf> oh did you start a castle?
2011-01-22 18:13:24 [INFO] <efess> not yet
2011-01-22 18:13:27 [INFO] <nawf> kevin did
2011-01-22 18:13:29 [INFO] <efess> heh
2011-01-22 18:13:36 [INFO] <efess> i'm heading over
2011-01-22 18:16:13 [INFO] <efess> lol
2011-01-22 18:16:19 [INFO] <efess> i'm missing like 3 chunks right in your garden
2011-01-22 18:16:36 [INFO] <efess> our lava pool is 4 blocks deep
2011-01-22 18:16:47 [INFO] <nawf> I don't know what to do with it
2011-01-22 18:16:52 [INFO] <nawf> maybe just fill it
2011-01-22 18:17:00 [INFO] <nawf> or fill buckets with it just in case
2011-01-22 18:17:03 [INFO] <efess> ya
2011-01-22 18:17:14 [INFO] <efess> we should surround it with glas
2011-01-22 18:17:27 [INFO] <efess> lol @ random torch underground
2011-01-22 18:18:39 [INFO] efess lost connection: disconnect.quitting
2011-01-22 18:18:42 [INFO] efess [/69.119.7.235:26778] logged in with entity id 984727
2011-01-22 18:19:12 [INFO] <efess> where you at?
2011-01-22 18:21:51 [INFO] <nawf> at kevins castle
2011-01-22 18:21:57 [INFO] <nawf> its right outside the spawner
2011-01-22 18:22:09 [INFO] <nawf> I was going to get some sand
2011-01-22 18:24:23 [INFO] <efess> hotel kevin
2011-01-22 18:27:40 [INFO] <nawf> yeah, so I don't have any gd rice
2011-01-22 18:27:52 [INFO] <nawf> I'm making some indian dish with fettucini
2011-01-22 18:28:00 [INFO] <efess> just buy a 40lb bag
2011-01-22 18:28:03 [INFO] <efess> never run out
2011-01-22 18:28:12 [INFO] <nawf> well I did and forgot
2011-01-22 18:29:16 [INFO] efess lost connection: disconnect.quitting
2011-01-22 18:29:19 [INFO] efess [/69.119.7.235:26851] logged in with entity id 1002773
2011-01-22 18:33:46 [INFO] <efess> brb eats
2011-01-22 18:33:52 [INFO] <nawf> I'll be gone soon too
2011-01-22 18:33:53 [INFO] efess lost connection: disconnect.quitting
2011-01-22 18:34:09 [INFO] efess [/69.119.7.235:26891] logged in with entity id 1010093
2011-01-22 18:34:18 [INFO] efess lost connection: disconnect.quitting
2011-01-22 18:49:24 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 18:49:44 [INFO] efess [/69.119.7.235:27001] logged in with entity id 1017288
2011-01-22 18:51:19 [INFO] efess lost connection: disconnect.quitting
2011-01-22 18:51:22 [INFO] efess [/69.119.7.235:27017] logged in with entity id 1020834
2011-01-22 18:55:06 [INFO] <efess> holy shit
2011-01-22 18:55:09 [INFO] <efess> spiders are fast now?
2011-01-22 18:56:59 [INFO] <efess> I put more sand in the chest for you
2011-01-22 19:05:55 [INFO] <efess> yt?
2011-01-22 19:14:12 [WARNING] efess moved wrongly!
2011-01-22 19:53:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-22 19:54:28 [INFO] efess [/69.119.7.235:27527] logged in with entity id 1132893
2011-01-22 20:02:16 [INFO] nawf [/76.23.232.27:55067] logged in with entity id 1163662
2011-01-22 20:02:24 [INFO] <efess> nah I was fighting a creeper
2011-01-22 20:02:32 [INFO] <efess> than I look behind me, two fucking zombies
2011-01-22 20:03:27 [INFO] <nawf> lol
2011-01-22 20:03:50 [INFO] <nawf> where in the new cave?
2011-01-22 20:03:52 [INFO] <nawf> down the tunnel
2011-01-22 20:04:02 [INFO] <efess> ya take a minecart to the end of the track
2011-01-22 20:04:05 [INFO] <efess> and there's a new cave
2011-01-22 20:04:39 [INFO] <efess> shit
2011-01-22 20:04:53 [INFO] <efess> 3 skeletons
2011-01-22 20:04:53 [INFO] <efess> lol
2011-01-22 20:04:55 [INFO] <nawf> lol
2011-01-22 20:08:13 [INFO] <nawf> lol, carting through a chunk error
2011-01-22 20:08:22 [INFO] <efess> haha nice
2011-01-22 20:08:26 [INFO] <efess> funny how it doesn't glitch
2011-01-22 20:08:34 [INFO] <nawf> holy shit this is long
2011-01-22 20:08:40 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 20:08:42 [INFO] nawf [/76.23.232.27:55004] logged in with entity id 1170853
2011-01-22 20:08:46 [INFO] <efess> its even longer
2011-01-22 20:09:23 [INFO] <nawf> no blue stuff yet?
2011-01-22 20:09:27 [INFO] <efess> nope :/
2011-01-22 20:10:57 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 20:10:59 [INFO] nawf [/76.23.232.27:55003] logged in with entity id 1173326
2011-01-22 20:13:19 [INFO] <efess> yo!
2011-01-22 20:13:29 [INFO] <efess> big cave
2011-01-22 20:13:45 [INFO] <nawf> need fud
2011-01-22 20:13:51 [INFO] <efess> hre
2011-01-22 20:14:02 [INFO] <nawf> oops, I meant need food?
2011-01-22 20:14:05 [INFO] <efess> oh
2011-01-22 20:14:19 [INFO] <efess> need arrows
2011-01-22 20:14:29 [INFO] <efess> thx
2011-01-22 20:14:33 [INFO] <nawf> np
2011-01-22 20:15:55 [INFO] <efess> so many mobs
2011-01-22 20:17:07 [INFO] <nawf> nothing here
2011-01-22 20:17:40 [INFO] <efess> boom?
2011-01-22 20:17:42 [INFO] <efess> lol
2011-01-22 20:17:57 [INFO] <efess> i gtg, need anything?
2011-01-22 20:18:05 [INFO] <nawf> naw, I follow you
2011-01-22 20:18:10 [INFO] <efess> jess is giving me the evil eye
2011-01-22 20:18:19 [INFO] <nawf> oh I thought you meant back
2011-01-22 20:18:23 [INFO] <efess> oh haha
2011-01-22 20:18:38 [INFO] <nawf> I'll prob go back, need to finish river
2011-01-22 20:18:42 [INFO] <efess> heh
2011-01-22 20:18:43 [INFO] <efess> alright
2011-01-22 20:18:47 [INFO] <efess> gl finding the way out i'm lost
2011-01-22 20:18:48 [INFO] <efess> lol
2011-01-22 20:18:54 [INFO] <efess> l8r dude
2011-01-22 20:18:57 [INFO] <nawf> see yah
2011-01-22 20:18:59 [INFO] efess lost connection: disconnect.quitting
2011-01-22 21:02:24 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 21:29:56 [INFO] nawf [/76.23.232.27:55002] logged in with entity id 1347216
2011-01-22 21:57:33 [INFO] nawf lost connection: disconnect.quitting
2011-01-22 22:19:00 [INFO] nawf [/76.23.232.27:55075] logged in with entity id 1383780
2011-01-22 22:48:21 [INFO] nawf lost connection: disconnect.quitting
2011-01-23 00:03:48 [INFO] nawf [/76.23.232.27:55009] logged in with entity id 1420628
2011-01-23 00:19:44 [INFO] nawf lost connection: disconnect.quitting
2011-01-23 00:39:51 [INFO] nawf [/76.23.232.27:55060] logged in with entity id 1435491
2011-01-23 00:52:35 [INFO] nawf lost connection: disconnect.quitting
2011-01-23 09:55:28 [INFO] nawf [/76.23.232.27:55032] logged in with entity id 1463796
2011-01-23 10:54:32 [INFO] efess [/69.119.7.235:28454] logged in with entity id 1851224
2011-01-23 10:54:35 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-23 10:54:38 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-23 10:55:27 [INFO] <nawf> I filled a mountain back by the base with tnt
2011-01-23 10:55:32 [INFO] <nawf> :D:D:D:D
2011-01-23 10:55:46 [INFO] <nawf> if you get back there let me know and we'll blwo it up
2011-01-23 10:55:59 [INFO] <efess> alright i'm still lost
2011-01-23 10:56:03 [INFO] <efess> so I have to find my way out
2011-01-23 10:56:05 [INFO] <nawf> I'll prob be idling for a while, getting gunpowder, have to do some work today
2011-01-23 10:56:18 [INFO] <nawf> the path I took up was in the middle of the ocean so if you find a tall stream
2011-01-23 10:56:19 [INFO] <efess> yea I have to leave in about an hour
2011-01-23 10:56:20 [INFO] <nawf> thats a way out
2011-01-23 10:56:26 [INFO] <nawf> flowers?
2011-01-23 10:56:31 [INFO] <efess> haha that was yesterday
2011-01-23 10:56:40 [INFO] <efess> you're getting an orange flower
2011-01-23 10:56:47 [INFO] <nawf> lol
2011-01-23 10:56:55 [INFO] <nawf> rofl, thats too mcuh
2011-01-23 10:57:01 [INFO] <efess> too excited?
2011-01-23 10:57:14 [INFO] <nawf> lol, naw, I'm just psyched about being your best man
2011-01-23 10:57:19 [INFO] <efess> :D
2011-01-23 10:57:52 [INFO] <nawf> sent jess this on skype: ""orance flower? that will clash with my eyes wtf?
2011-01-23 10:57:59 [INFO] <efess> haha
2011-01-23 11:02:25 [INFO] <efess> I FOUND IT
2011-01-23 11:04:32 [INFO] <nawf> the weird tower?
2011-01-23 11:04:41 [INFO] <efess> no, I mean the way out
2011-01-23 11:05:09 [INFO] <nawf> oh nice, the stream I dug or the path?
2011-01-23 11:05:22 [INFO] <efess> nah back to the tracks
2011-01-23 11:05:32 [INFO] <nawf> oh wow, I was just screwed
2011-01-23 11:06:12 [INFO] <efess> lol michelle
2011-01-23 11:06:17 [INFO] <nawf> lol
2011-01-23 11:06:31 [INFO] <efess> sooo much cobble
2011-01-23 11:06:36 [INFO] <efess> we need to start on this castle soon
2011-01-23 11:06:45 [INFO] <nawf> I know, lets go blow up the mountain
2011-01-23 11:06:49 [INFO] <efess> k
2011-01-23 11:13:36 [INFO] <efess> leveling this all out?
2011-01-23 11:13:59 [INFO] <nawf> yeah, I don't know if we need to
2011-01-23 11:15:11 [INFO] <nawf> wait where are you?
2011-01-23 11:15:21 [INFO] <efess> fuck
2011-01-23 11:15:25 [INFO] <efess> forgot spiders could climb
2011-01-23 11:15:32 [INFO] <nawf> lol
2011-01-23 11:15:35 [INFO] <efess> ran out of arrows
2011-01-23 11:15:45 [INFO] <nawf> I didn't even see you
2011-01-23 11:16:09 [INFO] <efess> wait
2011-01-23 11:16:14 [INFO] <efess> you didn't see me?
2011-01-23 11:16:16 [INFO] <nawf> naw
2011-01-23 11:16:20 [INFO] <nawf> now I do
2011-01-23 11:16:24 [INFO] <nawf> where you right around me?
2011-01-23 11:16:27 [INFO] <efess> ya
2011-01-23 11:16:32 [INFO] <nawf> lol, ninja mode
2011-01-23 11:17:02 [INFO] <efess> you were waiting for me? lol
2011-01-23 11:17:06 [INFO] <nawf> I figure we should build the casle in this etire valley
2011-01-23 11:17:18 [INFO] <efess> ah you don't want to do it underground?
2011-01-23 11:17:20 [INFO] <nawf> yeah, well should I explore the mountain now or wait until day?
2011-01-23 11:17:34 [INFO] <nawf> well we could explore this entire area
2011-01-23 11:17:37 [INFO] <nawf> explode
2011-01-23 11:17:41 [INFO] <efess> :D
2011-01-23 11:17:43 [INFO] <nawf> make it lol huege
2011-01-23 11:18:00 [INFO] <efess> do it now!
2011-01-23 11:18:06 [INFO] <nawf> here, take my diamond pick axe
2011-01-23 11:18:13 [INFO] <nawf> I will probably die
2011-01-23 11:18:39 [INFO] <nawf> ready?
2011-01-23 11:18:45 [INFO] <efess> ya
2011-01-23 11:18:58 [INFO] <efess> LOL
2011-01-23 11:19:05 [INFO] <efess> TNT was flying everywhere
2011-01-23 11:19:21 [INFO] <nawf> need moar
2011-01-23 11:19:30 [INFO] <nawf> see right ahead there
2011-01-23 11:19:35 [INFO] <nawf> thats where the river is coming up
2011-01-23 11:19:48 [INFO] <nawf> well sorta, if we blow this whole area up it could come anywhere
2011-01-23 11:19:55 [INFO] <efess> right
2011-01-23 11:20:05 [INFO] <efess> hmmm
2011-01-23 11:20:15 [INFO] <efess> they're debating the sunday liquer law
2011-01-23 11:20:25 [INFO] <nawf> cool
2011-01-23 11:20:33 [INFO] <nawf> you gave me the tnt
2011-01-23 11:20:36 [INFO] <nawf> got my pick?
2011-01-23 11:20:51 [INFO] <efess> ya I gave you the tnt
2011-01-23 11:20:53 [INFO] <efess> to blow shit up
2011-01-23 11:21:05 [INFO] <nawf> oh, my plan today is to idle and get a dumb amount of tnt
2011-01-23 11:21:17 [INFO] <efess> nice
2011-01-23 11:21:43 [INFO] <efess> wtf
2011-01-23 11:21:56 [INFO] <efess> this guy is saying ""We don't want to take business away from
2011-01-23 11:21:59 [INFO] <efess> other stores on sunday""
2011-01-23 11:22:31 [INFO] <nawf> lol
2011-01-23 11:22:34 [INFO] <nawf> like tj maxx
2011-01-23 11:22:37 [INFO] <efess> ya
2011-01-23 11:23:13 [INFO] <efess> this guy has no argument
2011-01-23 11:23:18 [INFO] <nawf> so your saying lets blow this area up, build from underground until sky?
2011-01-23 11:23:35 [INFO] <efess> oh no lol not that high
2011-01-23 11:23:40 [INFO] <nawf> oh, ok
2011-01-23 11:23:57 [INFO] <efess> no this is cool
2011-01-23 11:24:22 [INFO] <nawf> well I'll blow up up I mean, it will be cool if it connects to the river, like the castle has an und
2011-01-23 11:24:30 [INFO] <nawf> underground garden
2011-01-23 11:24:40 [INFO] <efess> yea def
2011-01-23 11:28:32 [INFO] <efess> lol hole
2011-01-23 11:29:08 [INFO] <nawf> lol, I fell in your hole
2011-01-23 11:29:12 [INFO] <efess> haha
2011-01-23 11:29:17 [INFO] <efess> trying to find iron
2011-01-23 11:29:32 [INFO] <nawf> there is 16 bars in the base
2011-01-23 11:29:39 [INFO] <efess> nice
2011-01-23 11:29:50 [INFO] <efess> need tons for minecarts/tracks
2011-01-23 11:41:51 [INFO] efess lost connection: disconnect.quitting
2011-01-23 15:51:48 [INFO] nawf lost connection: disconnect.quitting
2011-01-23 15:51:51 [INFO] nawf [/76.23.232.27:55090] logged in with entity id 1953455
2011-01-23 20:34:05 [INFO] efess [/69.119.7.235:29519] logged in with entity id 2071099
2011-01-23 20:53:15 [INFO] nawf lost connection: disconnect.quitting
2011-01-23 21:01:58 [INFO] nawf [/76.23.232.27:55010] logged in with entity id 2132400
2011-01-23 21:02:12 [INFO] <nawf> I'm alive!
2011-01-23 21:02:20 [INFO] <efess> need food?
2011-01-23 21:02:25 [INFO] <nawf> I think I can make it
2011-01-23 21:02:57 [INFO] <nawf> ok, I'm on ice, good to go, thanks
2011-01-23 21:03:01 [INFO] <efess> nice
2011-01-23 21:03:01 [INFO] <nawf> you saved the sand delivery
2011-01-23 21:05:24 [INFO] <nawf> ok, we have enough sand for 448 more tnt
2011-01-23 21:05:32 [INFO] <efess> not enough!
2011-01-23 21:05:54 [INFO] <nawf> that will give us 960 tnt
2011-01-23 21:06:33 [INFO] <nawf> I restocked some arrows too
2011-01-23 21:06:38 [INFO] <efess> ya I saw
2011-01-23 21:06:43 [INFO] <efess> def needed
2011-01-23 21:06:50 [INFO] <efess> i don't even make swords anymore
2011-01-23 21:07:08 [INFO] <nawf> I just use it for killing pigs and cows
2011-01-23 21:08:32 [INFO] <efess> LOL
2011-01-23 21:08:41 [INFO] <efess> i went up the ladder to close the spawner doors
2011-01-23 21:08:50 [INFO] <efess> fuckin creeper drops down while i'm climbing
2011-01-23 21:08:53 [INFO] <efess> oh hai!
2011-01-23 21:09:04 [INFO] <nawf> lol, thats what happened when I tried to show it to b
2011-01-23 21:09:17 [INFO] <nawf> well, similar, mob swarm
2011-01-23 21:10:09 [INFO] <efess> man that thing works too well
2011-01-23 21:10:10 [INFO] <efess> lol
2011-01-23 21:10:17 [INFO] <nawf> did you close it?
2011-01-23 21:10:27 [INFO] <efess> two more creepers
2011-01-23 21:10:29 [INFO] <efess> now a skeleton
2011-01-23 21:10:29 [INFO] <efess> lol
2011-01-23 21:11:19 [INFO] <efess> it is sealed!
2011-01-23 21:11:29 [INFO] <nawf> nice, I already saw a bunch of mobs fall in
2011-01-23 21:11:36 [INFO] <nawf> lol drowned
2011-01-23 21:11:55 [INFO] <nawf> lol, I shot myself
2011-01-23 21:11:58 [INFO] <efess> lol
2011-01-23 21:12:17 [INFO] <efess> this thing never gets old
2011-01-23 21:12:37 [INFO] <nawf> aw yeah, now its working much better, I can tell
2011-01-23 21:12:43 [INFO] <nawf> I've been idling all day
2011-01-23 21:16:57 [INFO] <nawf> lol
2011-01-23 21:19:40 [INFO] <efess> You got any plans for the smooth stone?
2011-01-23 21:20:01 [INFO] <nawf> I need some of it but but I just smelt it just because
2011-01-23 21:20:14 [INFO] <efess> 'cause we can
2011-01-23 21:20:28 [INFO] <nawf> pretty much, I figure we'll need some of it for the cashle
2011-01-23 21:20:32 [INFO] <nawf> err, castle
2011-01-23 21:20:46 [INFO] <nawf> like outside with cobble, make pillars and inside shit with smooth, dunno
2011-01-23 21:20:51 [INFO] <efess> yea
2011-01-23 21:21:39 [INFO] <nawf> thats why I've been collecting coal and trying to just make torches out of charchaol
2011-01-23 21:22:06 [INFO] <efess> can't use charcoal in the furnace?
2011-01-23 21:22:12 [INFO] <nawf> naw
2011-01-23 21:22:23 [INFO] <nawf> but you can get 2-3 pieces of charcoal from one coal
2011-01-23 21:22:29 [INFO] <efess> oh wow
2011-01-23 21:22:38 [INFO] <efess> and wood
2011-01-23 21:22:38 [INFO] <nawf> just have to get the wood
2011-01-23 21:28:46 [INFO] efess lost connection: disconnect.quitting
2011-01-23 21:28:49 [INFO] efess [/69.119.7.235:29866] logged in with entity id 2160736
2011-01-23 21:34:36 [INFO] <nawf> so right up there is where we may have to make a turn in the river
2011-01-23 21:34:45 [INFO] <nawf> dunno yet, depends on the hole we blow up
2011-01-23 21:35:27 [INFO] <nawf> we may have to dismantle the tracks over there too, explode and then recover
2011-01-23 21:35:34 [INFO] <nawf> err, rebuild
2011-01-23 21:35:36 [INFO] <efess> oh yea that's fine
2011-01-23 21:35:40 [INFO] <nawf> cause the tnt will be too close for comfort
2011-01-23 21:35:41 [INFO] <efess> they can be relocated if needed
2011-01-23 21:36:25 [INFO] <nawf> maybe we can make an elevated track following the river
2011-01-23 21:36:36 [INFO] <efess> that would be cool!
2011-01-23 21:36:50 [INFO] <efess> wouldn't be that bad re-routing it
2011-01-23 21:37:20 [INFO] <nawf> prob the worse it making this ceiling safe, haven't really done up and smoothed it out yet
2011-01-23 21:37:24 [INFO] <nawf> mobs come out of nowhere
2011-01-23 21:37:38 [INFO] <efess> yea they drop out of nowhere
2011-01-23 21:38:29 [INFO] <nawf> I spent time out in the lakeish area clearing it out, if a mob took < 5 arrows
2011-01-23 21:38:34 [INFO] <nawf> I knew it fell from above
2011-01-23 21:38:49 [INFO] <efess> true
2011-01-23 21:41:22 [INFO] <efess> lava fall!
2011-01-23 21:41:29 [INFO] <nawf> sweet
2011-01-23 21:53:50 [INFO] <efess> lol
2011-01-23 21:53:58 [INFO] <efess> threw an egg above lava
2011-01-23 21:54:04 [INFO] <efess> hatched
2011-01-23 21:54:06 [INFO] <efess> lol.
2011-01-23 21:54:06 [INFO] <nawf> lol
2011-01-23 21:56:27 [INFO] <nawf> wtf, I cow just died trying to climb up grass
2011-01-23 21:56:31 [INFO] <nawf> *a cow
2011-01-23 21:56:37 [INFO] <efess> I was killing it
2011-01-23 21:56:51 [INFO] <nawf> are you over here?
2011-01-23 21:56:56 [INFO] <efess> i'm right in back of you
2011-01-23 21:57:01 [INFO] <nawf> you're invisible again
2011-01-23 21:57:05 [INFO] <efess> wow
2011-01-23 21:57:06 [INFO] <efess> wtf
2011-01-23 21:57:31 [INFO] nawf lost connection: disconnect.quitting
2011-01-23 21:57:34 [INFO] nawf [/76.23.232.27:55008] logged in with entity id 2189612
2011-01-23 21:57:38 [INFO] <nawf> wow
2011-01-23 21:57:47 [INFO] <efess> good now?
2011-01-23 21:58:01 [INFO] <nawf> yeah
2011-01-23 21:58:59 [INFO] <nawf> I made cake
2011-01-23 21:59:25 [INFO] <efess> wooo
2011-01-23 21:59:33 [INFO] <efess> lol
2011-01-23 21:59:35 [INFO] <nawf> thats pretty cool
2011-01-23 21:59:37 [INFO] <efess> that is
2011-01-23 22:01:09 [INFO] <nawf> just by the sound I can tell removing the entry made a big difference
2011-01-23 22:02:05 [INFO] <nawf> I want some lapis damnit
2011-01-23 22:02:17 [INFO] <nawf> chicken in rave mode
2011-01-23 22:02:34 [INFO] <nawf> lol
2011-01-23 22:02:41 [INFO] <efess> haha
2011-01-23 22:02:46 [INFO] <efess> silly chicken
2011-01-23 22:03:31 [INFO] <efess> chicken was thrown away
2011-01-23 22:03:38 [INFO] <nawf> lol
2011-01-23 22:03:51 [INFO] <nawf> I'm going to resume idling, got some codez I want to write
2011-01-23 22:04:00 [INFO] <nawf> playing around with ravendb
2011-01-23 22:04:02 [INFO] <efess> aight man i'm going to hit the sack
2011-01-23 22:04:07 [INFO] <nawf> later
2011-01-23 22:04:08 [INFO] <efess> yea sweet
2011-01-23 22:04:08 [INFO] <efess> l8r
2011-01-23 22:05:19 [INFO] efess lost connection: disconnect.quitting
2011-01-24 03:01:50 [WARNING] Time ran backwards! Did the system time change?
2011-01-24 16:52:40 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 17:19:28 [INFO] nawf [/76.23.232.27:55200] logged in with entity id 2321949
2011-01-24 17:31:14 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 17:33:13 [INFO] nawf [/76.23.232.27:55062] logged in with entity id 2342984
2011-01-24 17:36:09 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 17:52:29 [INFO] nawf [/76.23.232.27:55086] logged in with entity id 2344689
2011-01-24 18:04:51 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 18:08:14 [INFO] efess [/69.119.7.235:30811] logged in with entity id 2354396
2011-01-24 18:09:44 [INFO] nawf [/76.23.232.27:55064] logged in with entity id 2354892
2011-01-24 18:29:45 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 18:41:37 [INFO] nawf [/76.23.232.27:55086] logged in with entity id 2392254
2011-01-24 18:41:38 [INFO] <efess> yo
2011-01-24 18:41:41 [INFO] <nawf> yo
2011-01-24 18:41:51 [INFO] <efess> hammer time
2011-01-24 18:42:03 [INFO] <nawf> are you at the spawner base?  if so can you bring arrows?
2011-01-24 18:42:07 [INFO] <efess> ya
2011-01-24 18:45:13 [INFO] <efess> oh did you modify the booster at the base?
2011-01-24 18:45:19 [INFO] <nawf> nope
2011-01-24 18:45:26 [INFO] <efess> there's no more booster carts
2011-01-24 18:45:33 [INFO] <nawf> uh...
2011-01-24 18:45:57 [INFO] <nawf> I didn't do anything, there was a cart stuck so I just pushed it along
2011-01-24 18:46:06 [INFO] <efess> weird
2011-01-24 18:49:22 [INFO] <efess> where you at?
2011-01-24 18:49:28 [INFO] <nawf> main base
2011-01-24 18:49:36 [INFO] <nawf> over in the destroyed mountain shell
2011-01-24 18:50:25 [INFO] <nawf> we can do this later, lets blow shit up
2011-01-24 18:51:57 [INFO] <efess> your inventory full of tnt? :P
2011-01-24 18:52:03 [INFO] <nawf> naw, just some
2011-01-24 18:52:14 [INFO] <nawf> well only 60, I l eft the rest in the base
2011-01-24 18:53:39 [INFO] <nawf> I'm safe underground if you want to hit that
2011-01-24 18:53:45 [INFO] <efess> i'd hit that
2011-01-24 18:54:02 [INFO] <efess> oh shit
2011-01-24 18:54:03 [INFO] <efess> boom!
2011-01-24 18:54:34 [INFO] <nawf> holy shit, so close to the tracks
2011-01-24 18:56:04 [INFO] <nawf> fill the moats?
2011-01-24 18:56:11 [INFO] <nawf> did you grab tnt?
2011-01-24 18:56:28 [INFO] <nawf> poor pig
2011-01-24 18:56:44 [INFO] <efess> oh yea the chest
2011-01-24 18:56:45 [INFO] <efess> llol
2011-01-24 18:58:21 [INFO] <efess> so we're blasting out for a foundation?
2011-01-24 18:58:33 [INFO] <efess> what's your vision here
2011-01-24 18:58:38 [INFO] <nawf> yeah, I thought we wanted to go deeper
2011-01-24 18:58:59 [INFO] <efess> not too deep if its above ground
2011-01-24 18:59:02 [INFO] <nawf> rue
2011-01-24 18:59:05 [INFO] <nawf> true
2011-01-24 18:59:09 [INFO] <efess> I think this is perfect
2011-01-24 18:59:16 [INFO] <nawf> well my biggest goal would be to link up with the river
2011-01-24 18:59:19 [INFO] <nawf> the underground one
2011-01-24 18:59:21 [INFO] <efess> ya
2011-01-24 18:59:45 [INFO] <efess> you'll need a waterfall
2011-01-24 19:00:16 [INFO] <nawf> yeah, I can blast that out, I just need to know where in the casle to link it up
2011-01-24 19:00:35 [INFO] <efess> cool
2011-01-24 19:01:17 [INFO] <nawf> so maybe after that moat explosion just keep it level up here?
2011-01-24 19:01:26 [INFO] <efess> yea
2011-01-24 19:01:28 [INFO] <nawf> ok
2011-01-24 19:01:38 [INFO] <nawf> ready?
2011-01-24 19:01:40 [INFO] <efess> ya!
2011-01-24 19:01:53 [INFO] <efess> lolz.
2011-01-24 19:04:52 [INFO] <nawf> fire in the hole!
2011-01-24 19:05:12 [INFO] <nawf> wtf
2011-01-24 19:05:13 [INFO] <efess> lol
2011-01-24 19:05:17 [INFO] <nawf> was that you?
2011-01-24 19:05:18 [INFO] <efess> ya
2011-01-24 19:05:25 [INFO] <nawf> oh, lol, I thought there was a tnt chain someplace
2011-01-24 19:05:28 [INFO] <efess> ya haha
2011-01-24 19:05:30 [INFO] <nawf> I forgot about or something
2011-01-24 19:06:39 [INFO] <nawf> fuck
2011-01-24 19:06:46 [INFO] <efess> fall?
2011-01-24 19:06:51 [INFO] <nawf> yeah, and zombie
2011-01-24 19:07:57 [INFO] <efess> oops
2011-01-24 19:14:10 [INFO] <nawf> I'm trapped, too far our to make it back to base
2011-01-24 19:14:46 [INFO] <nawf> I think the waterfall will start right at the edge of were the destroyed mountain is
2011-01-24 19:15:16 [INFO] <efess> k
2011-01-24 19:16:28 [INFO] <nawf> and I think we can link that up to the pit that goes opposite of the railstation
2011-01-24 19:16:40 [INFO] <nawf> well with enough tnt we can do anything really
2011-01-24 19:16:41 [INFO] <nawf> :D
2011-01-24 19:21:12 [INFO] <nawf> lol
2011-01-24 19:21:19 [INFO] <efess> fire in the hole!
2011-01-24 19:23:02 [INFO] <nawf> lit wheat farm on fire?
2011-01-24 19:23:06 [INFO] <nawf> lite
2011-01-24 19:23:10 [INFO] <efess> hehe
2011-01-24 19:24:12 [INFO] <efess> lol
2011-01-24 19:25:24 [INFO] <efess> wooo
2011-01-24 19:27:39 [INFO] <efess> mmm terraforming
2011-01-24 19:30:55 [INFO] <nawf> need anything from the spawner base?
2011-01-24 19:30:58 [INFO] <efess> arrows
2011-01-24 19:31:00 [INFO] <efess> lol
2011-01-24 19:31:07 [INFO] <nawf> I blew a hole, can't go back up it, too dangerous
2011-01-24 19:34:41 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 19:36:13 [INFO] nawf [/76.23.232.27:55041] logged in with entity id 2493718
2011-01-24 19:36:26 [INFO] <efess> dude
2011-01-24 19:36:31 [INFO] <nawf> dude
2011-01-24 19:36:32 [INFO] <efess> i'm drinking pot flavored coffee
2011-01-24 19:36:36 [INFO] <nawf> rofl
2011-01-24 19:36:48 [INFO] <efess> thc + caffine? hmmmm
2011-01-24 19:36:57 [INFO] <efess> she threw the package away
2011-01-24 19:37:01 [INFO] <efess> I don't even know what kind it is
2011-01-24 19:37:12 [INFO] <nawf> hold in the ground
2011-01-24 19:37:14 [INFO] <nawf> hole
2011-01-24 19:37:21 [INFO] <efess> i need that hole for other shit?
2011-01-24 19:37:30 [INFO] <nawf> gj on the burning logic notch
2011-01-24 19:39:06 [INFO] <efess> fkn mobs
2011-01-24 19:39:46 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 19:39:48 [INFO] nawf [/76.23.232.27:55040] logged in with entity id 2497034
2011-01-24 19:40:01 [INFO] <nawf> I think you are invisible again
2011-01-24 19:40:14 [INFO] <efess> im behind you
2011-01-24 19:40:48 [INFO] <efess> that pillar going to be a corner?
2011-01-24 19:40:58 [INFO] <nawf> naw, I was just farting around
2011-01-24 19:41:02 [INFO] <efess> k
2011-01-24 19:48:35 [INFO] <efess> lol
2011-01-24 19:48:40 [INFO] <efess> perfect tnt
2011-01-24 19:50:43 [INFO] <efess> that was 900 tnt?
2011-01-24 19:50:44 [INFO] <efess> :P
2011-01-24 19:50:48 [INFO] <nawf> right
2011-01-24 19:50:51 [INFO] <nawf> goes so quick
2011-01-24 19:50:54 [INFO] <efess> no shit!
2011-01-24 19:56:59 [INFO] <nawf> I have two left
2011-01-24 19:57:07 [INFO] <efess> I used all mine
2011-01-24 20:10:36 [INFO] <nawf> shit got messed up
2011-01-24 20:10:44 [INFO] <efess> oh not here
2011-01-24 20:10:52 [INFO] <efess> the cart wasn't going back on the track
2011-01-24 20:10:57 [INFO] <efess> if it wasn't able to push you
2011-01-24 20:11:01 [INFO] <efess> pissing me off
2011-01-24 20:11:29 [INFO] <nawf> man, we fucked a lot of shit up
2011-01-24 20:11:38 [INFO] <nawf> did you look at the future waterfall hole?
2011-01-24 20:11:44 [INFO] <efess> nah
2011-01-24 20:12:05 [INFO] <nawf> its all sloped so I'm going to have to fix that somehow
2011-01-24 20:12:16 [INFO] <nawf> but I'm going to go for a while, got some codez to write
2011-01-24 20:12:22 [INFO] <efess> aight
2011-01-24 20:12:26 [INFO] <nawf> ttyl
2011-01-24 20:12:30 [INFO] <efess> l8r man
2011-01-24 20:12:39 [INFO] <nawf> oh, I should mention, I'm prob going to philly for two months
2011-01-24 20:12:46 [INFO] <efess> oh no shit
2011-01-24 20:12:47 [INFO] <efess> when?
2011-01-24 20:12:51 [INFO] <nawf> in 3 weeks
2011-01-24 20:12:58 [INFO] <efess> nice. what's there?
2011-01-24 20:13:22 [INFO] <nawf> yellow book, doing analysis shit so not much code but it will be a cool change of pace
2011-01-24 20:13:34 [INFO] <efess> nice they putting you up down there?
2011-01-24 20:13:45 [INFO] <nawf> I guess they want to replace salesforce
2011-01-24 20:14:01 [INFO] <nawf> yeah, hotel, meals paid, travel abck and forth if I want to come back, boss is working out the detai
2011-01-24 20:14:09 [INFO] <efess> nice
2011-01-24 20:14:18 [INFO] <efess> good deal
2011-01-24 20:14:27 [INFO] <nawf> yeah, do something different
2011-01-24 20:14:30 [INFO] <efess> you'll get sick of hotel life
2011-01-24 20:14:43 [INFO] <nawf> yeah, I'll prob come home on the weekends though
2011-01-24 20:14:58 [INFO] <nawf> I'll get paid per mile
2011-01-24 20:15:01 [INFO] <nawf> you know how it is
2011-01-24 20:15:04 [INFO] <efess> yea
2011-01-24 20:15:14 [INFO] <efess> it's cool they think all that's worth it
2011-01-24 20:15:40 [INFO] <nawf> yeah, well the entire goal is to make it seem like whatever they want to do is feasible
2011-01-24 20:15:44 [INFO] <nawf> as long as they pay us more money
2011-01-24 20:15:46 [INFO] <efess> lol
2011-01-24 20:15:52 [INFO] <efess> that could get ugly
2011-01-24 20:15:56 [INFO] <nawf> and the boss says he trusts me a lot
2011-01-24 20:16:04 [INFO] <nawf> I'm good at this type of shit I think
2011-01-24 20:16:28 [INFO] <nawf> anyway, I'll ttyl l8r
2011-01-24 20:16:30 [INFO] <efess> well good luck
2011-01-24 20:16:32 [INFO] <efess> l8r
2011-01-24 20:16:34 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 20:20:31 [INFO] efess lost connection: disconnect.quitting
2011-01-24 20:23:14 [INFO] efess [/69.119.7.235:31686] logged in with entity id 2559782
2011-01-24 22:10:31 [INFO] nawf [/76.23.232.27:55065] logged in with entity id 2630813
2011-01-24 22:11:20 [INFO] nawf lost connection: disconnect.quitting
2011-01-24 22:16:10 [INFO] AngryRhetoric [/24.147.183.4:60259] logged in with entity id 2633981
2011-01-24 22:16:18 [INFO] <AngryRhetoric> whats up
2011-01-24 22:22:47 [INFO] efess lost connection: disconnect.quitting
2011-01-24 23:07:29 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-24 23:08:40 [INFO] nawf [/76.23.232.27:55061] logged in with entity id 2672633
2011-01-24 23:11:45 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 09:29:07 [INFO] nawf [/76.23.232.27:55147] logged in with entity id 2679569
2011-01-25 11:31:20 [INFO] nawf lost connection: disconnect.genericReason
2011-01-25 14:17:30 [INFO] nawf [/76.23.232.27:55033] logged in with entity id 2721792
2011-01-25 17:30:19 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 17:34:48 [INFO] nawf [/76.23.232.27:55133] logged in with entity id 2782109
2011-01-25 18:25:11 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 18:53:43 [INFO] nawf [/76.23.232.27:55172] logged in with entity id 2827479
2011-01-25 19:27:13 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 19:43:34 [INFO] nawf [/76.23.232.27:55017] logged in with entity id 2862717
2011-01-25 19:53:09 [INFO] <nawf> twwww
2011-01-25 20:45:19 [INFO] AngryRhetoric [/24.147.183.4:55794] logged in with entity id 2883652
2011-01-25 20:45:33 [INFO] <AngryRhetoric> yo!
2011-01-25 21:29:49 [INFO] <AngryRhetoric> sucka!!
2011-01-25 21:30:00 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-25 22:07:57 [INFO] efess [/69.119.7.235:38069] logged in with entity id 2910427
2011-01-25 22:08:12 [INFO] <nawf> wtf
2011-01-25 22:08:27 [INFO] <nawf> did I get teleported over here?
2011-01-25 22:08:31 [INFO] <efess> huh?
2011-01-25 22:08:32 [INFO] <nawf> I was idling
2011-01-25 22:08:40 [INFO] <efess> lol
2011-01-25 22:08:54 [INFO] <efess> maybe when I joined
2011-01-25 22:08:57 [INFO] <efess> I was in your space
2011-01-25 22:10:08 [INFO] efess lost connection: disconnect.quitting
2011-01-25 22:12:18 [INFO] <nawf> brb, I was just going to start playing a little
2011-01-25 22:15:27 [INFO] <nawf> I almost have the waterfall finished
2011-01-25 22:15:41 [INFO] <nawf> saw your tracks, those are cool
2011-01-25 22:17:46 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 22:18:09 [INFO] nawf [/76.23.232.27:55276] logged in with entity id 2915672
2011-01-25 22:58:50 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 23:04:34 [INFO] nawf [/76.23.232.27:55009] logged in with entity id 2957622
2011-01-25 23:13:13 [INFO] nawf lost connection: disconnect.quitting
2011-01-25 23:53:47 [INFO] nawf [/76.23.232.27:55005] logged in with entity id 2975398
2011-01-26 00:08:24 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 16:30:07 [INFO] nawf [/76.23.232.27:55022] logged in with entity id 2999066
2011-01-26 16:44:52 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 16:45:29 [INFO] nawf [/76.23.232.27:55069] logged in with entity id 3014660
2011-01-26 17:31:28 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 17:31:31 [INFO] nawf [/76.23.232.27:55069] logged in with entity id 3360766
2011-01-26 17:35:31 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 17:55:29 [INFO] nawf [/76.23.232.27:55250] logged in with entity id 3363459
2011-01-26 18:54:31 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 19:00:20 [INFO] nawf [/76.23.232.27:55134] logged in with entity id 3444933
2011-01-26 19:05:18 [INFO] efess [/69.119.7.235:39584] logged in with entity id 3447378
2011-01-26 19:05:26 [INFO] <efess> you damn idler
2011-01-26 19:09:22 [INFO] <nawf> need moar gunpowder
2011-01-26 19:12:01 [WARNING] nawf moved wrongly!
2011-01-26 19:18:36 [INFO] <efess> you been idling all day?
2011-01-26 19:18:40 [INFO] <nawf> naw
2011-01-26 19:20:18 [INFO] <nawf> been farting about outside the main base since after work
2011-01-26 19:20:21 [INFO] <nawf> but only at night
2011-01-26 19:20:31 [INFO] <nawf> err, only during the day
2011-01-26 19:20:34 [INFO] <nawf> at night I code
2011-01-26 19:21:47 [INFO] <nawf> there is tnt in the misc chest
2011-01-26 19:21:52 [INFO] <nawf> I think we have about 240
2011-01-26 19:24:30 [INFO] <efess> still problems with idling
2011-01-26 19:24:40 [INFO] <efess> ?
2011-01-26 19:24:48 [INFO] <nawf> yeah, you have to move around or the drops stop
2011-01-26 19:29:43 [INFO] <efess> need anything from the vault?
2011-01-26 19:29:48 [INFO] <nawf> nope
2011-01-26 19:31:42 [INFO] <efess> c'mon boosters wtf
2011-01-26 19:31:59 [INFO] <efess> lol
2011-01-26 19:32:11 [INFO] <efess> lame
2011-01-26 19:32:22 [INFO] <nawf> lame booster is lame
2011-01-26 19:34:38 [INFO] <efess> kamikaze shrubs!
2011-01-26 19:34:39 [INFO] <nawf> so is this the castle wall line here?
2011-01-26 19:34:42 [INFO] <nawf> rofl
2011-01-26 19:35:05 [INFO] <efess> hmm
2011-01-26 19:35:27 [INFO] <efess> well this mountain was destroyed...
2011-01-26 19:35:30 [INFO] <nawf> cause I was going to even out this field unless we want to blow it up more
2011-01-26 19:35:46 [INFO] <efess> I say we make it out to here
2011-01-26 19:35:59 [INFO] <efess> ya here
2011-01-26 19:36:05 [INFO] <nawf> to blow this area up too?
2011-01-26 19:36:13 [INFO] <nawf> or is this the above ground casle?
2011-01-26 19:36:19 [INFO] <nawf> then I won't fill it with dirt
2011-01-26 19:36:49 [INFO] <efess> hold on talking centerpieces
2011-01-26 19:37:11 [INFO] <nawf> thats boring, lets talk about strippers
2011-01-26 19:37:46 [INFO] <efess> lulz.
2011-01-26 19:37:50 [INFO] <efess> yes!
2011-01-26 19:37:55 [INFO] <efess> LOL
2011-01-26 19:37:57 [INFO] <efess> LOL
2011-01-26 19:37:58 [INFO] <nawf> wtf
2011-01-26 19:37:58 [INFO] <efess> n1
2011-01-26 19:38:53 [INFO] <efess> got your back bro
2011-01-26 19:39:23 [INFO] <nawf> why didn't the tnt fall damnit
2011-01-26 19:39:26 [INFO] <efess> I donno
2011-01-26 19:39:41 [INFO] <nawf> I was thinking ""oh thats just a glitch it will explode down there""
2011-01-26 19:40:11 [INFO] <efess> so yea the whole thing will be the castle
2011-01-26 19:40:20 [INFO] <nawf> so we need to blow this part up?
2011-01-26 19:40:30 [INFO] <efess> we can, but we don't have to
2011-01-26 19:40:35 [INFO] <efess> it will be the basement right?
2011-01-26 19:40:43 [INFO] <efess> er dungeon or w/e
2011-01-26 19:41:09 [INFO] <efess> but it doesn't have to take up the entire area
2011-01-26 19:41:11 [INFO] <nawf> yeah, I mean we could, we already have a big basement though
2011-01-26 19:45:12 [INFO] <nawf> I forgot, there is a huge cavern under here too
2011-01-26 19:45:54 [INFO] <nawf> nvm, we already blew that up
2011-01-26 19:47:38 [INFO] <nawf> dayum
2011-01-26 19:48:08 [INFO] <efess> what do you think?
2011-01-26 19:48:17 [INFO] <nawf> yeah, that will be awesome
2011-01-26 19:49:38 [INFO] <efess> oh your river is done?
2011-01-26 19:49:52 [INFO] <nawf> sorta, needs some touches but it flows all the way
2011-01-26 19:49:56 [INFO] <efess> nice
2011-01-26 19:49:59 [INFO] <nawf> had to take a break from it
2011-01-26 19:50:27 [INFO] <efess> big enough? :D
2011-01-26 19:50:54 [INFO] <nawf> we should put a tower here so you can see kevins castle and vice versa
2011-01-26 19:51:01 [INFO] <nawf> and the spawner
2011-01-26 19:51:08 [INFO] <nawf> like maybe just a wall and a path to a big tower
2011-01-26 19:51:20 [INFO] <efess> k
2011-01-26 19:53:12 [INFO] <efess> can a boat go up it though?
2011-01-26 19:53:33 [INFO] <nawf> probably but it will be a pain, I have to make a water ladder but need to know where to make it firs
2011-01-26 19:53:39 [INFO] <efess> ya
2011-01-26 19:53:39 [INFO] <nawf> need castle then water ladder
2011-01-26 19:54:50 [INFO] <nawf> kamakazi shrubs want hugs
2011-01-26 19:54:55 [INFO] <efess> lol
2011-01-26 19:55:07 [INFO] <nawf> brb
2011-01-26 19:55:10 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 20:04:40 [INFO] nawf [/76.23.232.27:55067] logged in with entity id 3524997
2011-01-26 20:06:39 [INFO] <efess> need more tnt, i'll idle for a bit
2011-01-26 20:07:00 [INFO] <nawf> more than the 240 in the misc chest?
2011-01-26 20:07:04 [INFO] <efess> ya
2011-01-26 20:07:06 [INFO] <nawf> I have no plans for that
2011-01-26 20:07:11 [INFO] <efess> blow shit up.
2011-01-26 20:07:19 [INFO] <efess> polish out the ""dungeon""
2011-01-26 20:07:39 [INFO] <efess> got some intergis bs to do
2011-01-26 20:07:56 [INFO] <efess> adam re-wrote the CR server, now I got assigned a bug for it
2011-01-26 20:07:58 [INFO] <efess> :\
2011-01-26 20:08:08 [INFO] <nawf> lol
2011-01-26 20:11:18 [INFO] <nawf> I'm going to bounce in and out too, want to do some work, cleaning to do
2011-01-26 20:11:34 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 21:09:24 [INFO] nawf [/76.23.232.27:55104] logged in with entity id 3554229
2011-01-26 21:31:02 [INFO] nawf lost connection: disconnect.genericReason
2011-01-26 21:31:03 [INFO] efess lost connection: disconnect.genericReason
2011-01-26 21:31:11 [INFO] nawf [/76.23.232.27:55024] logged in with entity id 3581440
2011-01-26 21:31:47 [INFO] efess [/69.119.7.235:41338] logged in with entity id 3581841
2011-01-26 21:32:04 [INFO] <nawf> server down
2011-01-26 21:32:06 [INFO] <efess> heh
2011-01-26 21:33:14 [INFO] <nawf> saw you walking almost beneath me
2011-01-26 21:33:18 [INFO] <efess> ya
2011-01-26 21:33:23 [INFO] <efess> i'm by your river
2011-01-26 21:33:28 [INFO] <efess> planning the minecart track
2011-01-26 21:33:58 [INFO] <efess> but I'm going to stop, will probably need to run it to the castle
2011-01-26 21:34:18 [INFO] <nawf> heck yeah
2011-01-26 22:00:41 [INFO] <nawf> mother fucker
2011-01-26 22:00:49 [INFO] <efess> ?
2011-01-26 22:01:04 [INFO] <nawf> skeleton shot a creeper, creeper aggros blew up some tower
2011-01-26 22:01:08 [INFO] <efess> lol
2011-01-26 22:01:51 [INFO] <efess> that was fkn weird
2011-01-26 22:02:18 [INFO] <nawf> lots o lag
2011-01-26 22:31:51 [INFO] <efess> don't jump!
2011-01-26 22:32:47 [INFO] <nawf> fck
2011-01-26 22:32:54 [INFO] <efess> lol
2011-01-26 22:32:58 [INFO] <efess> told you not to
2011-01-26 22:33:06 [INFO] <nawf> if you land in the water its ok
2011-01-26 22:33:10 [INFO] <efess> heh
2011-01-26 22:34:16 [INFO] <efess> well gtg
2011-01-26 22:34:28 [INFO] <efess> night dude
2011-01-26 22:34:32 [INFO] <nawf> aight, I'll prob mess aroudn with the tower some more
2011-01-26 22:34:34 [INFO] <nawf> later
2011-01-26 22:34:37 [INFO] <efess> nice
2011-01-26 22:34:40 [INFO] <efess> it looks cool
2011-01-26 22:34:48 [INFO] <efess> this will be sweet
2011-01-26 22:34:52 [INFO] <efess> lot of work
2011-01-26 22:35:01 [INFO] <nawf> heh, yeah
2011-01-26 22:35:08 [INFO] <nawf> I want to make it so it glowes without seeing torches
2011-01-26 22:35:11 [INFO] <nawf> that will be awesome
2011-01-26 22:35:16 [INFO] <efess> yea
2011-01-26 22:35:22 [INFO] <efess> nice good idea
2011-01-26 22:35:25 [INFO] efess lost connection: disconnect.quitting
2011-01-26 22:51:14 [INFO] nawf lost connection: disconnect.quitting
2011-01-26 22:57:58 [INFO] nawf [/76.23.232.27:55038] logged in with entity id 3769468
2011-01-26 23:14:03 [INFO] nawf lost connection: disconnect.quitting
2011-01-27 00:19:05 [INFO] nawf [/76.23.232.27:55096] logged in with entity id 3786580
2011-01-27 00:21:48 [INFO] nawf lost connection: disconnect.quitting
2011-01-27 05:59:04 [INFO] efess [/69.119.7.235:42322] logged in with entity id 3789079
2011-01-27 07:52:32 [INFO] efess lost connection: disconnect.quitting
2011-01-27 07:52:34 [INFO] efess [/69.119.7.235:43755] logged in with entity id 3830363
2011-01-27 09:47:06 [INFO] nawf [/76.23.232.27:55131] logged in with entity id 3896179
2011-01-27 10:08:42 [INFO] nawf lost connection: disconnect.genericReason
2011-01-27 14:45:28 [INFO] nawf [/76.23.232.27:55092] logged in with entity id 3956171
2011-01-27 14:46:52 [INFO] nawf lost connection: disconnect.quitting
2011-01-27 16:10:11 [INFO] nawf [/76.23.232.27:55332] logged in with entity id 3973651
2011-01-27 16:10:42 [INFO] <efess> wooo
2011-01-27 16:10:44 [INFO] <efess> feathers!
2011-01-27 16:11:11 [INFO] <nawf> yesssss sulfer
2011-01-27 16:11:23 [INFO] <efess> enough?
2011-01-27 16:11:43 [INFO] <nawf> thats only 8 stacks of tnt
2011-01-27 16:11:45 [INFO] <nawf> in the chest
2011-01-27 16:11:52 [INFO] <efess> never enough!
2011-01-27 16:12:05 [INFO] <efess> no 10
2011-01-27 16:12:18 [INFO] <efess> 4 for tnt
2011-01-27 16:12:21 [INFO] <efess> right?
2011-01-27 16:12:21 [INFO] <nawf> 5
2011-01-27 16:12:27 [INFO] <efess> I thought 5 was sand
2011-01-27 16:12:27 [INFO] <nawf> 4sand
2011-01-27 16:13:00 [INFO] <efess> ah
2011-01-27 16:13:07 [INFO] <efess> well there's another in here
2011-01-27 16:13:08 [INFO] <efess> lol
2011-01-27 16:14:12 [INFO] <efess> just finishing up some work
2011-01-27 16:14:35 [INFO] <nawf> taking a break myself
2011-01-27 16:14:38 [INFO] <nawf> need to get some cleaning done
2011-01-27 16:15:02 [INFO] <efess> yea this place is a mess
2011-01-27 16:15:14 [INFO] <efess> irregular rocks, random missing blocks
2011-01-27 16:15:42 [INFO] <efess> i'd be ashamed if we invited someone over for cooked porkchops
2011-01-27 16:55:14 [INFO] <efess> excellent..
2011-01-27 16:59:55 [INFO] nawf lost connection: disconnect.quitting
2011-01-27 17:46:04 [INFO] nawf [/76.23.232.27:55158] logged in with entity id 4056854
2011-01-27 17:52:23 [INFO] <efess> splunkin
2011-01-27 17:52:42 [INFO] <nawf> I didn't even know you were still here lol
2011-01-27 17:55:21 [INFO] <efess> getting low on diamond, trying to find more
2011-01-27 17:55:37 [INFO] <efess> and we're never going to have enough cobblestone
2011-01-27 17:55:38 [INFO] <efess> lol
2011-01-27 17:55:52 [INFO] <nawf> yeah, I wanted to go lapis hunting and spulinking after finishing this tower
2011-01-27 17:56:06 [INFO] <efess> funny we don't have any use for it
2011-01-27 17:56:08 [INFO] <efess> just want it
2011-01-27 17:56:08 [INFO] <efess> :P
2011-01-27 17:56:15 [INFO] <nawf> its so blue!
2011-01-27 17:56:17 [INFO] <efess> !
2011-01-27 17:56:27 [INFO] <nawf> then we can make purple shit!
2011-01-27 17:56:30 [INFO] <nawf> fucking purple
2011-01-27 17:56:37 [INFO] <efess> a giant purple cock + balls?
2011-01-27 17:56:44 [INFO] <nawf> with a gold ring
2011-01-27 17:56:49 [INFO] <efess> !
2011-01-27 17:58:19 [INFO] efess lost connection: disconnect.quitting
2011-01-27 17:58:22 [INFO] efess [/69.119.7.235:55319] logged in with entity id 4073260
2011-01-27 18:04:45 [INFO] nawf lost connection: disconnect.quitting
2011-01-27 18:10:05 [INFO] nawf [/76.23.232.27:55030] logged in with entity id 4087799
2011-01-27 18:10:11 [INFO] <nawf> bleck
2011-01-27 18:10:18 [INFO] <efess> black!
2011-01-27 18:10:21 [INFO] <nawf> I love this cabernet from Wente vineyards
2011-01-27 18:10:26 [INFO] <nawf> so I hadthe guy order some
2011-01-27 18:10:30 [INFO] <nawf> backordered
2011-01-27 18:10:39 [INFO] <efess> never heard of it
2011-01-27 18:10:52 [INFO] <nawf> so I bought their less expensive cabernet
2011-01-27 18:10:56 [INFO] <nawf> its bleck
2011-01-27 18:11:07 [INFO] <nawf> this is an impressive hole we have here
2011-01-27 18:11:18 [INFO] <efess> at the base?
2011-01-27 18:11:22 [INFO] <nawf> yeah
2011-01-27 18:11:27 [INFO] <efess> yea its almsot flat
2011-01-27 18:23:20 [INFO] efess lost connection: disconnect.quitting
2011-01-27 18:36:02 [INFO] <nawf> you suck
2011-01-27 18:36:18 [INFO] nawf lost connection: disconnect.quitting
2011-01-27 23:05:28 [INFO] nawf [/76.23.232.27:55008] logged in with entity id 4125791
2011-01-27 23:26:07 [INFO] nawf lost connection: disconnect.quitting
2011-01-28 09:29:04 [INFO] nawf [/76.23.232.27:55248] logged in with entity id 4149402
2011-01-28 09:30:59 [INFO] nawf lost connection: disconnect.genericReason
2011-01-28 10:04:17 [INFO] redux06790 [/69.119.8.191:49397] logged in with entity id 4152450
2011-01-28 10:04:28 [INFO] <redux06790> John!
2011-01-28 10:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-28 10:51:12 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-28 18:40:04 [INFO] efess [/69.119.7.235:56588] logged in with entity id 4224903
2011-01-28 19:21:51 [INFO] efess lost connection: disconnect.quitting
2011-01-28 19:21:53 [INFO] /69.119.7.235:58618 lost connection
2011-01-28 19:22:19 [INFO] /69.119.7.235:58631 lost connection
2011-01-28 19:22:25 [INFO] /69.119.7.235:58648 lost connection
2011-01-28 19:22:34 [INFO] /69.119.7.235:58657 lost connection
2011-01-28 19:22:40 [INFO] /69.119.7.235:58661 lost connection
2011-01-28 19:23:19 [INFO] Disconnecting /192.168.0.198:58669: Took too long to log in
2011-01-28 19:24:50 [INFO] /192.168.0.198:58710 lost connection
2011-01-28 19:25:44 [INFO] efess [/192.168.0.198:58746] logged in with entity id 4255598
2011-01-28 20:14:13 [INFO] Starting minecraft server version Beta 1.2_01
2011-01-28 20:14:13 [INFO] Loading properties
2011-01-28 20:14:13 [INFO] Starting Minecraft server on *:25565
2011-01-28 20:14:14 [INFO] Preparing level ""world""
2011-01-28 20:14:14 [INFO] Preparing start region
2011-01-28 20:14:15 [INFO] Preparing spawn area: 3%
2011-01-28 20:14:16 [INFO] Preparing spawn area: 8%
2011-01-28 20:14:17 [INFO] Preparing spawn area: 12%
2011-01-28 20:14:18 [INFO] Preparing spawn area: 16%
2011-01-28 20:14:19 [INFO] Preparing spawn area: 20%
2011-01-28 20:14:20 [INFO] Preparing spawn area: 24%
2011-01-28 20:14:21 [INFO] Preparing spawn area: 28%
2011-01-28 20:14:22 [INFO] Preparing spawn area: 28%
2011-01-28 20:14:24 [INFO] Preparing spawn area: 32%
2011-01-28 20:14:25 [INFO] Preparing spawn area: 36%
2011-01-28 20:14:26 [INFO] Preparing spawn area: 40%
2011-01-28 20:14:27 [INFO] Preparing spawn area: 44%
2011-01-28 20:14:28 [INFO] Preparing spawn area: 48%
2011-01-28 20:14:29 [INFO] Preparing spawn area: 52%
2011-01-28 20:14:30 [INFO] Preparing spawn area: 57%
2011-01-28 20:14:31 [INFO] Preparing spawn area: 61%
2011-01-28 20:14:32 [INFO] Preparing spawn area: 65%
2011-01-28 20:14:33 [INFO] Preparing spawn area: 73%
2011-01-28 20:14:34 [INFO] Preparing spawn area: 77%
2011-01-28 20:14:35 [INFO] Preparing spawn area: 81%
2011-01-28 20:14:36 [INFO] Preparing spawn area: 85%
2011-01-28 20:14:37 [INFO] Preparing spawn area: 93%
2011-01-28 20:14:38 [INFO] Preparing spawn area: 97%
2011-01-28 20:14:38 [INFO] Done! For help, type ""help"" or ""?""
2011-01-28 20:48:15 [INFO] efess [/192.168.0.198:60655] logged in with entity id 71
2011-01-28 21:37:26 [INFO] efess lost connection: disconnect.quitting
2011-01-28 21:37:41 [INFO] efess [/192.168.0.198:61989] logged in with entity id 52183
2011-01-28 21:40:26 [INFO] efess lost connection: disconnect.quitting
2011-01-29 10:20:47 [INFO] Disconnecting /76.23.232.27:55140: Took too long to log in
2011-01-29 10:20:58 [INFO] /76.23.232.27:55030 lost connection
2011-01-29 10:21:03 [INFO] /76.23.232.27:55004 lost connection
2011-01-29 10:21:34 [INFO] nawf [/76.23.232.27:55032] logged in with entity id 54009
2011-01-29 10:36:26 [INFO] nawf lost connection: disconnect.quitting
2011-01-29 10:41:01 [INFO] redux06790 [/69.119.8.191:49324] logged in with entity id 80019
2011-01-29 10:41:11 [INFO] <redux06790> Marco!
2011-01-29 10:41:53 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-29 10:42:05 [INFO] redux06790 [/69.119.8.191:49329] lost connection
2011-01-29 10:42:10 [INFO] redux06790 [/69.119.8.191:49332] logged in with entity id 80596
2011-01-29 10:43:35 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-29 11:39:50 [INFO] Disconnecting nawf [/76.23.232.27:55025]: Took too long to log in
2011-01-29 11:39:56 [INFO] /76.23.232.27:55014 lost connection
2011-01-29 11:40:08 [INFO] /76.23.232.27:55009 lost connection
2011-01-29 11:40:22 [INFO] /76.23.232.27:55009 lost connection
2011-01-29 11:41:13 [INFO] Disconnecting /76.23.232.27:55014: Took too long to log in
2011-01-29 11:41:49 [INFO] nawf [/76.23.232.27:55013] logged in with entity id 85724
2011-01-29 12:12:03 [INFO] nawf lost connection: disconnect.quitting
2011-01-29 15:19:39 [INFO] AngryRhetoric [/24.147.183.4:56374] logged in with entity id 131078
2011-01-29 15:19:45 [INFO] <AngryRhetoric> yo
2011-01-29 15:21:22 [INFO] <AngryRhetoric> major lag
2011-01-29 15:53:31 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-29 15:53:34 [INFO] /24.147.183.4:57873 lost connection
2011-01-29 15:54:55 [INFO] AngryRhetoric [/24.147.183.4:57927] logged in with entity id 158927
2011-01-29 16:14:35 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-29 16:14:58 [INFO] AngryRhetoric [/24.147.183.4:58784] logged in with entity id 177142
2011-01-29 17:01:46 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-29 17:02:00 [INFO] AngryRhetoric [/24.147.183.4:60785] logged in with entity id 207800
2011-01-29 17:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-29 17:26:45 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-29 17:27:35 [INFO] AngryRhetoric [/24.147.183.4:61908] logged in with entity id 232611
2011-01-29 18:41:53 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-30 17:22:39 [INFO] efess [/192.168.0.198:5490] logged in with entity id 327316
2011-01-30 17:35:41 [INFO] efess lost connection: disconnect.quitting
2011-01-30 17:53:51 [INFO] efess [/192.168.0.198:6030] logged in with entity id 355176
2011-01-30 17:56:04 [INFO] efess lost connection: disconnect.quitting
2011-01-30 17:58:34 [INFO] efess [/192.168.0.198:6153] logged in with entity id 357243
2011-01-30 19:29:00 [INFO] nawf [/76.23.232.27:55117] logged in with entity id 596278
2011-01-30 19:30:01 [INFO] <nawf> lol kevin
2011-01-30 19:30:05 [INFO] <efess> haha
2011-01-30 19:30:08 [INFO] <efess> yea I found his shit
2011-01-30 19:30:19 [INFO] <nawf> I told him we needed a road
2011-01-30 19:30:21 [INFO] <nawf> not this though
2011-01-30 19:30:23 [INFO] <nawf> lol
2011-01-30 19:30:24 [INFO] <efess> lol
2011-01-30 19:30:34 [INFO] <efess> was wondering wtf that was
2011-01-30 19:31:12 [INFO] <nawf> his tower is pretty cool
2011-01-30 19:31:22 [INFO] <efess> yea I like the roof
2011-01-30 19:31:37 [INFO] <efess> so you planning on using lava for your tower lighting?
2011-01-30 19:31:40 [INFO] <efess> it seems to be brighter
2011-01-30 19:31:54 [INFO] <nawf> yeah, I don't like that you can see it though, I'll probably replace it with torches
2011-01-30 19:32:03 [INFO] <efess> did you try just one column?
2011-01-30 19:32:07 [INFO] <nawf> yeah
2011-01-30 19:36:08 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 19:36:11 [INFO] nawf [/76.23.232.27:55055] logged in with entity id 621750
2011-01-30 19:36:58 [INFO] <efess> found a cave down here with tons of lava
2011-01-30 19:39:23 [INFO] <nawf> I'm going to go up and see whats up
2011-01-30 19:39:32 [INFO] <nawf> I haven't explored in this direction this far
2011-01-30 19:39:39 [INFO] <efess> oh nice
2011-01-30 19:39:43 [INFO] <efess> ocean here
2011-01-30 19:39:48 [INFO] <efess> i have minimap
2011-01-30 19:40:01 [INFO] <efess> its desert looks like
2011-01-30 19:40:16 [INFO] <efess> with ice
2011-01-30 19:40:20 [INFO] <efess> too much snow in this world
2011-01-30 19:41:03 [INFO] <nawf> I think we spawned at a northern longitude or something
2011-01-30 19:41:12 [INFO] <efess> hehe
2011-01-30 19:44:49 [INFO] <efess> lol diamond
2011-01-30 19:45:01 [INFO] <efess> 5 woot
2011-01-30 19:46:27 [INFO] <nawf> nothing too exciting up here
2011-01-30 19:47:31 [INFO] <efess> nothin down here but a strait tunnel
2011-01-30 19:47:33 [INFO] <nawf> its weird, there are planted saprolings
2011-01-30 19:47:53 [INFO] <efess> maybe because it was just generated
2011-01-30 19:48:22 [INFO] <efess> but a new world you see trees...
2011-01-30 19:48:24 [INFO] <efess> weird.
2011-01-30 19:48:32 [INFO] <nawf> yeah, there are trees too
2011-01-30 19:49:48 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 19:49:51 [INFO] nawf [/76.23.232.27:55064] logged in with entity id 742914
2011-01-30 19:51:02 [INFO] <efess> gonna drop off what I have
2011-01-30 19:51:11 [INFO] <efess> this is fkn far
2011-01-30 19:51:58 [INFO] <nawf> LAPIS
2011-01-30 19:52:01 [INFO] <nawf> LAOPISISIPSPPS
2011-01-30 19:52:02 [INFO] <efess> omg
2011-01-30 19:52:05 [INFO] <efess> you find it? pfft
2011-01-30 19:52:17 [INFO] <nawf> I know, I clear 60 blocks
2011-01-30 19:52:19 [INFO] <nawf> woo
2011-01-30 19:52:22 [INFO] <efess> Quick make some blue wool!
2011-01-30 19:52:26 [INFO] <efess> MAKE A BLUE SHEEP
2011-01-30 19:52:27 [INFO] <efess> LOL
2011-01-30 19:52:40 [INFO] <efess> OMG
2011-01-30 19:52:52 [INFO] <efess> im clearing out coal here
2011-01-30 19:52:55 [INFO] <efess> find 3 more diamond
2011-01-30 19:53:13 [INFO] <nawf> wtf
2011-01-30 19:53:17 [INFO] <nawf> one lapis
2011-01-30 19:53:30 [INFO] <efess> 3x rarer than diamond
2011-01-30 19:53:40 [INFO] <nawf> well no, only one actual block spawned
2011-01-30 19:53:54 [INFO] <nawf> I mean one of the dye items
2011-01-30 19:54:03 [INFO] <efess> heh
2011-01-30 19:54:08 [INFO] <nawf> I think thats been changed to it gives several
2011-01-30 19:54:12 [INFO] <efess> they were talking about it making it like redstone
2011-01-30 19:54:21 [INFO] <nawf> I think it is changed
2011-01-30 19:54:23 [INFO] <efess> yea, so it gives 5-6
2011-01-30 19:54:38 [INFO] <efess> maybe it was in the _02?
2011-01-30 19:54:52 [INFO] <efess> I updated the server soo
2011-01-30 19:55:10 [INFO] <nawf> yeah
2011-01-30 19:55:15 [INFO] <nawf> its a bug L(
2011-01-30 19:55:17 [INFO] <nawf> :(
2011-01-30 19:55:22 [INFO] <nawf> I went to the wiki
2011-01-30 19:55:26 [INFO] <nawf> smp is broke
2011-01-30 19:55:31 [INFO] <efess> damnit
2011-01-30 19:55:34 [INFO] <nawf> so if we find any we'll have to just leave it
2011-01-30 19:55:38 [INFO] <efess> good idea
2011-01-30 19:56:06 [INFO] <efess> need anything here
2011-01-30 19:56:16 [INFO] <nawf> naw
2011-01-30 20:02:10 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 20:02:13 [INFO] nawf [/76.23.232.27:55064] logged in with entity id 901330
2011-01-30 20:06:25 [INFO] <efess> I think I found two dungeons
2011-01-30 20:06:37 [INFO] <efess> right next to each toher
2011-01-30 20:06:37 [INFO] <efess> lol
2011-01-30 20:12:06 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 20:12:08 [INFO] nawf [/76.23.232.27:55070] logged in with entity id 924913
2011-01-30 20:12:44 [INFO] <nawf> damn this is long
2011-01-30 20:12:52 [INFO] <efess> ya dude
2011-01-30 20:13:02 [INFO] <nawf> we should just branch mine off it
2011-01-30 20:13:08 [INFO] <efess> sure
2011-01-30 20:13:16 [INFO] <nawf> well I will, this is so much walking
2011-01-30 20:13:21 [INFO] <nawf> my index finger is tired
2011-01-30 20:13:25 [INFO] <efess> heh
2011-01-30 20:13:48 [INFO] <efess> put some railings down?
2011-01-30 20:14:13 [INFO] <nawf> yeah, I mean we'll have to have something far out to mine for lapis
2011-01-30 20:14:18 [INFO] <nawf> I found more, just left it
2011-01-30 20:14:19 [INFO] <efess> yup
2011-01-30 20:14:43 [INFO] <efess> lol zombie in tunnel
2011-01-30 20:14:46 [INFO] <efess> thought it was you
2011-01-30 20:15:08 [INFO] <efess> we're good with diamond for a while
2011-01-30 20:15:10 [INFO] <efess> bringing back 7 more
2011-01-30 20:15:14 [INFO] <nawf> I just found 6
2011-01-30 20:15:25 [INFO] <nawf> damn, 48!
2011-01-30 20:15:33 [INFO] <nawf> you've been busy DAYUM
2011-01-30 20:15:43 [INFO] <efess> we should start lining the walls with diamond blocks
2011-01-30 20:15:59 [INFO] <efess> nah just lucky today
2011-01-30 20:17:11 [INFO] <efess> woo lapis
2011-01-30 20:17:24 [INFO] <nawf> I made some light blue dye
2011-01-30 20:17:26 [INFO] <nawf> need sheep
2011-01-30 20:18:38 [INFO] <nawf> lol, light blue sheep
2011-01-30 20:19:09 [INFO] <efess> that was him?
2011-01-30 20:19:26 [INFO] <nawf> wha?
2011-01-30 20:19:30 [INFO] <efess> blue sheep
2011-01-30 20:19:36 [INFO] <nawf> that was me
2011-01-30 20:22:41 [INFO] <efess> ooooo
2011-01-30 20:23:26 [INFO] <nawf> ooooo?
2011-01-30 20:23:37 [INFO] <efess> the blue blocks
2011-01-30 20:23:44 [INFO] <nawf> damn, you are invisible again
2011-01-30 20:24:08 [INFO] <efess> i'm behind you
2011-01-30 20:24:16 [INFO] <nawf> colorzzzzz
2011-01-30 20:24:19 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 20:24:21 [INFO] nawf [/76.23.232.27:55055] logged in with entity id 937005
2011-01-30 20:24:25 [INFO] <efess> lo
2011-01-30 20:24:36 [INFO] <efess> yay.
2011-01-30 20:25:20 [INFO] <efess> so you can't just color wool
2011-01-30 20:25:23 [INFO] <efess> you have to color the sheep
2011-01-30 20:25:24 [INFO] <efess> ?
2011-01-30 20:25:28 [INFO] <nawf> naw, you can
2011-01-30 20:25:37 [INFO] <efess> but you can get more?
2011-01-30 20:25:43 [INFO] <nawf> but sheep drop 1-3 wool per dye
2011-01-30 20:25:47 [INFO] <efess> nice
2011-01-30 20:25:58 [INFO] <nawf> so its more efficient to dye sheep
2011-01-30 20:27:42 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 20:27:44 [INFO] nawf [/76.23.232.27:55043] logged in with entity id 940732
2011-01-30 20:34:51 [INFO] <efess> woot
2011-01-30 20:34:55 [INFO] <efess> first lapis
2011-01-30 20:35:11 [INFO] <nawf> you popped your blueberry
2011-01-30 20:35:20 [INFO] <efess> just one
2011-01-30 20:37:27 [INFO] <nawf> gonna just idle for a while, codez need writing
2011-01-30 20:37:36 [INFO] <efess> they won't write themselves
2011-01-30 20:46:42 [INFO] efess lost connection: disconnect.quitting
2011-01-30 20:46:45 [INFO] efess [/192.168.0.198:10442] logged in with entity id 963937
2011-01-30 21:25:05 [INFO] <efess> yo
2011-01-30 21:25:09 [INFO] <nawf> hey
2011-01-30 21:25:16 [INFO] <efess> got trax
2011-01-30 21:26:58 [INFO] <efess> need more boost
2011-01-30 21:38:37 [INFO] AngryRhetoric [/24.147.183.4:64123] logged in with entity id 1003422
2011-01-30 21:38:42 [INFO] <efess> yo
2011-01-30 21:38:56 [INFO] <AngryRhetoric> sup joe
2011-01-30 21:39:02 [INFO] <efess> nm, die lately?
2011-01-30 21:39:07 [INFO] <AngryRhetoric> haha yes i  did
2011-01-30 21:39:16 [INFO] <AngryRhetoric> lost all my gear to
2011-01-30 21:39:18 [INFO] <AngryRhetoric> *too
2011-01-30 21:39:19 [INFO] <efess> I recovered some of your stuff and its in a box
2011-01-30 21:39:20 [INFO] <efess> in the base
2011-01-30 21:41:28 [INFO] <nawf> kev, I think I'm going to redo these roads, make them on the ground level, that cool with you?
2011-01-30 21:42:12 [INFO] <nawf> spiders in your castle
2011-01-30 21:42:18 [INFO] <nawf> in the ramparts
2011-01-30 21:42:20 [INFO] <AngryRhetoric> bastids
2011-01-30 21:42:36 [INFO] <AngryRhetoric> hey you found some of my gear!
2011-01-30 21:42:40 [INFO] <AngryRhetoric> in this chest lol
2011-01-30 21:42:40 [INFO] <efess> :D
2011-01-30 21:42:56 [INFO] <AngryRhetoric> niiice i dont' have to start over completely thx heh
2011-01-30 21:43:01 [INFO] <nawf> your tower is sweet kevin
2011-01-30 21:43:07 [INFO] <efess> np
2011-01-30 21:43:09 [INFO] <nawf> needs a mosque dome though
2011-01-30 21:43:13 [INFO] <nawf> I think you'd like that
2011-01-30 21:43:19 [INFO] <efess> we have tons of stuff at the spawner if you need anything
2011-01-30 21:43:20 [INFO] <AngryRhetoric> hahahah HALLLAHHHH
2011-01-30 21:43:31 [INFO] <AngryRhetoric> praise allah my tower needs that haha ehh
2011-01-30 21:43:40 [INFO] <AngryRhetoric> thx i thought it came out well
2011-01-30 21:44:20 [INFO] <nawf> joe went nuts and mined all the good stuff in a 1000 block radius
2011-01-30 21:44:37 [INFO] <efess> stuff was calling my name
2011-01-30 21:44:46 [INFO] <nawf> we found lapis!
2011-01-30 21:45:01 [INFO] <AngryRhetoric> haha
2011-01-30 21:45:05 [INFO] <AngryRhetoric> that's a lot of stuff, what's lapis?
2011-01-30 21:45:21 [INFO] <nawf> you can make blue dye with it, its a blue mineral block
2011-01-30 21:45:56 [INFO] <AngryRhetoric> oh cool
2011-01-30 21:46:14 [INFO] <AngryRhetoric> i found squid ink lol
2011-01-30 21:46:20 [INFO] <nawf> nice
2011-01-30 21:50:44 [INFO] <AngryRhetoric> so how does the tower work exactly, i didn't see any ladders or stairs
2011-01-30 21:50:54 [INFO] <nawf> didn't build those yet
2011-01-30 21:51:05 [INFO] <nawf> it doesn't work
2011-01-30 21:51:08 [INFO] <AngryRhetoric> heh ah
2011-01-30 21:51:24 [INFO] <AngryRhetoric> it doesn't have to do anything, now help me plug it in (space ghost)
2011-01-30 21:51:32 [INFO] <efess> lol more diamond
2011-01-30 21:52:22 [INFO] <AngryRhetoric> my above-ground walkways are a bit obnoxious lol
2011-01-30 21:53:03 [INFO] <nawf> we can do a ground road
2011-01-30 21:53:09 [INFO] <nawf> and then connect everything underground too
2011-01-30 21:53:15 [INFO] <AngryRhetoric> yeah
2011-01-30 21:54:39 [INFO] <AngryRhetoric> where you guys at
2011-01-30 21:54:43 [INFO] <nawf> in your tower
2011-01-30 21:54:57 [INFO] <AngryRhetoric> haha nice
2011-01-30 21:55:31 [INFO] <nawf> safe
2011-01-30 21:55:37 [INFO] <AngryRhetoric> you can't see the glass from a distance but it lets light in :)
2011-01-30 21:55:58 [INFO] <nawf> I think monsters will spawn up here though
2011-01-30 21:56:07 [INFO] <AngryRhetoric> i haven't had any yet
2011-01-30 21:56:09 [INFO] <AngryRhetoric> but maybe
2011-01-30 21:56:18 [INFO] <AngryRhetoric> i think the roof lighting keeps them away
2011-01-30 21:56:34 [INFO] <AngryRhetoric> sand ahhh
2011-01-30 21:57:32 [INFO] <nawf> lol, sniper tower
2011-01-30 21:57:35 [INFO] <AngryRhetoric> hahaha yeah
2011-01-30 21:57:47 [INFO] <AngryRhetoric> bogey down
2011-01-30 21:58:48 [INFO] <AngryRhetoric> my castle's not big enough for it but i might add a walled in village around the outside
2011-01-30 21:58:54 [INFO] <nawf> cool
2011-01-30 21:59:07 [INFO] <nawf> mcdonnelton?
2011-01-30 22:01:32 [INFO] <AngryRhetoric> hahah mcdonnelltonshire
2011-01-30 22:01:39 [INFO] <nawf> ville
2011-01-30 22:01:40 [INFO] <AngryRhetoric> a peaceful hamlet
2011-01-30 22:02:31 [INFO] <AngryRhetoric> shit  dude my walkway
2011-01-30 22:02:42 [INFO] <AngryRhetoric> booo
2011-01-30 22:03:04 [INFO] <nawf> oops, I thought you said it was ok for me to take it down
2011-01-30 22:03:25 [INFO] <AngryRhetoric> and do an underground one instead?
2011-01-30 22:03:32 [INFO] <nawf> or one on the ground, both
2011-01-30 22:04:10 [INFO] <AngryRhetoric> well yeah i figured we'd have both, but it will take awhile to remake this one lol
2011-01-30 22:04:40 [INFO] <nawf> naw, we'll do one on the ground, with a cool bridge
2011-01-30 22:05:02 [INFO] <AngryRhetoric> ok
2011-01-30 22:06:33 [INFO] <AngryRhetoric> i fell off at least 6 times building my bridge lol
2011-01-30 22:06:54 [INFO] <efess> you know the shift key right? :)
2011-01-30 22:07:29 [INFO] <nawf> yeah, it prevents you from falling
2011-01-30 22:07:34 [INFO] <nawf> man I love that key
2011-01-30 22:07:40 [INFO] <AngryRhetoric> ahh dam i forgot about that
2011-01-30 22:16:24 [INFO] <AngryRhetoric> i just saw a skeleton attempt to mount a spider...
2011-01-30 22:16:52 [INFO] <efess> apparently they can still climb walls
2011-01-30 22:16:53 [INFO] <nawf> there are spider riding skeleton archers
2011-01-30 22:16:55 [INFO] <efess> when a skeleton is on them
2011-01-30 22:17:02 [INFO] redux06790 [/69.119.8.191:50726] logged in with entity id 1094305
2011-01-30 22:17:06 [INFO] <redux06790> derp!
2011-01-30 22:17:10 [INFO] <nawf> hrup
2011-01-30 22:17:15 [INFO] <AngryRhetoric> yeah i've seen them ride spiders but this one was failing lol
2011-01-30 22:17:16 [INFO] <redux06790> OH HAI JAWN!!!
2011-01-30 22:17:16 [INFO] <efess> sup
2011-01-30 22:17:23 [INFO] <AngryRhetoric> sup
2011-01-30 22:17:24 [INFO] <nawf> hey erin, guys, this is erin
2011-01-30 22:17:27 [INFO] <redux06790> Ok so which one is John?
2011-01-30 22:17:28 [INFO] <efess> hi erin
2011-01-30 22:17:29 [INFO] <redux06790> nvm
2011-01-30 22:17:35 [INFO] <redux06790> herrow
2011-01-30 22:17:41 [INFO] <nawf> I'm john, efess is Joe, angry is Kevin
2011-01-30 22:17:42 [INFO] <redux06790> this is the first time ive seen anyone on here
2011-01-30 22:17:46 [INFO] <redux06790> you guys have a vent?
2011-01-30 22:17:50 [INFO] <redux06790> or do you wanna use mine?
2011-01-30 22:18:03 [INFO] <redux06790> because typing is for the birds
2011-01-30 22:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-30 22:18:08 [INFO] <efess> can't use vent right now
2011-01-30 22:18:28 [INFO] <efess> mumble > vent
2011-01-30 22:18:31 [INFO] <redux06790> btw i got lost likea motherfucker in your giant caves
2011-01-30 22:18:34 [INFO] <nawf> I don't mind typing
2011-01-30 22:18:38 [INFO] <nawf> haha
2011-01-30 22:18:45 [INFO] <nawf> which ones?
2011-01-30 22:18:47 [INFO] <AngryRhetoric> hahaha yeah the cave is massive
2011-01-30 22:18:49 [INFO] <redux06790> um
2011-01-30 22:18:51 [INFO] <redux06790> idk
2011-01-30 22:18:54 [INFO] <AngryRhetoric> the bat cave
2011-01-30 22:18:54 [INFO] <redux06790> there were trees
2011-01-30 22:18:58 [INFO] <redux06790> and waterfalls and shit
2011-01-30 22:18:59 [INFO] <nawf> oh
2011-01-30 22:19:01 [INFO] <nawf> hell yeah
2011-01-30 22:19:05 [INFO] <redux06790> and tracks... lots of tracks
2011-01-30 22:19:08 [INFO] <nawf> thats the vault river
2011-01-30 22:19:27 [INFO] <redux06790> well i got hopelessly lost in that shit
2011-01-30 22:19:34 [INFO] <AngryRhetoric> i have too
2011-01-30 22:19:40 [INFO] <redux06790> lol
2011-01-30 22:19:50 [INFO] <efess> there's been times when the only way to find the way out
2011-01-30 22:19:51 [INFO] <nawf> needs to be bigger
2011-01-30 22:19:51 [INFO] <efess> is dig up
2011-01-30 22:19:51 [INFO] <redux06790> any commands/mods running on here?
2011-01-30 22:19:57 [INFO] <efess> nah
2011-01-30 22:20:06 [INFO] <redux06790> all legit ehh?
2011-01-30 22:20:12 [INFO] <efess> ya
2011-01-30 22:20:13 [INFO] <AngryRhetoric> heh
2011-01-30 22:20:34 [INFO] <nawf> did y
2011-01-30 22:21:03 [INFO] <redux06790> wtb diamond tools pst
2011-01-30 22:21:12 [INFO] <nawf> 3 diamond per tool
2011-01-30 22:21:24 [INFO] <redux06790> GAH! youre trying to put me in the poor house!
2011-01-30 22:21:42 [INFO] <nawf> so this is ""the vault""
2011-01-30 22:21:58 [INFO] <redux06790> what manner of shennanagry is this!?
2011-01-30 22:22:02 [INFO] <nawf> come over here
2011-01-30 22:22:06 [INFO] <AngryRhetoric> haha now there's a good word
2011-01-30 22:22:13 [INFO] <redux06790> SOAD
2011-01-30 22:22:14 [INFO] <nawf> this is where all the mob loot drops down
2011-01-30 22:22:16 [INFO] <redux06790> thats alot of mats
2011-01-30 22:22:30 [INFO] <nawf> did you go up and see the spawner?
2011-01-30 22:22:31 [INFO] <redux06790> oh right you guys dont know that saod means shit on a dick...
2011-01-30 22:22:36 [INFO] <redux06790> not yet
2011-01-30 22:22:45 [INFO] <redux06790> i have a spawner being designed on my SSP
2011-01-30 22:22:54 [INFO] <redux06790> better than the companion cube
2011-01-30 22:22:55 [INFO] <AngryRhetoric> i didn't know that
2011-01-30 22:23:02 [INFO] <AngryRhetoric> there is no cake
2011-01-30 22:23:14 [INFO] <nawf> this is the death chute
2011-01-30 22:23:17 [INFO] <redux06790> hmm
2011-01-30 22:23:19 [INFO] <nawf> its awesome
2011-01-30 22:23:26 [INFO] <redux06790> thats what i did wrong for my spawner...
2011-01-30 22:23:31 [INFO] <redux06790> ill have to make a note of that
2011-01-30 22:23:38 [INFO] <nawf> the chute kills them fast so more spawn
2011-01-30 22:23:40 [INFO] <AngryRhetoric> yeah this mob grinder is massive
2011-01-30 22:23:42 [INFO] <redux06790> my lava is at the begining of the chute
2011-01-30 22:24:02 [INFO] <AngryRhetoric> he should see inside the grinder heh
2011-01-30 22:24:07 [INFO] <nawf> oh god no
2011-01-30 22:24:17 [INFO] <AngryRhetoric> with lights i mean
2011-01-30 22:24:20 [INFO] <nawf> true
2011-01-30 22:24:25 [INFO] <redux06790> so you went with indiana jones ehh?
2011-01-30 22:24:27 [INFO] <nawf> I tried to show somebody it and was assaulted
2011-01-30 22:24:32 [INFO] <nawf> by like 7 mobs
2011-01-30 22:24:35 [INFO] <AngryRhetoric> haha
2011-01-30 22:24:44 [INFO] <AngryRhetoric> like dawn of the dead
2011-01-30 22:24:59 [INFO] <nawf> yeah, this is it
2011-01-30 22:25:04 [INFO] <redux06790> do i have to be careful with fire?
2011-01-30 22:25:07 [INFO] <redux06790> seriously...
2011-01-30 22:25:10 [INFO] <nawf> took joe and I 2-3 days to build one half
2011-01-30 22:25:11 [INFO] <redux06790> because im a pyro
2011-01-30 22:25:17 [INFO] <AngryRhetoric> not in castle mcdonnell you don't
2011-01-30 22:25:18 [INFO] <nawf> and kevin joe and I 3 hours to build the other
2011-01-30 22:25:30 [INFO] <nawf> we used wood so if we wanted to expand we could
2011-01-30 22:25:33 [INFO] <efess> ... there are plenty of trees
2011-01-30 22:25:34 [INFO] <efess> :P
2011-01-30 22:25:36 [INFO] <nawf> just by burning the wall
2011-01-30 22:25:44 [INFO] <nawf> but its already exceeding expectations
2011-01-30 22:26:08 [INFO] <nawf> thats kevins castle
2011-01-30 22:26:17 [INFO] <redux06790> very phallic
2011-01-30 22:26:23 [INFO] <AngryRhetoric> LOL
2011-01-30 22:26:26 [INFO] <nawf> he's into the cocks
2011-01-30 22:26:31 [INFO] <redux06790> who isnt?
2011-01-30 22:26:36 [INFO] <AngryRhetoric> my tower is 8===D
2011-01-30 22:26:40 [INFO] <redux06790> hell im in love with mine
2011-01-30 22:27:00 [INFO] <nawf> and this is just some random tower I've been working on
2011-01-30 22:27:02 [INFO] <AngryRhetoric> technically all castles are phallic
2011-01-30 22:27:20 [INFO] <redux06790> hmm
2011-01-30 22:27:34 [INFO] <redux06790> im going to have to hike to get to an untouched place
2011-01-30 22:27:55 [INFO] <nawf> well ther eis across the river from the spawn
2011-01-30 22:28:21 [INFO] <redux06790> i usually build AT or NORTH of any given spawn
2011-01-30 22:28:25 [INFO] <redux06790> just for self reference
2011-01-30 22:28:31 [INFO] <nawf> and this is what we do with our tnt
2011-01-30 22:28:37 [INFO] <redux06790> maybe ill just build in this giant ass crater
2011-01-30 22:28:39 [INFO] <nawf> this is another castles basement
2011-01-30 22:28:45 [INFO] <redux06790> o
2011-01-30 22:28:50 [INFO] <nawf> we just haven't build anything yet
2011-01-30 22:28:57 [INFO] <redux06790> that sheep is getting ass raped by fire
2011-01-30 22:29:11 [INFO] <nawf> so we want to elvel out to over here
2011-01-30 22:29:12 [INFO] <redux06790> ...
2011-01-30 22:29:22 [INFO] <nawf> there is a... cross dirt thing
2011-01-30 22:29:57 [INFO] <redux06790> wtf skin do i have on right now?
2011-01-30 22:30:05 [INFO] <nawf> redhead
2011-01-30 22:30:08 [INFO] <nawf> green shirt
2011-01-30 22:30:08 [INFO] <redux06790> o
2011-01-30 22:30:12 [INFO] <redux06790> scott pilgrim...
2011-01-30 22:30:14 [INFO] <AngryRhetoric> that's what that is
2011-01-30 22:30:14 [INFO] <redux06790> right
2011-01-30 22:30:21 [INFO] <AngryRhetoric> looks like a toupe :p
2011-01-30 22:30:53 [INFO] <redux06790> im going to make an amusement park
2011-01-30 22:30:56 [INFO] <redux06790> and call it bigotland
2011-01-30 22:31:02 [INFO] <AngryRhetoric> LOL
2011-01-30 22:31:10 [INFO] <AngryRhetoric> what kind of rides will bigotland host?
2011-01-30 22:31:29 [INFO] <nawf> we haven't touhed any of this space
2011-01-30 22:31:46 [INFO] <redux06790> the misogynist rollercoaster
2011-01-30 22:31:54 [INFO] <redux06790> the kike cafe...
2011-01-30 22:31:56 [INFO] <redux06790> hmm
2011-01-30 22:31:59 [INFO] <redux06790> the...
2011-01-30 22:32:17 [INFO] <redux06790> i dunno... i cant think of anything sufficiently racist
2011-01-30 22:32:31 [INFO] <redux06790> i should have come prepaired
2011-01-30 22:32:40 [INFO] <AngryRhetoric> haha that's good start
2011-01-30 22:32:55 [INFO] <redux06790> that and i dont know how fucking insane you guys are yet
2011-01-30 22:32:56 [INFO] <redux06790> lol
2011-01-30 22:33:03 [INFO] <redux06790> so i dont know how far to push my humor
2011-01-30 22:33:08 [INFO] <AngryRhetoric> dude we're playing minecraft!
2011-01-30 22:33:13 [INFO] <efess> haha
2011-01-30 22:33:17 [INFO] <redux06790> so what youre telling me
2011-01-30 22:33:23 [INFO] <AngryRhetoric> minecraft = insanity
2011-01-30 22:33:25 [INFO] <redux06790> is i can make niggerland, and nobody will care?
2011-01-30 22:33:27 [INFO] <nawf> lol
2011-01-30 22:33:33 [INFO] <efess> nope
2011-01-30 22:33:35 [INFO] <efess> will not care
2011-01-30 22:33:36 [INFO] <redux06790> yay
2011-01-30 22:33:50 [INFO] <redux06790> because i made something similar and got banned from a random server
2011-01-30 22:34:06 [INFO] <efess> you motherfucker
2011-01-30 22:34:08 [INFO] <efess> throwing a snowball at me
2011-01-30 22:34:09 [INFO] <AngryRhetoric> haha
2011-01-30 22:34:10 [INFO] <redux06790> and i was all LULWUT
2011-01-30 22:34:26 [INFO] <redux06790> its just a giant black cock named ""Your real dad""
2011-01-30 22:34:38 [INFO] <AngryRhetoric> made out of obsidian haha
2011-01-30 22:34:40 [INFO] <redux06790> fuckers probably kept it up too
2011-01-30 22:34:44 [INFO] <redux06790> yea it was
2011-01-30 22:34:51 [INFO] <redux06790> you know how long it takes to get that kind of obby?
2011-01-30 22:35:15 [INFO] <redux06790> I called it ""Spooky Tower""
2011-01-30 22:35:21 [INFO] <nawf> that scares me your first instinct is to build a giant black penis
2011-01-30 22:35:26 [INFO] <redux06790> lol
2011-01-30 22:35:31 [INFO] <nawf> because a gold penis is so much better
2011-01-30 22:35:38 [INFO] <efess> yes a golden cock+balls
2011-01-30 22:35:44 [INFO] <AngryRhetoric> haha
2011-01-30 22:35:48 [INFO] <redux06790> ahhh fuck my ass i just got buttraped by a spider
2011-01-30 22:35:52 [INFO] <redux06790> anyone have any extra iron?
2011-01-30 22:36:18 [INFO] <nawf> dunno, there maybe some in chests in the main base
2011-01-30 22:36:30 [INFO] <efess> ya should be some
2011-01-30 22:36:38 [INFO] <nawf> I think we are getting low, dunno how many rails we need atm
2011-01-30 22:36:58 [INFO] <nawf> joe is railmaster, the rail god
2011-01-30 22:37:07 [INFO] <redux06790> idk where the fuck i am
2011-01-30 22:37:12 [INFO] <redux06790> wtb map
2011-01-30 22:37:17 [INFO] <redux06790> and more signs
2011-01-30 22:37:28 [INFO] <AngryRhetoric> we could use more signs around here
2011-01-30 22:37:33 [INFO] <nawf> psshh
2011-01-30 22:37:40 [INFO] <AngryRhetoric> hah
2011-01-30 22:37:42 [INFO] <redux06790> ok i found rails
2011-01-30 22:37:43 [INFO] <redux06790> im good
2011-01-30 22:38:19 [INFO] <redux06790> imma build some shit that will make you cream yourself
2011-01-30 22:39:09 [INFO] <redux06790> just as soon as a gank some supplies
2011-01-30 22:39:18 [INFO] <redux06790> and mine about 100 obby
2011-01-30 22:39:40 [INFO] <redux06790> OH wait
2011-01-30 22:39:43 [INFO] <redux06790> black wool
2011-01-30 22:39:47 [INFO] <redux06790> much easier to get
2011-01-30 22:39:59 [INFO] <redux06790> you should make a squid grinder... i wonder if thats possible?
2011-01-30 22:40:07 [INFO] <efess> I think so...
2011-01-30 22:40:11 [INFO] <AngryRhetoric> waterfalls?
2011-01-30 22:40:18 [INFO] <redux06790> all the black dye you can handle
2011-01-30 22:40:21 [INFO] <efess> I saw a ss of some dude making a hole in the ocean
2011-01-30 22:40:33 [INFO] <redux06790> ok
2011-01-30 22:40:33 [INFO] <efess> squid got cought in it
2011-01-30 22:40:40 [INFO] <redux06790> one of two things are going on here
2011-01-30 22:40:46 [INFO] <redux06790> either this chunk is gone
2011-01-30 22:40:48 [INFO] <redux06790> or its not loaded
2011-01-30 22:40:49 [INFO] <efess> haha
2011-01-30 22:40:56 [INFO] <efess> yea there are chunk errors
2011-01-30 22:40:58 [INFO] <redux06790> either way im scared
2011-01-30 22:41:01 [INFO] <efess> you have to disconnect and reconnect
2011-01-30 22:41:04 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-30 22:41:07 [INFO] redux06790 [/69.119.8.191:50758] logged in with entity id 1164449
2011-01-30 22:41:10 [INFO] <redux06790> ok
2011-01-30 22:41:11 [INFO] <redux06790> phew
2011-01-30 22:41:53 [INFO] <redux06790> whats with this cactus?
2011-01-30 22:42:01 [INFO] <efess> that's our trashcan
2011-01-30 22:42:06 [INFO] <AngryRhetoric> DUH! haha
2011-01-30 22:42:11 [INFO] <efess> :D
2011-01-30 22:42:13 [INFO] <redux06790> ive always used lava
2011-01-30 22:42:30 [INFO] <redux06790> btw
2011-01-30 22:42:34 [INFO] <redux06790> whatever i make
2011-01-30 22:42:39 [INFO] <redux06790> it will be booby trapped
2011-01-30 22:42:46 [INFO] <redux06790> because im a cockass
2011-01-30 22:42:49 [INFO] <AngryRhetoric> haha
2011-01-30 22:43:23 [INFO] <nawf> well I don't think you have to worry about any grifers here
2011-01-30 22:43:32 [INFO] <redux06790> lol
2011-01-30 22:43:42 [INFO] <redux06790> yeah but itll be funny to watch people scramble
2011-01-30 22:43:55 [INFO] <redux06790> and accidentally hit the self destruct button
2011-01-30 22:44:08 [INFO] <efess> people you mean everyone on this server currently
2011-01-30 22:44:08 [INFO] <efess> :p
2011-01-30 22:44:14 [INFO] <redux06790> yes
2011-01-30 22:44:19 [INFO] <nawf> yeah, thats won't be fun
2011-01-30 22:44:25 [INFO] <redux06790> it will for me
2011-01-30 22:44:27 [INFO] <redux06790> ...
2011-01-30 22:44:31 [INFO] <redux06790> until i have to rebuild my house
2011-01-30 22:44:44 [INFO] <redux06790> because i blowed it up when i forgot that i booby trapped it
2011-01-30 22:45:52 [INFO] <AngryRhetoric> mm chunk errors
2011-01-30 22:48:37 [INFO] <redux06790> how do i get to the surface?
2011-01-30 22:48:46 [INFO] <nawf> where do you want to end up?
2011-01-30 22:48:55 [INFO] <redux06790> nvm theres grass down here
2011-01-30 22:49:03 [INFO] <AngryRhetoric> stairway near the mob spawner
2011-01-30 22:49:45 [INFO] <nawf> doesn't bonemeal feel like cheating?
2011-01-30 22:49:56 [INFO] <nawf> that tree just raped you
2011-01-30 22:49:57 [INFO] <AngryRhetoric> how so
2011-01-30 22:50:00 [INFO] <redux06790> it did
2011-01-30 22:50:02 [INFO] <redux06790> i liked it
2011-01-30 22:50:13 [INFO] <nawf> if you put bonemeal on a saproling it will grow the tree instantly
2011-01-30 22:50:44 [INFO] <redux06790> how did you make the note blocks repeat?
2011-01-30 22:50:59 [INFO] <nawf> the repeaters just cycle
2011-01-30 22:51:41 [INFO] <nawf> to tell you the truth I'm not that good with redstone, went to the wiki
2011-01-30 22:51:46 [INFO] <nawf> and copied the pattern
2011-01-30 22:53:38 [INFO] <efess> lol just found 3 diamond deposits
2011-01-30 22:53:43 [INFO] <redux06790> does nether work in SMP yet?
2011-01-30 22:53:44 [INFO] <AngryRhetoric> niice
2011-01-30 22:53:48 [INFO] <efess> nah
2011-01-30 22:53:56 [INFO] <efess> tonights the night for diamond :D
2011-01-30 22:54:01 [INFO] <AngryRhetoric> i preferred when spiders couldn't climb
2011-01-30 22:54:13 [INFO] <nawf> thats the nicest way to say
2011-01-30 22:54:13 [INFO] <efess> notch is talking about having the ether a separate server
2011-01-30 22:54:18 [INFO] <nawf> FUCK THOSE FUCKING SPIDERS
2011-01-30 22:54:36 [INFO] <redux06790> notch needs to do more with the nether it feels so unfinished
2011-01-30 22:54:45 [INFO] <redux06790> there needs to be more nethermats
2011-01-30 22:54:55 [INFO] <efess> found some new caves
2011-01-30 22:55:12 [INFO] <efess> if you guys want to get your splunking on
2011-01-30 22:55:44 [INFO] <nawf> I need to do some mining, need lapis
2011-01-30 22:57:01 [INFO] <efess> at the end of the rail, walk in the left tunnel
2011-01-30 22:57:22 [INFO] <nawf> ok
2011-01-30 22:57:27 [INFO] <nawf> once daytime comes around
2011-01-30 22:57:36 [INFO] <nawf> need a break from nighttime
2011-01-30 22:57:40 [INFO] <nawf> underground is somehow safer
2011-01-30 22:57:54 [INFO] <AngryRhetoric> heheh
2011-01-30 22:59:11 [INFO] <nawf> I killed pigs on your land kevin
2011-01-30 22:59:25 [INFO] <nawf> are you going to send the sheriff of mcdonnelham after me?
2011-01-30 23:00:41 [INFO] <redux06790> i keep getting tree raped
2011-01-30 23:01:08 [INFO] <nawf> if you stand right on top if it when you throw the bonemeal you won't get leaf raped
2011-01-30 23:01:20 [INFO] <redux06790> look
2011-01-30 23:01:28 [INFO] <redux06790> maybe i like getting wood every now and again
2011-01-30 23:01:29 [INFO] <redux06790> lol
2011-01-30 23:01:31 [INFO] <redux06790> dont make sense
2011-01-30 23:01:34 [INFO] <AngryRhetoric> haha
2011-01-30 23:01:44 [INFO] <AngryRhetoric> you owe me a pig tariff
2011-01-30 23:01:54 [INFO] <AngryRhetoric> what will the serfs eat
2011-01-30 23:02:38 [INFO] <nawf> erin, did you get arrows?
2011-01-30 23:02:43 [INFO] <redux06790> no
2011-01-30 23:02:45 [INFO] <redux06790> do i need arrows?
2011-01-30 23:02:50 [INFO] <nawf> the mob spawner keeps us with almost an unlimited supply
2011-01-30 23:03:01 [INFO] <nawf> so its safter than swords
2011-01-30 23:03:08 [INFO] <nawf> I only kill friendly mobs with swords now
2011-01-30 23:03:10 [INFO] <redux06790> oh ya
2011-01-30 23:03:17 [INFO] <redux06790> i can go apeshit with a bow huh?
2011-01-30 23:03:26 [INFO] <nawf> yeah, just go nuts
2011-01-30 23:03:27 [INFO] <AngryRhetoric> big time
2011-01-30 23:03:38 [INFO] <redux06790> OMG
2011-01-30 23:03:43 [INFO] <redux06790> i thought pvp was on
2011-01-30 23:03:47 [INFO] <nawf> oh lol
2011-01-30 23:04:02 [INFO] <redux06790> i was all ""FMA!!!""
2011-01-30 23:04:15 [INFO] <nawf> arrowspam ftw
2011-01-30 23:04:33 [INFO] <redux06790> invisible leaves FTL
2011-01-30 23:04:53 [INFO] <nawf> yeah, I'm suprised your still collecting that way
2011-01-30 23:05:09 [INFO] <nawf> I always ended up with  an invisible leave barrier just cutting me off completly
2011-01-30 23:05:14 [INFO] <nawf> *leaf
2011-01-30 23:05:25 [INFO] <redux06790> well sorry im not part of the elite wood collecting club
2011-01-30 23:05:31 [INFO] <redux06790> some of us like to do it the hard way
2011-01-30 23:05:33 [INFO] <AngryRhetoric> haha the EWCC?
2011-01-30 23:05:40 [INFO] <AngryRhetoric> you didn't get the card for that?
2011-01-30 23:05:41 [INFO] <redux06790> no but really
2011-01-30 23:05:44 [INFO] <nawf> no, I mean your doing better than me
2011-01-30 23:05:47 [INFO] <redux06790> if there is an easier way
2011-01-30 23:05:48 [INFO] <redux06790> please
2011-01-30 23:05:52 [INFO] <AngryRhetoric> the EWCC is awesome
2011-01-30 23:06:16 [INFO] <redux06790> as soon as i pirate a good portable version of photoshop i will be making EWCC shirts
2011-01-30 23:06:34 [INFO] redux06790 tried command: sethome
2011-01-30 23:06:38 [INFO] redux06790 tried command: home
2011-01-30 23:06:53 [INFO] <nawf> the empowering world christian center?
2011-01-30 23:07:07 [INFO] <redux06790> no the elite wood collectors club
2011-01-30 23:07:23 [INFO] <AngryRhetoric> hahaha
2011-01-30 23:07:26 [INFO] <AngryRhetoric> t-shirts!
2011-01-30 23:07:29 [INFO] <efess> are they rivals to the elite stone collectors club?
2011-01-30 23:07:33 [INFO] <AngryRhetoric> the other one works for me too john :)
2011-01-30 23:07:37 [INFO] <redux06790> once i go through about an iron axe im all good
2011-01-30 23:07:49 [INFO] <redux06790> btw this wood is for our coffers
2011-01-30 23:07:52 [INFO] <nawf> I just googled it
2011-01-30 23:08:00 [INFO] <nawf> sweet
2011-01-30 23:08:08 [INFO] <redux06790> i emptied it sooo....
2011-01-30 23:08:17 [INFO] <redux06790> plus i wont feel bad ganking stone
2011-01-30 23:08:29 [INFO] <nawf> there is cobble everywhere
2011-01-30 23:08:34 [INFO] <nawf> well there was
2011-01-30 23:08:39 [INFO] <redux06790> not cobble
2011-01-30 23:08:41 [INFO] <redux06790> stone...
2011-01-30 23:08:46 [INFO] <redux06790> for my house
2011-01-30 23:08:47 [INFO] <nawf> oh
2011-01-30 23:09:08 [INFO] <redux06790> i need piles of stone, wool, pink dye and semen
2011-01-30 23:09:13 [INFO] <nawf> hahahahaha
2011-01-30 23:09:24 [INFO] <nawf> there is a fucking creeper in one of the new track booster carts
2011-01-30 23:09:27 [INFO] <nawf> roflroflrooflf
2011-01-30 23:09:28 [INFO] <redux06790> the semen is merely aesthetic
2011-01-30 23:09:31 [INFO] <efess> nice
2011-01-30 23:09:37 [INFO] <efess> if it explodes, extra boost
2011-01-30 23:09:41 [INFO] <AngryRhetoric> the creeper's goin for a ride?
2011-01-30 23:09:52 [INFO] <redux06790> hes saying ""this is a nice booster you have here, be a shame if something happend to it""
2011-01-30 23:10:04 [INFO] <efess> nice booster you had there
2011-01-30 23:10:06 [INFO] <nawf> ""I like your house, hope you don't""
2011-01-30 23:10:09 [INFO] <efess> hahahaha
2011-01-30 23:10:11 [INFO] <redux06790> lol
2011-01-30 23:10:15 [INFO] <AngryRhetoric> hahaha BAM no more house
2011-01-30 23:10:42 [INFO] <redux06790> anyone seen the sexy creeper yet?
2011-01-30 23:10:45 [INFO] <redux06790> the fan art
2011-01-30 23:10:53 [INFO] <efess> nah
2011-01-30 23:11:14 [INFO] <nawf> lol, first google result for sexy creeper is a link about justin bieber impregnating his mother
2011-01-30 23:11:26 [INFO] <AngryRhetoric> that sounds about right hahaa
2011-01-30 23:12:23 [INFO] <redux06790> idk what its called
2011-01-30 23:12:25 [INFO] <redux06790> gimme sec
2011-01-30 23:13:49 [INFO] <redux06790> ok found it
2011-01-30 23:13:58 [INFO] <redux06790> google images. minecraft creeper ass
2011-01-30 23:14:04 [INFO] <redux06790> second image
2011-01-30 23:14:23 [INFO] <nawf> rule 34
2011-01-30 23:14:25 [INFO] <redux06790> yea
2011-01-30 23:14:27 [INFO] <redux06790> def
2011-01-30 23:14:34 [INFO] <redux06790> i think its a trap tho..
2011-01-30 23:14:44 [INFO] <redux06790> not sure if want
2011-01-30 23:15:22 [INFO] <nawf> tell erin about infinite arrows
2011-01-30 23:15:28 [INFO] <nawf> go splunking, find mobs
2011-01-30 23:15:34 [INFO] <nawf> immediatly run out of arrows
2011-01-30 23:15:55 [INFO] <redux06790> that sounds not good
2011-01-30 23:16:03 [INFO] <nawf> yeah, a lot of more bad
2011-01-30 23:16:09 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 23:16:11 [INFO] nawf [/76.23.232.27:55075] logged in with entity id 1234025
2011-01-30 23:16:22 [INFO] <redux06790> ok my little niglets
2011-01-30 23:16:27 [INFO] <redux06790> two stacks of logs
2011-01-30 23:16:40 [INFO] <redux06790> aka 8 stacks of planks
2011-01-30 23:17:05 [INFO] <nawf> damn, went to take a screenie of the creeper
2011-01-30 23:17:11 [INFO] <nawf> didn't even get close, he blew up
2011-01-30 23:19:24 [INFO] <redux06790> i wish feathers were useful
2011-01-30 23:19:35 [INFO] <efess> they make trash cans useful
2011-01-30 23:19:46 [INFO] <redux06790> lol
2011-01-30 23:20:11 [INFO] <redux06790> ok time to gank some smooth stone and make me a hosue
2011-01-30 23:20:13 [INFO] <redux06790> house
2011-01-30 23:20:24 [INFO] <redux06790> not an edifice house... a gregory house
2011-01-30 23:20:27 [INFO] <redux06790> out of stone
2011-01-30 23:20:45 [INFO] <redux06790> just one thing
2011-01-30 23:20:50 [INFO] <redux06790> how the hell do i get to the surface?
2011-01-30 23:21:02 [INFO] <AngryRhetoric> are you in near the mob grinder?
2011-01-30 23:21:03 [INFO] <nawf> to the mob spawner
2011-01-30 23:21:06 [INFO] <nawf> or the spawn?
2011-01-30 23:21:16 [INFO] <redux06790> wait i think i remember
2011-01-30 23:21:23 [INFO] <nawf> that goes straight up
2011-01-30 23:21:31 [INFO] <nawf> the tracks take you to the main base
2011-01-30 23:21:44 [INFO] <redux06790> ...
2011-01-30 23:21:48 [INFO] <redux06790> well stick a finger in my ass
2011-01-30 23:21:50 [INFO] <redux06790> of course its night
2011-01-30 23:21:59 [INFO] <redux06790> ohh
2011-01-30 23:22:02 [INFO] <redux06790> wait its dawn
2011-01-30 23:22:28 [INFO] <nawf> you can also follow the river
2011-01-30 23:22:36 [INFO] <nawf> when you get to the big waterfalls stay to the right
2011-01-30 23:22:40 [INFO] <nawf> there are ladders up
2011-01-30 23:22:53 [INFO] <redux06790> im going to build right on this lake i think
2011-01-30 23:23:21 [INFO] <nawf> well try to stay away from the spawner
2011-01-30 23:23:30 [INFO] <nawf> he more ""space"" taken up by shit the lower the spawn rate
2011-01-30 23:23:32 [INFO] <AngryRhetoric> yeah i ganked most of the dirt
2011-01-30 23:23:35 [INFO] <nawf> thats why we blew the hell out of here
2011-01-30 23:23:43 [INFO] <redux06790> hmm
2011-01-30 23:23:48 [INFO] <nawf> the area around the death chute I mean
2011-01-30 23:23:58 [INFO] <redux06790> noo im on the surface
2011-01-30 23:24:04 [INFO] <redux06790> about 100 blocks from the spawner
2011-01-30 23:24:10 [INFO] <nawf> oh
2011-01-30 23:24:14 [INFO] <redux06790> on the wooden side
2011-01-30 23:24:17 [INFO] <nawf> yeah that should be good
2011-01-30 23:24:32 [INFO] <nawf> just light it up well, because the spawner algo works overtime around this area because
2011-01-30 23:24:40 [INFO] <nawf> so many mobs die and we have so much empty space around here
2011-01-30 23:24:51 [INFO] efess lost connection: disconnect.quitting
2011-01-30 23:24:54 [INFO] efess [/192.168.0.198:14072] logged in with entity id 1250478
2011-01-30 23:24:54 [INFO] <nawf> there is a cool thread called mob spawning science
2011-01-30 23:24:57 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-30 23:26:21 [INFO] <efess> oh hai
2011-01-30 23:26:24 [INFO] <nawf> rofl
2011-01-30 23:26:30 [INFO] <efess> lol
2011-01-30 23:26:33 [INFO] <nawf> wtf is happening
2011-01-30 23:26:38 [INFO] <efess> you're pushing me back
2011-01-30 23:26:39 [INFO] <efess> lol
2011-01-30 23:26:44 [INFO] <efess> HAHAH
2011-01-30 23:26:46 [INFO] <nawf> rofl
2011-01-30 23:26:55 [INFO] <efess> i'm still going
2011-01-30 23:26:59 [INFO] <efess> i took your momentum
2011-01-30 23:27:00 [INFO] <efess> lol
2011-01-30 23:27:03 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 23:27:05 [INFO] nawf [/76.23.232.27:55030] logged in with entity id 1257316
2011-01-30 23:28:14 [INFO] <efess> your invisible
2011-01-30 23:28:15 [INFO] <efess> lol.
2011-01-30 23:28:22 [INFO] <efess> blocks are randomly dissapearing
2011-01-30 23:28:28 [INFO] efess lost connection: disconnect.quitting
2011-01-30 23:28:31 [INFO] efess [/192.168.0.198:14142] logged in with entity id 1260469
2011-01-30 23:28:52 [INFO] <efess> LOL
2011-01-30 23:28:52 [INFO] <nawf> rofl
2011-01-30 23:29:20 [INFO] <redux06790> guys
2011-01-30 23:29:24 [INFO] <redux06790> i think i figured out a way
2011-01-30 23:29:27 [INFO] <redux06790> to offend everyone
2011-01-30 23:29:32 [INFO] <efess> bs
2011-01-30 23:29:43 [INFO] <redux06790> a bumper sticker that says ""I love niggers""
2011-01-30 23:29:44 [INFO] <AngryRhetoric> everyone?
2011-01-30 23:29:47 [INFO] <AngryRhetoric> haha
2011-01-30 23:29:57 [INFO] <AngryRhetoric> dude bruce willis did that in Die Hard
2011-01-30 23:29:57 [INFO] <nawf> well I'm not offended by that
2011-01-30 23:30:11 [INFO] <redux06790> ? i thought it was that he wanted them to die
2011-01-30 23:30:14 [INFO] <nawf> maybe your momma loves niggers
2011-01-30 23:30:14 [INFO] <AngryRhetoric> you'll have to drive through harlem
2011-01-30 23:30:15 [INFO] <redux06790> and that was a sammich board
2011-01-30 23:30:20 [INFO] <redux06790> not a bumper sticker
2011-01-30 23:30:30 [INFO] <redux06790> also
2011-01-30 23:30:35 [INFO] <redux06790> john broke his thumb
2011-01-30 23:30:38 [INFO] <redux06790> on my FACE
2011-01-30 23:30:47 [INFO] <redux06790> fun fact
2011-01-30 23:30:47 [INFO] <nawf> true story
2011-01-30 23:30:49 [INFO] <AngryRhetoric> haha sammich board even better
2011-01-30 23:30:56 [INFO] <AngryRhetoric> nice
2011-01-30 23:31:11 [INFO] <efess> I can't even imagine how that could happen
2011-01-30 23:31:17 [INFO] <nawf> I told you to stop throwing snow at me
2011-01-30 23:31:21 [INFO] <nawf> shits cold
2011-01-30 23:31:28 [INFO] <redux06790> lol
2011-01-30 23:31:34 [INFO] <redux06790> then you crammed it all up in my face
2011-01-30 23:31:41 [INFO] <redux06790> and i was all ""FUCK YOU!!!""
2011-01-30 23:31:52 [INFO] <redux06790> and you were all ""FUCK YOU TOO"" *Punch*
2011-01-30 23:32:03 [INFO] <nawf> good times
2011-01-30 23:32:07 [INFO] <redux06790> yea
2011-01-30 23:32:08 [INFO] <AngryRhetoric> did you put your thumb behind your fingers and then punch? haha
2011-01-30 23:32:13 [INFO] <redux06790> my wife thinks i hate you lol
2011-01-30 23:32:34 [INFO] <nawf> I think erin ducked and I ended up punching him with my thumb
2011-01-30 23:32:38 [INFO] <redux06790> im like ""No I dont hate him, its called debating... some people find it fun""
2011-01-30 23:32:57 [INFO] <AngryRhetoric> lol
2011-01-30 23:33:17 [INFO] <redux06790> man my feet are cold
2011-01-30 23:33:22 [INFO] <redux06790> i need another wife...
2011-01-30 23:33:30 [INFO] <redux06790> so i can wear their vaginas like slippers
2011-01-30 23:35:04 [INFO] <redux06790> so
2011-01-30 23:35:10 [INFO] <redux06790> lets get a mega construction going on
2011-01-30 23:35:24 [INFO] <AngryRhetoric> dual vagina slippers?
2011-01-30 23:35:25 [INFO] <redux06790> find an ocean biome and build a cruise ship or some shit
2011-01-30 23:35:37 [INFO] <redux06790> hell yea dual vagina slippers
2011-01-30 23:35:37 [INFO] <nawf> the ocean is ""north""
2011-01-30 23:35:42 [INFO] <nawf> well the big one
2011-01-30 23:36:07 [INFO] <redux06790> that would be cool if notch made it so the map was finite
2011-01-30 23:36:11 [INFO] <redux06790> huge but finite
2011-01-30 23:36:22 [INFO] <nawf> isn't that the way it is?
2011-01-30 23:36:26 [INFO] <redux06790> and it looped or something
2011-01-30 23:36:30 [INFO] <redux06790> no
2011-01-30 23:36:33 [INFO] <redux06790> it just goes on forever
2011-01-30 23:36:52 [INFO] <efess> yea world keeps generating
2011-01-30 23:36:57 [INFO] <nawf> oh
2011-01-30 23:37:04 [INFO] <redux06790> you could have a world the size of the sun technically
2011-01-30 23:37:14 [INFO] <redux06790> im saying after so many block the world just loops
2011-01-30 23:37:21 [INFO] <redux06790> to give the illusion of being on a globe
2011-01-30 23:37:31 [INFO] <redux06790> would be awesome
2011-01-30 23:37:41 [INFO] <redux06790> then you can make a train that goes around the world
2011-01-30 23:37:58 [INFO] <AngryRhetoric> i thought it had a limit?
2011-01-30 23:38:11 [INFO] <AngryRhetoric> that's cool lol
2011-01-30 23:38:12 [INFO] <redux06790> nope
2011-01-30 23:38:21 [INFO] <redux06790> i walked in one direction for about an hour looking for reeds once
2011-01-30 23:38:23 [INFO] <redux06790> no lie
2011-01-30 23:38:30 [INFO] <redux06790> dont know why i didnt just reroll my map
2011-01-30 23:38:41 [INFO] <nawf> I did the same on this one for the cactus
2011-01-30 23:38:46 [INFO] <nawf> and then I died bring it back
2011-01-30 23:39:00 [INFO] <redux06790> yeah but all you need is one cactus block
2011-01-30 23:39:06 [INFO] <redux06790> then you can make yourself a cactory
2011-01-30 23:39:15 [INFO] <nawf> yeah, we did, but that one cactus took forever
2011-01-30 23:39:20 [INFO] <nawf> its all snow around us
2011-01-30 23:39:26 [INFO] <nawf> well except to the east I think
2011-01-30 23:41:12 [INFO] <redux06790> dude infinite arrows makes my nipples erect
2011-01-30 23:41:31 [INFO] <nawf> its odd, I aim now because spamming got boring
2011-01-30 23:41:38 [INFO] <AngryRhetoric> dont' be cuttin any glass with those
2011-01-30 23:42:02 [INFO] <redux06790> i did the very human thing and rained down death on a creepy simply because i could
2011-01-30 23:42:07 [INFO] <efess> i'm watching G4, there's a dude who paints with his penis
2011-01-30 23:42:09 [INFO] <redux06790> *creeper
2011-01-30 23:42:10 [INFO] <redux06790> lol
2011-01-30 23:42:24 [INFO] <efess> weird.
2011-01-30 23:42:36 [INFO] <nawf> man, its too scary spunking this far from the base
2011-01-30 23:42:40 [INFO] <redux06790> who hasnt painted with their penis at least once
2011-01-30 23:42:50 [INFO] <efess> he does it for a living
2011-01-30 23:42:53 [INFO] <redux06790> oh
2011-01-30 23:42:56 [INFO] <redux06790> i did it for fun
2011-01-30 23:42:58 [INFO] <efess> haha
2011-01-30 23:43:16 [INFO] <redux06790> nobody told me i could make money off it or i would have kept doing it
2011-01-30 23:43:41 [INFO] efess lost connection: disconnect.quitting
2011-01-30 23:43:45 [INFO] efess [/192.168.0.198:14447] logged in with entity id 1288995
2011-01-30 23:44:29 [INFO] <nawf> lol, fall into a pit one block away from lava
2011-01-30 23:44:30 [INFO] <nawf> live
2011-01-30 23:44:35 [INFO] <nawf> ""oh look, diamonds""
2011-01-30 23:44:37 [INFO] <efess> :o
2011-01-30 23:44:39 [INFO] <efess> haha
2011-01-30 23:44:51 [INFO] <efess> I found one because of a chunk error
2011-01-30 23:44:52 [INFO] <efess> woo
2011-01-30 23:46:06 [INFO] <redux06790> FUUUUU!!!!
2011-01-30 23:46:22 [INFO] redux06790 lost connection: disconnect.genericReason
2011-01-30 23:46:26 [INFO] <nawf> ragequit
2011-01-30 23:46:27 [INFO] <nawf> lol
2011-01-30 23:46:31 [INFO] redux06790 [/69.119.8.191:51003] logged in with entity id 1294622
2011-01-30 23:46:40 [INFO] <nawf> ragequit?
2011-01-30 23:46:43 [INFO] <redux06790> no
2011-01-30 23:46:49 [INFO] <redux06790> fucking skelly out of nowhere
2011-01-30 23:46:53 [INFO] <redux06790> then crashed
2011-01-30 23:48:28 [INFO] <redux06790> FUUUU!
2011-01-30 23:48:33 [INFO] <redux06790> i hate when i do that
2011-01-30 23:48:45 [INFO] <redux06790> walk all the way to the surface to need something else
2011-01-30 23:49:47 [INFO] <redux06790> i need like 900 string haha
2011-01-30 23:49:57 [INFO] <redux06790> unless someone has a fuckton of wool lying around
2011-01-30 23:50:04 [INFO] <redux06790> also we need a cactory
2011-01-30 23:50:06 [INFO] <nawf> just idle in the spawner
2011-01-30 23:50:09 [INFO] <redux06790> i think im going to build one
2011-01-30 23:50:16 [INFO] <nawf> err, the loot drop
2011-01-30 23:50:52 [INFO] <redux06790> hey john
2011-01-30 23:51:11 [INFO] <nawf> yes sugerplum?
2011-01-30 23:51:13 [INFO] <redux06790> lets go to mcdonalds and lulz on mc over their wifi
2011-01-30 23:51:47 [INFO] <redux06790> until we get kicked out
2011-01-30 23:51:55 [INFO] <redux06790> for our faggotry
2011-01-30 23:52:11 [INFO] <nawf> heh, are you by canton?
2011-01-30 23:52:15 [INFO] <redux06790> so is there a reason we arent on vent?
2011-01-30 23:52:22 [INFO] <redux06790> oh yeah i forgot you live in colinsville
2011-01-30 23:52:56 [INFO] <nawf> I don't think there is a ""reason"" persay
2011-01-30 23:53:06 [INFO] <redux06790> oh
2011-01-30 23:53:10 [INFO] <redux06790> just sayin
2011-01-30 23:53:15 [INFO] <redux06790> i have a 5 slot server
2011-01-30 23:53:25 [INFO] <nawf> orly?
2011-01-30 23:53:28 [INFO] <redux06790> wtf what is with the major lack of string
2011-01-30 23:53:31 [INFO] <redux06790> yearly
2011-01-30 23:53:36 [INFO] <redux06790> err
2011-01-30 23:53:37 [INFO] <nawf> we threw it all away
2011-01-30 23:53:39 [INFO] <redux06790> YARLY!!!
2011-01-30 23:53:51 [INFO] <redux06790> no no i mean its not producing alot of string
2011-01-30 23:54:00 [INFO] <redux06790> aka not producing alot of spiders
2011-01-30 23:54:15 [INFO] <AngryRhetoric> alright guys i'm out for the night
2011-01-30 23:54:16 [INFO] <nawf> thats because the spiders can climb out of the shoot
2011-01-30 23:54:21 [INFO] <efess> l8r kevin
2011-01-30 23:54:28 [INFO] <AngryRhetoric> laater
2011-01-30 23:54:32 [INFO] <nawf> yeah, me too too
2011-01-30 23:54:35 [INFO] <nawf> too too?
2011-01-30 23:54:48 [INFO] <efess> wearing one too?
2011-01-30 23:54:51 [INFO] <redux06790> buh spiders should not be able to climb
2011-01-30 23:54:54 [INFO] <redux06790> it makes me sad
2011-01-30 23:54:58 [INFO] <nawf> it makes me dead
2011-01-30 23:55:01 [INFO] <AngryRhetoric> tuutuu hot haha
2011-01-30 23:55:19 [INFO] <nawf> I idle during the day sometimes erin, I won't throw all the string away next time I do
2011-01-30 23:55:38 [INFO] <redux06790> easy wool blocks
2011-01-30 23:55:40 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-30 23:55:56 [INFO] <nawf> I'm out too, later fellers
2011-01-30 23:56:02 [INFO] <efess> l8r john
2011-01-30 23:56:10 [INFO] nawf lost connection: disconnect.quitting
2011-01-30 23:59:52 [INFO] <efess> i'm out too, l8r
2011-01-31 00:00:04 [INFO] efess lost connection: disconnect.quitting
2011-01-31 03:36:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-31 03:42:19 [INFO] redux06790 lost connection: disconnect.genericReason
2011-01-31 03:42:32 [INFO] redux06790 [/69.119.8.191:51608] logged in with entity id 1511511
2011-01-31 04:23:59 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 13:05:31 [INFO] redux06790 [/69.119.8.191:49261] logged in with entity id 1535984
2011-01-31 13:51:00 [INFO] nawf [/76.23.232.27:55313] logged in with entity id 1567985
2011-01-31 13:51:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-01-31 13:51:06 [INFO] <redux06790> RAWR
2011-01-31 13:51:27 [INFO] <nawf> damn, I logged into idle and collect mob drops
2011-01-31 13:51:33 [INFO] <nawf> forgot I'm totally lost in a cave
2011-01-31 13:51:55 [INFO] <redux06790> i made a new chute that drops a little something off at the collection point
2011-01-31 13:52:08 [INFO] <nawf> pigs?
2011-01-31 13:52:15 [INFO] <redux06790> nah... just cactus
2011-01-31 13:52:57 [INFO] <redux06790> we will have all the green dye we will ever desire
2011-01-31 13:53:05 [INFO] <redux06790> i also organized the store room
2011-01-31 13:53:21 [INFO] <redux06790> because im insane like that
2011-01-31 13:54:21 [INFO] <redux06790> so what you just afk and when you come back your inventory is full?
2011-01-31 13:54:29 [INFO] <nawf> yeah
2011-01-31 13:54:41 [INFO] <redux06790> the sulphur chest is full
2011-01-31 13:54:43 [INFO] <nawf> I work from home so its easy to check up on it
2011-01-31 13:59:03 [INFO] <nawf> where is the cactus spawner, upstairs?
2011-01-31 13:59:08 [INFO] <redux06790> no
2011-01-31 13:59:14 [INFO] <redux06790> its in the collection room
2011-01-31 13:59:28 [INFO] <redux06790> its just a small one because we dont need 600 cacti an hour
2011-01-31 13:59:36 [INFO] <nawf> sweet
2011-01-31 13:59:44 [INFO] <nawf> lol, random wool colors
2011-01-31 13:59:46 [INFO] <redux06790> i would say it makes maybe 10 an hour
2011-01-31 13:59:48 [INFO] <nawf> I was just farting about with those
2011-01-31 14:00:44 [INFO] <redux06790> the way i design my cactus factory makes it very expandable but it leaves a huge footprint if you ex
2011-01-31 14:01:00 [INFO] <redux06790> pand it
2011-01-31 14:01:03 [INFO] <nawf> right
2011-01-31 14:01:09 [INFO] <nawf> need a sand run soon
2011-01-31 14:01:27 [INFO] <redux06790> i picked up about 6 stacks
2011-01-31 14:01:50 [INFO] <redux06790> we have 3x +44 atm
2011-01-31 14:01:54 [INFO] <nawf> need about 31 more
2011-01-31 14:01:58 [INFO] <nawf> tnt!
2011-01-31 14:02:04 [INFO] <redux06790> um
2011-01-31 14:02:05 [INFO] <nawf> we've devastated entire mountains
2011-01-31 14:02:13 [INFO] <redux06790> theres a ton of TnT
2011-01-31 14:02:21 [INFO] <redux06790> we have 4 stacks of it
2011-01-31 14:02:25 [INFO] <nawf> pssh
2011-01-31 14:02:37 [INFO] <nawf> you must dream a little bigger darling
2011-01-31 14:02:44 [INFO] <nawf> BWAAAAAAAAAAAAMPH
2011-01-31 14:02:50 [INFO] <redux06790> yeah but
2011-01-31 14:02:54 [INFO] <redux06790> im weird
2011-01-31 14:03:05 [INFO] <redux06790> i dont like to disrupt the natural look of the surface if i dont have to
2011-01-31 14:03:16 [INFO] <nawf> yeah, me too
2011-01-31 14:03:25 [INFO] <nawf> thats why my sand pit is out yonder
2011-01-31 14:03:33 [INFO] <redux06790> um...
2011-01-31 14:03:36 [INFO] <redux06790> under water?
2011-01-31 14:03:40 [INFO] <nawf> and with the tnt we blend shit in usually
2011-01-31 14:04:08 [INFO] <redux06790> wtf
2011-01-31 14:04:13 [INFO] <redux06790> are you invis?
2011-01-31 14:04:15 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 14:04:18 [INFO] redux06790 [/69.119.8.191:49272] logged in with entity id 1580625
2011-01-31 14:04:22 [INFO] <redux06790> you were
2011-01-31 14:04:23 [INFO] <nawf> yeah, it happens from time to time
2011-01-31 14:04:30 [INFO] <redux06790> so what do you think?
2011-01-31 14:04:39 [INFO] <redux06790> of the improvements?
2011-01-31 14:04:50 [INFO] <nawf> its clean, as long as its easy to find stuff
2011-01-31 14:04:51 [INFO] <redux06790> i get a little OCD with inventory
2011-01-31 14:05:33 [INFO] <nawf> yeah, we org from time to time
2011-01-31 14:05:37 [INFO] <redux06790> i spent most of the night making the cactory and cleaning up in here
2011-01-31 14:05:44 [INFO] <nawf> I like it, I can find things
2011-01-31 14:06:01 [INFO] <nawf> the cactus thing is awesome
2011-01-31 14:06:06 [INFO] <redux06790> once i start figuring out where everything is i will be making waypoint signs
2011-01-31 14:06:17 [INFO] <redux06790> dude its so easy to make too check it
2011-01-31 14:06:21 [INFO] <nawf> yeah, we need a good list of coords
2011-01-31 14:06:27 [INFO] <nawf> yeah, I've made one before
2011-01-31 14:06:45 [INFO] <redux06790> i did a little decorative work with it too
2011-01-31 14:06:47 [INFO] <redux06790> cmere
2011-01-31 14:06:51 [INFO] <nawf> you should do glass here, it looks cool from here
2011-01-31 14:07:11 [INFO] <redux06790> check this out
2011-01-31 14:07:36 [INFO] <redux06790> cactus windows
2011-01-31 14:07:37 [INFO] <redux06790> lol
2011-01-31 14:07:40 [INFO] <nawf> oh thats cool
2011-01-31 14:07:51 [INFO] <nawf> joe or I will probably smooth stone it at some point
2011-01-31 14:07:51 [INFO] <redux06790> im going to turn this area into a loungey type thing
2011-01-31 14:08:01 [INFO] <nawf> we are ocd about smoothstone
2011-01-31 14:08:02 [INFO] <redux06790> yeah i noticed you guys are big on that
2011-01-31 14:08:09 [INFO] <nawf> yeah, well you see this wall here
2011-01-31 14:08:09 [INFO] <redux06790> i am too
2011-01-31 14:08:18 [INFO] <redux06790> yess
2011-01-31 14:08:19 [INFO] <nawf> we want ot blow it out
2011-01-31 14:08:25 [INFO] <nawf> so you can go to the lake and shit
2011-01-31 14:08:40 [INFO] <redux06790> yeah i need to make signs lol
2011-01-31 14:08:49 [INFO] <redux06790> with arrows pointing where everything is
2011-01-31 14:08:56 [INFO] <nawf> eventuall we want everything around the spawner to be blown out
2011-01-31 14:09:02 [INFO] <nawf> so the rate increases
2011-01-31 14:09:13 [INFO] <nawf> and it will be a cool underground cavern
2011-01-31 14:09:14 [INFO] <redux06790> do you use classic textures?
2011-01-31 14:09:23 [INFO] <nawf> yeah, with better grass and light
2011-01-31 14:09:28 [INFO] <nawf> do you use that?
2011-01-31 14:09:35 [INFO] <redux06790> i use painterly pack
2011-01-31 14:09:37 [INFO] <redux06790> custom
2011-01-31 14:09:59 [INFO] <nawf> I'll blow up this wall later tonight
2011-01-31 14:10:01 [INFO] <redux06790> i had an HD pack but i think it detracts away from the overall aesthetic of the game
2011-01-31 14:10:14 [INFO] <nawf> yeah, I just use the better light, smooths the lighting over
2011-01-31 14:10:23 [INFO] <redux06790> where do you get that?
2011-01-31 14:10:30 [INFO] <nawf> mrmods better light
2011-01-31 14:10:42 [INFO] <redux06790> huge difference or no?
2011-01-31 14:10:53 [INFO] <redux06790> i need to make a watervator
2011-01-31 14:10:53 [INFO] <nawf> oh yeah, its awesome but keeps the overall feel the same
2011-01-31 14:11:26 [INFO] <redux06790> this is pretty bad ass for being made only by 3 people
2011-01-31 14:11:34 [INFO] <nawf> yeah, or mostly 1
2011-01-31 14:11:38 [INFO] <redux06790> have you seen the raputre video?
2011-01-31 14:11:40 [INFO] <nawf> I don't play anything else anymore
2011-01-31 14:11:42 [INFO] <nawf> yeah
2011-01-31 14:11:55 [INFO] <redux06790> i wanna make ironforge or stormwind
2011-01-31 14:11:58 [INFO] <redux06790> ... or both
2011-01-31 14:12:25 [INFO] <nawf> we are standing on a future railine
2011-01-31 14:12:36 [INFO] <redux06790> yeah i dont get all that rail shit
2011-01-31 14:12:38 [INFO] <nawf> once the castle gets done, this will replace that straight one
2011-01-31 14:12:40 [INFO] <redux06790> with boosters and crap
2011-01-31 14:12:54 [INFO] <redux06790> the powered minecart has promise
2011-01-31 14:13:05 [INFO] <redux06790> but theres no way to ride them
2011-01-31 14:13:05 [INFO] <nawf> yeah, we do boosters because its the only way right now
2011-01-31 14:13:15 [INFO] <nawf> and we had to build the spawner in the ocean
2011-01-31 14:13:35 [INFO] <redux06790> i still wanna poke around inside that thing
2011-01-31 14:13:52 [INFO] <nawf> just be real careful, look in from the root
2011-01-31 14:13:58 [INFO] <nawf> roof
2011-01-31 14:14:04 [INFO] <nawf> because we had access doors
2011-01-31 14:14:12 [INFO] <nawf> but if you walked in you'd die
2011-01-31 14:14:16 [INFO] <redux06790> AHH!!!!!
2011-01-31 14:14:18 [INFO] <nawf> and creepers would fuck it up
2011-01-31 14:14:19 [INFO] <redux06790> HALP!
2011-01-31 14:14:54 [INFO] <redux06790> i am the victor
2011-01-31 14:15:10 [INFO] <redux06790> we need to make a livestock grinder
2011-01-31 14:15:30 [INFO] <nawf> yeah, there is some space directly under the mob spawner
2011-01-31 14:15:39 [INFO] <nawf> and we were going to connect it to the death chute
2011-01-31 14:15:48 [INFO] <redux06790> all the wool, bacon, and leather you will ever need
2011-01-31 14:16:10 [INFO] <redux06790> you should cheat and give yourself a grass block too... that way you dont have to make a path
2011-01-31 14:16:21 [INFO] <nawf> naw, no cheats
2011-01-31 14:16:26 [INFO] <redux06790> because im assuming you pathed all the grass down here
2011-01-31 14:16:30 [INFO] <nawf> oh yeah
2011-01-31 14:16:38 [INFO] <nawf> thats why the path up the chute is all fucked up
2011-01-31 14:16:57 [INFO] <nawf> it was grass, then kev put stairs on the grass
2011-01-31 14:17:00 [INFO] <nawf> then we blew shit out
2011-01-31 14:17:02 [INFO] <redux06790> yeah ive noticed you guys dont like to make direct routes haha
2011-01-31 14:17:06 [INFO] <nawf> then a creeper blew up
2011-01-31 14:17:10 [INFO] <nawf> well it WAS
2011-01-31 14:17:19 [INFO] <redux06790> i was thinking of fixing it
2011-01-31 14:17:34 [INFO] <nawf> yeah, we wanted to make it so you could see all the way up the death chute
2011-01-31 14:17:56 [INFO] <nawf> yeah, what a mess up there
2011-01-31 14:18:02 [INFO] <redux06790> lol
2011-01-31 14:18:10 [INFO] <redux06790> you should make a watervator next to it
2011-01-31 14:18:18 [INFO] <nawf> yeah, that would be awesome
2011-01-31 14:18:37 [INFO] <nawf> so much dying
2011-01-31 14:18:43 [INFO] <redux06790> all in all
2011-01-31 14:18:48 [INFO] <redux06790> this shit is pretty epic
2011-01-31 14:18:53 [INFO] <redux06790> what did it all start with?
2011-01-31 14:19:03 [INFO] <nawf> the base by the spawner
2011-01-31 14:19:11 [INFO] <nawf> and down here was like a 10x10 room
2011-01-31 14:19:18 [INFO] <nawf> then we built half the spanwer
2011-01-31 14:19:20 [INFO] <nawf> just joe and I
2011-01-31 14:19:30 [INFO] <nawf> blew out down here a little, and kev joe and I build the other half
2011-01-31 14:19:41 [INFO] <redux06790> you guys are on a whole new level
2011-01-31 14:19:48 [INFO] <redux06790> i just like making decorative stuff
2011-01-31 14:19:55 [INFO] <nawf> thanks, well we wanted the tnt
2011-01-31 14:20:04 [INFO] <nawf> and I like terraforming and scenic stuff
2011-01-31 14:20:12 [INFO] <nawf> so thats where the underground river came from
2011-01-31 14:21:36 [INFO] <nawf> joe does most of the redstone/track work
2011-01-31 14:21:42 [INFO] <nawf> kevin is building a castle + town up there
2011-01-31 14:21:59 [INFO] <redux06790> i like to build unorthodox buildings
2011-01-31 14:22:31 [INFO] <nawf> sweet, we don't have many ""houses"" or things like that
2011-01-31 14:22:35 [INFO] <nawf> everything is pretty utilitarian
2011-01-31 14:22:59 [INFO] <redux06790> yeah thats why i like smp
2011-01-31 14:23:07 [INFO] <redux06790> i dont do alot of fuctional building
2011-01-31 14:23:21 [INFO] <redux06790> i just like to build shit that makes people go... woah
2011-01-31 14:23:30 [INFO] <nawf> sweet
2011-01-31 14:23:47 [INFO] <redux06790> unfortunately wool is a bitch to get and i need about 600 of it for my next building
2011-01-31 14:23:59 [INFO] <redux06790> im thinking of just subbing with half blocks
2011-01-31 14:24:04 [INFO] <redux06790> since they are close to white
2011-01-31 14:24:29 [INFO] <nawf> I'm a fan of half blocks
2011-01-31 14:24:53 [INFO] <redux06790> there needs to be more variety in them tho
2011-01-31 14:24:58 [INFO] <redux06790> i would love wood half blocks
2011-01-31 14:25:01 [INFO] <redux06790> or wool half blocks
2011-01-31 14:25:26 [INFO] <nawf> haha, sweet portal cube
2011-01-31 14:25:34 [INFO] <redux06790> oh my house?
2011-01-31 14:25:38 [INFO] <redux06790> dont put torches on it
2011-01-31 14:25:42 [INFO] <redux06790> parts of it will melt lol
2011-01-31 14:26:22 [INFO] <redux06790> i WAS going to go full scale
2011-01-31 14:26:35 [INFO] <redux06790> but like i did with my horribly failed spawner in SSP
2011-01-31 14:26:41 [INFO] <redux06790> but thats like triple the blocks
2011-01-31 14:26:48 [INFO] <nawf> are those snow blocks?
2011-01-31 14:26:48 [INFO] <redux06790> and i dont need that much space
2011-01-31 14:26:51 [INFO] <redux06790> yea
2011-01-31 14:26:57 [INFO] <nawf> I didn't even know you could make those
2011-01-31 14:26:59 [INFO] <redux06790> till i get enough wool
2011-01-31 14:27:02 [INFO] <redux06790> yea
2011-01-31 14:27:05 [INFO] <redux06790> 4 snowballs
2011-01-31 14:27:12 [INFO] <nawf> oh man, I've been wasting snowballs
2011-01-31 14:27:17 [INFO] <redux06790> lol
2011-01-31 14:27:19 [INFO] <nawf> throwing them at joe
2011-01-31 14:27:37 [INFO] <nawf> this was the last sand pit
2011-01-31 14:27:41 [INFO] <redux06790> lol
2011-01-31 14:27:42 [INFO] <nawf> now its just ""the whirlpool""
2011-01-31 14:27:44 [INFO] <redux06790> it drove me nuts
2011-01-31 14:27:47 [INFO] <redux06790> ive been filling it in
2011-01-31 14:27:57 [INFO] <redux06790> wanna see an epic trick?
2011-01-31 14:27:58 [INFO] <nawf> lol, yeah, we didn't plan ahead
2011-01-31 14:28:02 [INFO] <redux06790> cmere
2011-01-31 14:28:14 [INFO] <redux06790> derp
2011-01-31 14:28:30 [INFO] <redux06790> i learned how to do this on my old SMP
2011-01-31 14:28:42 [INFO] <nawf> sweet
2011-01-31 14:28:44 [INFO] <redux06790> crap
2011-01-31 14:28:49 [INFO] <redux06790> i need a block to get out haha
2011-01-31 14:29:11 [INFO] <redux06790> good trick to hide shit under lakes
2011-01-31 14:29:26 [INFO] <redux06790> so yeah ibe been using the spare dirt to fill this bitch in
2011-01-31 14:29:27 [INFO] <nawf> true, we are going to try and keep the server ""friendly""
2011-01-31 14:29:37 [INFO] <nawf> and with known people so we can share shit and stuff
2011-01-31 14:29:42 [INFO] <nawf> not worry about griefers
2011-01-31 14:29:56 [INFO] <redux06790> and have no need to bog the server down with anti griefing addons
2011-01-31 14:30:23 [INFO] <redux06790> yoube played wow right?
2011-01-31 14:30:33 [INFO] <nawf> nope
2011-01-31 14:30:47 [INFO] <redux06790> sec
2011-01-31 14:30:58 [INFO] <redux06790> a chunk just dissapeared under my feet need to relog
2011-01-31 14:31:00 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 14:31:03 [INFO] redux06790 [/69.119.8.191:49275] logged in with entity id 1598096
2011-01-31 14:31:20 [INFO] <redux06790> i thought youve played wow
2011-01-31 14:31:23 [INFO] <redux06790> huh
2011-01-31 14:31:30 [INFO] <redux06790> i made the goldshire inn on one of my SSPs
2011-01-31 14:31:42 [INFO] <redux06790> took about 1000 wood
2011-01-31 14:31:57 [INFO] <nawf> nice, well I've gtg
2011-01-31 14:31:59 [INFO] <redux06790> k
2011-01-31 14:32:05 [INFO] <nawf> I'll be on later
2011-01-31 14:32:11 [INFO] <redux06790> yeah ill probably be on around 8
2011-01-31 14:32:15 [INFO] <redux06790> then again around 1am
2011-01-31 14:32:15 [INFO] <nawf> cool
2011-01-31 14:32:31 [INFO] <nawf> so thats where my boat went
2011-01-31 14:32:54 [INFO] nawf lost connection: disconnect.quitting
2011-01-31 14:34:22 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 14:37:16 [INFO] redux06790 [/69.119.8.191:49329] logged in with entity id 1601337
2011-01-31 14:37:26 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 17:42:26 [INFO] nawf [/76.23.232.27:55070] logged in with entity id 1601714
2011-01-31 18:05:30 [INFO] efess [/192.168.0.198:16835] logged in with entity id 1620020
2011-01-31 18:05:42 [INFO] <nawf> sup joe
2011-01-31 18:05:50 [INFO] <efess> Hey dude
2011-01-31 18:06:01 [INFO] <nawf> erin organised
2011-01-31 18:06:02 [INFO] <efess> did some remodeling?
2011-01-31 18:06:40 [INFO] <efess> haha cactus
2011-01-31 18:06:53 [INFO] <efess> awesome.
2011-01-31 18:06:56 [INFO] <nawf> he made a companion cube house oo
2011-01-31 18:07:01 [INFO] <nawf> its pretty cool
2011-01-31 18:09:02 [INFO] <efess> nice
2011-01-31 18:10:51 [INFO] <nawf> it was funny before
2011-01-31 18:10:58 [INFO] <nawf> he was like ""you have tons of tnt""
2011-01-31 18:11:14 [INFO] <efess> ahha ""tons""
2011-01-31 18:11:14 [INFO] <nawf> and I said, pssh 5 stacks, no we don't
2011-01-31 18:11:17 [INFO] <efess> yea
2011-01-31 18:11:18 [INFO] <efess> no shit
2011-01-31 18:13:01 [INFO] <efess> squids
2011-01-31 18:13:29 [INFO] <efess> i'm goin to pick a spot and funnel them to the death chute
2011-01-31 18:13:44 [INFO] <nawf> we should build the friendly mobs too
2011-01-31 18:13:51 [INFO] <nawf> the friendly funnel
2011-01-31 18:13:53 [INFO] <efess> yea
2011-01-31 18:14:58 [INFO] <nawf> man, how are you going to get the squids in there?
2011-01-31 18:17:03 [INFO] <nawf> brb
2011-01-31 18:17:05 [INFO] nawf lost connection: disconnect.quitting
2011-01-31 18:21:21 [INFO] redux06790 [/69.119.8.191:49359] logged in with entity id 1632517
2011-01-31 18:21:28 [INFO] <efess> hey
2011-01-31 18:21:46 [INFO] <redux06790> its literally always night when i log on
2011-01-31 18:21:52 [INFO] <redux06790> you like the cactus factory i made?
2011-01-31 18:21:57 [INFO] <efess> nice job with the house
2011-01-31 18:22:00 [INFO] nawf [/76.23.232.27:55006] logged in with entity id 1632915
2011-01-31 18:22:00 [INFO] <efess> yea that's pretty sweet
2011-01-31 18:22:06 [INFO] <redux06790> green dye for all!
2011-01-31 18:22:17 [INFO] <efess> haha, did you build on ice on purpose?
2011-01-31 18:22:22 [INFO] <redux06790> yes
2011-01-31 18:22:40 [INFO] <redux06790> its going to be boat access when its done
2011-01-31 18:22:49 [INFO] <efess> sweet
2011-01-31 18:23:09 [INFO] <redux06790> FUUUU!
2011-01-31 18:23:10 [INFO] <redux06790> dude
2011-01-31 18:23:26 [INFO] <redux06790> creepers where we dont want them
2011-01-31 18:23:32 [INFO] <redux06790> not cool zues
2011-01-31 18:23:40 [INFO] <redux06790> zeus
2011-01-31 18:23:42 [INFO] <redux06790> derp
2011-01-31 18:24:31 [INFO] <redux06790> so i am thinking i might go ahead and make myself a livestock grinder
2011-01-31 18:24:41 [INFO] <nawf> we were just talking about that
2011-01-31 18:24:46 [INFO] <nawf> hooking it into the death chute
2011-01-31 18:24:51 [INFO] <redux06790> because im always in need of wool
2011-01-31 18:25:04 [INFO] <nawf> there is a semi hollowed out space right below the mob grinder
2011-01-31 18:25:05 [INFO] <efess> yea i'm below the ocean working on a squid funnel
2011-01-31 18:25:22 [INFO] <redux06790> notch needs to make scuba gear
2011-01-31 18:26:07 [INFO] <redux06790> ok
2011-01-31 18:26:13 [INFO] <redux06790> are feathers junk?
2011-01-31 18:26:19 [INFO] <redux06790> like do we need them for anything at all?
2011-01-31 18:26:23 [INFO] <nawf> nope
2011-01-31 18:26:24 [INFO] <efess> they're junk
2011-01-31 18:26:34 [INFO] <redux06790> k im going to toss them out then because we have almost 20 stacks
2011-01-31 18:26:46 [INFO] <efess> same with string
2011-01-31 18:26:47 [INFO] <nawf> yeah, before we had a whole double chest full
2011-01-31 18:26:50 [INFO] <nawf> just wasted space
2011-01-31 18:26:56 [INFO] <redux06790> No way
2011-01-31 18:27:01 [INFO] <redux06790> string is valuable
2011-01-31 18:27:11 [INFO] <redux06790> string = wool
2011-01-31 18:27:12 [INFO] <efess> what for? wool?
2011-01-31 18:27:17 [INFO] <redux06790> wool = awesome builds
2011-01-31 18:27:28 [INFO] <nawf> oh erin, leave lapis if you find it
2011-01-31 18:27:31 [INFO] <efess> I'm not much into artwork :D
2011-01-31 18:27:45 [INFO] <nawf> there is a bug in smp and it will only drop one lapis when you mine it
2011-01-31 18:27:49 [INFO] <redux06790> yeah john was explaining that most of you guys' builds are utilitarin
2011-01-31 18:28:00 [INFO] <redux06790> ok so
2011-01-31 18:28:06 [INFO] <nawf> I just like terraforming, but I do dig my tower
2011-01-31 18:28:06 [INFO] <redux06790> just leave it till the bux it patched?
2011-01-31 18:28:18 [INFO] <nawf> yeah, that way we don't waste it
2011-01-31 18:28:25 [INFO] <nawf> the rate goes from 1 to 4-6 per block
2011-01-31 18:28:26 [INFO] <nawf> so thats huge
2011-01-31 18:28:35 [INFO] <redux06790> well
2011-01-31 18:29:06 [INFO] <redux06790> one thing we are severly lacking is buckets of lava
2011-01-31 18:29:15 [INFO] <nawf> I have 3 by my tower
2011-01-31 18:29:18 [INFO] <redux06790> lava = best furnace fuel
2011-01-31 18:29:23 [INFO] <redux06790> for long burns
2011-01-31 18:29:32 [INFO] <efess> oh you can use lava in furnace?
2011-01-31 18:29:36 [INFO] <redux06790> hell yea
2011-01-31 18:29:39 [INFO] <redux06790> it burns FOREVER
2011-01-31 18:29:41 [INFO] <efess> nice, did not know that
2011-01-31 18:29:41 [INFO] <nawf> yeah, 1000 smelt
2011-01-31 18:29:56 [INFO] <efess> and why aren't we doin that? :)
2011-01-31 18:29:56 [INFO] <redux06790> its good when you want to devote time to mass smelting
2011-01-31 18:30:03 [INFO] <nawf> because you have to sit there
2011-01-31 18:30:12 [INFO] <redux06790> because unless youre going to babysit the furnaces its a waste
2011-01-31 18:30:14 [INFO] <nawf> it will burn out if it has nothing to do, unlike coal or wood
2011-01-31 18:30:18 [INFO] <efess> oh
2011-01-31 18:30:38 [INFO] <redux06790> but its valuable to have at least a half chest full of the stuff
2011-01-31 18:30:45 [INFO] <redux06790> if you have the iron to waste
2011-01-31 18:31:41 [INFO] <redux06790> also you should use wood to cook food
2011-01-31 18:31:48 [INFO] <redux06790> its less wastefull
2011-01-31 18:31:55 [INFO] <nawf> I geddit
2011-01-31 18:32:06 [INFO] <nawf> I'm going to use lava to make you angry
2011-01-31 18:32:06 [INFO] <redux06790> 1 coal for 1 porkchop not worth it imo
2011-01-31 18:32:10 [INFO] <efess> haha
2011-01-31 18:32:15 [INFO] <efess> one lava for one porkchop
2011-01-31 18:32:17 [INFO] <redux06790> lol
2011-01-31 18:32:23 [INFO] <redux06790> thats a well done chop
2011-01-31 18:34:35 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 18:36:07 [INFO] <efess> LOL
2011-01-31 18:36:17 [INFO] <nawf> squid funnel?
2011-01-31 18:36:18 [INFO] <efess> mine-strone
2011-01-31 18:36:21 [INFO] <nawf> rofl
2011-01-31 18:41:44 [INFO] <efess> its a food trap
2011-01-31 18:41:46 [INFO] <efess> :o
2011-01-31 18:43:21 [INFO] <efess> ;o blocks of iron...
2011-01-31 18:43:37 [INFO] <nawf> wha?
2011-01-31 18:43:52 [INFO] <efess> I think erin made a bunch of iron blocks
2011-01-31 18:44:29 [INFO] <efess> I don't believe they serve any purpose other than aestetic
2011-01-31 18:44:35 [INFO] <efess> but they use 9 iron
2011-01-31 18:44:39 [INFO] <nawf> less space I think
2011-01-31 18:44:45 [INFO] <efess> can you break them apart?
2011-01-31 18:44:48 [INFO] <nawf> yeah
2011-01-31 18:44:50 [INFO] <efess> oh nm
2011-01-31 18:46:34 [INFO] <efess> omg creeper in my condo
2011-01-31 18:46:46 [INFO] <efess> she put on my shirt
2011-01-31 18:49:34 [INFO] AngryRhetoric [/24.147.183.4:49478] logged in with entity id 1671438
2011-01-31 18:49:41 [INFO] <nawf> yo
2011-01-31 18:49:44 [INFO] <efess> supz
2011-01-31 18:49:49 [INFO] <AngryRhetoric> sup john, joe
2011-01-31 18:49:55 [INFO] <AngryRhetoric> fancy meeting you on here
2011-01-31 18:51:42 [INFO] <AngryRhetoric> we gotta get konrad hooked onthis
2011-01-31 18:51:56 [INFO] <AngryRhetoric> and alan too heh
2011-01-31 18:52:09 [INFO] <nawf> naw, alans japanese, he'll just win all the time
2011-01-31 18:52:14 [INFO] <efess> LOL
2011-01-31 18:52:21 [INFO] <efess> I thoguht that was korean
2011-01-31 18:52:30 [INFO] <AngryRhetoric> hahha
2011-01-31 18:52:35 [INFO] <AngryRhetoric> he finds a way to win at minecraft
2011-01-31 18:53:13 [INFO] <AngryRhetoric> yeah he's not turned starcraft2 into a full-time career
2011-01-31 18:54:45 [INFO] <nawf> man creepers are dicks
2011-01-31 18:54:50 [INFO] <AngryRhetoric> yes
2011-01-31 18:55:05 [INFO] <efess> I concur
2011-01-31 18:57:36 [INFO] <efess> brb
2011-01-31 18:57:38 [INFO] efess lost connection: disconnect.quitting
2011-01-31 19:03:01 [INFO] <AngryRhetoric> ""punch her really hard right inher hepatitis""
2011-01-31 19:03:15 [INFO] <nawf> huh
2011-01-31 19:03:18 [INFO] <AngryRhetoric> haha
2011-01-31 19:04:35 [INFO] <AngryRhetoric> family guy
2011-01-31 19:06:39 [INFO] <nawf> are you filling in that whole areas depth?
2011-01-31 19:06:45 [INFO] <nawf> the town?
2011-01-31 19:07:01 [INFO] <AngryRhetoric> haha yeah probably
2011-01-31 19:07:05 [INFO] <nawf> damn thats a lot of work
2011-01-31 19:07:07 [INFO] <AngryRhetoric> i might leave one step down
2011-01-31 19:07:15 [INFO] <AngryRhetoric> yeah i already burned through a ton of dirt, literally
2011-01-31 19:07:17 [INFO] <nawf> I cheat by putting torches down and building over that
2011-01-31 19:07:25 [INFO] <nawf> so you only have to do one level
2011-01-31 19:07:34 [INFO] <AngryRhetoric> yeah i could
2011-01-31 19:07:43 [INFO] <AngryRhetoric> heh i'd know i cheated with it lol
2011-01-31 19:07:53 [INFO] <nawf> heh, yeah
2011-01-31 19:08:23 [INFO] <AngryRhetoric> i don't have that much left to fill
2011-01-31 19:08:27 [INFO] <nawf> 66, 212, that is the center point of your castel
2011-01-31 19:08:40 [INFO] <nawf> well, 66, -212
2011-01-31 19:09:26 [INFO] <AngryRhetoric> what's at those coords
2011-01-31 19:09:53 [INFO] <nawf> the tower
2011-01-31 19:10:00 [INFO] <AngryRhetoric> haha nice
2011-01-31 19:10:11 [INFO] <nawf> I want to see what it will take to get the river over there
2011-01-31 19:17:33 [INFO] <AngryRhetoric> snowballs don't kill creeprs
2011-01-31 19:17:43 [INFO] <AngryRhetoric> does the tower have a ladder ?
2011-01-31 19:17:52 [INFO] <nawf> mine?  nope, not yet
2011-01-31 19:22:59 [INFO] <nawf> ok, I'm directly under your tower
2011-01-31 19:23:06 [INFO] <AngryRhetoric> no way
2011-01-31 19:23:12 [INFO] <AngryRhetoric> i'll build a stair way down
2011-01-31 19:23:24 [INFO] <AngryRhetoric> holy shit you're way down lol
2011-01-31 19:26:45 [INFO] <AngryRhetoric> you still under my tower?
2011-01-31 19:26:56 [INFO] <nawf> naw, I left
2011-01-31 19:27:15 [INFO] <AngryRhetoric> i'm building a stairway down
2011-01-31 19:27:54 [INFO] <AngryRhetoric> come back so i can see where to build to
2011-01-31 19:28:27 [INFO] <nawf> ok
2011-01-31 19:28:29 [INFO] <nawf> I got a little lost
2011-01-31 19:28:41 [INFO] <AngryRhetoric> hah
2011-01-31 19:29:59 [INFO] <nawf> still lost
2011-01-31 19:30:01 [INFO] <nawf> damn
2011-01-31 19:30:03 [INFO] <AngryRhetoric> lol
2011-01-31 19:30:05 [INFO] <nawf> went the wrong way
2011-01-31 19:30:17 [INFO] <AngryRhetoric> my tower is at coords:
2011-01-31 19:30:27 [INFO] <nawf> 66, -220
2011-01-31 19:30:31 [INFO] <AngryRhetoric> 64,41,-221
2011-01-31 19:32:20 [INFO] <nawf> ok, I got it
2011-01-31 19:32:36 [INFO] <nawf> wait right there, in fact go up
2011-01-31 19:32:39 [INFO] <nawf> let me set off some tnt
2011-01-31 19:33:06 [INFO] <AngryRhetoric> whats your y coord?
2011-01-31 19:33:10 [INFO] <AngryRhetoric> i'm at 35
2011-01-31 19:33:12 [INFO] <nawf> 13
2011-01-31 19:33:19 [INFO] <nawf> I think you'll be safe
2011-01-31 19:33:25 [INFO] <AngryRhetoric> oh yeah i had a ways to go
2011-01-31 19:33:32 [INFO] <nawf> well I want to explode some tnt
2011-01-31 19:33:39 [INFO] <nawf> you maybe too close
2011-01-31 19:33:40 [INFO] <AngryRhetoric> haha i'll hear it from here
2011-01-31 19:33:48 [INFO] <AngryRhetoric> DO  IT
2011-01-31 19:33:49 [INFO] <nawf> ok
2011-01-31 19:33:53 [INFO] <nawf> FIRE IN THE HOLE
2011-01-31 19:34:11 [INFO] <AngryRhetoric> i heard it
2011-01-31 19:34:15 [INFO] <AngryRhetoric> didn't see anything
2011-01-31 19:36:06 [INFO] <AngryRhetoric> sweeeet
2011-01-31 19:36:07 [INFO] <AngryRhetoric> found it
2011-01-31 19:36:19 [INFO] <AngryRhetoric> lava
2011-01-31 19:37:32 [INFO] <nawf> holy shit
2011-01-31 19:37:37 [INFO] <nawf> mob party
2011-01-31 19:39:25 [INFO] <nawf> I'm going to head back and lay a lot of tnt
2011-01-31 19:39:32 [INFO] <nawf> I won't explode it until you sa your clear
2011-01-31 19:39:38 [INFO] <AngryRhetoric> this connects to the other tower?
2011-01-31 19:39:43 [INFO] <nawf> naw, the vault
2011-01-31 19:42:11 [INFO] <nawf> ok, just let me know when you're ready
2011-01-31 19:42:46 [INFO] efess [/192.168.0.198:19550] logged in with entity id 1744256
2011-01-31 19:45:21 [INFO] nawf lost connection: disconnect.quitting
2011-01-31 19:45:23 [INFO] /76.23.232.27:55037 lost connection
2011-01-31 19:46:12 [INFO] Disconnecting /76.23.232.27:55002: Took too long to log in
2011-01-31 19:47:16 [INFO] Disconnecting nawf [/76.23.232.27:55028]: Took too long to log in
2011-01-31 19:50:11 [INFO] Disconnecting /76.23.232.27:55012: Took too long to log in
2011-01-31 19:50:49 [INFO] /76.23.232.27:55200 lost connection
2011-01-31 19:51:29 [INFO] Disconnecting nawf [/76.23.232.27:55060]: Took too long to log in
2011-01-31 19:52:38 [INFO] nawf [/76.23.232.27:55043] logged in with entity id 1756611
2011-01-31 19:52:44 [INFO] <efess> wb
2011-01-31 19:52:47 [INFO] <nawf> woo
2011-01-31 19:55:55 [INFO] /69.119.8.191:49460 lost connection
2011-01-31 19:56:17 [INFO] <nawf> kevin are you clear of that area?
2011-01-31 19:56:20 [INFO] redux06790 [/69.119.8.191:49462] lost connection
2011-01-31 19:56:24 [INFO] redux06790 [/69.119.8.191:49465] lost connection
2011-01-31 19:56:32 [INFO] /69.119.8.191:49470 lost connection
2011-01-31 19:57:01 [INFO] <AngryRhetoric> sorry which area?
2011-01-31 19:57:05 [INFO] <AngryRhetoric> beneath my tower?
2011-01-31 19:57:08 [INFO] <nawf> yeah
2011-01-31 19:57:11 [INFO] <AngryRhetoric> yeah
2011-01-31 19:57:13 [INFO] redux06790 [/69.119.8.191:49494] logged in with entity id 1761642
2011-01-31 19:57:17 [INFO] <AngryRhetoric> how's our wood stockpile?
2011-01-31 19:57:19 [INFO] <AngryRhetoric> welcome
2011-01-31 19:57:24 [INFO] <redux06790> brb lol
2011-01-31 19:57:42 [INFO] <AngryRhetoric> you dynamiting more below the tower?
2011-01-31 19:57:53 [INFO] <nawf> close, but just being safe
2011-01-31 19:58:07 [INFO] <AngryRhetoric> ok thx
2011-01-31 19:59:36 [INFO] <AngryRhetoric> who made the heart box?
2011-01-31 19:59:39 [INFO] <AngryRhetoric> lol
2011-01-31 20:00:03 [INFO] <nawf> fire in the hole
2011-01-31 20:00:15 [INFO] <redux06790> anyone want a fucking dog or two?
2011-01-31 20:00:20 [INFO] <redux06790> before i fucking shoot them?
2011-01-31 20:00:26 [INFO] <AngryRhetoric> lol
2011-01-31 20:00:30 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-31 20:00:32 [INFO] <nawf> I'll take them after
2011-01-31 20:00:35 [INFO] <redux06790> lol
2011-01-31 20:00:50 [INFO] <redux06790> christ my dog hailey is fucking annoying
2011-01-31 20:00:57 [INFO] /24.147.183.4:52601 lost connection
2011-01-31 20:00:59 [INFO] <redux06790> she paces everywhere when youre walking around the house
2011-01-31 20:01:06 [INFO] <redux06790> and manages to constantly be underfoot
2011-01-31 20:01:13 [INFO] <redux06790> FUUUUU!!!!!!!!!!!!!!!!!
2011-01-31 20:01:41 [INFO] <redux06790> ok
2011-01-31 20:01:42 [INFO] <redux06790> so
2011-01-31 20:01:47 [INFO] <redux06790> what resources do we need?
2011-01-31 20:01:50 [INFO] /24.147.183.4:52634 lost connection
2011-01-31 20:01:57 [INFO] <efess> diamond?
2011-01-31 20:02:01 [INFO] <redux06790> *cough* wool *cough*
2011-01-31 20:02:03 [INFO] <efess> :D
2011-01-31 20:02:07 [INFO] /24.147.183.4:52649 lost connection
2011-01-31 20:02:16 [INFO] <redux06790> i suppose i COULD make a branch mine
2011-01-31 20:02:32 [INFO] <nawf> there are some already
2011-01-31 20:02:54 [INFO] <efess> gay
2011-01-31 20:03:40 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:52689]: Took too long to log in
2011-01-31 20:03:56 [INFO] /24.147.183.4:52722 lost connection
2011-01-31 20:04:04 [INFO] /24.147.183.4:52729 lost connection
2011-01-31 20:04:18 [INFO] <redux06790> I made a bacon dispenser
2011-01-31 20:04:19 [INFO] <redux06790> woot
2011-01-31 20:04:25 [INFO] <redux06790> err porkchop
2011-01-31 20:04:33 [INFO] /24.147.183.4:52747 lost connection
2011-01-31 20:04:35 [INFO] <redux06790> i forgot its not bacon with the classic texture pack
2011-01-31 20:05:30 [INFO] Disconnecting /24.147.183.4:52769: Took too long to log in
2011-01-31 20:05:49 [INFO] <nawf> damn, holy chunk error
2011-01-31 20:06:04 [INFO] <nawf> I'm missing dozens here
2011-01-31 20:07:03 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:52889]: Took too long to log in
2011-01-31 20:07:16 [INFO] <redux06790> I am the self appointed inventory keeper
2011-01-31 20:07:39 [INFO] <redux06790> holy shitballs
2011-01-31 20:07:46 [INFO] <redux06790> looks like someone made some tnt ehh?
2011-01-31 20:07:49 [INFO] <nawf> yeah
2011-01-31 20:07:54 [INFO] <nawf> did a sand run
2011-01-31 20:08:00 [INFO] AngryRhetoric [/24.147.183.4:52957] logged in with entity id 1777829
2011-01-31 20:08:06 [INFO] <AngryRhetoric> finally got back in!
2011-01-31 20:08:56 [INFO] <redux06790> FUUUU!!!! rageface.jpg
2011-01-31 20:08:59 [INFO] <nawf> lol
2011-01-31 20:09:30 [INFO] <redux06790> glass is in the misc bin btw
2011-01-31 20:10:46 [INFO] <nawf> damn, full house in here
2011-01-31 20:11:17 [INFO] <redux06790> woot
2011-01-31 20:11:22 [INFO] <AngryRhetoric> giggity
2011-01-31 20:11:24 [INFO] <redux06790> tons of dirt for the vortex
2011-01-31 20:11:27 [INFO] <nawf> what are you doing joe? squids?
2011-01-31 20:11:34 [INFO] <efess> ya
2011-01-31 20:11:47 [INFO] <efess> havn't seen any drop down yet
2011-01-31 20:12:02 [INFO] <nawf> squid grinders, how do they work
2011-01-31 20:12:08 [INFO] <efess> true
2011-01-31 20:12:13 [INFO] <efess> why you no work
2011-01-31 20:13:37 [INFO] <redux06790> you know
2011-01-31 20:13:52 [INFO] <redux06790> keeping the stock room neat can be a full time job in terms of gameplay
2011-01-31 20:14:03 [INFO] <AngryRhetoric> haha
2011-01-31 20:14:05 [INFO] <AngryRhetoric> true
2011-01-31 20:14:11 [INFO] <nawf> its usually not bad, I think you caught it at its worst
2011-01-31 20:14:25 [INFO] <AngryRhetoric> yeah the chests were fairly organized yesterday
2011-01-31 20:14:27 [INFO] <redux06790> well i was thinking about making a room dedicated to stone
2011-01-31 20:14:48 [INFO] <redux06790> what in the fried dick are you doing john?
2011-01-31 20:15:01 [INFO] <nawf> clearing out some dirt
2011-01-31 20:15:13 [INFO] <redux06790> whatever tickles your pickle bro
2011-01-31 20:15:34 [INFO] <redux06790> im going to use said dirt to fill in the vortex
2011-01-31 20:15:55 [INFO] <nawf> well just make it one deep and fill with water
2011-01-31 20:15:55 [INFO] <redux06790> and plant a forest
2011-01-31 20:16:14 [INFO] <nawf> its all about the spawn rate!
2011-01-31 20:16:16 [INFO] <redux06790> but...
2011-01-31 20:16:48 [INFO] <nawf> well you could if you wanted, we can always make the spawner bigger too
2011-01-31 20:16:50 [INFO] <redux06790> why not just flood all the open areas with light
2011-01-31 20:17:05 [INFO] <nawf> because the algo is weird
2011-01-31 20:17:05 [INFO] <redux06790> that way the only place they CAN spawn is the spawner
2011-01-31 20:17:17 [INFO] <redux06790> well i mean
2011-01-31 20:17:35 [INFO] <redux06790> you picked a shitty spot to put your main base if you want your spawner right there
2011-01-31 20:17:51 [INFO] <nawf> well its not the main base
2011-01-31 20:17:52 [INFO] <redux06790> because by your logic, eventually youre going to have to demolish your base
2011-01-31 20:18:07 [INFO] <redux06790> and my aperture science weighted compainion cube :(
2011-01-31 20:18:08 [INFO] <nawf> YES
2011-01-31 20:18:11 [INFO] <nawf> destroy it all!
2011-01-31 20:18:16 [INFO] <efess> hehe
2011-01-31 20:18:22 [INFO] <redux06790> server wipe! start over!
2011-01-31 20:18:28 [INFO] <nawf> well I don't think it matters actually
2011-01-31 20:18:36 [INFO] <nawf> the spawn rate is high enough and we can always go taller
2011-01-31 20:19:02 [INFO] <redux06790> i vote we expand the spawner
2011-01-31 20:19:11 [INFO] <AngryRhetoric> the mob grinder?
2011-01-31 20:19:18 [INFO] <redux06790> yeah whatever you wanna call it
2011-01-31 20:19:20 [INFO] <redux06790> make it bigger
2011-01-31 20:19:27 [INFO] <AngryRhetoric> we're not getting enough stuff yet? lol
2011-01-31 20:19:37 [INFO] <efess> enough stuff? pshh
2011-01-31 20:19:59 [INFO] <redux06790> i dont think john will be happy till hes getting like 10,000+ per hour
2011-01-31 20:20:25 [INFO] <redux06790> im going to wander off somewhere and make a world tree
2011-01-31 20:20:35 [INFO] <redux06790> no girls allowed
2011-01-31 20:20:37 [INFO] <nawf> naw, I'm ok with it now, its so ingrained in me to not effect the spawn rate
2011-01-31 20:20:40 [INFO] <efess> let us know so we can bring the lighters :)
2011-01-31 20:21:05 [INFO] <redux06790> maybe ill build a massive igloo
2011-01-31 20:21:07 [INFO] <redux06790> idk
2011-01-31 20:21:17 [INFO] <redux06790> i have like 4 ideas
2011-01-31 20:21:26 [INFO] <redux06790> but the one i really wanna do requires tons of wool
2011-01-31 20:21:30 [INFO] <efess> whatever happened to the racist theme park
2011-01-31 20:21:34 [INFO] <redux06790> and yet we dont have a livestock grinder
2011-01-31 20:23:11 [INFO] <redux06790> so
2011-01-31 20:23:16 [INFO] <redux06790> forgive my faggotry
2011-01-31 20:23:17 [INFO] <redux06790> but
2011-01-31 20:23:26 [INFO] <redux06790> how does a hollow area = greater spawn rate
2011-01-31 20:24:41 [INFO] <nawf> well its all about how the algo checks for eligable spots
2011-01-31 20:24:53 [INFO] <nawf> and thats the first loop
2011-01-31 20:25:04 [INFO] <redux06790> that is to say
2011-01-31 20:25:07 [INFO] <nawf> inside a wall isn't eligable, but open space is or something
2011-01-31 20:25:16 [INFO] <redux06790> sooo
2011-01-31 20:25:17 [INFO] <nawf> I gotget, google ""Mob spawning science
2011-01-31 20:25:24 [INFO] <efess> the more empty space in a chunk, the more likely it is to spawn an entity
2011-01-31 20:25:33 [INFO] <redux06790> wouldnt logic dictate to fill the space instead of make it empty?
2011-01-31 20:25:41 [INFO] <redux06790> oh i see
2011-01-31 20:25:42 [INFO] <redux06790> well
2011-01-31 20:25:47 [INFO] <nawf> naw, it makes the spawner algo bail out early
2011-01-31 20:26:10 [INFO] <nawf> hey erin, there is a perfect space for a friendly grinder right below the mob grinder
2011-01-31 20:26:18 [INFO] <nawf> if you walk up the death chute you'll fine it, I'm there
2011-01-31 20:26:23 [INFO] <efess> after it picks the chunk, next step is to find a valid spot to spawn (usually the spanwer)
2011-01-31 20:26:25 [INFO] <nawf> this space was part of a cave system
2011-01-31 20:26:28 [INFO] <redux06790> ok one sec
2011-01-31 20:26:43 [INFO] <redux06790> do we have a path for grass?
2011-01-31 20:26:50 [INFO] <redux06790> or do friendlies spawn on dirt too?
2011-01-31 20:26:57 [INFO] <nawf> I think dirt
2011-01-31 20:27:33 [INFO] efess lost connection: disconnect.quitting
2011-01-31 20:27:36 [INFO] efess [/192.168.0.198:20646] logged in with entity id 1801805
2011-01-31 20:27:38 [INFO] <redux06790> FUUUUUUU!!!!!!!
2011-01-31 20:27:41 [INFO] <redux06790> fucking gravity
2011-01-31 20:27:44 [INFO] <AngryRhetoric> FU!!!
2011-01-31 20:27:45 [INFO] <redux06790> wtb guard rails
2011-01-31 20:27:46 [INFO] <AngryRhetoric> haha
2011-01-31 20:28:30 [INFO] <AngryRhetoric> my village hamlet is turning into a 1950's housing development
2011-01-31 20:28:44 [INFO] <redux06790> im going to tell black people to move in
2011-01-31 20:28:50 [INFO] <redux06790> and drop your property values
2011-01-31 20:28:56 [INFO] <AngryRhetoric> haha its for white nuclear families only
2011-01-31 20:29:14 [INFO] <AngryRhetoric> with an average income of 15k 1950's money
2011-01-31 20:29:23 [INFO] <redux06790> oh hey john
2011-01-31 20:29:31 [INFO] <redux06790> remember the whole starving kids in africa thing?
2011-01-31 20:29:39 [INFO] <nawf> yeah
2011-01-31 20:29:40 [INFO] <AngryRhetoric> scraps across america?
2011-01-31 20:29:46 [INFO] <nawf> fuck, you can hear about all the spiders up here
2011-01-31 20:29:49 [INFO] <redux06790> i was going to make the joke that nobody cares about africans
2011-01-31 20:30:10 [INFO] <redux06790> but i figured that would be a thought halting joke
2011-01-31 20:30:33 [INFO] <nawf> naw, everybody loves starving africans anyway
2011-01-31 20:30:56 [INFO] <redux06790> how else are white people going to feel better about themselves?
2011-01-31 20:31:35 [INFO] <AngryRhetoric> i love the save darfur bumper stickers, those people probably dont' even know where it is
2011-01-31 20:31:50 [INFO] <nawf> this will be perfect, I think we can feed the friendly mobs into joes squid grinder path
2011-01-31 20:31:50 [INFO] <redux06790> isnt darfur a yogurt shop?
2011-01-31 20:31:58 [INFO] <redux06790> trollface.jpg
2011-01-31 20:32:23 [INFO] <AngryRhetoric> hahaha
2011-01-31 20:32:28 [INFO] <AngryRhetoric> darfur frozen treats
2011-01-31 20:32:37 [INFO] <AngryRhetoric> ps: its not icecream
2011-01-31 20:32:51 [INFO] <redux06790> OMFG
2011-01-31 20:32:55 [INFO] <redux06790> i should make a trollface
2011-01-31 20:32:59 [INFO] <redux06790> hells yea
2011-01-31 20:33:19 [INFO] <redux06790> what the fucking cock shit
2011-01-31 20:33:26 [INFO] <redux06790> i got ass raped by a fucking spider
2011-01-31 20:33:50 [INFO] <nawf> I think we can make the friendly spawner right around this existing waterway
2011-01-31 20:34:01 [INFO] <efess> k
2011-01-31 20:34:05 [INFO] <AngryRhetoric> my village is spawning friendlies left and rigth
2011-01-31 20:34:07 [INFO] <efess> they spawn this far away?
2011-01-31 20:34:37 [INFO] <redux06790> wheeee! mine cart! YAHOOOOO!!!!
2011-01-31 20:35:01 [INFO] <nawf> they should I think
2011-01-31 20:35:21 [INFO] <redux06790> wtf chunk error
2011-01-31 20:35:23 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 20:35:25 [INFO] /69.119.8.191:49556 lost connection
2011-01-31 20:36:40 [INFO] <efess> fkn drowning glitch
2011-01-31 20:36:46 [INFO] redux06790 [/69.119.8.191:49579] logged in with entity id 1815289
2011-01-31 20:36:49 [INFO] <redux06790> the fuck
2011-01-31 20:37:33 [INFO] <nawf> shit, we do need grass up here
2011-01-31 20:37:45 [INFO] <efess> there's some at the chute walkway
2011-01-31 20:39:32 [INFO] <redux06790> OK
2011-01-31 20:39:36 [INFO] <redux06790> you still there john
2011-01-31 20:39:54 [INFO] <nawf> yeah, but you'll have to dig your way up the dirt I just laid, trapped myself in here
2011-01-31 20:40:34 [INFO] <redux06790> this is going to be the friendly grinder?
2011-01-31 20:40:48 [INFO] <nawf> yeah, we can feed it right into joes squid grinder
2011-01-31 20:41:06 [INFO] <efess> donno if we can call it a squid grinder if it hasn't ground any squids yet
2011-01-31 20:41:13 [INFO] <redux06790> i wish flowers would grow
2011-01-31 20:41:27 [INFO] <redux06790> and other things
2011-01-31 20:41:38 [INFO] <redux06790> that way we can have every resource at our disposal
2011-01-31 20:41:49 [INFO] <AngryRhetoric> i wonder how much water you'd need to make a squid grinder heh
2011-01-31 20:42:10 [INFO] <redux06790> so whats the logic here john?
2011-01-31 20:42:12 [INFO] <nawf> do you have water egin?
2011-01-31 20:42:22 [INFO] <redux06790> i can go get some
2011-01-31 20:42:22 [INFO] <nawf> err, erin, a bucket?
2011-01-31 20:42:27 [INFO] <redux06790> yes
2011-01-31 20:42:29 [INFO] <redux06790> sec
2011-01-31 20:42:33 [INFO] <nawf> yeah, I can show you if you give me some water,
2011-01-31 20:42:38 [INFO] <nawf> I forgot like a fool
2011-01-31 20:42:59 [INFO] <redux06790> oh
2011-01-31 20:43:00 [INFO] <redux06790> nvm
2011-01-31 20:43:04 [INFO] <redux06790> you already have a spring
2011-01-31 20:43:55 [INFO] <nawf> so right, water flows into the pit, 8 blocks long
2011-01-31 20:44:07 [INFO] <redux06790> k
2011-01-31 20:44:28 [INFO] <nawf> and then we make these grass floating platforms
2011-01-31 20:44:31 [INFO] <nawf> mobs fall in and die
2011-01-31 20:45:06 [INFO] <redux06790> step 1 make cave, step 2 place water, step 3 ???, step 4 profit?
2011-01-31 20:45:30 [INFO] <nawf> joe, I checked out some designs online, you don't need channels, just plains of water
2011-01-31 20:45:34 [INFO] <nawf> and floating platforms
2011-01-31 20:45:47 [INFO] <efess> they work the same as channels
2011-01-31 20:46:06 [INFO] <redux06790> ginger bread grahm crackers are the poo
2011-01-31 20:46:56 [INFO] <redux06790> is there something i can do?
2011-01-31 20:47:01 [INFO] <nawf> dig!
2011-01-31 20:47:08 [INFO] <redux06790> ok from where to where?
2011-01-31 20:47:19 [INFO] <nawf> dunno, depends how ambitious we want to be
2011-01-31 20:47:29 [INFO] <redux06790> dude i dig like no other
2011-01-31 20:48:32 [INFO] <nawf> yeah, I guess we can sto phere
2011-01-31 20:49:38 [INFO] <nawf> and see erin, after 8 blocks we go one level up
2011-01-31 20:50:03 [INFO] <redux06790> how big is the platform above supposed to be?
2011-01-31 20:50:10 [INFO] <redux06790> lol
2011-01-31 20:50:15 [INFO] <nawf> 8 by whatever we decide
2011-01-31 20:50:32 [INFO] <redux06790> with a space for them to fall through?
2011-01-31 20:50:37 [INFO] <nawf> I say we go until this sand dirt, down to the torches
2011-01-31 20:50:48 [INFO] <nawf> naw, they spawn on the platforms and fall into the water
2011-01-31 20:50:54 [INFO] <redux06790> yes
2011-01-31 20:51:02 [INFO] <redux06790> so there needs to be a hole in the platforms?
2011-01-31 20:51:17 [INFO] <nawf> naw, we'll just do 3x3 floaters or whatever
2011-01-31 20:51:25 [INFO] <nawf> and temporarily link them for grass
2011-01-31 20:51:38 [INFO] <redux06790> ok
2011-01-31 20:51:46 [INFO] <redux06790> i say we go 8x24
2011-01-31 20:51:51 [INFO] <nawf> well we can do 3x4
2011-01-31 20:51:51 [INFO] <redux06790> nice even numbers
2011-01-31 20:51:58 [INFO] <redux06790> for the channels
2011-01-31 20:52:17 [INFO] <nawf> ok, up to the sandblock is 25
2011-01-31 20:52:55 [INFO] <nawf> well the ladder gold block over here is the end of the 24 now
2011-01-31 20:53:51 [INFO] <nawf> and we just need 5 height
2011-01-31 20:54:02 [INFO] <nawf> 2 for water, 1 dirt block, 2 spaces above
2011-01-31 20:56:32 [INFO] <redux06790> how many channels we making?
2011-01-31 20:56:49 [INFO] <nawf> prob just this one
2011-01-31 20:56:57 [INFO] <redux06790> how many levels?
2011-01-31 20:57:07 [INFO] <redux06790> id say at least 5?
2011-01-31 20:57:11 [INFO] <nawf> whatever, we can go up to the water
2011-01-31 20:58:36 [INFO] <redux06790> this is 9 long
2011-01-31 20:58:49 [INFO] <efess> ah miscounted
2011-01-31 20:58:54 [INFO] <redux06790> youre fired
2011-01-31 20:59:00 [INFO] <efess> Fuuu
2011-01-31 20:59:04 [INFO] <AngryRhetoric> haha
2011-01-31 21:00:09 [INFO] <nawf> I have to go drop off a load
2011-01-31 21:00:17 [INFO] <redux06790> me too
2011-01-31 21:02:04 [INFO] <redux06790> KACHING!@!!!!@@#%
2011-01-31 21:02:09 [INFO] <nawf> ROFL
2011-01-31 21:02:15 [INFO] <nawf> diamondz in the base ftw
2011-01-31 21:02:37 [INFO] <nawf> need more cobble chests
2011-01-31 21:04:05 [INFO] <redux06790> ok im going back
2011-01-31 21:04:12 [INFO] <redux06790> i made another cobble chest
2011-01-31 21:04:20 [INFO] <redux06790> here
2011-01-31 21:04:27 [INFO] <nawf> I saw
2011-01-31 21:16:12 [INFO] <redux06790> so
2011-01-31 21:16:20 [INFO] <redux06790> this is kinda how im making my grinder
2011-01-31 21:16:22 [INFO] <redux06790> except
2011-01-31 21:16:40 [INFO] <redux06790> im putting channels on boths sides that you cant get out of once you fallin
2011-01-31 21:16:52 [INFO] <nawf> yeah, but they can't get out of this one either
2011-01-31 21:16:52 [INFO] <redux06790> figuring eventually mobs will walk into them
2011-01-31 21:16:57 [INFO] <redux06790> but
2011-01-31 21:17:04 [INFO] <redux06790> this one is 100%
2011-01-31 21:17:16 [INFO] <nawf> right
2011-01-31 21:18:11 [INFO] <redux06790> too far back eff
2011-01-31 21:18:20 [INFO] <efess> no that's 7
2011-01-31 21:18:25 [INFO] <redux06790> is it?
2011-01-31 21:18:30 [INFO] <efess> fired.
2011-01-31 21:18:35 [INFO] <redux06790> well fuck my ass
2011-01-31 21:18:41 [INFO] <redux06790> see you at the unemployment line
2011-01-31 21:18:49 [INFO] <efess> hehe
2011-01-31 21:18:52 [INFO] <nawf> test bucket says your wrong!@
2011-01-31 21:18:56 [INFO] <nawf> brb
2011-01-31 21:19:52 [INFO] <redux06790> FUUU!
2011-01-31 21:20:50 [INFO] <redux06790> lol
2011-01-31 21:20:56 [INFO] <redux06790> look at john
2011-01-31 21:21:07 [INFO] <redux06790> haha
2011-01-31 21:21:10 [INFO] <redux06790> pwned
2011-01-31 21:21:34 [INFO] <redux06790> worth it
2011-01-31 21:21:41 [INFO] <efess> totally
2011-01-31 21:21:52 [INFO] <redux06790> lol <3
2011-01-31 21:21:53 [INFO] <nawf> afk tombs ftw
2011-01-31 21:21:58 [INFO] <efess> lol
2011-01-31 21:22:08 [INFO] <efess> thought about filling it with water....
2011-01-31 21:22:12 [INFO] <efess> making it a real tomb
2011-01-31 21:22:13 [INFO] <redux06790> I afk tombed a kid in obby and he only had a wooden pick once
2011-01-31 21:22:18 [INFO] <efess> LOL
2011-01-31 21:22:29 [INFO] <AngryRhetoric> nice music
2011-01-31 21:23:38 [INFO] <redux06790> ok whos not click mining?
2011-01-31 21:23:44 [INFO] <nawf> this should be good
2011-01-31 21:23:48 [INFO] <nawf> I am
2011-01-31 21:23:53 [INFO] <nawf> finger hurts
2011-01-31 21:23:53 [INFO] <redux06790> think so?
2011-01-31 21:24:05 [INFO] <nawf> yeah, we'll have so much shit
2011-01-31 21:24:20 [INFO] <redux06790> ill get some torches brb
2011-01-31 21:24:24 [INFO] <nawf> and dirt
2011-01-31 21:24:28 [INFO] <redux06790> k
2011-01-31 21:24:31 [INFO] <nawf> need dirtz
2011-01-31 21:26:00 [INFO] <efess> found the ocean
2011-01-31 21:26:14 [INFO] <efess> LOL
2011-01-31 21:26:22 [INFO] <nawf> oh man, I don't think we could go up higher
2011-01-31 21:26:37 [INFO] <nawf> maybe one or two more, we'll see how this does
2011-01-31 21:26:52 [INFO] <redux06790> youre puking stones
2011-01-31 21:27:53 [INFO] <nawf> I think we can do 3x5
2011-01-31 21:28:04 [INFO] <efess> even 3x6
2011-01-31 21:28:06 [INFO] <nawf> yeah
2011-01-31 21:28:12 [INFO] <redux06790> that would be better i think
2011-01-31 21:29:17 [INFO] <AngryRhetoric> who dug mine#5? lol
2011-01-31 21:29:29 [INFO] <efess> yea that goes around the world
2011-01-31 21:29:43 [INFO] <nawf> uh erin
2011-01-31 21:29:48 [INFO] <nawf> what are you doing?
2011-01-31 21:29:51 [INFO] <redux06790> 3x6
2011-01-31 21:29:56 [INFO] <redux06790> not 3x7
2011-01-31 21:30:03 [INFO] <redux06790> keeping it centered
2011-01-31 21:30:05 [INFO] <nawf> l2count
2011-01-31 21:30:18 [INFO] <redux06790> oh i see what youre doing
2011-01-31 21:30:20 [INFO] <redux06790> ...
2011-01-31 21:30:25 [INFO] <redux06790> its not centered tho
2011-01-31 21:30:29 [INFO] <redux06790> y u no center?
2011-01-31 21:30:34 [INFO] <nawf> psh, mobs will still die
2011-01-31 21:30:42 [INFO] <redux06790> Y U NO CENTER!?!?!?
2011-01-31 21:30:46 [INFO] <redux06790> :p
2011-01-31 21:30:53 [INFO] <nawf> well this way they fall into the fastest flowing current
2011-01-31 21:31:25 [INFO] <redux06790> will mobs spawn on a tile that has a torch on top of it?
2011-01-31 21:31:34 [INFO] <nawf> I think so
2011-01-31 21:32:12 [INFO] <nawf> so the light level needs to be 9
2011-01-31 21:32:36 [INFO] <efess> gonna grab more torches
2011-01-31 21:32:54 [INFO] <nawf> if we put one in the middle or off center of each dirt platform we should be good
2011-01-31 21:33:04 [INFO] <nawf> we don't need all of these
2011-01-31 21:33:22 [INFO] <redux06790> but its smexy
2011-01-31 21:33:26 [INFO] <nawf> true
2011-01-31 21:33:53 [INFO] <redux06790> AND
2011-01-31 21:34:04 [INFO] <redux06790> we know where there are extra torches if for some reason you ever need them
2011-01-31 21:34:13 [INFO] <redux06790> did you know you can make torches out of trees?
2011-01-31 21:34:24 [INFO] <redux06790> i was like WHUT!?
2011-01-31 21:34:32 [INFO] <AngryRhetoric> haha yeah pyrolicious
2011-01-31 21:34:40 [INFO] <nawf> yeah, I try to make torches out of charcoal only to save the coal
2011-01-31 21:34:49 [INFO] <nawf> for a while we didn't have a lot of extra coal
2011-01-31 21:36:10 [INFO] <redux06790> Y U NO SPAWN MOBS?
2011-01-31 21:36:18 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-31 21:36:28 [INFO] /24.147.183.4:56642 lost connection
2011-01-31 21:36:30 [INFO] <nawf> need grass
2011-01-31 21:36:33 [INFO] <redux06790> derp
2011-01-31 21:36:38 [INFO] /24.147.183.4:56650 lost connection
2011-01-31 21:37:15 [INFO] AngryRhetoric [/24.147.183.4:56665] logged in with entity id 1902606
2011-01-31 21:37:43 [INFO] <nawf> I swore this was grass up here at some point
2011-01-31 21:38:02 [INFO] <efess> no more island
2011-01-31 21:38:04 [INFO] <efess> :(
2011-01-31 21:38:15 [INFO] <redux06790> wtf
2011-01-31 21:38:20 [INFO] <redux06790> i drowned because i got lost
2011-01-31 21:38:40 [INFO] <AngryRhetoric> nice job with the water
2011-01-31 21:38:45 [INFO] <nawf> lol
2011-01-31 21:38:47 [INFO] <AngryRhetoric> haha
2011-01-31 21:39:06 [INFO] <efess> fuuu
2011-01-31 21:39:13 [INFO] <efess> that was a long fall
2011-01-31 21:39:13 [INFO] <AngryRhetoric> that sucks
2011-01-31 21:39:31 [INFO] <AngryRhetoric> i'll pick up all your stuff and then disconnect
2011-01-31 21:39:36 [INFO] <efess> !!
2011-01-31 21:39:53 [INFO] <nawf> I have most of it
2011-01-31 21:39:57 [INFO] <nawf> kevin took all the good stuff
2011-01-31 21:40:06 [INFO] <AngryRhetoric> LOL
2011-01-31 21:40:08 [INFO] <AngryRhetoric> i took NOTHING
2011-01-31 21:40:16 [INFO] <AngryRhetoric> ya bastid
2011-01-31 21:42:04 [INFO] <efess> yay stuffs
2011-01-31 21:42:13 [INFO] <nawf> I think thats it, I already dumped the cobble and stuff
2011-01-31 21:42:17 [INFO] <efess> cool
2011-01-31 21:42:25 [INFO] <nawf> omg books
2011-01-31 21:43:12 [INFO] <AngryRhetoric> sup
2011-01-31 21:45:04 [INFO] <nawf> sloding
2011-01-31 21:46:55 [INFO] <AngryRhetoric> aight i'm out for the night, peace!!!
2011-01-31 21:47:00 [INFO] <efess> l8r kevin
2011-01-31 21:47:02 [INFO] <nawf> later
2011-01-31 21:47:22 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-01-31 21:49:11 [INFO] <nawf> I'm going to take off for a little but, may be back on later
2011-01-31 21:49:23 [INFO] <efess> i'll probably take off soon anyway
2011-01-31 21:49:23 [INFO] <redux06790> yeah ill be back on at 1am during my break
2011-01-31 21:49:31 [INFO] <efess> l8r
2011-01-31 21:49:33 [INFO] <nawf> peace out
2011-01-31 21:49:35 [INFO] nawf lost connection: disconnect.quitting
2011-01-31 21:58:30 [INFO] <efess> need wood?
2011-01-31 21:58:45 [INFO] <redux06790> lol oh baby
2011-01-31 21:58:49 [INFO] <efess> ;)
2011-01-31 21:58:57 [INFO] <redux06790> um i was going to log on at work and farm shit tons of wood
2011-01-31 21:59:06 [INFO] <redux06790> a little deforesting
2011-01-31 21:59:20 [INFO] <efess> just got 3 stacks
2011-01-31 21:59:42 [INFO] <redux06790> wood is one of those blocks that nobody wants to farm but everyone needs
2011-01-31 22:00:08 [INFO] <efess> yup its a pain in the ass
2011-01-31 22:04:12 [INFO] <redux06790> ok well hopefully the grass will work its way to the new spawner so i can finally have woooooool
2011-01-31 22:04:22 [INFO] <efess> I don't think things move when noone's on the server
2011-01-31 22:04:37 [INFO] <efess> its almost there
2011-01-31 22:05:02 [INFO] <redux06790> well i gotta get ready for work
2011-01-31 22:05:07 [INFO] <redux06790> be back in 3 hours
2011-01-31 22:05:14 [INFO] <efess> alright man l8r
2011-01-31 22:05:17 [INFO] redux06790 lost connection: disconnect.quitting
2011-01-31 22:07:56 [INFO] efess lost connection: disconnect.quitting
2011-02-01 00:59:09 [INFO] redux06790 [/24.151.90.200:49186] logged in with entity id 1930562
2011-02-01 00:59:38 [INFO] <redux06790> derp
2011-02-01 01:04:03 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-01 13:10:52 [INFO] nawf [/76.23.232.27:55294] logged in with entity id 1933417
2011-02-01 16:40:44 [INFO] nawf lost connection: disconnect.quitting
2011-02-01 17:30:06 [INFO] redux06790 [/69.119.8.191:49194] logged in with entity id 2000257
2011-02-01 17:30:11 [INFO] <redux06790> derp
2011-02-01 17:31:07 [INFO] nawf [/76.23.232.27:55065] logged in with entity id 2001175
2011-02-01 17:45:46 [INFO] nawf lost connection: disconnect.genericReason
2011-02-01 17:46:05 [INFO] nawf [/76.23.232.27:55040] logged in with entity id 2019639
2011-02-01 18:19:52 [INFO] <nawf> some pork coming down here
2011-02-01 18:40:59 [INFO] AngryRhetoric [/24.147.183.4:52255] logged in with entity id 2057572
2011-02-01 18:41:04 [INFO] <AngryRhetoric> sup!
2011-02-01 18:41:14 [INFO] <AngryRhetoric> BONES
2011-02-01 18:41:21 [INFO] <nawf> lol
2011-02-01 18:42:37 [INFO] <nawf> hey, did you end up every talkng to the girl from friday night?
2011-02-01 18:43:48 [INFO] <AngryRhetoric> dam did the cave get bigger??
2011-02-01 18:43:55 [INFO] <AngryRhetoric> hmm yeahhhh
2011-02-01 18:43:58 [INFO] <AngryRhetoric> not so much
2011-02-01 18:43:58 [INFO] <nawf> I do a little every day
2011-02-01 18:44:05 [INFO] <AngryRhetoric> i called her on sunday and it was her real number
2011-02-01 18:44:10 [INFO] <AngryRhetoric> but i haven't heard back from her :-/
2011-02-01 18:44:12 [INFO] <nawf> nice
2011-02-01 18:44:18 [INFO] <AngryRhetoric> yeah
2011-02-01 18:44:33 [INFO] <AngryRhetoric> i think she just gave me her number to get out of the bar lol
2011-02-01 18:45:00 [INFO] <AngryRhetoric> lathough she seemed interested at the time...
2011-02-01 18:45:01 [INFO] <nawf> who knows, I mean she wouldn't leave your side all night
2011-02-01 18:45:08 [INFO] <AngryRhetoric> yeah i know
2011-02-01 18:45:08 [INFO] <nawf> unless you were following her around
2011-02-01 18:45:18 [INFO] <AngryRhetoric> haha she'd talk to her friend and come back to me
2011-02-01 18:45:39 [INFO] <nawf> her friend could beat me up
2011-02-01 18:45:59 [INFO] <AngryRhetoric> lol her friend was huge
2011-02-01 18:46:04 [INFO] <AngryRhetoric> she even commented on that
2011-02-01 18:57:50 [INFO] <AngryRhetoric> m
2011-02-01 18:57:58 [INFO] <nawf> n
2011-02-01 18:58:06 [INFO] <AngryRhetoric> o
2011-02-01 18:58:09 [INFO] <nawf> p
2011-02-01 18:58:54 [INFO] <AngryRhetoric> wierd my keyboard died lol
2011-02-01 18:59:01 [INFO] <AngryRhetoric> q
2011-02-01 18:59:10 [INFO] <AngryRhetoric> or is t laggy?
2011-02-01 19:00:00 [INFO] <AngryRhetoric> you lagginin brau??
2011-02-01 19:00:04 [INFO] <nawf> yeah
2011-02-01 19:00:10 [INFO] <AngryRhetoric> ok good
2011-02-01 19:00:32 [INFO] <AngryRhetoric> tell joe to stop bit torrenting his porn for a bit
2011-02-01 19:00:37 [INFO] <nawf> srsly
2011-02-01 19:00:41 [INFO] <nawf> I'll be back on later
2011-02-01 19:00:44 [INFO] <nawf> peace playa
2011-02-01 19:00:46 [INFO] nawf lost connection: disconnect.quitting
2011-02-01 19:05:10 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-01 19:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-01 19:34:42 [INFO] <redux06790> fuck a cock i come back from afk and youre gone!?
2011-02-01 20:04:03 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-01 20:04:07 [INFO] redux06790 [/69.119.8.191:49663] logged in with entity id 2106614
2011-02-01 21:38:32 [INFO] nawf [/76.23.232.27:55071] logged in with entity id 2345958
2011-02-01 21:39:01 [INFO] <nawf> anybody here?
2011-02-01 21:39:07 [INFO] <redux06790> no
2011-02-01 21:39:34 [INFO] <redux06790> im currently making more improvements to the base
2011-02-01 21:39:38 [INFO] <nawf> found some more wool, we had it in the spawn base
2011-02-01 21:41:42 [INFO] nawf lost connection: disconnect.quitting
2011-02-01 21:41:45 [INFO] nawf [/76.23.232.27:55019] logged in with entity id 2363823
2011-02-01 21:41:50 [INFO] <redux06790> lol sorry
2011-02-01 21:42:09 [INFO] AngryRhetoric [/24.147.183.4:60711] logged in with entity id 2366000
2011-02-01 21:43:07 [INFO] <nawf> aw, why'd you stop the zombie conveyor?
2011-02-01 21:43:14 [INFO] <AngryRhetoric> sup gentlemen
2011-02-01 21:43:16 [INFO] <redux06790> because we dont need feathers
2011-02-01 21:43:20 [INFO] <AngryRhetoric> and john...whooooaaa
2011-02-01 21:43:28 [INFO] <redux06790> less zombies = more something else
2011-02-01 21:43:49 [INFO] <redux06790> plus that room makes a lovely viewpoint
2011-02-01 21:44:46 [INFO] efess [/192.168.0.198:33022] logged in with entity id 2378899
2011-02-01 21:44:57 [INFO] <efess> chickens?
2011-02-01 21:44:57 [INFO] <AngryRhetoric> welcome
2011-02-01 21:45:01 [INFO] <efess> hey!w
2011-02-01 21:45:03 [INFO] <nawf> go to the mob chute
2011-02-01 21:45:06 [INFO] <redux06790> ahoy matey
2011-02-01 21:45:20 [INFO] <nawf> the bottom I mean
2011-02-01 21:45:21 [INFO] <redux06790> what about it john?
2011-02-01 21:45:27 [INFO] <nawf> wtf
2011-02-01 21:45:28 [INFO] <efess> wtf
2011-02-01 21:45:28 [INFO] <efess> lol
2011-02-01 21:45:35 [INFO] <redux06790> holy duck
2011-02-01 21:45:36 [INFO] <nawf> stuck chickens
2011-02-01 21:45:38 [INFO] <efess> that's perfect
2011-02-01 21:45:44 [INFO] <efess> fkn eggs
2011-02-01 21:45:46 [INFO] <efess> :D
2011-02-01 21:45:54 [INFO] <redux06790> cake yaay!
2011-02-01 21:46:22 [INFO] <redux06790> is that from the livestock spawner?
2011-02-01 21:46:27 [INFO] <nawf> yeah
2011-02-01 21:46:30 [INFO] <nawf> must be
2011-02-01 21:46:32 [INFO] <efess> no more zombie spawner?
2011-02-01 21:46:37 [INFO] <redux06790> no
2011-02-01 21:46:41 [INFO] <nawf> :(
2011-02-01 21:46:42 [INFO] <redux06790> i figured feathers are useless
2011-02-01 21:46:47 [INFO] <efess> pretty much
2011-02-01 21:46:59 [INFO] <redux06790> less zombies = more other mobs
2011-02-01 21:47:03 [INFO] <efess> the chickens are perfect
2011-02-01 21:47:04 [INFO] <efess> fuck yea
2011-02-01 21:47:16 [INFO] <nawf> so many eggs
2011-02-01 21:47:23 [INFO] <redux06790> i wish it were a creeper spawner
2011-02-01 21:47:46 [INFO] <efess> got pork?
2011-02-01 21:47:49 [INFO] <redux06790> im going to be bummed if we ever stop using this base lol
2011-02-01 21:47:54 [INFO] <redux06790> i made us a vault
2011-02-01 21:48:11 [INFO] <nawf> well don't put things here, its just harder to get too now
2011-02-01 21:48:28 [INFO] <redux06790> what do you mean?
2011-02-01 21:48:39 [INFO] <nawf> its farther to walk to get stuff
2011-02-01 21:49:02 [INFO] <redux06790> this is more for stuff from the spawner
2011-02-01 21:49:20 [INFO] <nawf> oic, I thought you were moving stuff from the other part
2011-02-01 21:49:23 [INFO] <efess> well i'll be on tomorrow
2011-02-01 21:49:24 [INFO] <redux06790> no
2011-02-01 21:49:28 [INFO] <nawf> leaky condo?
2011-02-01 21:49:31 [INFO] <efess> ya
2011-02-01 21:49:32 [INFO] <redux06790> no this is specifically for spawner output
2011-02-01 21:49:35 [INFO] <efess> gotta call roofing
2011-02-01 21:49:38 [INFO] <efess> :\
2011-02-01 21:49:41 [INFO] <AngryRhetoric> that sucks
2011-02-01 21:49:42 [INFO] <efess> ice dams
2011-02-01 21:50:00 [INFO] <efess> good job with the spanwer that's awesome
2011-02-01 21:50:44 [INFO] <redux06790> my next fix is going to be the stairwell going up the death chute
2011-02-01 21:50:45 [INFO] <efess> grind.. grind... grind...
2011-02-01 21:51:00 [INFO] efess lost connection: disconnect.quitting
2011-02-01 21:51:10 [INFO] <nawf> creeper blewed it up
2011-02-01 21:51:19 [INFO] <nawf> yeah, the chute is haggard
2011-02-01 21:53:19 [INFO] <nawf> I brought back the wool from the spawn base
2011-02-01 21:53:28 [INFO] <nawf> we have 90 ish
2011-02-01 21:53:32 [INFO] <redux06790> wtf?
2011-02-01 21:55:48 [INFO] <redux06790> ok we need to do something about this chicken problem
2011-02-01 21:56:06 [INFO] <redux06790> its going to kill the spawn rate
2011-02-01 21:56:17 [INFO] <redux06790> where did you get all the wool from?
2011-02-01 21:56:28 [INFO] <nawf> it was in the base by the spawne
2011-02-01 21:56:31 [INFO] <nawf> r
2011-02-01 21:56:35 [INFO] <redux06790> nice
2011-02-01 21:57:00 [INFO] <redux06790> we need to move all the mats from there to here
2011-02-01 21:57:07 [INFO] <nawf> mats?
2011-02-01 21:57:11 [INFO] <redux06790> materials
2011-02-01 21:57:19 [INFO] <nawf> well we will be building hte castle there
2011-02-01 21:57:25 [INFO] <AngryRhetoric> whoa whoa
2011-02-01 21:57:28 [INFO] <nawf> that really is the ""main base""
2011-02-01 21:57:29 [INFO] <AngryRhetoric> what's this about a castle
2011-02-01 21:57:36 [INFO] <nawf> we just did all sorts of shit over here
2011-02-01 21:57:57 [INFO] <redux06790> well then
2011-02-01 21:58:09 [INFO] <AngryRhetoric> hey john you'll have to show where that cool mountain was for bldg a castle
2011-02-01 21:58:10 [INFO] <redux06790> i suppose when im done with everything ill be laying claim to the secondary base haha
2011-02-01 21:59:52 [INFO] <redux06790> purdy
2011-02-01 21:59:56 [INFO] <nawf> bleck
2011-02-01 22:00:02 [INFO] <redux06790> ikik you hate cobble
2011-02-01 22:00:13 [INFO] <nawf> well no, you just blocked off open space
2011-02-01 22:00:26 [INFO] <redux06790> well look at it this way
2011-02-01 22:00:37 [INFO] <redux06790> ive opened more space today than ive blocked off
2011-02-01 22:01:54 [INFO] <nawf> no I mean open sight lines
2011-02-01 22:02:20 [INFO] <redux06790> what do you mean?
2011-02-01 22:02:31 [INFO] <nawf> you could see the entirety of the base before
2011-02-01 22:02:37 [INFO] <nawf> now there are columns and a wall
2011-02-01 22:02:56 [INFO] <redux06790> i see your point...
2011-02-01 22:03:09 [INFO] <redux06790> hmm
2011-02-01 22:04:45 [INFO] <redux06790> how can we bring this block up one?
2011-02-01 22:04:57 [INFO] <nawf> which one?
2011-02-01 22:05:05 [INFO] <redux06790> these
2011-02-01 22:05:10 [INFO] <redux06790> with the torches
2011-02-01 22:05:24 [INFO] <nawf> we'd just have to move the water flow up
2011-02-01 22:05:36 [INFO] <redux06790> i dont wanna tinker with your baby
2011-02-01 22:05:40 [INFO] <redux06790> but now that you mentioned it
2011-02-01 22:05:47 [INFO] <redux06790> the open lines looked better
2011-02-01 22:06:41 [INFO] <redux06790> wtf is going on here?
2011-02-01 22:06:48 [INFO] <nawf> phantoms
2011-02-01 22:06:50 [INFO] <redux06790> its shitting out sulphur
2011-02-01 22:06:51 [INFO] nawf lost connection: disconnect.quitting
2011-02-01 22:06:54 [INFO] nawf [/76.23.232.27:55046] logged in with entity id 2456045
2011-02-01 22:06:55 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-01 22:06:58 [INFO] redux06790 [/69.119.8.191:49722] logged in with entity id 2456161
2011-02-01 22:07:04 [INFO] <redux06790> ahh
2011-02-01 22:07:06 [INFO] <nawf> its just a repeating animation
2011-02-01 22:07:09 [INFO] <nawf> still happening for me
2011-02-01 22:07:13 [INFO] <redux06790> me too
2011-02-01 22:08:53 [INFO] <nawf> lol
2011-02-01 22:08:59 [INFO] <redux06790> ?
2011-02-01 22:09:07 [INFO] <nawf> thats there so you can see if there are mobs around
2011-02-01 22:09:09 [INFO] <nawf> the glass I mean
2011-02-01 22:09:16 [INFO] <nawf> because its not 100% safe down here
2011-02-01 22:09:22 [INFO] <redux06790> its really not
2011-02-01 22:09:28 [INFO] <redux06790> i got fucking ass raped by zombies
2011-02-01 22:09:39 [INFO] <nawf> yeah, they come from up high
2011-02-01 22:11:19 [INFO] <redux06790> shit i dont wanna go to work
2011-02-01 22:11:24 [INFO] <redux06790> john cmere sec
2011-02-01 22:11:42 [INFO] <redux06790> farm
2011-02-01 22:11:49 [INFO] <nawf> cool
2011-02-01 22:12:00 [INFO] <redux06790> for making teh fuds
2011-02-01 22:12:27 [INFO] <AngryRhetoric> neeed teh fuds
2011-02-01 22:12:37 [INFO] <nawf> ahhh
2011-02-01 22:13:46 [INFO] <redux06790> well
2011-02-01 22:13:52 [INFO] <redux06790> i need some freaking lightstone
2011-02-01 22:13:56 [INFO] <redux06790> so i can make a lit floor
2011-02-01 22:14:11 [INFO] <nawf> I know, sucks that there isn't any
2011-02-01 22:14:41 [INFO] <nawf> that may work
2011-02-01 22:15:23 [INFO] <redux06790> balls this isnt going to work
2011-02-01 22:15:39 [INFO] <nawf> what about
2011-02-01 22:16:01 [INFO] <nawf> naw, too close
2011-02-01 22:16:02 [INFO] <redux06790> heres what im thinking
2011-02-01 22:16:04 [INFO] <nawf> we could raise the root
2011-02-01 22:16:07 [INFO] <nawf> roof
2011-02-01 22:16:25 [INFO] <nawf> yeah, that will work
2011-02-01 22:16:34 [INFO] <redux06790> DERP
2011-02-01 22:16:35 [INFO] <redux06790> OMG
2011-02-01 22:17:40 [INFO] <nawf> rofl
2011-02-01 22:17:46 [INFO] <nawf> awesome
2011-02-01 22:17:58 [INFO] <redux06790> there we go
2011-02-01 22:18:03 [INFO] <redux06790> forgot about that
2011-02-01 22:18:17 [INFO] <nawf> and this too
2011-02-01 22:18:17 [INFO] <redux06790> were gonna need more pumpkins
2011-02-01 22:18:25 [INFO] <nawf> aw, thats ugly
2011-02-01 22:18:39 [INFO] <redux06790> well its esp ugly for me because my jack o lanterns are ghasts
2011-02-01 22:18:51 [INFO] <nawf> oh, lol
2011-02-01 22:18:58 [INFO] <nawf> naw I just meant with the die
2011-02-01 22:19:04 [INFO] <nawf> I like the floor pumpkins
2011-02-01 22:19:10 [INFO] <redux06790> how bout there?
2011-02-01 22:19:32 [INFO] <redux06790> not bad
2011-02-01 22:19:46 [INFO] <redux06790> k well i gtg to fucking work
2011-02-01 22:19:46 [INFO] <redux06790> lol
2011-02-01 22:19:50 [INFO] <redux06790> im so late
2011-02-01 22:20:04 [INFO] <nawf> ""sorry boss, we were color coordinating the base
2011-02-01 22:20:09 [INFO] <redux06790> this area is haping up nicely though
2011-02-01 22:20:18 [INFO] <redux06790> im not sure what ill put here
2011-02-01 22:20:24 [INFO] <redux06790> maybe another forge
2011-02-01 22:20:26 [INFO] <nawf> it was just a mini farm
2011-02-01 22:20:32 [INFO] <nawf> because we have so much bonemeal
2011-02-01 22:20:36 [INFO] <redux06790> or a reed wall
2011-02-01 22:20:39 [INFO] <nawf> it doesn't make sense to wait in a way
2011-02-01 22:20:56 [INFO] <nawf> lets gid it out and glass it
2011-02-01 22:22:01 [INFO] <nawf> the only reason this has a stair roof is because the stairs were built first
2011-02-01 22:22:48 [INFO] <nawf> thats pretty cool
2011-02-01 22:22:49 [INFO] <redux06790> that looks cool
2011-02-01 22:22:54 [INFO] <redux06790> hell yeah
2011-02-01 22:22:58 [INFO] <redux06790> ill be back at 1AM
2011-02-01 22:23:02 [INFO] <AngryRhetoric> hah
2011-02-01 22:23:03 [INFO] <nawf> I'll be asleep
2011-02-01 22:23:04 [INFO] <redux06790> i REAAALLLLLLY need to get to wrok
2011-02-01 22:23:08 [INFO] <redux06790> lol
2011-02-01 22:23:36 [INFO] <nawf> we could move this dock too
2011-02-01 22:23:39 [INFO] <redux06790> this base is getting epic
2011-02-01 22:23:42 [INFO] <redux06790> yeah i dont like that
2011-02-01 22:23:45 [INFO] <redux06790> actually
2011-02-01 22:23:54 [INFO] <redux06790> we should turn this area into the entrance
2011-02-01 22:23:54 [INFO] <nawf> replace the walls with the glass dome look
2011-02-01 22:24:01 [INFO] <nawf> oh right
2011-02-01 22:24:02 [INFO] <redux06790> and seal off the other entarnce
2011-02-01 22:24:04 [INFO] <nawf> yeah
2011-02-01 22:24:08 [INFO] <redux06790> ok i gtg though
2011-02-01 22:24:10 [INFO] <redux06790> lol
2011-02-01 22:24:10 [INFO] <nawf> as long as we can see around us
2011-02-01 22:24:15 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-01 22:25:52 [INFO] <nawf> where are you kevin?
2011-02-01 22:26:04 [INFO] <AngryRhetoric> over by my castle / village hamlet thingy
2011-02-01 22:26:15 [INFO] <AngryRhetoric> you need me?
2011-02-01 22:26:16 [INFO] <nawf> find clay yet?
2011-02-01 22:26:20 [INFO] <nawf> naw, just mucking around
2011-02-01 22:26:29 [INFO] <AngryRhetoric> actually yes i did a few days ago
2011-02-01 22:26:39 [INFO] <AngryRhetoric> was thinking of making chimneys for the village houses haha
2011-02-01 22:26:46 [INFO] <nawf> yeah cool
2011-02-01 22:26:52 [INFO] <nawf> I just haven't seen a single piece yet
2011-02-01 22:27:00 [INFO] <AngryRhetoric> its rare in this world
2011-02-01 22:27:05 [INFO] <AngryRhetoric> my single player one had a bit more
2011-02-01 22:32:36 [INFO] <AngryRhetoric> tree farming
2011-02-01 22:33:06 [INFO] <nawf> punch trees, get wood
2011-02-01 22:33:09 [INFO] <AngryRhetoric> haha
2011-02-01 22:36:39 [INFO] <AngryRhetoric> you like?
2011-02-01 22:36:45 [INFO] <nawf> yeah, whats the rent?
2011-02-01 22:36:49 [INFO] <nawf> neighborhood good?
2011-02-01 22:36:56 [INFO] <AngryRhetoric> for these lower lots you can get a good deal
2011-02-01 22:37:05 [INFO] <AngryRhetoric> there's two primo houses right near the castle
2011-02-01 22:37:21 [INFO] <AngryRhetoric> those will have two, count them TWO rooms
2011-02-01 22:37:25 [INFO] <nawf> jesus
2011-02-01 22:37:53 [INFO] <nawf> need glass for these
2011-02-01 22:38:03 [INFO] <AngryRhetoric> that's where the lords and high councelmen will live
2011-02-01 22:38:09 [INFO] <AngryRhetoric> yeah i'm short on sand/ glass
2011-02-01 22:38:14 [INFO] <AngryRhetoric> nice thx!
2011-02-01 22:38:16 [INFO] <nawf> I was carrying some around I didn't need
2011-02-01 22:38:21 [INFO] <AngryRhetoric> perfect
2011-02-01 22:38:28 [INFO] <nawf> I'm just hiding out here for the night
2011-02-01 22:38:38 [INFO] <AngryRhetoric> i might make beds in these things too
2011-02-01 22:38:41 [INFO] <nawf> brb, mugging and raping villagers
2011-02-01 22:38:45 [INFO] <AngryRhetoric> LOL
2011-02-01 22:38:54 [INFO] <AngryRhetoric> the villagers sound like cows when they scream
2011-02-01 22:39:00 [INFO] <AngryRhetoric> that or you're not raping villagers
2011-02-01 22:39:00 [INFO] <nawf> noooooooooo
2011-02-01 22:40:08 [INFO] <AngryRhetoric> that poor sheep never saw it coming
2011-02-01 22:41:34 [INFO] <nawf> creeper in the tower
2011-02-01 22:41:36 [INFO] <AngryRhetoric> may have to do more with the castle
2011-02-01 22:41:39 [INFO] <AngryRhetoric> darn they do get in
2011-02-01 22:42:07 [INFO] <AngryRhetoric> i thought this part was well lit lol
2011-02-01 22:46:59 [INFO] <AngryRhetoric> if we were to head south in this game would there be less snow? he should put palm trees in this thi
2011-02-01 22:47:20 [INFO] <nawf> yeah, there is almost no snow south
2011-02-01 22:48:11 [INFO] <AngryRhetoric> cool
2011-02-01 23:04:44 [INFO] nawf lost connection: disconnect.quitting
2011-02-01 23:04:46 [INFO] nawf [/76.23.232.27:55020] logged in with entity id 2572388
2011-02-01 23:04:49 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-01 23:05:42 [INFO] <AngryRhetoric> alright i'm out for the night
2011-02-01 23:05:45 [INFO] <nawf> lol
2011-02-01 23:05:48 [INFO] <nawf> I went south
2011-02-01 23:05:52 [INFO] <AngryRhetoric> how far?
2011-02-01 23:05:55 [INFO] <nawf> a lava pit just lit the forest on fire
2011-02-01 23:06:04 [INFO] <AngryRhetoric> hahaha burrrn
2011-02-01 23:06:09 [INFO] <nawf> z is 605
2011-02-01 23:06:38 [INFO] <AngryRhetoric> positive 605?? you're miles away
2011-02-01 23:06:48 [INFO] <nawf> yeah, z 600 ish
2011-02-01 23:07:26 [INFO] <AngryRhetoric> anything worth travelling for?
2011-02-01 23:07:32 [INFO] <nawf> pretty cool mountain
2011-02-01 23:08:10 [INFO] <AngryRhetoric> maybe tomorrow i'll check it out
2011-02-01 23:09:02 [INFO] <AngryRhetoric> laters
2011-02-01 23:09:06 [INFO] <nawf> see yah
2011-02-01 23:09:08 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-01 23:14:12 [INFO] nawf lost connection: disconnect.quitting
2011-02-02 03:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 04:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 06:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 06:59:42 [INFO] efess [/192.168.0.198:33684] logged in with entity id 2596869
2011-02-02 07:18:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 08:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 09:04:25 [INFO] efess lost connection: disconnect.genericReason
2011-02-02 09:04:29 [INFO] efess [/192.168.0.198:37133] logged in with entity id 2954371
2011-02-02 09:06:21 [INFO] nawf [/76.23.232.27:55175] logged in with entity id 2960332
2011-02-02 09:07:27 [INFO] <efess> sup
2011-02-02 09:07:34 [INFO] <nawf> just died exploring
2011-02-02 09:07:35 [INFO] <nawf> pissed
2011-02-02 09:07:41 [INFO] <efess> fuuuu
2011-02-02 09:07:52 [INFO] <nawf> there are sick mountains around z -600
2011-02-02 09:08:09 [INFO] <efess> o really?
2011-02-02 09:08:16 [INFO] <nawf> yeah, epic shit
2011-02-02 09:08:42 [INFO] <efess> so minecart tunnel NORTH?
2011-02-02 09:08:49 [INFO] <nawf> I think thats west
2011-02-02 09:09:18 [INFO] <efess> Z is north/south from what I understand
2011-02-02 09:09:32 [INFO] <nawf> oh, yeah, so south
2011-02-02 09:09:49 [INFO] <efess> south is +Z
2011-02-02 09:09:51 [INFO] <efess> NORTH is -Z
2011-02-02 09:09:57 [INFO] <nawf> oh, so north
2011-02-02 09:10:05 [INFO] <nawf> north east across the ocean
2011-02-02 09:10:06 [INFO] <efess> unless i'm wrong
2011-02-02 09:10:07 [INFO] <efess> :P
2011-02-02 09:10:15 [INFO] <nawf> and its new chunk too, birth trees to lapis
2011-02-02 09:10:26 [INFO] <efess> nice
2011-02-02 09:11:01 [INFO] <efess> gotta work @ 10
2011-02-02 09:11:11 [INFO] <nawf> I'm just preparing to idle
2011-02-02 09:11:14 [INFO] <efess> so let me send you my resume
2011-02-02 09:11:20 [INFO] <efess> I just need to update it
2011-02-02 09:11:33 [INFO] <nawf> need a new job?
2011-02-02 09:11:39 [INFO] <efess> i'm just sick of what i'm doing
2011-02-02 09:11:50 [INFO] <efess> well I wouldn't mind it if it wasn't for the pair programming
2011-02-02 09:12:07 [INFO] <nawf> true, did you know ray is in the interview process right now?
2011-02-02 09:12:08 [INFO] <efess> and I wouldn't mind the pair programming if it wasn't for my co workers
2011-02-02 09:12:20 [INFO] <efess> nah, that's cool
2011-02-02 09:12:25 [INFO] <efess> poor intergis
2011-02-02 09:12:26 [INFO] <efess> haha
2011-02-02 09:12:31 [INFO] <nawf> yeah, he just had his tech interview yesterday
2011-02-02 09:12:34 [INFO] <nawf> don't know how he did
2011-02-02 09:12:45 [INFO] <efess> yea he'll do well
2011-02-02 09:13:04 [INFO] <efess> he's good, esp with gui's and shit
2011-02-02 09:13:13 [INFO] <nawf> well you need some web background here, like understanding how to change your dns
2011-02-02 09:13:16 [INFO] <nawf> what the host file is
2011-02-02 09:13:29 [INFO] <nawf> they ask things like that, low level, he said he doesn't know a lot of that
2011-02-02 09:13:35 [INFO] <efess> ah
2011-02-02 09:13:48 [INFO] <nawf> it depends, dunno, I guess he tech'ed with a real moron
2011-02-02 09:13:48 [INFO] <efess> that's too bad, DNS is general knowledge
2011-02-02 09:13:49 [INFO] <nawf> ;)
2011-02-02 09:14:06 [INFO] <nawf> yeah, the rationale here is that you may be thrown into some fubar
2011-02-02 09:14:14 [INFO] <nawf> situation you'll need to know useless trivia to solve
2011-02-02 09:14:22 [INFO] <nawf> but its a good job
2011-02-02 09:14:48 [INFO] <efess> ya well you need to know google
2011-02-02 09:15:03 [INFO] <nawf> yeah, its weird how they interview
2011-02-02 09:16:09 [INFO] <efess> I like what erin did to the place
2011-02-02 09:16:29 [INFO] <nawf> yeah, except the cobble makes me to crazy
2011-02-02 09:16:36 [INFO] <efess> cobble?
2011-02-02 09:16:54 [INFO] <efess> he's a really get er done kinda guy lol
2011-02-02 09:18:01 [INFO] <efess> oh and the only problem with the passive spawner
2011-02-02 09:18:09 [INFO] <efess> is your sweet underground river
2011-02-02 09:20:09 [INFO] <nawf> the river is a problem?
2011-02-02 09:20:13 [INFO] <efess> nope
2011-02-02 09:20:18 [INFO] <efess> I mean the grass down here
2011-02-02 09:20:29 [INFO] <nawf> true
2011-02-02 09:20:47 [INFO] <efess> def don' twant to dig it up though
2011-02-02 09:20:57 [INFO] <nawf> yeah erin is good, I like his style, we pumpkins the floor last night
2011-02-02 09:21:06 [INFO] <efess> LOL I was curious why
2011-02-02 09:21:21 [INFO] <nawf> well were were talking about sight lines, bigget sight lines = better
2011-02-02 09:21:43 [INFO] <nawf> so we may glass out the base walls, dig it out more
2011-02-02 09:23:14 [INFO] <efess> mmm leaks
2011-02-02 09:23:28 [INFO] <efess> having a roofing dude come out here
2011-02-02 09:23:34 [INFO] <efess> gotta get rid of the ice dams
2011-02-02 09:28:13 [INFO] <nawf> you should just turn them into waterfalls
2011-02-02 09:43:48 [INFO] <efess> lol
2011-02-02 09:44:02 [INFO] <efess> when the guy goes and makes channels
2011-02-02 09:44:13 [INFO] <efess> i'm going to expect the pool of water to slowly make its way down
2011-02-02 09:44:17 [INFO] <efess> one block at a time
2011-02-02 09:45:54 [INFO] efess lost connection: disconnect.quitting
2011-02-02 10:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 10:56:04 [INFO] efess [/192.168.0.198:40260] logged in with entity id 3515158
2011-02-02 10:56:18 [INFO] <efess> yo
2011-02-02 10:56:40 [INFO] <nawf> yo, chickens are clogged again
2011-02-02 10:57:01 [INFO] <efess> are they clogging it meaning mobs can't hit lava
2011-02-02 10:57:14 [INFO] <nawf> oh, no, just glitched
2011-02-02 10:57:18 [INFO] <efess> oh
2011-02-02 10:57:34 [INFO] <efess> well do you see any problem with it?
2011-02-02 10:57:46 [INFO] <efess> they provide eggs and lulz
2011-02-02 10:57:53 [INFO] <nawf> oh no I'm just saying
2011-02-02 10:57:58 [INFO] <nawf> I think its awesome
2011-02-02 10:58:04 [INFO] <nawf> the sound over here is wild
2011-02-02 10:58:11 [INFO] <nawf> chickens loosing their shit and death
2011-02-02 10:59:07 [INFO] <efess> heh
2011-02-02 10:59:23 [INFO] <efess> need me to idle anywhere like the passive spawner?
2011-02-02 10:59:41 [INFO] <efess> my laptop is just sitting here
2011-02-02 10:59:50 [INFO] <nawf> dunno, will that effect the rate?  I'm not sure why we don't get as many passive drops
2011-02-02 10:59:57 [INFO] <nawf> my concern is the wool, why we don't get any
2011-02-02 11:00:06 [INFO] <efess> well i'm sure it's because of the grass down here
2011-02-02 11:00:10 [INFO] <nawf> maybe we need a cactus that hits the sheep?
2011-02-02 11:00:32 [INFO] <efess> oh you don't think the wool is making it down? or the sheep just aren't spawning there/
2011-02-02 11:00:55 [INFO] <nawf> I don't think the wool is making it down, like they die without loosing it or something
2011-02-02 11:01:09 [INFO] <efess> ahh
2011-02-02 11:01:13 [INFO] <nawf> I mean I'm happy with the rate right now, but I know erin needs a bunch of wool
2011-02-02 11:01:18 [INFO] <efess> makes sense , maybe they need to be attacked
2011-02-02 11:01:25 [INFO] <efess> for the wool to fall off
2011-02-02 11:01:30 [INFO] <nawf> and since spiders climb the string rate is low
2011-02-02 11:01:44 [INFO] <nawf> if you go right under the grinder you can hear tons of spiders
2011-02-02 11:03:43 [INFO] <efess> I don't see any spiders up there
2011-02-02 11:03:50 [INFO] <efess> you mean in the spawner?
2011-02-02 11:04:13 [INFO] <efess> oh so the problem with the chickens
2011-02-02 11:04:18 [INFO] <efess> they prevent other passive mobs from spawning
2011-02-02 11:04:24 [INFO] <efess> since there's a 15 passive mob limit
2011-02-02 11:04:29 [INFO] <nawf> no shit
2011-02-02 11:04:37 [INFO] <nawf> I didn't know that
2011-02-02 11:04:40 [INFO] <efess> ya
2011-02-02 11:04:43 [INFO] <efess> random zombie
2011-02-02 11:04:45 [INFO] <efess> fkr
2011-02-02 11:05:32 [INFO] <nawf> tonight I'm probably going to blow more shit out and then make things safer
2011-02-02 11:05:38 [INFO] <nawf> tons of nooks and crannies up top
2011-02-02 11:07:37 [INFO] <efess> going to clear out above this base?
2011-02-02 11:09:14 [INFO] <nawf> yeah, just torch it out
2011-02-02 11:09:24 [INFO] <nawf> remove ledges
2011-02-02 11:10:07 [INFO] <nawf> shit, zombie in the base, I have no weapons
2011-02-02 11:10:30 [INFO] <efess> trying this again huh
2011-02-02 11:10:38 [INFO] <nawf> lol, the zombie fucked up the wheat farm
2011-02-02 11:10:41 [INFO] <nawf> naw, this is erins
2011-02-02 11:10:44 [INFO] <efess> ah
2011-02-02 11:10:52 [INFO] <efess> does he know its a PITA
2011-02-02 11:11:00 [INFO] <nawf> I don't think so
2011-02-02 11:11:07 [INFO] <nawf> and with bonemeal its almost a waste
2011-02-02 11:11:16 [INFO] <efess> yea, if it was automatic that'd be one thing
2011-02-02 11:11:37 [INFO] <nawf> I think we just have to kill the zombie spawner
2011-02-02 11:11:44 [INFO] <nawf> because it will glitch and spawn up to 5 blocks away
2011-02-02 11:11:54 [INFO] <nawf> which is what probably happened there
2011-02-02 11:12:00 [INFO] <efess> yea true
2011-02-02 11:12:05 [INFO] <efess> its useless anyway
2011-02-02 11:12:10 [INFO] <nawf> yeah
2011-02-02 11:12:21 [INFO] <efess> unless we want a zombie zoo
2011-02-02 11:18:51 [INFO] <nawf> lol, just make it one space with bars
2011-02-02 11:25:54 [INFO] <efess> if we weren't worried about zombies spawning here i'd say lets do it
2011-02-02 12:10:17 [INFO] efess lost connection: disconnect.quitting
2011-02-02 14:25:42 [INFO] efess [/192.168.0.198:46957] logged in with entity id 4424300
2011-02-02 14:25:54 [INFO] <efess> lol chickens
2011-02-02 14:27:48 [INFO] efess lost connection: disconnect.quitting
2011-02-02 15:46:00 [INFO] /192.168.0.198:49483 lost connection
2011-02-02 15:46:40 [INFO] Disconnecting /192.168.0.198:49501: Took too long to log in
2011-02-02 16:20:07 [INFO] /192.168.0.198:50506 lost connection
2011-02-02 16:20:50 [INFO] efess [/192.168.0.198:50517] lost connection
2011-02-02 16:20:53 [INFO] /192.168.0.198:50534 lost connection
2011-02-02 16:34:36 [INFO] nawf lost connection: disconnect.quitting
2011-02-02 16:53:28 [INFO] AngryRhetoric [/24.147.183.4:49598] logged in with entity id 4877842
2011-02-02 16:53:43 [INFO] <AngryRhetoric> yo
2011-02-02 17:11:10 [INFO] efess [/192.168.0.198:51832] logged in with entity id 4898421
2011-02-02 17:11:16 [INFO] <AngryRhetoric> sup joe
2011-02-02 17:11:20 [INFO] <efess> hey kevin
2011-02-02 17:11:41 [INFO] <AngryRhetoric> hi my name's kevin and i'm a minecraft addict
2011-02-02 17:11:49 [INFO] <AngryRhetoric> this is MA right?
2011-02-02 17:11:53 [INFO] <efess> haha hold on brb
2011-02-02 17:16:02 [INFO] <efess> MAA
2011-02-02 17:16:45 [INFO] <AngryRhetoric> minecraft-aholics-anonymous lol
2011-02-02 17:18:17 [INFO] <AngryRhetoric> what was you guys were making last night? the dialogue was funny
2011-02-02 17:18:39 [INFO] <efess> oh haha the passive spawner
2011-02-02 17:18:52 [INFO] <efess> there's a spot where pigs/chickens/cows will spawn
2011-02-02 17:18:58 [INFO] <efess> and fall into the death chute
2011-02-02 17:18:58 [INFO] <AngryRhetoric> ahh yeah i saw that
2011-02-02 17:19:00 [INFO] <AngryRhetoric> does it work?
2011-02-02 17:19:04 [INFO] <efess> kinda
2011-02-02 17:19:12 [INFO] <efess> making a village?
2011-02-02 17:19:14 [INFO] <AngryRhetoric> i saw a couple of animals hah
2011-02-02 17:19:16 [INFO] <AngryRhetoric> yes sir
2011-02-02 17:19:22 [INFO] <efess> niceee
2011-02-02 17:19:34 [INFO] <AngryRhetoric> haha thanks its supposed to be part of the castle setting but
2011-02-02 17:19:41 [INFO] <efess> looks like you have mobs moving in
2011-02-02 17:19:41 [INFO] <efess> ;P
2011-02-02 17:19:43 [INFO] <AngryRhetoric> they look like pre-fab houses
2011-02-02 17:19:51 [INFO] <AngryRhetoric> there goes the neighborhood!!
2011-02-02 17:20:10 [INFO] <AngryRhetoric> mob free since...yesterday haha
2011-02-02 17:21:10 [INFO] <AngryRhetoric> you can have one if you want
2011-02-02 17:21:22 [INFO] <AngryRhetoric> the ""primo""housing is up here
2011-02-02 17:21:24 [INFO] <efess> haha thanks
2011-02-02 17:21:30 [INFO] <AngryRhetoric> with TWO, count them TWO rooms
2011-02-02 17:21:49 [INFO] <AngryRhetoric> nothing says ""i'm the king's favorite peasant"" like these houses
2011-02-02 17:21:53 [INFO] <efess> :D
2011-02-02 17:22:08 [INFO] <efess> a suite!
2011-02-02 17:22:21 [INFO] <efess> nice view of the sunrise!
2011-02-02 17:22:30 [INFO] <AngryRhetoric> yeah thats true!
2011-02-02 17:23:59 [INFO] <AngryRhetoric> haha
2011-02-02 17:24:03 [INFO] <AngryRhetoric> that's the sniper tower
2011-02-02 17:24:16 [INFO] <efess> pick off your peasants? :P
2011-02-02 17:24:21 [INFO] <AngryRhetoric> apparently its bar time, on a wednesday hahah
2011-02-02 17:24:24 [INFO] <AngryRhetoric> i'll be back on later
2011-02-02 17:24:27 [INFO] <AngryRhetoric> yes
2011-02-02 17:24:29 [INFO] <efess> alright
2011-02-02 17:24:33 [INFO] <efess> dinner time :)
2011-02-02 17:24:34 [INFO] <AngryRhetoric> the one's that don't pay the king's tribute
2011-02-02 17:24:34 [INFO] <efess> l8r
2011-02-02 17:24:37 [INFO] <efess> haha
2011-02-02 17:24:39 [INFO] <AngryRhetoric> later !
2011-02-02 17:24:41 [INFO] efess lost connection: disconnect.quitting
2011-02-02 17:24:49 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-02 17:45:32 [INFO] efess [/192.168.0.198:53067] logged in with entity id 4915503
2011-02-02 17:51:42 [INFO] /76.23.232.27:55006 lost connection
2011-02-02 17:52:34 [INFO] nawf [/76.23.232.27:55070] logged in with entity id 4921735
2011-02-02 18:04:44 [INFO] nawf lost connection: disconnect.quitting
2011-02-02 18:07:34 [INFO] redux06790 [/69.119.8.191:49293] logged in with entity id 4935737
2011-02-02 18:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 18:25:05 [INFO] nawf [/76.23.232.27:55011] logged in with entity id 4940435
2011-02-02 18:27:20 [INFO] <redux06790> oh herro
2011-02-02 18:27:22 [INFO] <redux06790> i was afk
2011-02-02 18:27:25 [INFO] <redux06790> we need sand
2011-02-02 18:27:45 [INFO] <nawf> thats what I was doing until I fell in a lava pit
2011-02-02 18:27:55 [INFO] <nawf> fyi, no sand in lava
2011-02-02 18:28:02 [INFO] <redux06790> we need like 38 stacks lol
2011-02-02 18:28:22 [INFO] <redux06790> brb bio
2011-02-02 18:29:13 [INFO] efess lost connection: disconnect.quitting
2011-02-02 18:29:17 [INFO] efess [/192.168.0.198:54321] logged in with entity id 4946485
2011-02-02 18:29:28 [INFO] <nawf> my apt is leaking too
2011-02-02 18:29:34 [INFO] <efess> o shit
2011-02-02 18:29:51 [INFO] <efess> I just wrote a check for 3k
2011-02-02 18:29:52 [INFO] <efess> woohoo
2011-02-02 18:30:09 [INFO] <nawf> you mean the condo association did right?
2011-02-02 18:31:47 [INFO] <redux06790> ugh i gotta shovel brb
2011-02-02 18:31:55 [INFO] <nawf> rl is lame sometimes
2011-02-02 18:33:59 [INFO] efess lost connection: disconnect.quitting
2011-02-02 18:44:25 [INFO] efess [/192.168.0.198:54763] logged in with entity id 4957029
2011-02-02 18:44:34 [INFO] <efess> yea I wrote it for the assoc
2011-02-02 18:44:44 [INFO] <efess> dude wanted to charge 5k
2011-02-02 18:45:16 [INFO] <nawf> damn
2011-02-02 18:45:33 [INFO] <nawf> was talking to my neighbor, they rape in the winter
2011-02-02 18:45:42 [INFO] <nawf> because who else are you going to find to climb up there?
2011-02-02 18:47:19 [INFO] <efess> yea man
2011-02-02 18:47:24 [INFO] <efess> especially last minute
2011-02-02 18:52:35 [INFO] <efess> how bad are the leaks?
2011-02-02 18:52:47 [INFO] <nawf> before, ok, now shitty
2011-02-02 18:52:57 [INFO] <efess> like a drisle
2011-02-02 18:53:07 [INFO] <nawf> fo shizzle
2011-02-02 18:53:12 [INFO] <efess> yo nizzle.
2011-02-02 18:53:27 [INFO] <efess> what's your landlord saying?
2011-02-02 18:53:33 [INFO] <efess> FUuuuu?
2011-02-02 18:54:22 [INFO] <nawf> well now its much worse, I didn't call them before, doing it now
2011-02-02 18:56:26 [INFO] <efess> what should we do with so much cacti?
2011-02-02 18:56:34 [INFO] <redux06790> make tons of green dye
2011-02-02 18:56:37 [INFO] <efess> a deadly maze?
2011-02-02 18:56:55 [INFO] <redux06790> or make walls that kill mobs
2011-02-02 18:57:04 [INFO] <redux06790> use them as decoration
2011-02-02 18:57:05 [INFO] <redux06790> idk
2011-02-02 18:57:22 [INFO] <efess> hehe electric fence
2011-02-02 19:14:53 [INFO] efess lost connection: disconnect.quitting
2011-02-02 19:14:56 [INFO] efess [/192.168.0.198:55478] logged in with entity id 4992179
2011-02-02 19:15:20 [INFO] <nawf> now I am def going to move
2011-02-02 19:15:22 [INFO] <nawf> fuck this guy
2011-02-02 19:15:26 [INFO] <efess> what?
2011-02-02 19:15:34 [INFO] <efess> not going to do anything about it?
2011-02-02 19:15:40 [INFO] <nawf> oh i did
2011-02-02 19:15:45 [INFO] <efess> no he's not?
2011-02-02 19:15:56 [INFO] <nawf> probably not, I know what to expect from them
2011-02-02 19:16:07 [INFO] <nawf> and its been ok, but shit is piling up now
2011-02-02 19:16:19 [INFO] <nawf> my light in the livingroom shorts, the office floor is sinking
2011-02-02 19:16:28 [INFO] <efess> I mean its not just about you, its his house, if he lets it go, shits just going
2011-02-02 19:16:29 [INFO] <efess> to rot
2011-02-02 19:16:42 [INFO] <efess> damn
2011-02-02 19:17:07 [INFO] <nawf> it is too, the porch beams have disconnected from their mounts
2011-02-02 19:17:19 [INFO] <nawf> nails are just holding them in now, ice probably pushing it out
2011-02-02 19:17:55 [INFO] <efess> so is your shit getting fucked?
2011-02-02 19:18:28 [INFO] <nawf> I think I covered it but I don't know
2011-02-02 19:21:26 [INFO] <redux06790> john you should see the new entrance
2011-02-02 19:28:28 [INFO] <efess> so whats this for?
2011-02-02 19:28:39 [INFO] <redux06790> whatever really... i thought it looked cool
2011-02-02 19:28:42 [INFO] <efess> cool
2011-02-02 19:28:44 [INFO] <redux06790> probably more stone
2011-02-02 19:28:54 [INFO] <redux06790> since thats our most abundant resource
2011-02-02 19:32:23 [INFO] <redux06790> dude
2011-02-02 19:32:27 [INFO] <redux06790> this base is awesome
2011-02-02 19:32:40 [INFO] <efess> yea i'm goin to move the tracks over there
2011-02-02 19:32:50 [INFO] <efess> and give it some more functionality
2011-02-02 19:32:55 [INFO] <efess> auto carts and shit
2011-02-02 19:32:56 [INFO] <redux06790> lol youre the track guy?
2011-02-02 19:33:00 [INFO] <efess> yea I guess so
2011-02-02 19:33:03 [INFO] <redux06790> whos the redstone guy then?
2011-02-02 19:33:08 [INFO] <efess> John and I
2011-02-02 19:33:09 [INFO] <efess> lol
2011-02-02 19:33:11 [INFO] <redux06790> lol
2011-02-02 19:33:16 [INFO] <efess> john's the music guru
2011-02-02 19:33:17 [INFO] <nawf> I just make useless music things
2011-02-02 19:33:21 [INFO] <redux06790> im the aesthetic guy
2011-02-02 19:33:33 [INFO] <redux06790> this base is much more open now
2011-02-02 19:33:34 [INFO] <nawf> can't be unless you use smoothstone
2011-02-02 19:33:49 [INFO] <redux06790> yeah ive been planning on going back over my cobble
2011-02-02 19:33:56 [INFO] <redux06790> cobble has its place too you know
2011-02-02 19:33:57 [INFO] <redux06790> lol
2011-02-02 19:34:01 [INFO] <nawf> smoothstone ocd for the win
2011-02-02 19:34:03 [INFO] <nawf> joe gave it to me
2011-02-02 19:34:06 [INFO] <nawf> you'll get it soon
2011-02-02 19:34:20 [INFO] <efess> cobble looks cool with the tronic pack
2011-02-02 19:34:37 [INFO] <efess> you use a texturepack erin?
2011-02-02 19:34:43 [INFO] <redux06790> yes
2011-02-02 19:34:47 [INFO] <redux06790> custom painterly
2011-02-02 19:34:52 [INFO] <efess> ah that ones cool
2011-02-02 19:34:59 [INFO] <nawf> I feel like a nub for not using one
2011-02-02 19:35:20 [INFO] <nawf> 36 stacks of sand incoming soon
2011-02-02 19:35:24 [INFO] <nawf> once day breaks
2011-02-02 19:35:29 [INFO] <redux06790> we need more pumpkins
2011-02-02 19:36:54 [INFO] <efess> sounds like an earthquake here
2011-02-02 19:36:58 [INFO] <efess> with all the snow being moved off the roof
2011-02-02 19:42:00 [INFO] <efess> we should have an infinite water source in here
2011-02-02 19:42:10 [INFO] <redux06790> yeah i was thinking of making a well
2011-02-02 19:42:20 [INFO] <redux06790> like right wehre im standing
2011-02-02 19:42:26 [INFO] <efess> dig a hole i'll get the water
2011-02-02 19:47:00 [INFO] <efess> LOL
2011-02-02 19:47:14 [INFO] <efess> jess just said a picture of our cat looks
2011-02-02 19:47:18 [INFO] <efess> like a pedophile
2011-02-02 19:47:23 [INFO] <nawf> W
2011-02-02 19:47:23 [INFO] <efess> fuckin cat
2011-02-02 19:47:25 [INFO] <nawf> T
2011-02-02 19:47:27 [INFO] <nawf> F
2011-02-02 19:47:36 [INFO] <efess> the one she put on facebook
2011-02-02 19:47:43 [INFO] <efess> he's got a pedosmirk
2011-02-02 19:48:18 [INFO] <efess> platters?
2011-02-02 19:48:19 [INFO] <efess> mmm
2011-02-02 19:48:32 [INFO] <nawf> she just said ""she doesn't have much platters""
2011-02-02 19:48:34 [INFO] <nawf> pshh
2011-02-02 19:48:37 [INFO] <efess> LOL
2011-02-02 19:48:54 [INFO] <efess> we have plenty of snowman platters
2011-02-02 19:49:02 [INFO] <nawf> idk
2011-02-02 19:58:45 [INFO] <nawf> 512 tnt
2011-02-02 19:58:47 [INFO] <nawf> :D:D:D:D:D
2011-02-02 19:58:53 [INFO] <redux06790> FUCK YEA!!!
2011-02-02 19:59:05 [INFO] <redux06790> brb gotta lie molly down for bed
2011-02-02 20:00:13 [INFO] <nawf> we have over 800 tnt now
2011-02-02 20:00:15 [INFO] <nawf> :D
2011-02-02 20:00:43 [INFO] <efess> what are we going to blow up?!
2011-02-02 20:00:50 [INFO] <nawf> EVERYTHING
2011-02-02 20:00:53 [INFO] <efess> !!!
2011-02-02 20:03:18 [INFO] <nawf> anybody got any sticks? we are out of wood
2011-02-02 20:03:23 [INFO] <efess> ya
2011-02-02 20:03:29 [INFO] <nawf> I'll go fuck up a forest but I need some protection
2011-02-02 20:03:54 [INFO] <efess> wooo
2011-02-02 20:05:58 [INFO] <nawf> forgot arrows lol
2011-02-02 20:06:09 [INFO] <redux06790> what do you think john?
2011-02-02 20:06:21 [INFO] <nawf> I dig it
2011-02-02 20:06:26 [INFO] <redux06790> i see what you did there
2011-02-02 20:07:31 [INFO] <redux06790> i love smacking the chickens with the shovel
2011-02-02 20:07:44 [INFO] <efess> i love pushing chickens in lava
2011-02-02 20:07:56 [INFO] <nawf> when I was idling before I threw the eggs around
2011-02-02 20:08:01 [INFO] <nawf> had about 100 chickens in the base
2011-02-02 20:08:03 [INFO] <nawf> talk about lag
2011-02-02 20:08:04 [INFO] <efess> lol I saw
2011-02-02 20:08:14 [INFO] <nawf> they all got stuck in corners though
2011-02-02 20:08:51 [INFO] <redux06790> where the hell did i get this sand block from?
2011-02-02 20:09:03 [INFO] <efess> sand inception
2011-02-02 20:09:08 [INFO] <nawf> I probably threw it at you
2011-02-02 20:09:12 [INFO] <redux06790> lol
2011-02-02 20:09:14 [INFO] <nawf> thats my mo, ive people useless shit
2011-02-02 20:09:18 [INFO] <efess> lol
2011-02-02 20:09:25 [INFO] <nawf> feather bombs ftw
2011-02-02 20:09:27 [INFO] <redux06790> i was gonna say
2011-02-02 20:09:32 [INFO] <redux06790> i havent been topside in wtf
2011-02-02 20:10:02 [INFO] <redux06790> hey uhh im going to block this off so the base isnt exposed
2011-02-02 20:10:10 [INFO] <efess> well
2011-02-02 20:10:13 [INFO] <efess> i'm goin to make it higher
2011-02-02 20:10:16 [INFO] <nawf> whats this?
2011-02-02 20:10:26 [INFO] <efess> the tracks need to be raised
2011-02-02 20:10:34 [INFO] <efess> in order to put assistance carts under
2011-02-02 20:10:38 [INFO] <efess> since we're at bedrock
2011-02-02 20:11:03 [INFO] <efess> can do that for now I guess :P
2011-02-02 20:11:13 [INFO] <redux06790> im just worried about creepers
2011-02-02 20:11:26 [INFO] <efess> ssssss
2011-02-02 20:11:35 [INFO] <redux06790> ok guys there is going to be a temorary lack of access to the death chute entrance
2011-02-02 20:11:44 [INFO] <redux06790> im going to fix the stairs that go up it
2011-02-02 20:11:53 [INFO] <nawf> just don't wall it off
2011-02-02 20:12:03 [INFO] <redux06790> what do you mean?
2011-02-02 20:12:04 [INFO] <nawf> gotta be able to see it
2011-02-02 20:12:06 [INFO] <redux06790> oh i get it
2011-02-02 20:12:07 [INFO] <redux06790> yea no
2011-02-02 20:12:11 [INFO] <redux06790> i have plans
2011-02-02 20:12:12 [INFO] <nawf> because it is glorious
2011-02-02 20:12:13 [INFO] <redux06790> youll see
2011-02-02 20:12:31 [INFO] <nawf> you should have seen us all staring at it like hurp derps when we build it
2011-02-02 20:12:35 [INFO] <nawf> it was awesome
2011-02-02 20:12:44 [INFO] <efess> lol when it was complete
2011-02-02 20:12:47 [INFO] <efess> just looking up it
2011-02-02 20:12:48 [INFO] <redux06790> woooooow
2011-02-02 20:12:52 [INFO] <efess> rolling on the floor
2011-02-02 20:12:52 [INFO] <redux06790> you herped AND derped?
2011-02-02 20:12:53 [INFO] <efess> sobbing
2011-02-02 20:13:01 [INFO] <nawf> and burped
2011-02-02 20:13:16 [INFO] <redux06790> soo many eggs we have
2011-02-02 20:14:14 [INFO] <redux06790> how the fuck do ducks keep getting in here!?
2011-02-02 20:15:16 [INFO] <redux06790> shit
2011-02-02 20:15:19 [INFO] <redux06790> i need lava lol
2011-02-02 20:15:22 [INFO] <redux06790> you killed it all
2011-02-02 20:15:23 [INFO] <efess> there's some in that chest
2011-02-02 20:15:28 [INFO] <efess> and there's PLENTY
2011-02-02 20:15:29 [INFO] <efess> out there
2011-02-02 20:15:29 [INFO] <efess> lol
2011-02-02 20:15:31 [INFO] <nawf> there is some by my tower too
2011-02-02 20:15:38 [INFO] <nawf> 3 buckets I think
2011-02-02 20:15:43 [INFO] <redux06790> which chest?
2011-02-02 20:16:12 [INFO] <redux06790> ahh
2011-02-02 20:17:19 [INFO] <redux06790> oh right
2011-02-02 20:17:27 [INFO] <redux06790> before i can work on the stairs i need to farm
2011-02-02 20:17:31 [INFO] <redux06790> durr
2011-02-02 20:24:35 [INFO] <nawf> ih, did I fuck up the lava
2011-02-02 20:24:37 [INFO] <nawf> uh
2011-02-02 20:28:46 [INFO] <redux06790> emergency!
2011-02-02 20:28:57 [INFO] <redux06790> the loot chute is not pooping stuff out
2011-02-02 20:28:58 [INFO] <redux06790> wtf
2011-02-02 20:29:12 [INFO] <efess> constipation?
2011-02-02 20:29:17 [INFO] <nawf> I think I fucked it up
2011-02-02 20:29:26 [INFO] <efess> LOL
2011-02-02 20:29:28 [INFO] <efess> what'd you do john
2011-02-02 20:29:29 [INFO] <efess> lol
2011-02-02 20:29:37 [INFO] <efess> there's no sign
2011-02-02 20:29:38 [INFO] <redux06790> lol
2011-02-02 20:29:38 [INFO] <efess> here
2011-02-02 20:29:41 [INFO] <redux06790> HAHAHA
2011-02-02 20:29:48 [INFO] <nawf> fuck
2011-02-02 20:29:52 [INFO] <efess> lol
2011-02-02 20:30:35 [INFO] <redux06790> LOL
2011-02-02 20:30:40 [INFO] <redux06790> thers a chicken in the well
2011-02-02 20:30:54 [INFO] <efess> haha
2011-02-02 20:31:27 [INFO] <efess> LOL
2011-02-02 20:31:32 [INFO] <efess> check this out
2011-02-02 20:31:50 [INFO] <redux06790> oh my god
2011-02-02 20:31:57 [INFO] <nawf> pool party
2011-02-02 20:32:01 [INFO] <redux06790> omgwtfbbq
2011-02-02 20:32:07 [INFO] <efess> hhahaha
2011-02-02 20:32:11 [INFO] <efess> aids in the pool
2011-02-02 20:32:35 [INFO] <nawf> wtf
2011-02-02 20:32:41 [INFO] <efess> that hurt
2011-02-02 20:32:42 [INFO] <efess> lol
2011-02-02 20:32:54 [INFO] <redux06790> im a mur diddily urderer
2011-02-02 20:32:59 [INFO] <efess> LOL
2011-02-02 20:33:02 [INFO] <efess> is the sign there?
2011-02-02 20:33:31 [INFO] <redux06790> what the hell kind of shenanagins did you guys get up to?
2011-02-02 20:33:40 [INFO] <nawf> I'll block it off up top
2011-02-02 20:33:44 [INFO] <efess> I think the sign is back there
2011-02-02 20:33:48 [INFO] <efess> if it is let the lava loose
2011-02-02 20:33:49 [INFO] <nawf> I set off tnt too close
2011-02-02 20:33:57 [INFO] <redux06790> ok im going up top to start working on the erm... stairs.
2011-02-02 20:34:23 [INFO] <nawf> just leave it blocked so joe can get his stuff
2011-02-02 20:34:35 [INFO] <redux06790> tell me when i can start
2011-02-02 20:34:39 [INFO] <redux06790> maybe ill make a ladder
2011-02-02 20:34:48 [INFO] <redux06790> for temp access
2011-02-02 20:35:03 [INFO] <redux06790> what the shit
2011-02-02 20:35:41 [INFO] <redux06790> dude this is redonk they are getting out of the chute
2011-02-02 20:35:59 [INFO] <nawf> containment breach!
2011-02-02 20:36:04 [INFO] <efess> lol
2011-02-02 20:36:07 [INFO] <efess> dude I almost survived
2011-02-02 20:36:22 [INFO] <redux06790> im holing up in my house lol
2011-02-02 20:36:26 [INFO] <efess> lol
2011-02-02 20:36:42 [INFO] <nawf> holy shit, look at all the loot coming down
2011-02-02 20:36:55 [INFO] <efess> wtf?
2011-02-02 20:37:09 [INFO] <efess> there's so much
2011-02-02 20:37:17 [INFO] <efess> hahaha
2011-02-02 20:37:20 [INFO] <efess> a pig made it down
2011-02-02 20:37:50 [INFO] <nawf> I have your iron joe
2011-02-02 20:37:59 [INFO] <redux06790> is it fixed yet?
2011-02-02 20:38:01 [INFO] <efess> ya
2011-02-02 20:38:04 [INFO] <redux06790> ok
2011-02-02 20:38:05 [INFO] <nawf> yeah
2011-02-02 20:38:12 [INFO] <redux06790> can i start the stairs?
2011-02-02 20:38:29 [INFO] <nawf> hit it like you mean it
2011-02-02 20:38:44 [INFO] nawf lost connection: disconnect.quitting
2011-02-02 20:38:47 [INFO] nawf [/76.23.232.27:55056] logged in with entity id 5072004
2011-02-02 20:41:10 [INFO] <nawf> I made some leather shit for everybody
2011-02-02 20:41:50 [INFO] <nawf> erin where did you put all the string?
2011-02-02 20:41:59 [INFO] <redux06790> i turned it into wool
2011-02-02 20:42:03 [INFO] <nawf> oh ok
2011-02-02 20:42:12 [INFO] <nawf> I'm just dumping my load off over here
2011-02-02 20:44:36 [INFO] <nawf> fire in ze hole
2011-02-02 20:44:55 [INFO] <redux06790> ok ive made a ladder access point
2011-02-02 20:45:04 [INFO] <redux06790> so the surface is still accessable
2011-02-02 20:47:12 [INFO] <nawf> can I blow up the wall over there?
2011-02-02 20:47:13 [INFO] <efess> track will be there
2011-02-02 20:47:18 [INFO] <efess> that one
2011-02-02 20:47:19 [INFO] <efess> ?
2011-02-02 20:47:22 [INFO] <efess> ah
2011-02-02 20:47:25 [INFO] <nawf> oh fuck
2011-02-02 20:47:27 [INFO] <efess> i'm going to make it glass
2011-02-02 20:47:32 [INFO] <nawf> ok
2011-02-02 20:47:37 [INFO] <efess> what did you have planned?
2011-02-02 20:47:43 [INFO] <nawf> more river
2011-02-02 20:47:46 [INFO] <efess> MOAR!
2011-02-02 20:47:58 [INFO] <efess> there's a lot of lava here
2011-02-02 20:48:12 [INFO] <nawf> over here is where it will start, stops at kevins base
2011-02-02 20:48:24 [INFO] <nawf> I'll just go around the laval pool
2011-02-02 20:48:38 [INFO] <efess> heh
2011-02-02 20:48:43 [INFO] <efess> this goes and geos
2011-02-02 21:00:49 [INFO] <redux06790> john youll be happy
2011-02-02 21:00:56 [INFO] <redux06790> im opening up more space
2011-02-02 21:01:28 [INFO] <nawf> cool
2011-02-02 21:01:32 [INFO] <nawf> I blewed a piggie up
2011-02-02 21:01:39 [INFO] <redux06790> lol
2011-02-02 21:02:05 [INFO] <redux06790> so what was blowing a pig like?
2011-02-02 21:03:00 [INFO] <nawf> tastes like bacon
2011-02-02 21:03:07 [INFO] <redux06790> awwwwww
2011-02-02 21:03:11 [INFO] <redux06790> thats awful
2011-02-02 21:03:36 [INFO] <redux06790> you mean ive been PAYING for bacon when you can get the taste for free?
2011-02-02 21:06:59 [INFO] <redux06790> sorry down there
2011-02-02 21:07:01 [INFO] <redux06790> lol
2011-02-02 21:07:06 [INFO] <efess> water!
2011-02-02 21:07:06 [INFO] <redux06790> incoming waterfall
2011-02-02 21:08:02 [INFO] <nawf> yes, blasting for diamonds
2011-02-02 21:10:36 [INFO] <redux06790> lag?
2011-02-02 21:10:40 [INFO] <redux06790> yup lag
2011-02-02 21:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-02 21:18:22 [INFO] <redux06790> balls
2011-02-02 21:18:51 [INFO] <redux06790> do chickens spawn on water?
2011-02-02 21:18:56 [INFO] <redux06790> because there are 3 in the well
2011-02-02 21:19:10 [INFO] <efess> they can get through anything
2011-02-02 21:19:21 [INFO] <nawf> chickens are an asshole
2011-02-02 21:19:54 [INFO] <redux06790> im going to have to sexy up this wall later
2011-02-02 21:20:02 [INFO] <redux06790> now that the tracks arent there
2011-02-02 21:20:08 [INFO] <efess> yea you should give your aestetic touch to it when I'm done
2011-02-02 21:20:27 [INFO] <redux06790> im working on the loot chute atm so youll have plenty of time
2011-02-02 21:23:39 [INFO] <efess> oh no
2011-02-02 21:23:57 [INFO] <nawf> I r drowned
2011-02-02 21:24:02 [INFO] <efess> :o
2011-02-02 21:26:50 [INFO] <redux06790> gonna need lots of glass
2011-02-02 21:26:53 [INFO] <redux06790> to fix up the chute
2011-02-02 21:27:12 [INFO] <nawf> I smelted 240ish I think
2011-02-02 21:31:16 [INFO] <redux06790> oh hai
2011-02-02 21:31:30 [INFO] <redux06790> i c u down dere
2011-02-02 21:36:47 [INFO] <nawf> thats pretty awesome
2011-02-02 21:36:54 [INFO] <redux06790> ?
2011-02-02 21:36:58 [INFO] <redux06790> oh
2011-02-02 21:37:02 [INFO] <nawf> the space around the chute
2011-02-02 21:37:02 [INFO] <redux06790> its almost done
2011-02-02 21:37:09 [INFO] <nawf> are you going all the way up
2011-02-02 21:37:11 [INFO] <nawf> ?
2011-02-02 21:37:13 [INFO] <redux06790> nah
2011-02-02 21:37:22 [INFO] <redux06790> i like feeling like were in an underground world
2011-02-02 21:37:28 [INFO] <redux06790> plus i dont wanna deal with the ocean
2011-02-02 21:37:29 [INFO] <nawf> true
2011-02-02 21:40:46 [INFO] <nawf> I think we are going to have to use some of this smoothstone, maybe I'll build walls
2011-02-02 21:40:53 [INFO] <nawf> around that castle dungeon, just to use it up
2011-02-02 21:41:09 [INFO] <redux06790> lets build a badass tower
2011-02-02 21:41:14 [INFO] <efess> yea we need to start building that
2011-02-02 21:41:16 [INFO] <redux06790> on the surface
2011-02-02 21:41:22 [INFO] <nawf> did you see the basement?
2011-02-02 21:41:27 [INFO] <efess> not in a while
2011-02-02 21:41:29 [INFO] <redux06790> of what?
2011-02-02 21:41:33 [INFO] <redux06790> oh
2011-02-02 21:41:42 [INFO] <redux06790> thats the big blown out spot near spawn right?
2011-02-02 21:41:54 [INFO] <nawf> yeah
2011-02-02 21:41:57 [INFO] <nawf> its almost done
2011-02-02 21:42:05 [INFO] <nawf> I'm going to go work on it, we are reaching capacity
2011-02-02 21:42:18 [INFO] <redux06790> tnt capacity?
2011-02-02 21:42:27 [INFO] <nawf> naw, cobble and smooth
2011-02-02 21:42:31 [INFO] <redux06790> ahh
2011-02-02 21:42:53 [INFO] <redux06790> trust i have a project thats going to require about 18 stacks of smooth
2011-02-02 21:42:58 [INFO] <nawf> pssh
2011-02-02 21:43:04 [INFO] <redux06790> and maybe 5 stacks of obby
2011-02-02 21:43:11 [INFO] <efess> lol gl with that
2011-02-02 21:43:24 [INFO] <nawf> there is actually tons I need mined
2011-02-02 21:43:32 [INFO] <nawf> just go get out of the way
2011-02-02 21:45:09 [INFO] <redux06790> ok time to make stairs
2011-02-02 21:45:14 [INFO] <redux06790> hopefully this works out
2011-02-02 21:45:16 [INFO] <redux06790> haha
2011-02-02 21:45:42 [INFO] <redux06790> ive opened up about 10 stacks of cobble space
2011-02-02 21:45:47 [INFO] <redux06790> err
2011-02-02 21:45:51 [INFO] <redux06790> 640 blocks
2011-02-02 21:45:54 [INFO] <redux06790> probably more
2011-02-02 21:46:39 [INFO] <redux06790> fuck where did our iron go!?
2011-02-02 21:46:59 [INFO] <redux06790> nevermind
2011-02-02 21:47:00 [INFO] <efess> trakcs and minecarts
2011-02-02 21:47:10 [INFO] <redux06790> yeah i see that now that i opened the misc chest
2011-02-02 21:48:24 [INFO] <redux06790> the wheat farm is beautiful
2011-02-02 21:48:47 [INFO] <nawf> with bonemeal farms are a PITA
2011-02-02 21:49:00 [INFO] <redux06790> notch needs to make redstone do more shit
2011-02-02 21:50:59 [INFO] <redux06790> must hurry need to go to work soon
2011-02-02 22:00:21 [INFO] <efess> k gotta go
2011-02-02 22:00:24 [INFO] <efess> night guys
2011-02-02 22:00:27 [INFO] <redux06790> night
2011-02-02 22:00:33 [INFO] efess lost connection: disconnect.quitting
2011-02-02 22:17:11 [INFO] <redux06790> um anyone here?
2011-02-02 22:17:20 [INFO] <nawf> I'm hiding
2011-02-02 22:17:28 [INFO] <redux06790> ahh what are you up to then?
2011-02-02 22:17:40 [INFO] <nawf> filling in castle basement
2011-02-02 22:17:58 [INFO] <redux06790> ahh
2011-02-02 22:18:06 [INFO] <redux06790> im almost done with the chute stairs
2011-02-02 22:22:47 [INFO] <redux06790> fucking fall damage
2011-02-02 22:24:52 [INFO] <redux06790> i hate when you REALLLY explode when you die
2011-02-02 22:29:32 [INFO] <redux06790> come look dude
2011-02-02 22:29:57 [INFO] <nawf> I wil eventually
2011-02-02 22:35:32 [INFO] <redux06790> dude
2011-02-02 22:35:35 [INFO] <redux06790> it looks awesome
2011-02-02 22:35:37 [INFO] <redux06790> i gtg tho
2011-02-02 22:35:40 [INFO] <redux06790> work is calling
2011-02-02 22:35:46 [INFO] <nawf> aight, see you later
2011-02-02 22:35:58 [INFO] <redux06790> theres a big spiral staircase around it now
2011-02-02 22:36:46 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-02 23:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 00:30:26 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 06:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 07:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 08:18:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 12:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 12:34:24 [INFO] nawf [/76.23.232.27:55097] logged in with entity id 5352691
2011-02-03 13:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 14:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-03 17:04:23 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 17:40:46 [INFO] nawf [/76.23.232.27:55087] logged in with entity id 5409008
2011-02-03 17:56:49 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 18:22:43 [INFO] nawf [/76.23.232.27:55031] logged in with entity id 5429767
2011-02-03 18:27:14 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 19:04:19 [INFO] redux06790 [/69.119.8.191:49458] logged in with entity id 5437797
2011-02-03 19:04:26 [INFO] <redux06790> oh herro
2011-02-03 19:35:56 [INFO] nawf [/76.23.232.27:55011] logged in with entity id 5450211
2011-02-03 19:35:59 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 20:04:06 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-03 20:24:07 [INFO] nawf [/76.23.232.27:55097] logged in with entity id 5461225
2011-02-03 20:31:24 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 21:02:38 [INFO] redux06790 [/69.119.8.191:49720] logged in with entity id 5486733
2011-02-03 21:03:14 [INFO] <redux06790> MARCO!
2011-02-03 21:09:34 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-03 21:09:42 [INFO] redux06790 [/69.119.8.191:49890] logged in with entity id 5492263
2011-02-03 21:10:51 [INFO] <redux06790> wtflag
2011-02-03 21:20:14 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-03 23:33:00 [INFO] nawf [/76.23.232.27:55118] logged in with entity id 5507045
2011-02-03 23:33:29 [INFO] nawf lost connection: disconnect.quitting
2011-02-03 23:58:54 [INFO] AngryRhetoric [/24.147.183.4:49609] logged in with entity id 5508593
2011-02-03 23:59:28 [INFO] <AngryRhetoric> yo
2011-02-04 00:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 00:49:36 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-04 01:11:12 [INFO] redux06790 [/24.151.90.200:49482] logged in with entity id 5561019
2011-02-04 01:11:26 [INFO] <redux06790> anyone on?
2011-02-04 01:12:53 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-04 06:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 07:44:15 [INFO] redux06790 [/69.119.8.191:49611] logged in with entity id 5564556
2011-02-04 08:20:48 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-04 08:36:50 [INFO] nawf [/76.23.232.27:55020] logged in with entity id 5604459
2011-02-04 08:36:57 [INFO] nawf lost connection: disconnect.quitting
2011-02-04 10:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 11:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 12:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 13:11:39 [WARNING] Time ran backwards! Did the system time change?
2011-02-04 13:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 14:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 16:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 17:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 17:31:49 [INFO] efess [/192.168.0.198:64440] logged in with entity id 5605095
2011-02-04 17:38:20 [INFO] efess lost connection: disconnect.quitting
2011-02-04 18:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 18:59:44 [INFO] redux06790 [/69.119.8.191:50305] logged in with entity id 5609008
2011-02-04 18:59:51 [INFO] <redux06790> I dont always herp
2011-02-04 18:59:56 [INFO] <redux06790> but when i do, i also derp
2011-02-04 19:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 20:32:23 [INFO] AngryRhetoric [/24.147.183.4:51038] logged in with entity id 5691903
2011-02-04 20:32:28 [INFO] <redux06790> herp derp
2011-02-04 20:32:42 [INFO] <AngryRhetoric> urp
2011-02-04 20:32:51 [INFO] <redux06790> you should see the badass skull tower
2011-02-04 20:32:56 [INFO] <redux06790> that i made
2011-02-04 20:33:04 [INFO] <AngryRhetoric> nice where is it?
2011-02-04 20:33:17 [INFO] <redux06790> across from castle mcdonell
2011-02-04 20:33:27 [INFO] <AngryRhetoric> haha ok
2011-02-04 20:33:28 [INFO] <redux06790> you literally cant miss it
2011-02-04 20:35:02 [INFO] <AngryRhetoric> cool im grabbin some inventory then i'll come check it ou
2011-02-04 20:35:04 [INFO] <AngryRhetoric> t
2011-02-04 20:41:10 [INFO] <AngryRhetoric> haha dude that's awesome!
2011-02-04 20:41:17 [INFO] <redux06790> thanks
2011-02-04 20:41:38 [INFO] <AngryRhetoric> how long you been workin on that LOL he's got a gold toof
2011-02-04 20:41:53 [INFO] <redux06790> um it only took about 30 min
2011-02-04 20:42:06 [INFO] <redux06790> maybe an hour
2011-02-04 20:42:21 [INFO] <AngryRhetoric> not bad
2011-02-04 20:42:34 [INFO] <redux06790> im going to turn it into a workshop
2011-02-04 20:42:42 [INFO] <AngryRhetoric> john showed me the giant stone pit that's to be the new castle basement
2011-02-04 20:42:50 [INFO] <AngryRhetoric> that thing is Way too big
2011-02-04 20:42:53 [INFO] <redux06790> yeah i have to go look at that
2011-02-04 20:44:33 [INFO] <redux06790> dude
2011-02-04 20:44:55 [INFO] <AngryRhetoric> yeah
2011-02-04 20:44:59 [INFO] <redux06790> fuckbeans
2011-02-04 20:45:03 [INFO] <AngryRhetoric> hah
2011-02-04 20:45:14 [INFO] <redux06790> im speechless
2011-02-04 20:45:51 [INFO] <AngryRhetoric> hahah you checkin out mcdonnell hamlet or something?
2011-02-04 20:46:12 [INFO] <AngryRhetoric> i'm wondering about these floating islands behind your tower
2011-02-04 20:46:17 [INFO] <redux06790> i cant see you
2011-02-04 20:46:18 [INFO] <redux06790> sec
2011-02-04 20:46:20 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-04 20:46:28 [INFO] redux06790 [/69.119.8.191:50345] logged in with entity id 5708218
2011-02-04 20:47:25 [INFO] <redux06790> dude thats going to be a fucking bonkers ass castle
2011-02-04 20:47:40 [INFO] <AngryRhetoric> oh the pit! haha yeah, i was wondering how the hell he and joe did that
2011-02-04 20:47:56 [INFO] <AngryRhetoric> i was trying to envision a castle that large and am having a hard time with it hahaha
2011-02-04 20:47:59 [INFO] <redux06790> lots... and lots... of tnt
2011-02-04 20:48:06 [INFO] <redux06790> well i mean
2011-02-04 20:48:09 [INFO] <redux06790> i could do it
2011-02-04 20:48:12 [INFO] <AngryRhetoric> yeah but then he encased it in smooth stone
2011-02-04 20:48:14 [INFO] <redux06790> just alot of really big open rooms
2011-02-04 20:48:18 [INFO] <redux06790> with gardens
2011-02-04 20:48:21 [INFO] <redux06790> thick walls
2011-02-04 20:48:24 [INFO] <redux06790> etc
2011-02-04 20:48:26 [INFO] <redux06790> secret rooms
2011-02-04 20:48:41 [INFO] <AngryRhetoric> well i was thinking even with the blocks, you could express curvature in the walls at those dimensio
2011-02-04 20:48:46 [INFO] <AngryRhetoric> *dimensions
2011-02-04 20:48:58 [INFO] <redux06790> yea
2011-02-04 20:49:05 [INFO] <redux06790> im awesome at making circles
2011-02-04 20:49:16 [INFO] <AngryRhetoric> haha the floating islands are right near the pit i just realized
2011-02-04 20:53:26 [INFO] <redux06790> lol
2011-02-04 20:53:30 [INFO] <redux06790> hehe
2011-02-04 20:59:09 [INFO] <redux06790> ok gtg
2011-02-04 20:59:18 [INFO] <AngryRhetoric> alright
2011-02-04 20:59:20 [INFO] <AngryRhetoric> peace
2011-02-04 20:59:25 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-04 21:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-04 21:34:48 [INFO] <AngryRhetoric> its gotta be the keyboard, oh wait no its working fine here
2011-02-04 21:34:57 [INFO] <AngryRhetoric> laaaag
2011-02-04 21:37:58 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-04 22:20:46 [INFO] /76.23.232.27:55094 lost connection
2011-02-04 22:20:59 [INFO] nawf [/76.23.232.27:55003] logged in with entity id 5799245
2011-02-04 23:38:35 [INFO] nawf lost connection: disconnect.quitting
2011-02-05 00:07:01 [INFO] nawf [/76.23.232.27:55026] logged in with entity id 5893288
2011-02-05 00:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 01:10:53 [INFO] nawf lost connection: disconnect.genericReason
2011-02-05 07:18:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 08:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 09:48:09 [INFO] efess [/192.168.0.198:1359] logged in with entity id 5956103
2011-02-05 09:50:02 [INFO] nawf [/76.23.232.27:55146] logged in with entity id 5957696
2011-02-05 09:51:43 [INFO] <efess> yo
2011-02-05 09:51:51 [INFO] <nawf> yo
2011-02-05 09:52:21 [INFO] <efess> so we'll be there a little early tomorrow
2011-02-05 09:52:38 [INFO] <nawf> unacceptable
2011-02-05 09:52:50 [INFO] <efess> heh
2011-02-05 09:53:22 [INFO] <efess> fucking intergis man
2011-02-05 09:53:29 [INFO] <nawf> yeah
2011-02-05 09:53:50 [INFO] <efess> crazy how a company can just come by and axe it
2011-02-05 09:54:01 [INFO] <nawf> yeah, force everybody to sign fucked up contracts and move
2011-02-05 09:54:11 [INFO] <efess> yup
2011-02-05 09:54:17 [INFO] <nawf> I know most of the details
2011-02-05 09:54:23 [INFO] <nawf> dave ok?
2011-02-05 09:54:26 [INFO] <efess> yea he's doing fine
2011-02-05 09:54:30 [INFO] <nawf> cool
2011-02-05 09:54:37 [INFO] <efess> he sent an email already
2011-02-05 09:54:41 [INFO] <efess> saying he won't move
2011-02-05 09:54:49 [INFO] <efess> so its in their court
2011-02-05 09:55:11 [INFO] <nawf> he should go work for expedex or something
2011-02-05 09:55:22 [INFO] <efess> haha right next to the leach
2011-02-05 09:55:29 [INFO] <nawf> they can share a cube
2011-02-05 09:55:46 [INFO] <efess> yea he already talked to foley
2011-02-05 09:55:51 [INFO] <nawf> cool
2011-02-05 09:56:03 [INFO] <nawf> I think its wild they fired josh
2011-02-05 09:56:21 [INFO] <nawf> I have my critisisms of Josh but at least he knew VCR
2011-02-05 09:56:23 [INFO] <efess> I know, in a way i'm not suprised
2011-02-05 09:56:55 [INFO] <efess> he didn't develop the best reputation with the higher ups
2011-02-05 09:57:06 [INFO] <nawf> yeah, guess he should have showed up on time
2011-02-05 09:57:48 [INFO] <efess> I think everyon'es turning down the contract just because
2011-02-05 09:57:51 [INFO] <efess> of the texas clause
2011-02-05 09:58:01 [INFO] <nawf> yeah
2011-02-05 09:58:03 [INFO] <efess> so they'll have no choice but to remove it
2011-02-05 09:58:08 [INFO] <efess> or the lose all the customers
2011-02-05 09:58:15 [INFO] <nawf> I told trevor the past and future inventions part is kinda messed up
2011-02-05 09:58:28 [INFO] <efess> what's it say?
2011-02-05 09:58:35 [INFO] <nawf> well I don't know the vergbage but it seems like a super broad non-compete
2011-02-05 09:58:48 [INFO] <nawf> that the new company owns all inventions you made in the previous year and in the next
2011-02-05 09:58:55 [INFO] <efess> o wow
2011-02-05 09:59:08 [INFO] <nawf> I don't know the exact verbage but thats really broad
2011-02-05 09:59:18 [INFO] <nawf> over the top of a regular non-compete
2011-02-05 09:59:19 [INFO] <efess> yea no kidding, not even limiting just to shit at work
2011-02-05 09:59:32 [INFO] <nawf> usually a non-compete is just don't use the shit you did here elsewhere
2011-02-05 09:59:35 [INFO] <nawf> not all inventions
2011-02-05 09:59:38 [INFO] <efess> yea
2011-02-05 10:00:02 [INFO] <efess> I wonder what ray/adam will do
2011-02-05 10:00:08 [INFO] <efess> dave said ray told him his interview didn't go well
2011-02-05 10:00:23 [INFO] <nawf> uh oh
2011-02-05 10:00:32 [INFO] <nawf> well I know nothing he doesn't
2011-02-05 10:01:07 [INFO] <efess> ah
2011-02-05 10:01:12 [INFO] <nawf> that makes me feel awesome though, I nailed that tech interview ;)
2011-02-05 10:01:16 [INFO] <efess> haha
2011-02-05 10:01:54 [INFO] <efess> yea those fences below the half block glitch when
2011-02-05 10:01:55 [INFO] <efess> you walk
2011-02-05 10:01:57 [INFO] <efess> on them
2011-02-05 10:02:03 [INFO] <nawf> yeah, I took them down
2011-02-05 10:02:03 [INFO] <efess> wtf notch fix it
2011-02-05 10:02:16 [INFO] <nawf> did you or erin build those?
2011-02-05 10:02:18 [INFO] <nawf> or kevin
2011-02-05 10:02:20 [INFO] <efess> erin
2011-02-05 10:02:53 [INFO] <nawf> the only thing I don't like him doing is taking up space for the sake of taking up space
2011-02-05 10:03:03 [INFO] <nawf> but whatever
2011-02-05 10:03:14 [INFO] <efess> well just change it
2011-02-05 10:03:21 [INFO] <nawf> oh I did
2011-02-05 10:03:30 [INFO] <nawf> I like space
2011-02-05 10:03:35 [INFO] <nawf> space is the rare thing to me in this game
2011-02-05 10:06:17 [INFO] <efess> I just asked ed if my invoices will be paid :\
2011-02-05 10:06:36 [INFO] <nawf> lol, me too, I didn't get the cherry check yet
2011-02-05 10:06:40 [INFO] <efess> o man
2011-02-05 10:06:45 [INFO] <efess> dave said you got paid
2011-02-05 10:07:11 [INFO] <nawf> ed said they did write the check, but I never got one
2011-02-05 10:10:02 [INFO] <efess> ya i'm chatting with him now
2011-02-05 10:10:45 [INFO] <nawf> ask him if they ended it abrubly or becker told him they are passing?
2011-02-05 10:11:09 [INFO] <efess> tell him on skype
2011-02-05 10:11:17 [INFO] <nawf> I don't want to leave minecraft
2011-02-05 10:11:21 [INFO] <efess> lol f11
2011-02-05 10:11:26 [INFO] <nawf> nooo
2011-02-05 10:19:23 [INFO] <nawf> oh DUDE, I have a shakeweight
2011-02-05 10:25:47 [INFO] <efess> wtf?
2011-02-05 10:26:07 [INFO] <efess> a shakeweight?
2011-02-05 10:26:10 [INFO] <nawf> yeah
2011-02-05 10:26:30 [INFO] <nawf> as like a coffee table bullshit thing
2011-02-05 10:26:35 [INFO] <efess> OH
2011-02-05 10:26:37 [INFO] <nawf> I think nobody will be able to keep their hands off it
2011-02-05 10:26:39 [INFO] <efess> haha yea jess showed me
2011-02-05 10:26:45 [INFO] <nawf> and I'll have tons of cum gargling pics
2011-02-05 10:27:39 [INFO] nawf lost connection: disconnect.genericReason
2011-02-05 10:27:48 [INFO] nawf [/76.23.232.27:55034] logged in with entity id 6011120
2011-02-05 10:29:29 [INFO] <nawf> the castle dungeon is complete
2011-02-05 10:29:33 [INFO] <nawf> 90x55
2011-02-05 10:29:40 [INFO] <efess> ahh
2011-02-05 10:29:50 [INFO] <efess> I haven't seen it
2011-02-05 10:29:57 [INFO] <nawf> I just finished it
2011-02-05 10:30:41 [INFO] <efess> jess said unacceptable = no platters
2011-02-05 10:30:47 [INFO] <nawf> lol
2011-02-05 10:31:01 [INFO] <nawf> I'll just hold the dip in my hands then
2011-02-05 10:31:05 [INFO] <efess> hahahhah
2011-02-05 10:31:21 [INFO] <efess> who made the skull tower
2011-02-05 10:31:26 [INFO] <nawf> dunno
2011-02-05 10:31:31 [INFO] <efess> prolly eric
2011-02-05 10:31:32 [INFO] <efess> erin
2011-02-05 10:31:46 [INFO] <nawf> I should invite him to the superbowl
2011-02-05 10:31:51 [INFO] <efess> ya
2011-02-05 10:32:07 [INFO] <efess> o remember matt from that time at city steam?
2011-02-05 10:32:21 [INFO] <nawf> i think so, asian qa?
2011-02-05 10:32:26 [INFO] <efess> nah that was thuan
2011-02-05 10:32:42 [INFO] <efess> he was looking for something to do saturday
2011-02-05 10:32:57 [INFO] <efess> nice
2011-02-05 10:33:00 [INFO] <efess> its so smooth
2011-02-05 10:33:02 [INFO] <nawf> saturday
2011-02-05 10:33:08 [INFO] <efess> er
2011-02-05 10:33:10 [INFO] <efess> superbowl
2011-02-05 10:33:19 [INFO] <efess> I told him i'd let him know if anything comesup
2011-02-05 10:33:33 [INFO] <nawf> yeah, hrm, I'm not sure of the final count yet
2011-02-05 10:33:40 [INFO] <efess> no worries
2011-02-05 10:33:41 [INFO] <nawf> I think I'm already exceeding fire codes
2011-02-05 10:33:45 [INFO] <efess> hahaha
2011-02-05 10:33:51 [INFO] <efess> lets all go out on the porch
2011-02-05 10:33:55 [INFO] <nawf> lol
2011-02-05 10:34:02 [INFO] <nawf> or in the office with the sinking floor
2011-02-05 10:34:08 [INFO] <efess> wha'ts the best way down?
2011-02-05 10:34:09 [INFO] <nawf> fucking kevin the other night was jumping up and down on it
2011-02-05 10:34:12 [INFO] <nawf> didn't fall
2011-02-05 10:34:45 [INFO] <efess> mmm space
2011-02-05 10:35:02 [INFO] <nawf> now wtf do we do with it?
2011-02-05 10:35:07 [INFO] <nawf> FILL IT WITH COBBLE
2011-02-05 10:35:22 [INFO] <efess> mr creeps likes it
2011-02-05 10:35:25 [INFO] <efess> NOO
2011-02-05 10:35:43 [INFO] <efess> ugh I think we should make plans?
2011-02-05 10:35:47 [INFO] <efess> lol
2011-02-05 10:35:57 [INFO] <efess> like graph paper
2011-02-05 10:36:05 [INFO] <nawf> heh, there is a mc planner app someplace
2011-02-05 10:36:17 [INFO] <efess> oh minedraft.net
2011-02-05 10:37:45 [INFO] <nawf> I left down here open
2011-02-05 10:38:01 [INFO] <efess> your river comes up down here right?
2011-02-05 10:38:08 [INFO] <nawf> sorta
2011-02-05 10:38:16 [INFO] <nawf> I still need to dig it out from the waterfall
2011-02-05 10:46:09 [INFO] <nawf> turrets on corners?
2011-02-05 10:46:21 [INFO] <efess> woo!
2011-02-05 10:46:35 [INFO] <efess> everything going to be smooth stone?
2011-02-05 10:46:42 [INFO] <nawf> I think we could do that
2011-02-05 10:47:20 [INFO] <efess> k when I finish the rail enclosure from the other base i'll come back
2011-02-05 10:53:18 [INFO] <efess> yo
2011-02-05 10:53:20 [INFO] <nawf> yo
2011-02-05 10:53:30 [INFO] <efess> so in two weeks some guys from work are going to sundown
2011-02-05 10:53:37 [INFO] <efess> i'm going to try skiis for the first time
2011-02-05 10:53:44 [INFO] <efess> you wanna try it?
2011-02-05 10:54:02 [INFO] <nawf> oh yeah, two weeks, yeah, depends if I'm in PA or not at that point, don't know the deal with that y
2011-02-05 10:54:10 [INFO] <nawf> et
2011-02-05 10:54:12 [INFO] <efess> k its going to be a friday night
2011-02-05 10:54:48 [INFO] <nawf> ok
2011-02-05 10:56:54 [INFO] <nawf> I'll probably be on and off throughout the day, doing party setup cleaning work
2011-02-05 10:57:02 [INFO] <nawf> I have a safe idle room
2011-02-05 10:57:07 [INFO] <efess> k
2011-02-05 10:57:15 [INFO] <nawf> I'll probably built turrets and walls and transfer goods from the vault base
2011-02-05 10:57:29 [INFO] <nawf> well the outet set of turrets
2011-02-05 10:57:31 [INFO] <nawf> :D
2011-02-05 10:57:33 [INFO] <efess> ya
2011-02-05 11:17:28 [INFO] <nawf> ok, I'm trying to clean out the null isattending records
2011-02-05 11:17:42 [INFO] <efess> haha
2011-02-05 11:17:44 [INFO] <nawf> so I'll let you know if matt has a spot, I think the cap is 20
2011-02-05 11:17:50 [INFO] <efess> k
2011-02-05 11:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 11:18:10 [INFO] <nawf> b and rach are coming?
2011-02-05 11:18:25 [INFO] <efess> I donno, did you facebook them?
2011-02-05 11:18:35 [INFO] <nawf> I didn't know they had facebook
2011-02-05 11:18:41 [INFO] <efess> she doesn't check
2011-02-05 11:18:45 [INFO] <efess> jess can check
2011-02-05 11:18:52 [INFO] <nawf> I invited B, I just didn't hear from him since
2011-02-05 11:19:07 [INFO] <efess> oh
2011-02-05 11:19:13 [INFO] <efess> you have to go through rachael
2011-02-05 11:19:15 [INFO] <efess> :P
2011-02-05 11:23:35 [INFO] <nawf> lol
2011-02-05 11:26:36 [INFO] <efess> I like your rails. I hope you don't *BOOM*
2011-02-05 11:26:41 [INFO] <nawf> lol
2011-02-05 11:42:31 [INFO] <nawf> I have maximized the beer storage units of my fridge
2011-02-05 12:00:33 [INFO] <efess> with your pick axe?
2011-02-05 12:12:24 [INFO] <nawf> with my fist
2011-02-05 12:13:27 [INFO] <nawf> heh, did you see erin linked up the dirt sky islands
2011-02-05 12:13:30 [INFO] <nawf> thats going to be cool
2011-02-05 12:18:35 [INFO] /69.119.8.191:49219 lost connection
2011-02-05 12:19:18 [INFO] redux06790 [/69.119.8.191:49226] lost connection
2011-02-05 12:19:39 [INFO] redux06790 [/69.119.8.191:49230] lost connection
2011-02-05 12:19:41 [INFO] /69.119.8.191:49248 lost connection
2011-02-05 12:37:11 [INFO] <efess> nah how so?
2011-02-05 12:37:29 [INFO] <nawf> how'd he link them up, or how is it going to be cool?
2011-02-05 12:37:44 [INFO] <efess> how'd he link em
2011-02-05 12:37:52 [INFO] <nawf> with just dirt paths, but I see the potential
2011-02-05 12:37:56 [INFO] <efess> nice
2011-02-05 12:49:05 [INFO] /69.119.8.191:49422 lost connection
2011-02-05 12:49:28 [INFO] /69.119.8.191:49428 lost connection
2011-02-05 12:49:32 [INFO] /69.119.8.191:49430 lost connection
2011-02-05 12:49:53 [INFO] /69.119.8.191:49434 lost connection
2011-02-05 13:15:56 [INFO] <efess> k I think its done
2011-02-05 13:16:07 [INFO] <efess> just need erin to come by and beutify it
2011-02-05 13:16:16 [INFO] <efess> beautify*
2011-02-05 13:18:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 13:43:54 [INFO] efess lost connection: disconnect.quitting
2011-02-05 13:49:30 [INFO] /24.147.183.4:50949 lost connection
2011-02-05 13:50:33 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:50989]: Took too long to log in
2011-02-05 13:52:48 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:51129]: Took too long to log in
2011-02-05 13:54:47 [INFO] /24.147.183.4:51226 lost connection
2011-02-05 13:54:49 [INFO] nawf lost connection: disconnect.quitting
2011-02-05 13:55:04 [INFO] /24.147.183.4:51238 lost connection
2011-02-05 13:56:32 [INFO] /24.147.183.4:51285 lost connection
2011-02-05 13:59:25 [INFO] /24.147.183.4:51397 lost connection
2011-02-05 14:00:35 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:51438]: Took too long to log in
2011-02-05 14:02:05 [INFO] AngryRhetoric [/24.147.183.4:51509] logged in with entity id 6270126
2011-02-05 14:02:52 [INFO] <AngryRhetoric> sup
2011-02-05 14:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 14:38:03 [INFO] /69.119.8.191:50508 lost connection
2011-02-05 14:38:43 [INFO] /69.119.8.191:50522 lost connection
2011-02-05 14:39:16 [INFO] /69.119.8.191:50527 lost connection
2011-02-05 14:41:09 [INFO] /69.119.8.191:50536 lost connection
2011-02-05 14:42:35 [INFO] /69.119.8.191:50541 lost connection
2011-02-05 16:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 16:37:31 [INFO] /192.168.0.198:10853 lost connection
2011-02-05 16:38:05 [INFO] Disconnecting /192.168.0.198:10893: Took too long to log in
2011-02-05 16:39:05 [INFO] efess [/192.168.0.198:10962] lost connection
2011-02-05 16:39:37 [INFO] Disconnecting efess [/192.168.0.198:11004]: Took too long to log in
2011-02-05 16:39:42 [INFO] /192.168.0.198:11045 lost connection
2011-02-05 16:40:17 [INFO] Disconnecting /192.168.0.198:11050: Took too long to log in
2011-02-05 16:41:17 [INFO] /192.168.0.198:11113 lost connection
2011-02-05 16:41:55 [INFO] /192.168.0.198:11143 lost connection
2011-02-05 16:44:12 [INFO] /192.168.0.198:11266 lost connection
2011-02-05 16:45:35 [INFO] /192.168.0.198:11329 lost connection
2011-02-05 16:46:03 [INFO] /192.168.0.198:11344 lost connection
2011-02-05 16:46:22 [INFO] efess [/192.168.0.198:11360] logged in with entity id 6402476
2011-02-05 16:46:29 [INFO] <efess> yo
2011-02-05 16:56:32 [INFO] efess lost connection: disconnect.quitting
2011-02-05 16:59:29 [INFO] nawf [/76.23.232.27:55159] logged in with entity id 6412940
2011-02-05 17:14:07 [INFO] efess [/192.168.0.198:12066] logged in with entity id 6435025
2011-02-05 17:14:10 [INFO] <efess> yo
2011-02-05 17:14:12 [INFO] <nawf> yo
2011-02-05 17:14:20 [INFO] <nawf> how do you know when I'm onlien?
2011-02-05 17:14:24 [INFO] <efess> no clue
2011-02-05 17:14:25 [INFO] <nawf> or do you just always say yo
2011-02-05 17:14:27 [INFO] <efess> yup
2011-02-05 17:14:39 [INFO] <efess> some times I just like to say it to myself
2011-02-05 17:17:23 [INFO] <nawf> I am going all out with the front of this castle
2011-02-05 17:17:33 [INFO] <efess> nice i'm about to come with smoothstone
2011-02-05 17:18:06 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 17:19:04 [INFO] <nawf> can you bring arrows too?
2011-02-05 17:19:07 [INFO] <efess> sure
2011-02-05 17:21:34 [INFO] <AngryRhetoric> sup guys
2011-02-05 17:21:42 [INFO] <efess> hey kev!
2011-02-05 17:21:46 [INFO] <nawf> are you hiding?
2011-02-05 17:21:50 [INFO] <AngryRhetoric> lol yes
2011-02-05 17:22:50 [INFO] <AngryRhetoric> i was checking out the castle earlier
2011-02-05 17:22:58 [INFO] <AngryRhetoric> seems very contemporary at the entrance haha
2011-02-05 17:23:58 [INFO] <nawf> I don't know how to take that
2011-02-05 17:24:01 [INFO] <AngryRhetoric> haha
2011-02-05 17:24:18 [INFO] <AngryRhetoric> it looks cool
2011-02-05 17:26:10 [INFO] <nawf> I see a creeper likes it
2011-02-05 17:27:25 [INFO] <efess> nice
2011-02-05 17:27:55 [INFO] <efess> its pretty serial
2011-02-05 17:28:16 [INFO] <nawf> cerial?
2011-02-05 17:28:22 [INFO] <efess> haha
2011-02-05 17:28:31 [INFO] <AngryRhetoric> cereal killah
2011-02-05 17:28:40 [INFO] <efess> nooo
2011-02-05 17:28:42 [INFO] <nawf> oh fuck
2011-02-05 17:28:48 [INFO] <nawf> I killed the block you tried to walk on
2011-02-05 17:28:50 [INFO] <efess> hahah
2011-02-05 17:30:18 [INFO] <efess> arrow roulette?
2011-02-05 17:30:23 [INFO] <AngryRhetoric> haha
2011-02-05 17:30:59 [INFO] <AngryRhetoric> i brought a ton of smooth stone
2011-02-05 17:31:07 [INFO] <efess> me too
2011-02-05 17:31:15 [INFO] <nawf> sweet, I have 18 left
2011-02-05 17:31:41 [INFO] <efess> here
2011-02-05 17:31:58 [INFO] <efess> I think we'll need a material staging area
2011-02-05 17:32:03 [INFO] <nawf> there is one
2011-02-05 17:32:07 [INFO] <AngryRhetoric> close to the castle heh
2011-02-05 17:32:17 [INFO] <efess> I didn't see it
2011-02-05 17:32:26 [INFO] <nawf> over by the side entrance to the base
2011-02-05 17:32:28 [INFO] <AngryRhetoric> i could start making a 1st floor?
2011-02-05 17:32:33 [INFO] <nawf> yeah
2011-02-05 17:32:37 [INFO] <efess> hell yea.
2011-02-05 17:32:45 [INFO] <nawf> and we need an inner tower too
2011-02-05 17:33:02 [INFO] <nawf> should go past the clouds, that will be monsteroud
2011-02-05 17:33:03 [INFO] <nawf> s
2011-02-05 17:33:25 [INFO] <AngryRhetoric> i'm thinking a lot of rooms around the sides
2011-02-05 17:33:29 [INFO] <AngryRhetoric> a great hall for the entrance
2011-02-05 17:33:35 [INFO] <nawf> that would be awesome
2011-02-05 17:33:36 [INFO] <AngryRhetoric> and a main tower in the middle haha
2011-02-05 17:33:39 [INFO] <efess> how are we on rwood?
2011-02-05 17:33:42 [INFO] <nawf> I just built these upper floors for now
2011-02-05 17:33:49 [INFO] <nawf> I think we are low, well I am
2011-02-05 17:33:54 [INFO] <nawf> thats why I planted those trees
2011-02-05 17:34:09 [INFO] <efess> yea I think a great hall toward the back.. and maybe grass in the center?
2011-02-05 17:34:12 [INFO] <nawf> I may plant the entire side of this mountain over here
2011-02-05 17:34:22 [INFO] <nawf> yeah, we need an epic indoor garden
2011-02-05 17:34:28 [INFO] <AngryRhetoric> i've got some tree seeds too
2011-02-05 17:34:30 [INFO] <AngryRhetoric> ooh yeah
2011-02-05 17:34:31 [INFO] <nawf> I saved all the mossy cobble too
2011-02-05 17:34:35 [INFO] <AngryRhetoric> and a waterfall or two
2011-02-05 17:34:41 [INFO] <nawf> maybe a dozen
2011-02-05 17:37:27 [INFO] <efess> need anything else from the othe rbase?
2011-02-05 17:37:45 [INFO] <nawf> everything
2011-02-05 17:37:52 [INFO] <efess> bring the basee... to mee
2011-02-05 17:38:23 [INFO] <nawf> heh, we should expand the staging area, make furnaces, more chests, I just took
2011-02-05 17:38:27 [INFO] <nawf> what we had here already
2011-02-05 17:38:38 [INFO] <nawf> we need slaves like the egyptions had
2011-02-05 17:38:46 [INFO] <efess> no shit
2011-02-05 17:39:28 [INFO] <AngryRhetoric> hahaha nothing like slave labor
2011-02-05 17:39:48 [INFO] <AngryRhetoric> soemone needs to make minecraft bots
2011-02-05 17:39:55 [INFO] <efess> someone already did
2011-02-05 17:39:55 [INFO] <nawf> heh, somebody did
2011-02-05 17:39:56 [INFO] <efess> lol
2011-02-05 17:40:05 [INFO] <AngryRhetoric> get the F$)% out
2011-02-05 17:40:07 [INFO] <efess> they just dig
2011-02-05 17:40:09 [INFO] <AngryRhetoric> hahahaha
2011-02-05 17:40:13 [INFO] <nawf> and get wood
2011-02-05 17:40:19 [INFO] <efess> from digging
2011-02-05 17:41:56 [INFO] <AngryRhetoric> the castle needs anti spider walls
2011-02-05 17:42:32 [INFO] <AngryRhetoric> crap
2011-02-05 17:44:07 [INFO] <AngryRhetoric> hah
2011-02-05 17:44:21 [INFO] <AngryRhetoric> moat?
2011-02-05 17:44:28 [INFO] <nawf> def
2011-02-05 17:45:24 [INFO] <nawf> I'll be coming in and out, gotta clean make fud and shit for tomorrow
2011-02-05 17:45:36 [INFO] <nawf> made myself an idle cave
2011-02-05 17:45:42 [INFO] <AngryRhetoric> haha ok
2011-02-05 17:45:57 [INFO] <nawf> kev, I got the shakeweight in time
2011-02-05 17:45:58 [INFO] <nawf> yes
2011-02-05 17:46:02 [INFO] <AngryRhetoric> hahahahhaa
2011-02-05 17:46:18 [INFO] <AngryRhetoric> super bowl party / shakeweight party??
2011-02-05 17:46:39 [INFO] <AngryRhetoric> i was holding shift dammit
2011-02-05 17:47:33 [INFO] <nawf> lol
2011-02-05 17:47:42 [INFO] <nawf> oh, we need an awesomez library too
2011-02-05 17:47:47 [INFO] <AngryRhetoric> yes
2011-02-05 17:48:04 [INFO] <AngryRhetoric> a laboratory? hmm
2011-02-05 17:53:06 [INFO] <nawf> yes... with a record player
2011-02-05 17:53:22 [INFO] <AngryRhetoric> oh yeah!
2011-02-05 17:53:25 [INFO] <nawf> I invited erin to come tomorrow but he can't make it
2011-02-05 17:54:00 [INFO] <nawf> joe, that means matt can come if he'd like
2011-02-05 17:54:04 [INFO] <efess> alright
2011-02-05 17:54:32 [INFO] <efess> he came to the christmas party
2011-02-05 17:55:42 [INFO] <AngryRhetoric> shoudl i put half stone down on the first floor?
2011-02-05 17:55:57 [INFO] <AngryRhetoric> that or a ton of torches
2011-02-05 17:56:08 [INFO] <efess> I think stone
2011-02-05 18:08:56 [INFO] <AngryRhetoric> haha dahHH
2011-02-05 18:09:14 [INFO] <AngryRhetoric> yyou want half stone? you can follow behind me haha
2011-02-05 18:09:23 [INFO] <nawf> well don't do both
2011-02-05 18:09:33 [INFO] <AngryRhetoric> hmMm
2011-02-05 18:10:08 [INFO] <nawf> well we could, I dunno, then we'll use doubel teh materials
2011-02-05 18:10:17 [INFO] <AngryRhetoric> yeah i guess half stone makes more sense
2011-02-05 18:10:20 [INFO] <efess> chests are full with goodies
2011-02-05 18:10:23 [INFO] <efess> I gtg
2011-02-05 18:10:25 [INFO] <efess> l8r guys
2011-02-05 18:10:29 [INFO] <AngryRhetoric> later joe
2011-02-05 18:10:31 [INFO] efess lost connection: disconnect.quitting
2011-02-05 18:11:13 [INFO] <nawf> ok I planted enough trees to cause an ice age
2011-02-05 18:15:20 [INFO] <AngryRhetoric> darnit!
2011-02-05 18:15:34 [INFO] <AngryRhetoric> and nice job on the trees, i'd say this area's in an ice age already
2011-02-05 18:15:55 [INFO] <nawf> I know, one day I'm going to get sick of the snow and melt it all
2011-02-05 18:16:09 [INFO] <AngryRhetoric> farmington needs to buy a snow dragon
2011-02-05 18:17:14 [INFO] <nawf> roads are icy out there
2011-02-05 18:17:25 [INFO] <AngryRhetoric> yeah its been freezing rain all day
2011-02-05 18:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 18:19:50 [INFO] <AngryRhetoric> thx
2011-02-05 18:20:10 [INFO] <nawf> np, that was funny
2011-02-05 18:20:15 [INFO] <nawf> I was like wtf is he doing down there?
2011-02-05 18:20:15 [INFO] <AngryRhetoric> i had a parade
2011-02-05 18:21:24 [INFO] <AngryRhetoric> darn lost my bow
2011-02-05 18:21:36 [INFO] <nawf> ouch
2011-02-05 18:21:40 [INFO] <nawf> I don't have another
2011-02-05 18:21:53 [INFO] <nawf> damn, I gotta get back to doin shit, I can't play when I have so much to do
2011-02-05 18:21:59 [INFO] <nawf> but I'll take breaks from time to time
2011-02-05 18:22:02 [INFO] <AngryRhetoric> haha ok
2011-02-05 18:54:00 [INFO] redux06790 [/69.119.8.191:50868] logged in with entity id 6569125
2011-02-05 18:54:10 [INFO] <redux06790> OH EM GEE!!!
2011-02-05 18:54:16 [INFO] <redux06790> i got on!
2011-02-05 18:55:11 [INFO] <redux06790> i know youre here! the forges are running!
2011-02-05 18:55:22 [INFO] <redux06790> were... running
2011-02-05 18:55:44 [INFO] <AngryRhetoric> haha hey
2011-02-05 18:55:47 [INFO] <redux06790> lol
2011-02-05 18:56:00 [INFO] <redux06790> i need to make a watch i never know if its night on the surface
2011-02-05 18:56:04 [INFO] <AngryRhetoric> john's in and out and i'm making the first floor of castle gigundus
2011-02-05 18:56:16 [INFO] <redux06790> john is on?
2011-02-05 18:56:23 [INFO] <AngryRhetoric> yup
2011-02-05 18:56:34 [INFO] <AngryRhetoric> hes afk
2011-02-05 18:56:38 [INFO] <redux06790> because i wanna invite my friend mike fox to play
2011-02-05 18:56:55 [INFO] <AngryRhetoric> cool, joe's gotta give him access right?
2011-02-05 18:57:02 [INFO] <redux06790> i think so
2011-02-05 18:57:24 [INFO] <redux06790> im assuming theres a white list since john asked me for my minecraft name before inviting me
2011-02-05 18:57:45 [INFO] <redux06790> i think im going to actually explore these caves
2011-02-05 18:57:47 [INFO] <AngryRhetoric> yeah thats what i heard too, but i thnk joe controls it cuz its his server
2011-02-05 18:57:59 [INFO] <AngryRhetoric> don't forget a compass lol
2011-02-05 18:58:20 [INFO] <nawf> mike fox?
2011-02-05 18:58:21 [INFO] <nawf> no shit
2011-02-05 18:58:23 [INFO] <redux06790> yea
2011-02-05 18:58:27 [INFO] <redux06790> thats what i said john
2011-02-05 18:58:41 [INFO] <redux06790> we need to just flat out ask everyone they know if they play minecraft
2011-02-05 18:58:53 [INFO] <AngryRhetoric> john we gotta get konrad to play heh
2011-02-05 18:59:02 [INFO] <nawf> he said he might
2011-02-05 18:59:12 [INFO] <nawf> once he sees the castle he'll have too
2011-02-05 18:59:14 [INFO] <AngryRhetoric> yeah
2011-02-05 18:59:17 [INFO] <AngryRhetoric> haha
2011-02-05 18:59:21 [INFO] <nawf> the comtemporary castle
2011-02-05 18:59:22 [INFO] <redux06790> because mike posted a minecraft vid on facebook, and im like...
2011-02-05 18:59:31 [INFO] <redux06790> only someone who plays MC would do that
2011-02-05 18:59:45 [INFO] <redux06790> did you see my tower yet john?
2011-02-05 19:00:23 [INFO] <nawf> the gorilla, yeah
2011-02-05 19:00:35 [INFO] <redux06790> hey you make a better skull lol
2011-02-05 19:00:36 [INFO] <AngryRhetoric> uh oh
2011-02-05 19:00:40 [INFO] <AngryRhetoric> hahah
2011-02-05 19:00:49 [INFO] <AngryRhetoric> its a pimp, with the gold toofs
2011-02-05 19:00:53 [INFO] <nawf> lol, you take ""yeah"" as an insult?
2011-02-05 19:00:58 [INFO] <nawf> naw, its cool looking
2011-02-05 19:00:59 [INFO] <redux06790> shit yea son
2011-02-05 19:01:24 [INFO] <redux06790> i WAS going to make an easter island head but i wouldnt even know where to begin with that one
2011-02-05 19:01:32 [INFO] <nawf> the nose
2011-02-05 19:01:44 [INFO] <AngryRhetoric> you'd have to do a big one since they're sorta curved
2011-02-05 19:01:45 [INFO] <nawf> did you connect the floating islands?
2011-02-05 19:01:53 [INFO] <AngryRhetoric> yes i did
2011-02-05 19:01:58 [INFO] <nawf> thats pretty cool
2011-02-05 19:02:00 [INFO] <AngryRhetoric> i have a new home up there
2011-02-05 19:02:08 [INFO] <redux06790> behind the skull?
2011-02-05 19:02:14 [INFO] <AngryRhetoric> yup
2011-02-05 19:02:19 [INFO] <AngryRhetoric> nice view up there
2011-02-05 19:02:20 [INFO] <nawf> did you skull fuck it?
2011-02-05 19:02:21 [INFO] <redux06790> suck mah dick
2011-02-05 19:02:24 [INFO] <AngryRhetoric> LOL
2011-02-05 19:02:26 [INFO] <redux06790> i was so going to build a house there
2011-02-05 19:02:32 [INFO] <redux06790> youre fired
2011-02-05 19:02:41 [INFO] <AngryRhetoric> you can build a house on top of your gorilla mask ;)
2011-02-05 19:02:48 [INFO] <nawf> in it
2011-02-05 19:02:48 [INFO] <redux06790> :(
2011-02-05 19:02:52 [INFO] <AngryRhetoric> hahaha
2011-02-05 19:02:52 [INFO] <redux06790> but its a hooman
2011-02-05 19:03:04 [INFO] <AngryRhetoric> HOOMAN BEYEAN
2011-02-05 19:03:08 [INFO] <nawf> oh, I thought it was a gorilla
2011-02-05 19:03:11 [INFO] <redux06790> im going to put a landmine on your island
2011-02-05 19:03:14 [INFO] <AngryRhetoric> hunan beef
2011-02-05 19:03:17 [INFO] <redux06790> naw its a skull dude
2011-02-05 19:03:18 [INFO] <AngryRhetoric> NOOOOOOO
2011-02-05 19:03:39 [INFO] <redux06790> thats ok though
2011-02-05 19:03:42 [INFO] <redux06790> this is minecraft
2011-02-05 19:03:44 [INFO] <AngryRhetoric> adding this stone is like lawn mowing
2011-02-05 19:03:50 [INFO] <AngryRhetoric> virtual lawn mowing
2011-02-05 19:03:58 [INFO] <redux06790> only strange folk live on the surface
2011-02-05 19:04:06 [INFO] <nawf> hah, yeah
2011-02-05 19:04:06 [INFO] <redux06790> oops drown while typing
2011-02-05 19:04:12 [INFO] <nawf> lol
2011-02-05 19:04:16 [INFO] <AngryRhetoric> hahah
2011-02-05 19:04:22 [INFO] <AngryRhetoric> blub blub
2011-02-05 19:04:30 [INFO] <redux06790> we need to get some addons on this bitch
2011-02-05 19:04:33 [INFO] <redux06790> so we can fly and shit
2011-02-05 19:04:39 [INFO] <nawf> naw
2011-02-05 19:04:41 [INFO] <redux06790> or at the very least run some runecraft
2011-02-05 19:04:41 [INFO] <nawf> shits lame
2011-02-05 19:04:48 [INFO] <redux06790> so we can make it daytime whenever
2011-02-05 19:05:11 [INFO] <redux06790> HAHA
2011-02-05 19:05:16 [INFO] <redux06790> i forgot i wrote herp derp
2011-02-05 19:05:21 [INFO] <nawf> I think its better with the challenges of night and travel
2011-02-05 19:05:41 [INFO] <AngryRhetoric> yeah that was cool
2011-02-05 19:05:50 [INFO] <redux06790> im coming up there and im going to break one of your windows to be a dick
2011-02-05 19:06:09 [INFO] <AngryRhetoric> i will make your skull toothless!
2011-02-05 19:06:11 [INFO] <AngryRhetoric> haha
2011-02-05 19:06:15 [INFO] <redux06790> NOE!!!
2011-02-05 19:06:19 [INFO] <nawf> build a dick in its mouth
2011-02-05 19:06:21 [INFO] <nawf> no ear
2011-02-05 19:06:22 [INFO] <AngryRhetoric> LOL
2011-02-05 19:06:25 [INFO] <AngryRhetoric> out of tan wool
2011-02-05 19:06:29 [INFO] <redux06790> hahaha
2011-02-05 19:06:41 [INFO] <AngryRhetoric> skull F'ed
2011-02-05 19:06:47 [INFO] <redux06790> you gotta admit
2011-02-05 19:06:50 [INFO] <redux06790> that thing is tits
2011-02-05 19:07:00 [INFO] <nawf> yeah, really pulls the world together
2011-02-05 19:07:24 [INFO] <redux06790> brb
2011-02-05 19:07:54 [INFO] <nawf> we are out of cobble
2011-02-05 19:07:56 [INFO] <AngryRhetoric> you got any feud?
2011-02-05 19:08:06 [INFO] <nawf> yeah, wheats
2011-02-05 19:08:21 [INFO] <AngryRhetoric> i can't eat that
2011-02-05 19:08:26 [INFO] <nawf> make bread
2011-02-05 19:08:39 [INFO] <redux06790> ok back
2011-02-05 19:08:54 [INFO] <redux06790> WHAT
2011-02-05 19:08:58 [INFO] <redux06790> we are OUT of cobble?
2011-02-05 19:09:02 [INFO] <nawf> well here
2011-02-05 19:09:05 [INFO] <redux06790> oh
2011-02-05 19:09:08 [INFO] <redux06790> i was gonna say
2011-02-05 19:09:09 [INFO] <redux06790> wtf
2011-02-05 19:09:10 [INFO] <nawf> we started on the castle
2011-02-05 19:09:16 [INFO] <redux06790> ill deliver some
2011-02-05 19:09:17 [INFO] <redux06790> brt
2011-02-05 19:10:42 [INFO] <AngryRhetoric> gIT to THA CAWBLE (ahnold voice)
2011-02-05 19:10:47 [INFO] <nawf> lol
2011-02-05 19:11:06 [INFO] <nawf> if we have coal bring that too, need torches
2011-02-05 19:11:11 [INFO] <redux06790> i like that you guys dont steal shit haha
2011-02-05 19:11:13 [INFO] <AngryRhetoric> i have 20 coal
2011-02-05 19:11:16 [INFO] <nawf> fuck bring EVERYTHING
2011-02-05 19:11:19 [INFO] <redux06790> my last server needed hidden chests
2011-02-05 19:11:26 [INFO] <redux06790> im coming im coming
2011-02-05 19:11:26 [INFO] <nawf> naw, we keep things pretty open
2011-02-05 19:11:28 [INFO] <AngryRhetoric> i wouldn't want to play if we stole stuff
2011-02-05 19:11:51 [INFO] <redux06790> im going to put shit in minecarts gimme sec
2011-02-05 19:12:54 [INFO] <redux06790> you want cobble or smooth?
2011-02-05 19:12:57 [INFO] <nawf> cobble
2011-02-05 19:13:05 [INFO] <nawf> need to make a metric fuckton of halfstones
2011-02-05 19:13:13 [INFO] <AngryRhetoric> maybe two fucktons
2011-02-05 19:13:21 [INFO] <AngryRhetoric> we have  ton of smooth stone here
2011-02-05 19:13:44 [INFO] <redux06790> did you want me to bring coal?
2011-02-05 19:13:58 [INFO] <nawf> if we have it, we'll have to make tons of torches to light this bitch
2011-02-05 19:14:08 [INFO] <redux06790> we have 2 stacks left
2011-02-05 19:14:16 [INFO] <redux06790> that i just ganked from the forges
2011-02-05 19:14:21 [INFO] <nawf> damn
2011-02-05 19:14:27 [INFO] <redux06790> plus a stack of charcoal
2011-02-05 19:14:34 [INFO] <AngryRhetoric> torches here
2011-02-05 19:14:46 [INFO] <nawf> sweet
2011-02-05 19:14:54 [INFO] <AngryRhetoric> 64 more if you need more
2011-02-05 19:15:06 [INFO] <AngryRhetoric> that hurt
2011-02-05 19:15:55 [INFO] <nawf> where did you die?
2011-02-05 19:16:01 [INFO] <redux06790> the fuck!?
2011-02-05 19:16:02 [INFO] <AngryRhetoric> over here
2011-02-05 19:16:11 [INFO] <redux06790> what the hell happened to my awesome subway entrance!?
2011-02-05 19:16:20 [INFO] <AngryRhetoric> behind
2011-02-05 19:16:34 [INFO] <AngryRhetoric> thx
2011-02-05 19:16:37 [INFO] <nawf> np
2011-02-05 19:16:55 [INFO] <redux06790> k im not sure which way to go on these tracks
2011-02-05 19:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 19:18:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 19:18:13 [WARNING] redux06790 moved wrongly!
2011-02-05 19:20:15 [INFO] <redux06790> almost loaded up
2011-02-05 19:23:03 [INFO] <redux06790> incoming
2011-02-05 19:24:56 [INFO] <redux06790> the fuck
2011-02-05 19:25:00 [INFO] <redux06790> ...
2011-02-05 19:25:16 [INFO] <nawf> I got one of the carts
2011-02-05 19:25:19 [INFO] <AngryRhetoric> best to go via the surface heh
2011-02-05 19:26:43 [INFO] <redux06790> k heres another cart
2011-02-05 19:26:51 [INFO] <redux06790> and yea fuck the minecarts for shipping
2011-02-05 19:26:55 [INFO] <redux06790> that was a headache
2011-02-05 19:27:09 [INFO] <nawf> yeah, it doesn't boost as far without a player in it
2011-02-05 19:27:09 [INFO] <redux06790> ill brb with more
2011-02-05 19:27:46 [INFO] <redux06790> anyway theres another cart there
2011-02-05 19:28:20 [INFO] <redux06790> so i brought you a whole chest full
2011-02-05 19:28:27 [INFO] <redux06790> should be good for a bit now right?
2011-02-05 19:28:39 [INFO] <nawf> yeah, I think
2011-02-05 19:28:43 [INFO] <AngryRhetoric> nice thanks!
2011-02-05 19:28:56 [INFO] <nawf> yeah, what are you going to build over here erin?
2011-02-05 19:29:07 [INFO] <redux06790> this skull doesnt look as awesome with the classic textures
2011-02-05 19:29:18 [INFO] <nawf> did you see the castle progress so far?
2011-02-05 19:29:24 [INFO] <redux06790> idk i liked building a skull lol
2011-02-05 19:29:30 [INFO] <redux06790> no ill brt
2011-02-05 19:29:43 [INFO] <AngryRhetoric> so 4 stories john?
2011-02-05 19:29:44 [INFO] <redux06790> what the fuck
2011-02-05 19:29:52 [INFO] <nawf> well 4 outer stories
2011-02-05 19:30:00 [INFO] <AngryRhetoric> ok
2011-02-05 19:30:02 [INFO] <redux06790> i just fell into the abyss gimme a sec
2011-02-05 19:30:06 [INFO] <AngryRhetoric> need a great hall with pillars in the entrance
2011-02-05 19:30:07 [INFO] <nawf> we should go maybe 6 inside the cathedral or whatever
2011-02-05 19:31:36 [INFO] <redux06790> fuck john why didnt you tell me there was an abyss by your tower?
2011-02-05 19:31:56 [INFO] <nawf> there is?
2011-02-05 19:32:01 [INFO] <AngryRhetoric> abyss? you sure there's not a chunk error?
2011-02-05 19:32:08 [INFO] <redux06790> positive
2011-02-05 19:32:15 [INFO] <nawf> I just work here
2011-02-05 19:32:29 [INFO] <redux06790> there was a chest down there with 41 logs in it tho
2011-02-05 19:32:30 [INFO] <redux06790> woot
2011-02-05 19:32:36 [INFO] <nawf> really?
2011-02-05 19:32:44 [INFO] <redux06790> yea
2011-02-05 19:32:49 [INFO] <nawf> that may be an cave joe and I explored right when we started
2011-02-05 19:33:02 [INFO] <redux06790> holy shit on a cock
2011-02-05 19:33:12 [INFO] <redux06790> we should make a spleef stadium
2011-02-05 19:33:24 [INFO] <nawf> we certainly have the room
2011-02-05 19:33:39 [INFO] <nawf> I think the front is looking cool so far
2011-02-05 19:33:49 [INFO] <redux06790> im going to go on a grand adventure when the sun starts coming up
2011-02-05 19:33:57 [INFO] <nawf> that way?
2011-02-05 19:34:01 [INFO] <redux06790> seems like there would be nothing that way
2011-02-05 19:34:04 [INFO] <nawf> over the ocean?
2011-02-05 19:34:06 [INFO] <redux06790> yea
2011-02-05 19:34:09 [INFO] <nawf> there are sweet mountains over there
2011-02-05 19:34:10 [INFO] <AngryRhetoric> wanderlust
2011-02-05 19:34:17 [INFO] <redux06790> you been over there then?
2011-02-05 19:34:20 [INFO] <nawf> yeah
2011-02-05 19:34:24 [INFO] <redux06790> well fuck
2011-02-05 19:34:30 [INFO] <redux06790> i wanna go somewhere nobodys been
2011-02-05 19:34:31 [INFO] <nawf> well just a little, to like x -600
2011-02-05 19:34:38 [INFO] <nawf> go this way
2011-02-05 19:34:40 [INFO] <redux06790> and come back with a solar mass of clay
2011-02-05 19:34:55 [INFO] <nawf> I've only been to the moutain right in front of us
2011-02-05 19:35:13 [INFO] <nawf> that was my first base like 30 minutes when the server started
2011-02-05 19:35:34 [INFO] <redux06790> time to load up on arrows
2011-02-05 19:35:37 [INFO] <nawf> yeah we haven't found ANY clay so far
2011-02-05 19:35:45 [INFO] <redux06790> oh im a master at finding clay
2011-02-05 19:35:47 [INFO] <redux06790> you watch
2011-02-05 19:35:50 [INFO] <redux06790> brb
2011-02-05 19:35:52 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-05 19:35:52 [INFO] <nawf> I know kevin needs some too
2011-02-05 19:36:01 [INFO] redux06790 [/69.119.8.191:50933] logged in with entity id 6645031
2011-02-05 19:36:05 [INFO] <redux06790> thats better
2011-02-05 19:36:07 [INFO] <AngryRhetoric> yeah i could use clay for chimneys
2011-02-05 19:36:11 [INFO] <redux06790> with my texture pack
2011-02-05 19:36:13 [INFO] <redux06790> clay is red
2011-02-05 19:36:17 [INFO] <AngryRhetoric> the castle needs a big fireplace
2011-02-05 19:36:21 [INFO] <AngryRhetoric> speaking of which, not brick though
2011-02-05 19:36:27 [INFO] <redux06790> so im going to go get a fuckton of it
2011-02-05 19:36:39 [INFO] <AngryRhetoric> needs a wood / stone fireplace
2011-02-05 19:37:05 [INFO] <redux06790> ok i dropped off the coal
2011-02-05 19:37:16 [INFO] <nawf> cool, this is the staging area
2011-02-05 19:37:20 [INFO] <nawf> for ""the great build""
2011-02-05 19:37:36 [INFO] <redux06790> very modern looking
2011-02-05 19:37:44 [INFO] <redux06790> if its big enough
2011-02-05 19:37:47 [INFO] <nawf> heh, kev said its contemporary
2011-02-05 19:37:57 [INFO] <AngryRhetoric> hah yeah id id
2011-02-05 19:38:03 [INFO] <redux06790> if its big enough
2011-02-05 19:38:05 [INFO] <nawf> well this is just the outer wall, the inner one will be bigger
2011-02-05 19:38:07 [INFO] <redux06790> ill make a mosaic
2011-02-05 19:38:17 [INFO] <redux06790> going on an
2011-02-05 19:38:18 [INFO] <AngryRhetoric> inner wall goes higher hMmm
2011-02-05 19:38:19 [INFO] <nawf> yeah, that would be fucking awesome
2011-02-05 19:38:29 [INFO] <nawf> especially a mosiac ceiling or something
2011-02-05 19:38:31 [INFO] <redux06790> gah FUUU
2011-02-05 19:38:41 [INFO] <redux06790> so much for an epic quest
2011-02-05 19:38:47 [INFO] <redux06790> i just got shafted by a spider
2011-02-05 19:38:48 [INFO] <nawf> there is tons of wheat inside
2011-02-05 19:38:49 [INFO] <redux06790> any food?
2011-02-05 19:39:03 [INFO] <nawf> I mean inside the spawn base
2011-02-05 19:39:06 [INFO] <AngryRhetoric> i have hweat!
2011-02-05 19:39:13 [INFO] <AngryRhetoric> that john gave me
2011-02-05 19:39:20 [INFO] <redux06790> can you eat just the wheat?
2011-02-05 19:39:27 [INFO] <AngryRhetoric> no you put 3 in a row to make bread
2011-02-05 19:39:28 [INFO] <nawf> naw, make bread
2011-02-05 19:39:31 [INFO] <redux06790> yeah i know
2011-02-05 19:39:37 [INFO] <AngryRhetoric> i did try to eat wheat lol
2011-02-05 19:39:40 [INFO] <redux06790> but i was hoping you could just eat wheat
2011-02-05 19:39:46 [INFO] <redux06790> it would be more efficient
2011-02-05 19:39:54 [INFO] <nawf> just bring a crafting cube and the wheat
2011-02-05 19:40:05 [INFO] <AngryRhetoric> here's the hweat
2011-02-05 19:40:11 [INFO] <nawf> its the most efficient hearts per inventory method
2011-02-05 19:40:14 [INFO] <AngryRhetoric> hwill hweaton
2011-02-05 19:40:28 [INFO] <nawf> I gotta go back to cleaning and wtfever
2011-02-05 19:40:34 [INFO] <redux06790> ill give you hearts per inventory bitch
2011-02-05 19:40:40 [INFO] <nawf> good luck on your adventure
2011-02-05 19:40:47 [INFO] <nawf> come back with your shield or on it
2011-02-05 19:40:51 [INFO] <AngryRhetoric> haha
2011-02-05 19:40:52 [INFO] <redux06790> there will be great peril
2011-02-05 19:41:01 [INFO] <AngryRhetoric> THIS...IS....MINECRAAAAFT
2011-02-05 19:41:38 [INFO] <AngryRhetoric> shift doesn't work 100% of the time
2011-02-05 19:41:59 [INFO] <redux06790> off i go
2011-02-05 19:42:11 [INFO] <AngryRhetoric> which direction you heading?
2011-02-05 19:42:12 [INFO] <redux06790> im going to leave breadcrumbs
2011-02-05 19:42:19 [INFO] <redux06790> so to speak
2011-02-05 19:42:39 [INFO] <AngryRhetoric> you should head south and bring a compass
2011-02-05 19:43:00 [INFO] <redux06790> comapsses are for girly boys
2011-02-05 19:43:06 [INFO] <redux06790> death is the only way to get home
2011-02-05 19:43:06 [INFO] <AngryRhetoric> HAH
2011-02-05 19:43:42 [INFO] <redux06790> so my bread crumbs are going to be planks with a torch on them
2011-02-05 19:43:50 [INFO] <redux06790> i have 60 torches
2011-02-05 19:44:00 [INFO] <redux06790> so soon it will be planks with nothing on them
2011-02-05 19:46:14 [INFO] <redux06790> found a fuckton of coal
2011-02-05 19:46:18 [INFO] <AngryRhetoric> nice
2011-02-05 19:46:22 [INFO] <redux06790> and SURFACE iron
2011-02-05 19:46:40 [INFO] <AngryRhetoric> i dare say i'm halway
2011-02-05 19:46:49 [INFO] <AngryRhetoric> halfway done with the floor
2011-02-05 19:47:01 [INFO] <redux06790> you have to double stack them
2011-02-05 19:47:09 [INFO] <redux06790> boom now youre only 1/4th of the way done
2011-02-05 19:47:13 [INFO] <AngryRhetoric> haha
2011-02-05 19:47:17 [INFO] <AngryRhetoric> no double stack!
2011-02-05 19:48:20 [INFO] <redux06790> no way
2011-02-05 19:48:26 [INFO] <redux06790> fucking pine trees up the ass
2011-02-05 19:48:43 [INFO] <redux06790> these are the first ones ive seen
2011-02-05 19:49:27 [INFO] <AngryRhetoric> actual pine trees?
2011-02-05 19:49:30 [INFO] <redux06790> yea
2011-02-05 19:49:35 [INFO] <AngryRhetoric> did you head south?
2011-02-05 19:49:38 [INFO] <redux06790> no
2011-02-05 19:49:41 [INFO] <AngryRhetoric> west?
2011-02-05 19:49:44 [INFO] <redux06790> wait
2011-02-05 19:49:45 [INFO] <redux06790> yes
2011-02-05 19:49:47 [INFO] <redux06790> no way
2011-02-05 19:49:48 [INFO] <AngryRhetoric> oh ok
2011-02-05 19:49:49 [INFO] <redux06790> iaihtahrh
2011-02-05 19:49:51 [INFO] <AngryRhetoric> haha
2011-02-05 19:49:51 [INFO] <redux06790> fuck
2011-02-05 19:49:55 [INFO] <redux06790> which way is north?
2011-02-05 19:49:59 [INFO] <redux06790> direction of clouds?
2011-02-05 19:50:17 [INFO] <AngryRhetoric> clouds are heading south
2011-02-05 19:50:20 [INFO] <AngryRhetoric> starting from north
2011-02-05 19:50:23 [INFO] <redux06790> then i went south
2011-02-05 19:50:28 [INFO] <nawf> no, clouds move north
2011-02-05 19:50:31 [INFO] <redux06790> no no no
2011-02-05 19:50:32 [INFO] <redux06790> yeah
2011-02-05 19:50:33 [INFO] <redux06790> no
2011-02-05 19:50:35 [INFO] <AngryRhetoric> NO
2011-02-05 19:50:37 [INFO] <redux06790> ok take 3
2011-02-05 19:50:38 [INFO] <nawf> yeah, I googled it
2011-02-05 19:50:40 [INFO] <redux06790> i went north
2011-02-05 19:50:46 [INFO] <redux06790> i watched the sun lol
2011-02-05 19:50:47 [INFO] <nawf> because we have directions all fucked up
2011-02-05 19:50:48 [INFO] <AngryRhetoric> oh yeah
2011-02-05 19:50:49 [INFO] <redux06790> im heading north
2011-02-05 19:51:02 [INFO] <redux06790> follow the beacons
2011-02-05 19:51:06 [INFO] <redux06790> and youll find me
2011-02-05 19:51:07 [INFO] <AngryRhetoric> clouds head south to north sorry
2011-02-05 19:52:09 [INFO] <redux06790> im choppin me some fuckin pine
2011-02-05 19:52:16 [INFO] <nawf> yeah, its darker too
2011-02-05 19:52:31 [INFO] <nawf> the birch trees look sweet
2011-02-05 19:52:35 [INFO] <AngryRhetoric> that's cool
2011-02-05 19:52:39 [INFO] <nawf> damn, I REALLY can't be playing this game
2011-02-05 19:52:42 [INFO] <nawf> shit to do
2011-02-05 19:52:50 [INFO] <nawf> I'm just going to log off, its too tempting
2011-02-05 19:52:55 [INFO] <redux06790> lol
2011-02-05 19:52:58 [INFO] <nawf> see some of you tomorrow
2011-02-05 19:52:59 [INFO] <redux06790> JOOOHHHHHNNNNNN
2011-02-05 19:53:02 [INFO] <nawf> what
2011-02-05 19:53:11 [INFO] <redux06790> PLLLLLLAAAAAAAYYYYY MEEEEEEE
2011-02-05 19:53:27 [INFO] <nawf> wut?
2011-02-05 19:53:32 [INFO] <nawf> stop your nonsense
2011-02-05 19:53:35 [INFO] <AngryRhetoric> haha
2011-02-05 19:53:36 [INFO] <redux06790> thats minecraft calling to you
2011-02-05 19:53:40 [INFO] <nawf> seriously
2011-02-05 19:53:45 [INFO] <nawf> ok, time to go, bye
2011-02-05 19:53:45 [INFO] <AngryRhetoric> it whispers
2011-02-05 19:53:52 [INFO] <nawf> if I log on later just kill me with tnt
2011-02-05 19:53:57 [INFO] <redux06790> ok
2011-02-05 19:53:59 [INFO] <redux06790> tell you what
2011-02-05 19:54:02 [INFO] <redux06790> where are you logging off
2011-02-05 19:54:03 [INFO] <AngryRhetoric> i see where you are now i'll put TNT around that
2011-02-05 19:54:05 [INFO] <redux06790> ill just put a mine there
2011-02-05 19:54:09 [INFO] <nawf> fu nooo
2011-02-05 19:54:12 [INFO] <AngryRhetoric> with a pressure plate
2011-02-05 19:54:19 [INFO] <AngryRhetoric> hahaha
2011-02-05 19:54:48 [INFO] nawf lost connection: disconnect.quitting
2011-02-05 19:55:17 [INFO] <redux06790> lol afk for a sec
2011-02-05 19:55:22 [INFO] <AngryRhetoric> ok
2011-02-05 19:57:52 [INFO] <redux06790> lol
2011-02-05 19:57:58 [INFO] <redux06790> i love afking at night
2011-02-05 19:58:08 [INFO] <AngryRhetoric> hope you built a shelter haha
2011-02-05 19:58:09 [INFO] <redux06790> you have to bury yourself three squares down and cap it
2011-02-05 19:59:05 [INFO] <redux06790> fuck
2011-02-05 19:59:10 [INFO] <redux06790> little did i know
2011-02-05 19:59:17 [INFO] <redux06790> 6 spiders spawned on top of me
2011-02-05 19:59:29 [INFO] <AngryRhetoric> niice time to dig sideways
2011-02-05 19:59:40 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-05 19:59:51 [INFO] redux06790 [/69.119.8.191:50968] logged in with entity id 6682800
2011-02-05 19:59:58 [INFO] <redux06790> say what?
2011-02-05 19:59:59 [INFO] <redux06790> i crashed
2011-02-05 20:02:39 [INFO] <AngryRhetoric> oh that sucks
2011-02-05 20:02:43 [INFO] <redux06790> ?
2011-02-05 20:02:45 [INFO] <redux06790> oh
2011-02-05 20:02:47 [INFO] <redux06790> lolw
2011-02-05 20:02:58 [INFO] <AngryRhetoric> sorry delayed reaction
2011-02-05 20:03:01 [INFO] <redux06790> thank god for bread crumbs
2011-02-05 20:03:31 [INFO] <AngryRhetoric> haha you comin back this way?
2011-02-05 20:04:02 [INFO] <redux06790> picking up my bits and the adventure continues lol
2011-02-05 20:04:27 [INFO] <AngryRhetoric> i've used almost all the half stone
2011-02-05 20:04:51 [INFO] <redux06790> ahhh crap
2011-02-05 20:05:01 [INFO] <redux06790> i got creepered when i died so some of my shit is poof
2011-02-05 20:05:28 [INFO] <redux06790> woah
2011-02-05 20:05:28 [INFO] <redux06790> wtf
2011-02-05 20:05:34 [INFO] <redux06790> theres something you dont see every day
2011-02-05 20:05:43 [INFO] <AngryRhetoric> what?
2011-02-05 20:05:48 [INFO] <redux06790> mushroom in a tree
2011-02-05 20:06:40 [INFO] <AngryRhetoric> in a tree? huh that is wierd
2011-02-05 20:06:48 [INFO] <AngryRhetoric> he should make big oak or cedar trees
2011-02-05 20:06:50 [INFO] <AngryRhetoric> that'd be awesome
2011-02-05 20:07:13 [INFO] <redux06790> he should increase the chance of clay haha
2011-02-05 20:07:23 [INFO] <AngryRhetoric> true
2011-02-05 20:07:30 [INFO] <AngryRhetoric> in single player i never had a hard time finding it
2011-02-05 20:07:37 [INFO] <AngryRhetoric> it was always on the edge of water
2011-02-05 20:08:02 [INFO] <redux06790> ooooomfg
2011-02-05 20:08:06 [INFO] <redux06790> red flower motherload
2011-02-05 20:08:12 [INFO] <AngryRhetoric> cool
2011-02-05 20:08:22 [INFO] <AngryRhetoric> minecraft dutchland
2011-02-05 20:08:41 [INFO] <redux06790> there needs to be more plants
2011-02-05 20:09:11 [INFO] <redux06790> 26 red flowers all in this one little spot
2011-02-05 20:09:19 [INFO] <redux06790> OH yeah i remember why i wanted to go on an adventure
2011-02-05 20:09:22 [INFO] <redux06790> i want pumpkins
2011-02-05 20:09:24 [INFO] <AngryRhetoric> i wish if you planted them they would grow more like trees
2011-02-05 20:09:43 [INFO] <redux06790> OR i wish you could hit them with the sickle and get flower seeds
2011-02-05 20:09:52 [INFO] <redux06790> so you could plant say 2 from 1
2011-02-05 20:10:08 [INFO] <AngryRhetoric> yeah exactly
2011-02-05 20:10:54 [INFO] <redux06790> but yea there should be bamboo
2011-02-05 20:10:57 [INFO] <redux06790> and other plants
2011-02-05 20:12:04 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-05 20:12:15 [INFO] redux06790 [/69.119.8.191:50979] logged in with entity id 6720161
2011-02-05 20:12:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 20:16:00 [INFO] <redux06790> omg
2011-02-05 20:16:08 [INFO] <redux06790> this island is like nothing ive ever seen
2011-02-05 20:16:28 [INFO] <redux06790> its a tiny flat island in the ocean with about 10 trees on it
2011-02-05 20:16:41 [INFO] <redux06790> im so making a cottage here
2011-02-05 20:16:51 [INFO] <AngryRhetoric> hahah coool
2011-02-05 20:16:57 [INFO] <AngryRhetoric> thats why i liked the floating island
2011-02-05 20:17:02 [INFO] <AngryRhetoric> you should put a chair outside
2011-02-05 20:17:04 [INFO] <AngryRhetoric> or bench
2011-02-05 20:18:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 20:18:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 20:18:48 [INFO] <redux06790> my luck
2011-02-05 20:18:58 [INFO] <redux06790> i dig down to get some stone and discover a cave
2011-02-05 20:19:06 [INFO] <redux06790> had i been one block back i would not have found it
2011-02-05 20:19:14 [INFO] <redux06790> BOO my luck
2011-02-05 20:19:19 [INFO] <redux06790> the cave is tiny
2011-02-05 20:19:19 [INFO] <AngryRhetoric> did you fall to your death?
2011-02-05 20:19:21 [INFO] <redux06790> brb
2011-02-05 20:21:03 [INFO] <redux06790> back
2011-02-05 20:25:44 [INFO] <AngryRhetoric> i too feel like wandering
2011-02-05 20:25:57 [INFO] <AngryRhetoric> south though, just out of curiosity what's yoru coords?
2011-02-05 20:26:19 [INFO] <redux06790> follow my beacons
2011-02-05 20:26:31 [INFO] <AngryRhetoric> i just wanted to know how far you made it, relative to here
2011-02-05 20:26:36 [INFO] <redux06790> when you get to my island ill be headed in a different direction
2011-02-05 20:26:39 [INFO] <redux06790> really far
2011-02-05 20:26:54 [INFO] <redux06790> about 5 minute walk
2011-02-05 20:27:01 [INFO] <redux06790> the best part about my beacons
2011-02-05 20:27:08 [INFO] <redux06790> you can always see the last one
2011-02-05 20:27:18 [INFO] <AngryRhetoric> the castle is Z - 109
2011-02-05 20:27:19 [INFO] <redux06790> by standing on the nearest one
2011-02-05 20:27:28 [INFO] <redux06790> how do i know my coords?
2011-02-05 20:27:29 [INFO] redux06790 tried command: help
2011-02-05 20:27:33 [INFO] <AngryRhetoric> press f3
2011-02-05 20:27:47 [INFO] <redux06790> uhh
2011-02-05 20:28:08 [INFO] <redux06790> whats the X?
2011-02-05 20:28:12 [INFO] <redux06790> x is north south
2011-02-05 20:28:14 [INFO] <AngryRhetoric> -129
2011-02-05 20:28:23 [INFO] <redux06790> -1188
2011-02-05 20:28:45 [INFO] <AngryRhetoric> castle is -134
2011-02-05 20:28:52 [INFO] <AngryRhetoric> er -142 for x
2011-02-05 20:28:59 [INFO] <redux06790> yeah dude im out here
2011-02-05 20:29:03 [INFO] <AngryRhetoric> haha wow
2011-02-05 20:30:01 [INFO] <AngryRhetoric> so you're way north then
2011-02-05 20:30:09 [INFO] <redux06790> yea
2011-02-05 20:30:17 [INFO] <redux06790> im going to use this island as a hub
2011-02-05 20:30:21 [INFO] <redux06790> for beacons
2011-02-05 20:31:17 [INFO] <AngryRhetoric> i'll come check it out
2011-02-05 20:31:34 [INFO] <redux06790> im about to start building
2011-02-05 20:34:26 [INFO] <AngryRhetoric> i see a torch!
2011-02-05 20:34:45 [INFO] <AngryRhetoric> oh wait that's lava
2011-02-05 20:34:55 [INFO] <redux06790> lol
2011-02-05 20:37:19 [INFO] <redux06790> omg
2011-02-05 20:37:20 [INFO] <redux06790> dude
2011-02-05 20:37:29 [INFO] <redux06790> theres like 100 livestock on this tiny ass island
2011-02-05 20:37:35 [INFO] <AngryRhetoric> you got a farm lol
2011-02-05 20:37:39 [INFO] <redux06790> i so do
2011-02-05 20:38:21 [INFO] <AngryRhetoric> what's your z coord?
2011-02-05 20:38:49 [INFO] <AngryRhetoric> i ask cuz i gotta go to the left or right around water
2011-02-05 20:38:59 [INFO] <redux06790> um
2011-02-05 20:39:17 [INFO] <redux06790> -1193X
2011-02-05 20:39:26 [INFO] <redux06790> 223Z
2011-02-05 20:39:29 [INFO] <AngryRhetoric> yeah x i'm good on but east west ahh ok
2011-02-05 20:39:44 [INFO] <AngryRhetoric> i was slightly east of your trail
2011-02-05 20:40:51 [INFO] <AngryRhetoric> interesting farther north and the water isn't frozen
2011-02-05 20:41:09 [INFO] <redux06790> its seriously a neverending pile of livestock
2011-02-05 20:42:39 [INFO] <AngryRhetoric> i went wayyy east
2011-02-05 20:44:04 [INFO] <redux06790> i finally have a wool farm lol
2011-02-05 20:44:31 [INFO] <AngryRhetoric> yo
2011-02-05 20:44:44 [INFO] <redux06790> u here?
2011-02-05 20:45:08 [INFO] <AngryRhetoric> ther's no door
2011-02-05 20:45:16 [INFO] <redux06790> sec youre invis
2011-02-05 20:45:17 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-05 20:45:31 [INFO] redux06790 [/69.119.8.191:50989] lost connection
2011-02-05 20:45:58 [INFO] redux06790 [/69.119.8.191:50992] lost connection
2011-02-05 20:46:09 [INFO] /69.119.8.191:50996 lost connection
2011-02-05 20:46:39 [INFO] redux06790 [/69.119.8.191:51000] logged in with entity id 6846813
2011-02-05 20:46:48 [INFO] <AngryRhetoric> yo
2011-02-05 20:46:53 [INFO] <redux06790> yea no door yet
2011-02-05 20:46:58 [INFO] <redux06790> look at all the damned livestock
2011-02-05 20:47:01 [INFO] <redux06790> do you have some dirt on you?
2011-02-05 20:47:06 [INFO] <AngryRhetoric> yes
2011-02-05 20:47:11 [INFO] <redux06790> woot
2011-02-05 20:47:21 [INFO] <AngryRhetoric> i put a door over on the other side heh
2011-02-05 20:47:33 [INFO] <AngryRhetoric> dirt
2011-02-05 20:48:00 [INFO] <AngryRhetoric> that's cool
2011-02-05 20:50:37 [INFO] <redux06790> so yea
2011-02-05 20:50:45 [INFO] <redux06790> this is going to be my little home
2011-02-05 20:50:59 [INFO] <AngryRhetoric> haha very cool
2011-02-05 20:51:08 [INFO] <redux06790> next stop those mountains
2011-02-05 20:51:09 [INFO] <redux06790> i think
2011-02-05 20:51:17 [INFO] <AngryRhetoric> to the north? cool
2011-02-05 20:51:21 [INFO] <redux06790> yea
2011-02-05 20:51:31 [INFO] <redux06790> I WILL find pumpkins
2011-02-05 20:51:46 [INFO] <AngryRhetoric> hahah you need bigger mountains i think they're up on them..
2011-02-05 20:52:22 [INFO] <redux06790> hell yea
2011-02-05 20:52:24 [INFO] <redux06790> checker floor
2011-02-05 20:52:32 [INFO] <AngryRhetoric> nice
2011-02-05 20:52:46 [INFO] <AngryRhetoric> this house needs a chimney heh, haven't seen any clay on my travels tho
2011-02-05 20:53:35 [INFO] <AngryRhetoric> come sunrise i'ma head south
2011-02-05 20:54:09 [INFO] <redux06790> i think im going to turn the floor into crafting tables lol
2011-02-05 20:54:26 [INFO] <AngryRhetoric> that would look cool
2011-02-05 20:54:48 [INFO] <redux06790> since your up there wanna chop down the trees?
2011-02-05 20:54:49 [INFO] <redux06790> lol
2011-02-05 20:55:46 [INFO] <redux06790> i wanna have ONE big tree when this is done
2011-02-05 20:55:57 [INFO] <AngryRhetoric> one tree island
2011-02-05 20:57:26 [INFO] <redux06790> hows it look?
2011-02-05 20:57:31 [INFO] <AngryRhetoric> its busy hahaha
2011-02-05 20:57:43 [INFO] <AngryRhetoric> cool lookin
2011-02-05 20:57:44 [INFO] <redux06790> you got the classic textures?
2011-02-05 20:58:51 [INFO] <AngryRhetoric> yeah
2011-02-05 21:01:47 [INFO] <redux06790> how much cobble you got?
2011-02-05 21:02:09 [INFO] <redux06790> i need 104
2011-02-05 21:02:39 [INFO] <AngryRhetoric> i brought 64 smooth stone no cobble :(
2011-02-05 21:03:04 [INFO] <AngryRhetoric> i think i'm heading south
2011-02-05 21:04:51 [INFO] <redux06790> are you leaving beacons? or just headed back?
2011-02-05 21:05:03 [INFO] <AngryRhetoric> following your beacons back
2011-02-05 21:05:06 [INFO] <AngryRhetoric> might keep going heh
2011-02-05 21:05:07 [INFO] <redux06790> ahh
2011-02-05 21:05:11 [INFO] <AngryRhetoric> then add my own beacons
2011-02-05 21:05:25 [INFO] <redux06790> god idea beacons ehh?
2011-02-05 21:05:36 [INFO] <AngryRhetoric> yeah i just wish i wasn't so far east of them originally hahah
2011-02-05 21:17:55 [INFO] <redux06790> ok ill bbl
2011-02-05 21:17:59 [INFO] <AngryRhetoric> ok
2011-02-05 21:18:05 [INFO] <redux06790> im going to play wow with my wife before she goes to bed
2011-02-05 21:18:06 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-05 21:18:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 21:58:04 [INFO] /76.23.232.27:55035 lost connection
2011-02-05 21:58:31 [INFO] /76.23.232.27:55006 lost connection
2011-02-05 21:59:01 [INFO] nawf [/76.23.232.27:55010] logged in with entity id 7246215
2011-02-05 21:59:09 [INFO] <AngryRhetoric> he's back
2011-02-05 21:59:14 [INFO] <nawf> omg don't kill me I got a lot of shit done
2011-02-05 21:59:23 [INFO] <AngryRhetoric> TNT!
2011-02-05 21:59:27 [INFO] <AngryRhetoric> actually i'm miles away
2011-02-05 21:59:36 [INFO] <nawf> nice, clay search?
2011-02-05 22:00:03 [INFO] <AngryRhetoric> my x coord is
2011-02-05 22:00:07 [INFO] <AngryRhetoric> 1827
2011-02-05 22:00:10 [INFO] <nawf> damn
2011-02-05 22:00:13 [INFO] <AngryRhetoric> and i found 2 clays! and 10 pumpkins
2011-02-05 22:00:41 [INFO] <nawf> now you just have to make it back
2011-02-05 22:00:46 [INFO] <AngryRhetoric> haha eh
2011-02-05 22:01:35 [INFO] <AngryRhetoric> i found a cool hill with nice cliffs
2011-02-05 22:08:06 [INFO] <nawf> is erin still here?
2011-02-05 22:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 22:18:31 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 22:20:57 [INFO] <AngryRhetoric> you workin on the castle?
2011-02-05 22:21:10 [INFO] <AngryRhetoric> erin left  to go play wow with his wife
2011-02-05 22:21:23 [INFO] <nawf> yeah, workin on the castle
2011-02-05 22:21:27 [INFO] <nawf> wow with the wife
2011-02-05 22:21:30 [INFO] <nawf> yeah right...
2011-02-05 22:21:35 [INFO] <AngryRhetoric> hahaa
2011-02-05 22:23:47 [INFO] <AngryRhetoric> i'm bldg a house then coming back
2011-02-05 22:23:53 [INFO] <AngryRhetoric> its about 2 day's journey lol
2011-02-05 22:25:30 [INFO] <nawf> thats wild, I've never gone out that far
2011-02-05 22:25:45 [INFO] <AngryRhetoric> there's a ton of trees but the scenery isn't wildly diff
2011-02-05 22:25:46 [INFO] <nawf> is it still snow?
2011-02-05 22:25:56 [INFO] <AngryRhetoric> that's all gone :)
2011-02-05 22:26:18 [INFO] <AngryRhetoric> even on the hills there's no snow
2011-02-05 22:26:30 [INFO] <nawf> damn snow
2011-02-05 22:27:17 [INFO] <AngryRhetoric> LOT of trees
2011-02-05 22:27:27 [INFO] <nawf> prob a forest biome
2011-02-05 22:27:34 [INFO] <nawf> we haven't found a desert yet
2011-02-05 22:27:37 [INFO] <nawf> well just small ones
2011-02-05 22:27:46 [INFO] <AngryRhetoric> yeah i found a lot of sand
2011-02-05 22:27:47 [INFO] <nawf> in one of my singler player worlds there are huge deserts
2011-02-05 22:27:58 [INFO] <AngryRhetoric> that's cool this was more like a big beach
2011-02-05 22:33:33 [INFO] <nawf> there is this one block that torches are seemingly falling off of
2011-02-05 22:33:46 [INFO] <AngryRhetoric> in the castle?
2011-02-05 22:33:57 [INFO] <nawf> yeah, its just this one block, I go by, torch on the ground
2011-02-05 22:34:03 [INFO] <nawf> put it back up, come back, torch on the ground
2011-02-05 22:36:26 [INFO] <nawf> I'll be off and on again, still gotta do stuff, just need a break
2011-02-05 22:36:32 [INFO] <nawf> I just don't want to be hustling tomorrow
2011-02-05 22:36:35 [INFO] <AngryRhetoric> i hear that hehe
2011-02-05 22:36:41 [INFO] <AngryRhetoric> i won't be on too much longer
2011-02-05 22:36:42 [INFO] <nawf> heh, I bet I'll finish everything and just end up minecrafing all day
2011-02-05 22:36:56 [INFO] <AngryRhetoric> hahah til you hear the doorbell for the party
2011-02-05 22:41:15 [INFO] /69.119.8.191:51240 lost connection
2011-02-05 22:41:51 [INFO] Disconnecting /69.119.8.191:51242: Took too long to log in
2011-02-05 22:43:14 [INFO] /69.119.8.191:51246 lost connection
2011-02-05 22:43:47 [INFO] Disconnecting /69.119.8.191:51249: Took too long to log in
2011-02-05 22:43:58 [INFO] /69.119.8.191:51252 lost connection
2011-02-05 22:45:07 [INFO] /69.119.8.191:51262 lost connection
2011-02-05 22:47:59 [INFO] /69.119.8.191:51275 lost connection
2011-02-05 22:53:38 [INFO] <nawf> omg konrad just said ""how do I minecraft with you?""
2011-02-05 22:53:43 [INFO] <AngryRhetoric> hahaha
2011-02-05 22:53:44 [INFO] <AngryRhetoric> nice
2011-02-05 22:53:54 [INFO] <AngryRhetoric> did you tell him we've got 4 ppl playing so far?
2011-02-05 22:53:59 [INFO] Disconnecting /69.119.8.191:51327: Took too long to log in
2011-02-05 22:54:04 [INFO] <nawf> yeah
2011-02-05 22:54:39 [INFO] /69.119.8.191:51329 lost connection
2011-02-05 22:55:36 [INFO] /69.119.8.191:51355 lost connection
2011-02-05 22:55:58 [INFO] Disconnecting k0n2ad [/24.218.113.229:5359]: Took too long to log in
2011-02-05 23:03:34 [INFO] <AngryRhetoric> laaag
2011-02-05 23:05:08 [INFO] <AngryRhetoric> i can't moOOve
2011-02-05 23:10:41 [INFO] <AngryRhetoric> i found an interesting phenomenon
2011-02-05 23:17:22 [INFO] <AngryRhetoric> time to make the trek back
2011-02-05 23:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 23:18:39 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 23:21:21 [INFO] nawf lost connection: disconnect.quitting
2011-02-05 23:21:53 [INFO] Disconnecting /76.23.232.27:55010: Took too long to log in
2011-02-05 23:21:58 [INFO] /76.23.232.27:55084 lost connection
2011-02-05 23:23:36 [INFO] Disconnecting nawf [/76.23.232.27:55004]: Took too long to log in
2011-02-05 23:24:11 [INFO] Disconnecting /76.23.232.27:55009: Took too long to log in
2011-02-05 23:24:49 [INFO] /76.23.232.27:55100 lost connection
2011-02-05 23:25:27 [INFO] /76.23.232.27:55030 lost connection
2011-02-05 23:27:11 [INFO] nawf [/76.23.232.27:55046] logged in with entity id 7401994
2011-02-05 23:31:41 [INFO] redux06790 [/69.119.8.191:52097] logged in with entity id 7424966
2011-02-05 23:31:52 [INFO] <redux06790> derp
2011-02-05 23:31:55 [INFO] <nawf> hrup
2011-02-05 23:31:59 [INFO] <redux06790> OMGEH
2011-02-05 23:32:08 [INFO] <redux06790> i live elsewhere in the map now
2011-02-05 23:32:12 [INFO] <redux06790> on my hermit farm
2011-02-05 23:32:35 [INFO] <AngryRhetoric> haha
2011-02-05 23:32:43 [INFO] <AngryRhetoric> i made my own hermit farm in the opposite direction
2011-02-05 23:32:48 [INFO] <redux06790> lol
2011-02-05 23:32:51 [INFO] <redux06790> on anything cool?
2011-02-05 23:32:54 [INFO] <AngryRhetoric> i'm at 1826 for X
2011-02-05 23:33:02 [INFO] <AngryRhetoric> yes 2 clays, and 10 -15 pumpkins
2011-02-05 23:33:12 [INFO] <nawf> so -5 pumpkins?
2011-02-05 23:33:16 [INFO] <AngryRhetoric> lol!
2011-02-05 23:33:18 [INFO] <AngryRhetoric> yes
2011-02-05 23:33:25 [INFO] <AngryRhetoric> i somehow manifested anti-pumpkins
2011-02-05 23:33:48 [INFO] <redux06790> ???
2011-02-05 23:33:49 [INFO] <AngryRhetoric> only 2 clay tho, next sunrise i'm gonna make the trek back
2011-02-05 23:34:00 [INFO] <redux06790> anti pumpkins?
2011-02-05 23:34:03 [INFO] <AngryRhetoric> i was kidding i found about 15 pumpkins though
2011-02-05 23:34:09 [INFO] <nawf> he said he found 10 - 15 pumpkins
2011-02-05 23:34:09 [INFO] <redux06790> :O
2011-02-05 23:34:11 [INFO] <nawf> so -5
2011-02-05 23:34:31 [INFO] <nawf> I found some the other day too, I just spammed them in the vault so you'd fine them erin
2011-02-05 23:34:38 [INFO] <redux06790> i love using sand in my buildings
2011-02-05 23:34:45 [INFO] <redux06790> yeah i saw those
2011-02-05 23:34:50 [INFO] <AngryRhetoric> hey i found a cool phenomemon
2011-02-05 23:34:50 [INFO] <redux06790> i love pumpkins
2011-02-05 23:34:57 [INFO] <redux06790> the only light blocks you can get right now in smp
2011-02-05 23:35:00 [INFO] <AngryRhetoric> *phenomenon
2011-02-05 23:35:08 [INFO] <redux06790> brb gotta piss
2011-02-05 23:35:10 [INFO] <nawf> whats that?
2011-02-05 23:35:23 [INFO] <AngryRhetoric> if you build a roof out of wooden stairs with no blocks beneath it they don't hinder daylight
2011-02-05 23:35:27 [INFO] <redux06790> when you make ice cream come out of your penis
2011-02-05 23:35:34 [INFO] <AngryRhetoric> haha
2011-02-05 23:35:41 [INFO] <AngryRhetoric> rainbow sherbert
2011-02-05 23:35:48 [INFO] <nawf> thats cool, I didn't know that
2011-02-05 23:36:02 [INFO] <AngryRhetoric> yes it made the house very bright during the day while still having a roof over your head
2011-02-05 23:37:17 [INFO] <redux06790> ahh good piss
2011-02-05 23:37:26 [INFO] <nawf> black sheep, black sheep, have you any wool
2011-02-05 23:37:30 [INFO] <nawf> *punch*
2011-02-05 23:37:32 [INFO] <redux06790> im kinda regretting the crafting table floor
2011-02-05 23:37:37 [INFO] <redux06790> lol
2011-02-05 23:37:59 [INFO] <nawf> I don't like the wood floors in the front wall of the castle, I'm demoralized
2011-02-05 23:38:03 [INFO] <nawf> I have to rip it all down
2011-02-05 23:38:24 [INFO] <redux06790> yeah im ripping out my crafting table floor... who wants 20 crafting tables?
2011-02-05 23:41:26 [INFO] <redux06790> wtf where is my army of livestock?
2011-02-05 23:41:28 [INFO] <AngryRhetoric> you dn't like then?
2011-02-05 23:41:32 [INFO] <AngryRhetoric> *them?
2011-02-05 23:41:32 [INFO] <redux06790> no way
2011-02-05 23:41:35 [INFO] <redux06790> too busy
2011-02-05 23:41:58 [INFO] <AngryRhetoric> well the inside will need to be  nice and open
2011-02-05 23:43:44 [INFO] <redux06790> wtflag?
2011-02-05 23:45:18 [INFO] <redux06790> i hate huge trees
2011-02-05 23:45:28 [INFO] <redux06790> i wish they were all just 5 logs high
2011-02-05 23:47:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-05 23:48:08 [INFO] <AngryRhetoric> ooh another mini-desert
2011-02-05 23:48:37 [INFO] <redux06790> i heart desert biomes
2011-02-05 23:48:38 [INFO] <redux06790> free sand
2011-02-05 23:48:44 [INFO] <AngryRhetoric> there's a tone here
2011-02-05 23:48:47 [INFO] <AngryRhetoric> *ton
2011-02-05 23:49:56 [INFO] <redux06790> i wish notch would make hatch doors
2011-02-05 23:49:58 [INFO] <redux06790> or manholes
2011-02-05 23:50:09 [INFO] <redux06790> and or trap doors
2011-02-05 23:50:21 [INFO] <AngryRhetoric> i saw a youtube on how to make a trap door
2011-02-05 23:50:25 [INFO] <redux06790> like they look KINDA like a block but slightly different
2011-02-05 23:50:41 [INFO] <AngryRhetoric> trap door land mine with tnt and a pressure plate
2011-02-05 23:50:59 [INFO] <redux06790> poppycock
2011-02-05 23:51:05 [INFO] k0n2ad [/24.218.113.229:5717] logged in with entity id 7472856
2011-02-05 23:51:11 [INFO] <AngryRhetoric> haha no way
2011-02-05 23:51:12 [INFO] <redux06790> do this be mike?
2011-02-05 23:51:12 [INFO] <nawf> omg
2011-02-05 23:51:16 [INFO] <nawf> naw, this is dave
2011-02-05 23:51:18 [INFO] <redux06790> o
2011-02-05 23:51:19 [INFO] <AngryRhetoric> konrad!
2011-02-05 23:51:29 [INFO] <k0n2ad> where am i
2011-02-05 23:51:33 [INFO] <redux06790> get this man a diamond pickaxe!
2011-02-05 23:51:36 [INFO] <AngryRhetoric> john conned you into paying the minecraft $$?
2011-02-05 23:52:02 [INFO] <redux06790> dude its better than crack
2011-02-05 23:52:02 [INFO] <nawf> oh no, I think you went invisible
2011-02-05 23:52:05 [INFO] <redux06790> and its a one time fee
2011-02-05 23:52:16 [INFO] <AngryRhetoric> i know haha i'm here for those reasons
2011-02-05 23:52:20 [INFO] <k0n2ad> yea i haven't played since october
2011-02-05 23:52:32 [INFO] <nawf> can you see me konrad?
2011-02-05 23:52:42 [INFO] <k0n2ad> redux = ?, nawf?
2011-02-05 23:52:47 [INFO] <nawf> john
2011-02-05 23:52:48 [INFO] <redux06790> im erin
2011-02-05 23:52:50 [INFO] <AngryRhetoric> kevin
2011-02-05 23:52:55 [INFO] <AngryRhetoric> lol
2011-02-05 23:52:57 [INFO] <k0n2ad> sweet
2011-02-05 23:52:57 [INFO] <nawf> joe is efess
2011-02-05 23:53:03 [INFO] <redux06790> but im a guy
2011-02-05 23:53:07 [INFO] <redux06790> lol
2011-02-05 23:53:10 [INFO] <AngryRhetoric> hah!
2011-02-05 23:53:15 [INFO] <k0n2ad> oh no DARKNESS
2011-02-05 23:53:22 [INFO] <nawf> where are you?
2011-02-05 23:53:22 [INFO] <AngryRhetoric> i'm attacking the darkness
2011-02-05 23:53:32 [INFO] <redux06790> who is konrad? like is he anyone i know john?
2011-02-05 23:53:35 [INFO] <nawf> nope
2011-02-05 23:53:43 [INFO] <nawf> and it should stay that way
2011-02-05 23:53:44 [INFO] <redux06790> damn you and your friends outside my social group!
2011-02-05 23:53:57 [INFO] <AngryRhetoric> the restraining order states...
2011-02-05 23:54:18 [INFO] <nawf> I showed dave and kev my thumb you fucked up
2011-02-05 23:54:25 [INFO] <redux06790> lol
2011-02-05 23:54:28 [INFO] <redux06790> you fucked it up bro
2011-02-05 23:54:33 [INFO] <redux06790> you should know my face is made of steel
2011-02-05 23:54:41 [INFO] <AngryRhetoric> hah
2011-02-05 23:54:47 [INFO] <k0n2ad> where are yall
2011-02-05 23:54:50 [INFO] <nawf> I can't see konrad at all
2011-02-05 23:54:54 [INFO] nawf lost connection: disconnect.quitting
2011-02-05 23:55:09 [INFO] <redux06790> lol
2011-02-05 23:55:18 [INFO] <redux06790> i love the timing of some people leaving sometimes
2011-02-05 23:55:25 [INFO] Disconnecting /76.23.232.27:55052: Took too long to log in
2011-02-05 23:55:38 [INFO] <AngryRhetoric> he's rejoining
2011-02-05 23:55:42 [INFO] <redux06790> lol i know
2011-02-05 23:55:42 [INFO] <k0n2ad> im in castle mcdonnel
2011-02-05 23:55:47 [INFO] <AngryRhetoric> haha you made it there
2011-02-05 23:55:49 [INFO] <AngryRhetoric> nice
2011-02-05 23:55:50 [INFO] <redux06790> im in the northern farm
2011-02-05 23:55:55 [INFO] <redux06790> good luck finding me
2011-02-05 23:56:07 [INFO] <AngryRhetoric> i'm heading towards the mcdonnell hamlet
2011-02-05 23:56:12 [INFO] <AngryRhetoric> on the south side of the castle
2011-02-05 23:56:16 [INFO] Disconnecting nawf [/76.23.232.27:55055]: Took too long to log in
2011-02-05 23:56:31 [INFO] <redux06790> all that planting and i didnt even get two full stacks of wood
2011-02-05 23:56:31 [INFO] Disconnecting nawf [/76.23.232.27:55055]: Failed to verify username!
2011-02-05 23:56:57 [INFO] Disconnecting nawf [/76.23.232.27:55039]: Took too long to log in
2011-02-05 23:56:58 [INFO] <redux06790> FUUUU!
2011-02-05 23:57:02 [INFO] /76.23.232.27:55005 lost connection
2011-02-05 23:57:04 [INFO] <redux06790> i smelted my sand and i needed it lol
2011-02-05 23:57:07 [INFO] /76.23.232.27:55005 lost connection
2011-02-05 23:57:34 [INFO] /76.23.232.27:55012 lost connection
2011-02-05 23:57:47 [INFO] /76.23.232.27:55012 lost connection
2011-02-05 23:57:51 [INFO] <k0n2ad> where is you be kevin
2011-02-05 23:57:54 [INFO] /76.23.232.27:55012 lost connection
2011-02-05 23:58:15 [INFO] <AngryRhetoric> in the village
2011-02-05 23:58:26 [INFO] <AngryRhetoric> yo
2011-02-05 23:58:31 [INFO] <AngryRhetoric> i made a new house
2011-02-05 23:58:41 [INFO] <AngryRhetoric> damn spiders
2011-02-05 23:58:43 [INFO] Disconnecting /76.23.232.27:55016: Took too long to log in
2011-02-05 23:58:47 [INFO] <AngryRhetoric> LOL
2011-02-05 23:58:51 [INFO] <k0n2ad> lol u look fucking gay
2011-02-05 23:58:52 [INFO] <AngryRhetoric> NO penisi in the castle
2011-02-05 23:58:59 [INFO] <AngryRhetoric> i'm armored ;)
2011-02-05 23:59:24 [INFO] Disconnecting nawf [/76.23.232.27:55034]: Took too long to log in
2011-02-05 23:59:26 [INFO] <k0n2ad> wtf u r floating
2011-02-05 23:59:30 [INFO] <AngryRhetoric> i made a new house 2 days' journey to the south
2011-02-05 23:59:33 [INFO] /76.23.232.27:55009 lost connection
2011-02-05 23:59:36 [INFO] <AngryRhetoric> i am?
2011-02-05 23:59:36 [INFO] <redux06790> 2 days!
2011-02-05 23:59:41 [INFO] <redux06790> seriously?
2011-02-05 23:59:42 [INFO] <k0n2ad> yea
2011-02-05 23:59:46 [INFO] <redux06790> thats like 2000 blocks
2011-02-05 23:59:46 [INFO] /76.23.232.27:55046 lost connection
2011-02-05 23:59:48 [INFO] <AngryRhetoric> lol well day and a half
2011-02-06 00:00:03 [INFO] <AngryRhetoric> day and a half to my village
2011-02-06 00:00:03 [INFO] /76.23.232.27:55010 lost connection
2011-02-06 00:00:06 [INFO] <AngryRhetoric> 2 days to the new castle
2011-02-06 00:00:06 [INFO] <k0n2ad> im going to die so i can respawn and start building stuff
2011-02-06 00:00:13 [INFO] /76.23.232.27:55025 lost connection
2011-02-06 00:00:16 [INFO] <AngryRhetoric> why do you have to die to do that?
2011-02-06 00:00:22 [INFO] <k0n2ad> how else
2011-02-06 00:00:28 [INFO] /76.23.232.27:55034 lost connection
2011-02-06 00:00:28 [INFO] <AngryRhetoric> you collect stuff
2011-02-06 00:00:39 [INFO] <k0n2ad> to respawn i mean
2011-02-06 00:00:40 [INFO] <AngryRhetoric> i'll take you to the main base
2011-02-06 00:00:52 [INFO] <redux06790> now which one is actually the main base?
2011-02-06 00:01:04 [INFO] /76.23.232.27:55001 lost connection
2011-02-06 00:01:07 [INFO] <AngryRhetoric> well there's the underground cave base that has all our resources
2011-02-06 00:01:11 [INFO] <k0n2ad> wtf now you are inside the wall
2011-02-06 00:01:16 [INFO] <AngryRhetoric> that's wierd
2011-02-06 00:01:27 [INFO] <AngryRhetoric> still?
2011-02-06 00:01:29 [INFO] <k0n2ad> ok i only have 2 hearts now though
2011-02-06 00:01:44 [INFO] <k0n2ad> ill send u screen shot later
2011-02-06 00:01:44 [INFO] Disconnecting /76.23.232.27:55067: Took too long to log in
2011-02-06 00:01:49 [INFO] <AngryRhetoric> here
2011-02-06 00:01:57 [INFO] <k0n2ad> LOL
2011-02-06 00:01:59 [INFO] <AngryRhetoric> those regain health heh
2011-02-06 00:02:04 [INFO] <k0n2ad> thanks
2011-02-06 00:02:07 [INFO] /76.23.232.27:55003 lost connection
2011-02-06 00:02:12 [INFO] <k0n2ad> for giving me your feces
2011-02-06 00:02:14 [INFO] /76.23.232.27:55003 lost connection
2011-02-06 00:02:20 [INFO] <AngryRhetoric> eaat it
2011-02-06 00:02:33 [INFO] nawf [/76.23.232.27:55007] logged in with entity id 7493974
2011-02-06 00:02:37 [INFO] <AngryRhetoric> ok there's some stuff we'll pick up in the cave base
2011-02-06 00:02:37 [INFO] <redux06790> i knew this was going to happen
2011-02-06 00:02:42 [INFO] <nawf> there we go
2011-02-06 00:02:59 [INFO] <AngryRhetoric> couldn't rejoin?
2011-02-06 00:03:03 [INFO] <nawf> yeah
2011-02-06 00:03:10 [INFO] <nawf> hey konrad, whats your x/y's
2011-02-06 00:03:14 [INFO] <redux06790> i went on a quest for pumpkins and clay and now im stuck homesteading haha
2011-02-06 00:03:20 [INFO] <AngryRhetoric> he's with me going to the cave base
2011-02-06 00:03:23 [INFO] <AngryRhetoric> under the mob spawner
2011-02-06 00:03:24 [INFO] <k0n2ad> whats the button for that screen
2011-02-06 00:03:29 [INFO] <nawf> f3
2011-02-06 00:03:30 [INFO] <k0n2ad> tilda doesnt work
2011-02-06 00:03:36 [INFO] <AngryRhetoric> yeah f3
2011-02-06 00:03:42 [INFO] <k0n2ad> -35 70
2011-02-06 00:03:55 [INFO] <AngryRhetoric> x is north/south y is up/down and z is east/west
2011-02-06 00:04:50 [INFO] <k0n2ad> holy shit
2011-02-06 00:04:54 [INFO] <AngryRhetoric> this is mostly john and joe's work
2011-02-06 00:04:55 [INFO] <AngryRhetoric> down here
2011-02-06 00:04:58 [INFO] <k0n2ad> amazing
2011-02-06 00:05:00 [INFO] <redux06790> well no
2011-02-06 00:05:07 [INFO] <AngryRhetoric> you helped erin?
2011-02-06 00:05:08 [INFO] <AngryRhetoric> my bad
2011-02-06 00:05:08 [INFO] <redux06790> not the aesthetic aspect lol
2011-02-06 00:05:12 [INFO] <AngryRhetoric> haha
2011-02-06 00:05:14 [INFO] <k0n2ad> lol
2011-02-06 00:05:16 [INFO] <redux06790> i made the base look sick
2011-02-06 00:05:20 [INFO] <redux06790> before that it was a cave haha
2011-02-06 00:05:29 [INFO] <k0n2ad> nice touch with the bamboo there erin
2011-02-06 00:05:48 [INFO] <redux06790> yeah you guys have big plans
2011-02-06 00:06:00 [INFO] <redux06790> im just the faggot interior decorator haha
2011-02-06 00:06:07 [INFO] <k0n2ad> wow everything is labeled
2011-02-06 00:06:13 [INFO] <AngryRhetoric> Tthop it
2011-02-06 00:06:16 [INFO] <nawf> wait, what bamboo?
2011-02-06 00:06:25 [INFO] <redux06790> hes talking about the reeds
2011-02-06 00:06:29 [INFO] <redux06790> i didnt do the reeds
2011-02-06 00:06:33 [INFO] <AngryRhetoric> grab a pick axe and axe from the spare tools
2011-02-06 00:06:54 [INFO] <nawf> and get arrows too
2011-02-06 00:07:00 [INFO] <redux06790> for the love of god! 6 sheep!!
2011-02-06 00:07:03 [INFO] <nawf> we have infinite arrows so swords are just dumb
2011-02-06 00:07:21 [INFO] <AngryRhetoric> yeah i got him a bow
2011-02-06 00:07:51 [INFO] <AngryRhetoric> wait which chest has pumpkins?
2011-02-06 00:07:59 [INFO] <nawf> none right now
2011-02-06 00:08:05 [INFO] <nawf> I just spammed these extras up here
2011-02-06 00:08:09 [INFO] <AngryRhetoric> ok they're in miscellaneous
2011-02-06 00:08:55 [INFO] <AngryRhetoric> arrows
2011-02-06 00:09:01 [INFO] <k0n2ad> haha
2011-02-06 00:09:04 [INFO] <k0n2ad> thanks
2011-02-06 00:09:10 [INFO] <nawf> all the mob drops are in here
2011-02-06 00:10:08 [INFO] <redux06790> lol i get it
2011-02-06 00:10:11 [INFO] <redux06790> Tthop it
2011-02-06 00:10:12 [INFO] <redux06790> derp
2011-02-06 00:10:18 [INFO] <AngryRhetoric> hah nice timing
2011-02-06 00:10:23 [INFO] <redux06790> took me like... a million years but...
2011-02-06 00:10:44 [INFO] <k0n2ad> ok im going to run - wanted to check it out, will be back eventually
2011-02-06 00:10:45 [INFO] <nawf> oh sweet, joe has the rails working
2011-02-06 00:10:47 [INFO] <redux06790> my homestead is sexy
2011-02-06 00:10:58 [INFO] <k0n2ad> have to say, amazing
2011-02-06 00:11:05 [INFO] <nawf> did you see the castle yet?
2011-02-06 00:11:12 [INFO] <nawf> or the potential of the castle
2011-02-06 00:11:12 [INFO] <AngryRhetoric> the new one
2011-02-06 00:11:15 [INFO] <nawf> yeah
2011-02-06 00:11:21 [INFO] <k0n2ad> no, ok take me there then i gotta run
2011-02-06 00:11:23 [INFO] <AngryRhetoric> you saw castle mcdonnell
2011-02-06 00:11:24 [INFO] <redux06790> jhaha omg that place is HUGE
2011-02-06 00:11:33 [INFO] <redux06790> that place is almost bigger than my dick
2011-02-06 00:11:34 [INFO] <AngryRhetoric> that's a prototype compared to the new one
2011-02-06 00:11:40 [INFO] <redux06790> awww but you just got here!!!
2011-02-06 00:11:49 [INFO] <k0n2ad> -25 9
2011-02-06 00:12:12 [INFO] <k0n2ad> i know, just wanted to check it out for today
2011-02-06 00:12:35 [INFO] <k0n2ad> will be back later in the week - you going to johns party?
2011-02-06 00:12:37 [INFO] <nawf> kev are you leading him back
2011-02-06 00:12:42 [INFO] <nawf> I took the rail line
2011-02-06 00:12:44 [INFO] <AngryRhetoric> yeah i can take him
2011-02-06 00:12:50 [INFO] <nawf> the rail line works
2011-02-06 00:12:59 [INFO] <nawf> facing out, just put a cart on the pressure plate
2011-02-06 00:12:59 [INFO] <AngryRhetoric> wait to the big castle?
2011-02-06 00:13:04 [INFO] <nawf> well to the spawn base
2011-02-06 00:13:18 [INFO] <nawf> or you could huff it
2011-02-06 00:13:18 [INFO] <AngryRhetoric> oh ok i've never had good luck with it but we can try heh
2011-02-06 00:13:33 [INFO] <nawf> heh, yeah, joe's track killed kevin once
2011-02-06 00:13:46 [INFO] <k0n2ad> lol
2011-02-06 00:13:51 [INFO] <AngryRhetoric> ok right click on it
2011-02-06 00:14:00 [INFO] <AngryRhetoric> hahaha
2011-02-06 00:14:13 [INFO] <k0n2ad> weeeeeeeeeeeee
2011-02-06 00:15:16 [INFO] <AngryRhetoric> i can never self -propel the thing
2011-02-06 00:15:37 [INFO] <k0n2ad> lol
2011-02-06 00:15:45 [INFO] <k0n2ad> john you look like fucking indiana jones
2011-02-06 00:15:48 [INFO] <nawf> yeah
2011-02-06 00:16:00 [INFO] <nawf> we cleard this space
2011-02-06 00:16:06 [INFO] <nawf> and now we are just starting building
2011-02-06 00:16:23 [INFO] <nawf> just half the front here is almost done
2011-02-06 00:16:44 [INFO] <k0n2ad> nice
2011-02-06 00:17:02 [INFO] <nawf> arrow spam lol
2011-02-06 00:17:04 [INFO] <k0n2ad> lol fuicker
2011-02-06 00:17:24 [INFO] <nawf> punch sheep, get wool
2011-02-06 00:17:49 [INFO] <k0n2ad> they are using our castle
2011-02-06 00:18:02 [INFO] <nawf> fuckers
2011-02-06 00:18:06 [INFO] <AngryRhetoric> who is
2011-02-06 00:18:11 [INFO] <k0n2ad> lol
2011-02-06 00:18:11 [INFO] <nawf> well I have to go too
2011-02-06 00:18:11 [INFO] <nawf> skeles
2011-02-06 00:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 00:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 00:18:18 [INFO] <k0n2ad> me too dawgs
2011-02-06 00:18:19 [INFO] <nawf> see you guys tomorrow
2011-02-06 00:18:23 [INFO] <nawf> except for erin
2011-02-06 00:18:25 [INFO] <k0n2ad> see u tomorrow
2011-02-06 00:18:25 [INFO] <redux06790> boo
2011-02-06 00:18:25 [INFO] <AngryRhetoric> later john
2011-02-06 00:18:28 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 00:18:31 [INFO] <nawf> escape the inlaws
2011-02-06 00:18:33 [INFO] <nawf> show up
2011-02-06 00:18:39 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 00:18:40 [INFO] <nawf> be like we have to have a minecraft meeting
2011-02-06 00:18:47 [INFO] <redux06790> its manditory lol
2011-02-06 00:18:51 [INFO] <redux06790> i wish i could escape
2011-02-06 00:18:57 [INFO] <redux06790> ive been cooped up with them all winter
2011-02-06 00:19:02 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-06 00:19:08 [INFO] <nawf> sounds like a job for murder
2011-02-06 00:19:10 [INFO] <AngryRhetoric> that sucks
2011-02-06 00:19:10 [INFO] <nawf> ;)
2011-02-06 00:19:16 [INFO] <AngryRhetoric> it's on the menu
2011-02-06 00:19:43 [INFO] <nawf> anyway, peace
2011-02-06 00:19:45 [INFO] nawf lost connection: disconnect.quitting
2011-02-06 00:19:47 [INFO] <redux06790> what am i gonna call my homestead?
2011-02-06 00:19:58 [INFO] <redux06790> im thinking hullabaloo ranch
2011-02-06 00:20:04 [INFO] <AngryRhetoric> erin's house of sheepfux
2011-02-06 00:20:11 [INFO] <redux06790> just because i wanna here people say ""hes at hullabaloo""
2011-02-06 00:20:13 [INFO] <AngryRhetoric> i like mine better
2011-02-06 00:20:19 [INFO] <redux06790> lol
2011-02-06 00:20:27 [INFO] <AngryRhetoric> yours sounds almost australian
2011-02-06 00:20:30 [INFO] <redux06790> Pigfucker Farms
2011-02-06 00:20:35 [INFO] <AngryRhetoric> haha
2011-02-06 00:20:36 [INFO] <AngryRhetoric> TM
2011-02-06 00:20:45 [INFO] <redux06790> thats totally it
2011-02-06 00:24:04 [INFO] <redux06790> welcome to pigfucker island
2011-02-06 00:24:08 [INFO] <AngryRhetoric> haha
2011-02-06 00:24:17 [INFO] <AngryRhetoric> bacon complimentary
2011-02-06 00:24:22 [INFO] <redux06790> has a nice ring
2011-02-06 00:24:33 [INFO] <AngryRhetoric> lol yes poetic even
2011-02-06 00:24:37 [INFO] <AngryRhetoric> i'm going to my island home
2011-02-06 00:24:44 [INFO] <AngryRhetoric> floating island home
2011-02-06 00:24:49 [INFO] <redux06790> psh
2011-02-06 00:24:52 [INFO] <redux06790> thief
2011-02-06 00:25:07 [INFO] <AngryRhetoric> hey mine's floating !
2011-02-06 00:25:11 [INFO] <redux06790> you burgled my potential home
2011-02-06 00:25:24 [INFO] <AngryRhetoric> you were planning onusing this?
2011-02-06 00:25:27 [INFO] <redux06790> you should make it slightly bigger
2011-02-06 00:25:29 [INFO] <redux06790> yea
2011-02-06 00:25:29 [INFO] <AngryRhetoric> there's actuall 3 islands up here
2011-02-06 00:25:34 [INFO] <redux06790> when i got done making the skull
2011-02-06 00:25:38 [INFO] <AngryRhetoric> could combine them all and fill in the middle
2011-02-06 00:25:41 [INFO] <redux06790> i was going to build a tiny cottage up there
2011-02-06 00:25:44 [INFO] <AngryRhetoric> hah
2011-02-06 00:26:04 [INFO] <redux06790> im going to need ALOOOOOOOOOOOT of fences
2011-02-06 00:26:06 [INFO] <AngryRhetoric> well there's room for more than one tiny cottage up here
2011-02-06 00:26:11 [INFO] <redux06790> because i want to surround my island in them
2011-02-06 00:26:17 [INFO] <AngryRhetoric> to keep the pigs in
2011-02-06 00:26:20 [INFO] <redux06790> yes
2011-02-06 00:26:30 [INFO] <AngryRhetoric> to have them get stuck in the fence ;)
2011-02-06 00:27:28 [INFO] <AngryRhetoric> alright i'm heading out as well
2011-02-06 00:27:32 [INFO] <redux06790> boo
2011-02-06 00:27:36 [INFO] <AngryRhetoric> yeah sorry heh
2011-02-06 00:27:37 [INFO] <redux06790> ill be here alone griefing everything
2011-02-06 00:27:38 [INFO] <AngryRhetoric> been on all day
2011-02-06 00:27:38 [INFO] <redux06790> lol
2011-02-06 00:27:47 [INFO] <AngryRhetoric> hahah
2011-02-06 00:28:03 [INFO] <redux06790> meh i have to stay up since i work third and need to keep my sleep schedule adjusted
2011-02-06 00:28:16 [INFO] <AngryRhetoric> oh yeah you're just getting started haha
2011-02-06 00:28:46 [INFO] <redux06790> anyway have fun with your sleep and all that
2011-02-06 00:29:35 [INFO] <AngryRhetoric> hahah enjoy PigFucker farms!  peace
2011-02-06 00:29:41 [INFO] <redux06790> lol peace
2011-02-06 00:29:47 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-06 00:42:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 00:44:44 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-06 00:45:44 [INFO] redux06790 [/69.119.8.191:52127] logged in with entity id 7567941
2011-02-06 00:45:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 01:00:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 01:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 01:18:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 01:18:27 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 02:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 03:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 03:18:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 03:18:37 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 03:28:06 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 04:18:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 06:18:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 08:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 09:16:39 [INFO] efess [/192.168.0.198:15015] logged in with entity id 7675184
2011-02-06 09:16:46 [INFO] <efess> yo
2011-02-06 09:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 09:18:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 09:54:05 [INFO] nawf [/76.23.232.27:55087] logged in with entity id 7835297
2011-02-06 09:54:09 [INFO] <efess> yoo
2011-02-06 09:54:11 [INFO] <nawf> yo
2011-02-06 09:54:12 [INFO] <efess> did you just msg me
2011-02-06 09:54:15 [INFO] <nawf> yes
2011-02-06 09:54:21 [INFO] <nawf> I figured you may respond better here
2011-02-06 09:54:24 [INFO] <efess> haha
2011-02-06 09:54:27 [INFO] <efess> true.
2011-02-06 09:54:38 [INFO] <nawf> I was wondering if you guys had time to run to the grocery store for me
2011-02-06 09:54:54 [INFO] <efess> yea we have plenty of time
2011-02-06 09:54:55 [INFO] <nawf> I mean later too, not right now or anything
2011-02-06 09:54:56 [INFO] <efess> what do you need
2011-02-06 09:55:11 [INFO] <nawf> a vegetable tray and a bag of ruffles or whatever, those plain chips
2011-02-06 09:55:23 [INFO] <nawf> I have a poor dip to things you can dip ratio
2011-02-06 09:55:27 [INFO] <efess> tk
2011-02-06 09:55:57 [INFO] <nawf> erin and kev went exploring last night
2011-02-06 09:56:04 [INFO] <nawf> kev went as far at x 1700
2011-02-06 09:56:07 [INFO] <efess> oh wow
2011-02-06 09:56:11 [INFO] <nawf> yeah
2011-02-06 09:56:14 [INFO] <efess> now backups will be huge :D
2011-02-06 09:56:27 [INFO] <efess> did they find anything cool?
2011-02-06 09:56:37 [INFO] <nawf> I think kevin did, erin went out too, not sure where he is
2011-02-06 09:56:45 [INFO] <nawf> they have houses out there which is odd
2011-02-06 09:56:49 [INFO] <efess> lol
2011-02-06 09:57:02 [INFO] <efess> they'll need rails!
2011-02-06 09:57:03 [INFO] <nawf> they will  never return :,(
2011-02-06 09:57:12 [INFO] <nawf> lol, 1600 of them for kevin
2011-02-06 09:57:13 [INFO] <efess> you still need platters right?
2011-02-06 09:57:29 [INFO] <nawf> yeah, won't hurt, I bought some bowls and stuff
2011-02-06 09:57:38 [INFO] <nawf> but I know people are bringing more food
2011-02-06 09:57:57 [INFO] <nawf> man, I just want to play minecraft
2011-02-06 09:58:01 [INFO] <efess> ya
2011-02-06 09:58:05 [INFO] <nawf> but I have to clean and bs
2011-02-06 09:58:06 [INFO] <efess> that cave I found
2011-02-06 09:58:09 [INFO] <nawf> screw this, party is cancelled
2011-02-06 09:58:10 [INFO] <efess> to the left of the end of the tracks
2011-02-06 09:58:14 [INFO] <efess> I found more
2011-02-06 09:58:16 [INFO] <nawf> nice
2011-02-06 09:58:23 [INFO] <efess> so just collecting some coal
2011-02-06 09:58:27 [INFO] <efess> since it seems like we ran out
2011-02-06 09:58:40 [INFO] <efess> so are you going to randomly come down and photo bomb
2011-02-06 09:58:41 [INFO] <efess> us
2011-02-06 09:58:44 [INFO] <nawf> yeah, we only had 2 stacks left and I had erin bring them here for torches and smoothstone
2011-02-06 09:58:56 [INFO] <nawf> I was thinking about it
2011-02-06 09:58:58 [INFO] <efess> haha
2011-02-06 09:59:00 [INFO] <nawf> just send me the address
2011-02-06 09:59:05 [INFO] <efess> yea that'll suck if they stay 1700 blocks away
2011-02-06 09:59:17 [INFO] <efess> then it'll just be like they're on their own server
2011-02-06 09:59:22 [INFO] <nawf> yeah right?
2011-02-06 09:59:41 [INFO] <nawf> I just want to use up resources and then spunk, I haven't spunked in forever
2011-02-06 10:00:02 [INFO] <efess> lets just buy copies of minecraft for everyone
2011-02-06 10:00:03 [INFO] <efess> at the party
2011-02-06 10:00:06 [INFO] <efess> and tell them to bring laptops
2011-02-06 10:00:10 [INFO] <nawf> yeah, lol
2011-02-06 10:00:25 [INFO] <efess> we'll have that castle done in notime
2011-02-06 10:01:46 [INFO] <nawf> I need a useless superbowl trivia question
2011-02-06 10:02:01 [INFO] <efess> ?
2011-02-06 10:05:23 [INFO] <nawf> alright, I gotta get back to it, what time are you guys coming over?
2011-02-06 10:05:37 [INFO] <efess> ugh we're dropping things off around 12:15-30
2011-02-06 10:05:50 [INFO] <efess> then the pictures should be what a few hours maybe
2011-02-06 10:06:02 [INFO] <efess> we can come over and help w/ w/e
2011-02-06 10:06:02 [INFO] <nawf> dunno
2011-02-06 10:06:19 [INFO] <nawf> or we can just play minecraft
2011-02-06 10:06:20 [INFO] <nawf> lol
2011-02-06 10:06:21 [INFO] <efess> ya
2011-02-06 10:06:23 [INFO] <nawf> ttyl, see yah
2011-02-06 10:06:25 [INFO] <efess> l8r
2011-02-06 10:06:28 [INFO] nawf lost connection: disconnect.genericReason
2011-02-06 10:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 10:18:31 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 11:21:12 [INFO] efess lost connection: disconnect.quitting
2011-02-06 12:18:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 12:18:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 14:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 14:18:28 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 16:15:51 [INFO] redux06790 [/69.119.8.191:49454] logged in with entity id 7898680
2011-02-06 16:15:58 [INFO] <redux06790> Marco!
2011-02-06 16:18:21 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 16:27:08 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 17:18:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:08:34 [INFO] redux06790 [/69.119.8.191:49512] logged in with entity id 7911148
2011-02-06 18:08:41 [INFO] <redux06790> back to mining
2011-02-06 18:09:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:11:10 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 18:11:13 [INFO] redux06790 [/69.119.8.191:49519] logged in with entity id 7917560
2011-02-06 18:11:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:17:12 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 18:17:15 [INFO] redux06790 [/69.119.8.191:49523] logged in with entity id 7944370
2011-02-06 18:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:18:09 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-06 18:18:21 [INFO] redux06790 [/69.119.8.191:49528] logged in with entity id 7949382
2011-02-06 18:18:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:22:23 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 18:22:25 [INFO] redux06790 [/69.119.8.191:49531] logged in with entity id 8027295
2011-02-06 18:27:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:28:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:31:39 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-06 18:31:47 [INFO] redux06790 [/69.119.8.191:49540] logged in with entity id 8052114
2011-02-06 18:31:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 18:37:57 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 18:42:42 [INFO] redux06790 [/69.119.8.191:49543] logged in with entity id 8064237
2011-02-06 19:03:30 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 19:09:06 [INFO] redux06790 [/69.119.8.191:49557] logged in with entity id 8083132
2011-02-06 19:09:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 19:09:10 [INFO] <redux06790> hurrr
2011-02-06 20:32:35 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 20:32:38 [INFO] redux06790 [/69.119.8.191:49574] logged in with entity id 8159605
2011-02-06 20:55:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-06 20:55:19 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-06 21:18:09 [INFO] redux06790 [/69.119.8.191:49603] logged in with entity id 8181192
2011-02-06 21:18:26 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-07 08:19:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 09:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 09:19:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 10:18:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 11:18:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 12:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 13:18:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 14:18:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 14:18:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 15:18:21 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 16:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 17:00:10 [INFO] redux06790 [/69.119.8.191:49172] logged in with entity id 8181833
2011-02-07 17:00:17 [INFO] <redux06790> oh yeah i died
2011-02-07 17:00:19 [INFO] <redux06790> damn
2011-02-07 17:05:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 17:07:07 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-07 17:07:20 [INFO] redux06790 [/69.119.8.191:49180] logged in with entity id 8221264
2011-02-07 17:13:13 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-07 17:13:16 [INFO] redux06790 [/69.119.8.191:49185] logged in with entity id 8235858
2011-02-07 17:14:23 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-07 17:14:33 [INFO] redux06790 [/69.119.8.191:49190] logged in with entity id 8236622
2011-02-07 17:18:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 17:19:28 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-07 17:26:04 [INFO] redux06790 [/69.119.8.191:49195] logged in with entity id 8239440
2011-02-07 17:29:37 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-07 17:56:35 [INFO] AngryRhetoric [/24.147.183.4:49647] logged in with entity id 8240121
2011-02-07 17:56:54 [INFO] <AngryRhetoric> yo!
2011-02-07 18:02:02 [INFO] <AngryRhetoric> afk
2011-02-07 18:03:13 [INFO] AngryRhetoric lost connection: disconnect.genericReason
2011-02-07 18:11:02 [INFO] AngryRhetoric [/24.147.183.4:50195] logged in with entity id 8248553
2011-02-07 18:18:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 18:18:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 18:22:57 [INFO] redux06790 [/69.119.8.191:49230] logged in with entity id 8259704
2011-02-07 18:25:00 [INFO] <AngryRhetoric> sup Erin!
2011-02-07 18:25:05 [INFO] <redux06790> oh hai!
2011-02-07 18:25:09 [INFO] <redux06790> didnt think anyone was on
2011-02-07 18:25:38 [INFO] <redux06790> im currently filling in my mob spawner
2011-02-07 18:25:41 [INFO] <redux06790> and trying again
2011-02-07 18:25:50 [INFO] <AngryRhetoric> you made one near your farm?
2011-02-07 18:25:55 [INFO] <redux06790> under
2011-02-07 18:25:55 [INFO] <redux06790> yea
2011-02-07 18:26:00 [INFO] <redux06790> its not going to be high yeild
2011-02-07 18:26:04 [INFO] <redux06790> but it doesnt need to be
2011-02-07 18:26:11 [INFO] <AngryRhetoric> exactly
2011-02-07 18:27:23 [INFO] <redux06790> just a little something so i can get some gunpowder and such if i need it
2011-02-07 18:27:40 [INFO] <redux06790> anyone else on?
2011-02-07 18:27:46 [INFO] <AngryRhetoric> we got a ton of that here tho, you could export haha
2011-02-07 18:27:50 [INFO] <AngryRhetoric> nope just me
2011-02-07 18:27:54 [INFO] <redux06790> ahh
2011-02-07 18:27:56 [INFO] <redux06790> i was gonna say
2011-02-07 18:28:08 [INFO] <redux06790> i think there is too much focus on the mob spawner to be honest
2011-02-07 18:28:25 [INFO] <redux06790> i mean its nice to have
2011-02-07 18:28:27 [INFO] <AngryRhetoric> the big one?
2011-02-07 18:28:31 [INFO] <redux06790> yeah
2011-02-07 18:28:42 [INFO] <AngryRhetoric> that was the focus when i first joined but we've moved on to other projects...
2011-02-07 18:28:58 [INFO] <redux06790> my current project is this island
2011-02-07 18:29:05 [INFO] <redux06790> i want it to be fully self sustaining when its done
2011-02-07 18:29:11 [INFO] <redux06790> the only quandry im having
2011-02-07 18:29:14 [INFO] <redux06790> flowers...
2011-02-07 18:29:18 [INFO] <redux06790> you cant grow them
2011-02-07 18:29:30 [INFO] <AngryRhetoric> haha you need them or have too many
2011-02-07 18:29:30 [INFO] <AngryRhetoric> oh
2011-02-07 18:29:45 [INFO] <redux06790> and snow...
2011-02-07 18:29:56 [INFO] <redux06790> and pumpkins...
2011-02-07 18:30:05 [INFO] <redux06790> there is some stuff youll just have to leave for
2011-02-07 18:30:40 [INFO] <AngryRhetoric> whoa LAG
2011-02-07 18:30:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 18:30:55 [INFO] <redux06790> BUT when im done im thinking of ""doming"" the island with glass
2011-02-07 18:31:40 [INFO] AngryRhetoric lost connection: disconnect.timeout
2011-02-07 18:32:05 [INFO] AngryRhetoric [/24.147.183.4:50972] logged in with entity id 8272702
2011-02-07 18:32:15 [INFO] <AngryRhetoric> got booted
2011-02-07 18:32:18 [INFO] <redux06790> figured
2011-02-07 18:32:29 [INFO] <AngryRhetoric> and that's awesome, you can have your own biodome
2011-02-07 18:32:34 [INFO] <redux06790> yeah
2011-02-07 18:32:41 [INFO] <redux06790> ive decided on an actual name too
2011-02-07 18:32:48 [INFO] <redux06790> The Island of Plenty
2011-02-07 18:33:31 [INFO] <redux06790> dude when you see the place again youll be like... woah
2011-02-07 18:33:47 [INFO] <AngryRhetoric> haha big changes?
2011-02-07 18:33:50 [INFO] <redux06790> yeah
2011-02-07 18:34:02 [INFO] <AngryRhetoric> what were the coords again? i'll write them down this time
2011-02-07 18:34:16 [INFO] <redux06790> let me get topside to the front door
2011-02-07 18:34:39 [INFO] <redux06790> i still have to build a boat dock
2011-02-07 18:34:45 [INFO] <AngryRhetoric> hah coool
2011-02-07 18:34:47 [INFO] <redux06790> and make a channel to boat here on
2011-02-07 18:34:50 [INFO] <AngryRhetoric> i'm doing the big ass castle floor
2011-02-07 18:35:02 [INFO] <redux06790> i need to buy graph paper
2011-02-07 18:35:12 [INFO] <redux06790> to do concept work with
2011-02-07 18:35:23 [INFO] <AngryRhetoric> interesting, not a bad idea
2011-02-07 18:35:26 [INFO] <redux06790> i have a schematic for skulls on graph paper
2011-02-07 18:35:33 [INFO] <redux06790> thats how i built that tower so fast
2011-02-07 18:35:41 [INFO] <AngryRhetoric> i do my drafting in game with dirt blocks and measure out diff areas
2011-02-07 18:35:41 [INFO] <redux06790> coords are
2011-02-07 18:35:48 [INFO] <redux06790> -1179 C
2011-02-07 18:35:49 [INFO] <redux06790> err
2011-02-07 18:35:55 [INFO] <redux06790> -1179 X
2011-02-07 18:36:06 [INFO] <redux06790> 226 Z
2011-02-07 18:36:18 [INFO] <AngryRhetoric> nice thx
2011-02-07 18:36:29 [INFO] <redux06790> So -X is north +X is south right?
2011-02-07 18:38:01 [INFO] <redux06790> lol when my branch mine is done, and my mob spawner is built im going to fill all the branches of my
2011-02-07 18:38:08 [INFO] <redux06790> mine with TNT
2011-02-07 18:38:12 [INFO] <redux06790> and blow it to kingdom come
2011-02-07 18:38:26 [INFO] <redux06790> and make an awesome underground forest
2011-02-07 18:38:41 [INFO] <AngryRhetoric> yes +X is south
2011-02-07 18:38:58 [INFO] <AngryRhetoric> hahah nice and we have tons of TNT here as well
2011-02-07 18:39:06 [INFO] <redux06790> yeah
2011-02-07 18:39:10 [INFO] <redux06790> im going to be like a bandit
2011-02-07 18:39:19 [INFO] <redux06790> come out to the base and raid it every so often
2011-02-07 18:39:43 [INFO] <AngryRhetoric> there's so much stuff here i've done that too
2011-02-07 18:40:09 [INFO] <redux06790> you wouldnt believe how much iron ive gotten from this tiny mine i have
2011-02-07 18:40:31 [INFO] <AngryRhetoric> that and coal have been highly coveted
2011-02-07 18:40:41 [INFO] <redux06790> i have mountains of coal
2011-02-07 18:40:48 [INFO] <redux06790> ok not mountains
2011-02-07 18:40:50 [INFO] <redux06790> but like 6 stacks
2011-02-07 18:40:54 [INFO] <AngryRhetoric> wow nice
2011-02-07 18:41:44 [INFO] <redux06790> yeah and what i have will last me a dogs age
2011-02-07 18:42:00 [INFO] <AngryRhetoric> you could add a gazillion torches
2011-02-07 18:42:16 [INFO] <redux06790> i cant wait for notch to add the nether to SMP
2011-02-07 18:42:24 [INFO] <redux06790> so i can get mountains of lighstone
2011-02-07 18:42:48 [INFO] <AngryRhetoric> is that the red stuff?
2011-02-07 18:42:57 [INFO] <redux06790> thats the golden bricks that glow
2011-02-07 18:43:43 [INFO] <redux06790> when you break a lightstone you get 1 lightstone dust
2011-02-07 18:43:51 [INFO] <redux06790> 9 dust makes one lightstone brick
2011-02-07 18:44:00 [INFO] <redux06790> the bricks glow like a torch
2011-02-07 18:44:11 [INFO] <AngryRhetoric> oh coool
2011-02-07 18:44:16 [INFO] <AngryRhetoric> radioactive building
2011-02-07 18:44:27 [INFO] <redux06790> its very useful for recessed lighting
2011-02-07 18:44:59 [INFO] <redux06790> you wouldnt happen to know how far away mobs spawn do you/
2011-02-07 18:45:03 [INFO] <redux06790> isnt it like 24 blocks?
2011-02-07 18:45:20 [INFO] <AngryRhetoric> i don't know off hand sorry
2011-02-07 18:45:23 [INFO] <AngryRhetoric> but that sounds right haha
2011-02-07 18:46:33 [INFO] <redux06790> i just know there is a certain bubble around every player
2011-02-07 18:46:39 [INFO] <redux06790> that hostile mobs wont spawn in
2011-02-07 18:47:04 [INFO] <redux06790> so if we were all to go into the spawner and stand around in pitch black it wouldnt work
2011-02-07 18:48:05 [INFO] <AngryRhetoric> but the spawner's big enough that they'll spawn nearby and you'll get raped
2011-02-07 18:48:11 [INFO] <AngryRhetoric> haha that thing is awful in there
2011-02-07 18:48:31 [INFO] <redux06790> its the place where nightmares are born
2011-02-07 18:49:17 [INFO] <AngryRhetoric> yes, en masse
2011-02-07 18:50:18 [INFO] <redux06790> idk why the hell im filling in this spawner instead of lighting it with torches and trying again in
2011-02-07 18:50:23 [INFO] <redux06790> a different direction
2011-02-07 18:50:41 [INFO] <AngryRhetoric> yeah best to torch everything until you're done haha
2011-02-07 18:50:52 [INFO] <redux06790> well
2011-02-07 18:51:00 [INFO] <AngryRhetoric> PigFucker Farms Mob Spawner (PFMS) haha
2011-02-07 18:51:00 [INFO] <redux06790> my first attempt has been an epic failure
2011-02-07 18:51:20 [INFO] <AngryRhetoric> \the other reason the mob spawner works so well is its above water
2011-02-07 18:51:28 [INFO] <AngryRhetoric> its the only spot mobs Can spawn
2011-02-07 18:51:44 [INFO] <redux06790> see im applying that logic to bedrock
2011-02-07 18:51:59 [INFO] <redux06790> there are like no caves in the bottom 10 layers or so
2011-02-07 18:52:00 [INFO] <redux06790> so...
2011-02-07 18:52:29 [INFO] <redux06790> that and i dont want to build a sky spawner since more or less its an eyesore
2011-02-07 18:52:36 [INFO] <AngryRhetoric> might work but if it were me i'd build above the water near the island, not too near tho
2011-02-07 18:52:49 [INFO] <redux06790> well
2011-02-07 18:52:53 [INFO] <redux06790> my spawner worked
2011-02-07 18:52:56 [INFO] <redux06790> its just that
2011-02-07 18:53:02 [INFO] <redux06790> if you wanted to stand in the collection point
2011-02-07 18:53:12 [INFO] <redux06790> no mobs would spawn because you were to close to the rooms
2011-02-07 18:53:41 [INFO] <AngryRhetoric> ahh yeah you need a water chute
2011-02-07 18:54:00 [INFO] <redux06790> but ive scribbled out a new design
2011-02-07 18:54:16 [INFO] <redux06790> that i think will be (in borat voice) ""Much success""
2011-02-07 18:54:33 [INFO] <AngryRhetoric> hahaha
2011-02-07 18:54:37 [INFO] <AngryRhetoric> for Greaat success
2011-02-07 18:55:03 [INFO] <redux06790> is it bad that my misc box is labeled ""The Niggerbox""?
2011-02-07 18:55:28 [INFO] <AngryRhetoric> LOL
2011-02-07 18:55:48 [INFO] <redux06790> i have the wood box
2011-02-07 18:55:51 [INFO] <redux06790> the stone box
2011-02-07 18:55:52 [INFO] <AngryRhetoric> is that cuz its a brown box? haha
2011-02-07 18:55:54 [INFO] <redux06790> ore and minerals
2011-02-07 18:55:59 [INFO] <redux06790> food and drink
2011-02-07 18:56:04 [INFO] <redux06790> and the nigger box
2011-02-07 18:56:10 [INFO] <AngryRhetoric> haha
2011-02-07 18:56:13 [INFO] <redux06790> i just thought it was funny
2011-02-07 18:56:21 [INFO] <redux06790> to have this nice serene island paradise
2011-02-07 18:56:21 [INFO] <AngryRhetoric> that will be the FIRST box people look in
2011-02-07 18:56:28 [INFO] <AngryRhetoric> wait wait
2011-02-07 18:56:33 [INFO] <redux06790> with a blatantly racist label somewhere
2011-02-07 18:56:36 [INFO] <AngryRhetoric> i've got a better idea (from pulp fiction)
2011-02-07 18:56:49 [INFO] <AngryRhetoric> it should read ""Dead Nigger Storage""
2011-02-07 18:56:52 [INFO] <redux06790> hahaha
2011-02-07 18:56:54 [INFO] <redux06790> omg
2011-02-07 18:56:59 [INFO] <AngryRhetoric> am i right?? lol
2011-02-07 18:57:03 [INFO] <redux06790> yeah
2011-02-07 18:57:16 [INFO] <AngryRhetoric> do you see a sign, outside my house that says Dead Nigger Storage???
2011-02-07 18:57:21 [INFO] <redux06790> haha
2011-02-07 18:57:29 [INFO] <redux06790> such an awesome movie
2011-02-07 18:57:35 [INFO] <redux06790> i edited it once
2011-02-07 18:57:39 [INFO] <redux06790> so it was in order
2011-02-07 18:57:44 [INFO] <redux06790> it wasnt as awesome that way
2011-02-07 18:57:55 [INFO] <AngryRhetoric> great movie, what'd you do edit it on the pc?
2011-02-07 18:58:06 [INFO] <redux06790> no this was back in high school
2011-02-07 18:58:13 [INFO] <redux06790> me and my friend mark did it with VCRs
2011-02-07 18:58:16 [INFO] <redux06790> haha
2011-02-07 18:58:27 [INFO] <redux06790> took all afternoon
2011-02-07 18:58:27 [INFO] <AngryRhetoric> that's pretty good yeah its nice when its sorta out of order
2011-02-07 19:00:57 [INFO] <redux06790> who was it on here that loves cave exploring?
2011-02-07 19:01:07 [INFO] <AngryRhetoric> john maybe?
2011-02-07 19:01:15 [INFO] <redux06790> there is a massive cave here
2011-02-07 19:01:19 [INFO] /76.23.232.27:55046 lost connection
2011-02-07 19:01:21 [INFO] <redux06790> and i dont feel like charting it with torches
2011-02-07 19:01:34 [INFO] <AngryRhetoric> so easy to get lost
2011-02-07 19:01:35 [INFO] <redux06790> even though every time i find a cave i get 2 stacks of iron minimum
2011-02-07 19:01:49 [INFO] <redux06790> and like 6 stacks of coal
2011-02-07 19:01:59 [INFO] nawf [/76.23.232.27:55007] logged in with entity id 8304625
2011-02-07 19:02:07 [INFO] <AngryRhetoric> sup john!
2011-02-07 19:02:09 [INFO] <nawf> yo
2011-02-07 19:02:18 [INFO] <redux06790> john my island paradise is awesome
2011-02-07 19:02:20 [INFO] <redux06790> also
2011-02-07 19:02:26 [INFO] <redux06790> was it you that likes exploring caves?
2011-02-07 19:02:48 [INFO] <nawf> who doesn't?
2011-02-07 19:02:51 [INFO] <redux06790> me
2011-02-07 19:03:03 [INFO] <redux06790> and i have a massive cave system down here that needs exploring
2011-02-07 19:03:14 [INFO] <nawf> if its not explored then you don't know its massive
2011-02-07 19:03:25 [INFO] <AngryRhetoric> dam laag
2011-02-07 19:03:25 [INFO] <redux06790> well its pretty big
2011-02-07 19:03:31 [INFO] <nawf> how do you know?
2011-02-07 19:03:37 [INFO] <redux06790> i did a quick run through in the dark because i was out of torches
2011-02-07 19:03:51 [INFO] <redux06790> got hopelessly lost
2011-02-07 19:03:52 [INFO] <nawf> so you can quickly run through a ""massive"" cave
2011-02-07 19:03:54 [INFO] <redux06790> killed by shit
2011-02-07 19:03:59 [INFO] <redux06790> lost my gear
2011-02-07 19:04:02 [INFO] <redux06790> and said fuck it
2011-02-07 19:04:46 [INFO] <redux06790> plus
2011-02-07 19:04:55 [INFO] <redux06790> ive never actually seen a small cave system
2011-02-07 19:05:17 [INFO] <nawf> you make no sense
2011-02-07 19:05:24 [INFO] <redux06790> i make plenty of sense
2011-02-07 19:05:30 [INFO] <redux06790> you make no listen
2011-02-07 19:05:35 [INFO] <AngryRhetoric> lol oh boy
2011-02-07 19:05:42 [INFO] <nawf> because you cannot say something is massive if you haven't explored it
2011-02-07 19:05:47 [INFO] <AngryRhetoric> fuc%%) shift!!
2011-02-07 19:05:51 [INFO] <nawf> you said you ""quickly"" ran through it
2011-02-07 19:05:59 [INFO] <AngryRhetoric> i just got hit by a creeper at the spawn point
2011-02-07 19:06:03 [INFO] <nawf> and you don't know how to compare it to a small cave
2011-02-07 19:06:04 [INFO] <redux06790> *sigh*
2011-02-07 19:06:20 [INFO] <redux06790> trollface.jpg? trollface.jpg...
2011-02-07 19:06:46 [INFO] <redux06790> youre splitting hairs
2011-02-07 19:06:48 [INFO] <redux06790> point is
2011-02-07 19:06:51 [INFO] <redux06790> theres a cave down here
2011-02-07 19:06:53 [INFO] <redux06790> its big
2011-02-07 19:06:58 [INFO] <nawf> you don't know that
2011-02-07 19:07:05 [INFO] <redux06790> sure i do
2011-02-07 19:07:11 [INFO] <redux06790> i have mystical cave predicting powers
2011-02-07 19:08:41 [INFO] <redux06790> also
2011-02-07 19:08:49 [INFO] <redux06790> there are a few lapiz down here
2011-02-07 19:09:00 [INFO] <redux06790> which is nice
2011-02-07 19:09:05 [INFO] <redux06790> are they still bugged?
2011-02-07 19:09:08 [INFO] <nawf> yeah
2011-02-07 19:09:13 [INFO] <redux06790> ...
2011-02-07 19:09:19 [INFO] <redux06790> damn notch taking vacation
2011-02-07 19:10:19 [INFO] <redux06790> are you like me when you explore a cave/
2011-02-07 19:10:27 [INFO] <redux06790> you only bring iron tools?
2011-02-07 19:10:53 [INFO] <AngryRhetoric> iron tools and a lot of torches
2011-02-07 19:10:57 [INFO] <AngryRhetoric> and preferrably armor heh
2011-02-07 19:11:01 [INFO] <redux06790> lol me too
2011-02-07 19:11:03 [INFO] <nawf> naw, I'll bring diamond, I'm an expert spunker
2011-02-07 19:11:07 [INFO] <redux06790> that way if i die i can say fuck it
2011-02-07 19:11:15 [INFO] <redux06790> and not have to worry about losing my diamond tools
2011-02-07 19:11:38 [INFO] <redux06790> that like while ive been working on my brance mine ive been raped by lava twice
2011-02-07 19:11:46 [INFO] <redux06790> and lost my tools both times haha
2011-02-07 19:12:01 [INFO] <AngryRhetoric> spunker!
2011-02-07 19:12:05 [INFO] <AngryRhetoric> haha or spelunker
2011-02-07 19:12:06 [INFO] <redux06790> haha
2011-02-07 19:13:44 [INFO] <redux06790> how much TNT we have stored?
2011-02-07 19:13:51 [INFO] <nawf> hey kev, did konrad bring melissa home?
2011-02-07 19:14:01 [INFO] <nawf> I think 192 tnt
2011-02-07 19:14:11 [INFO] <AngryRhetoric> yeah he did bring, i asked about them today
2011-02-07 19:14:24 [INFO] <AngryRhetoric> apparently they droped will.i.am off and then went to his place to fool around lol
2011-02-07 19:14:53 [INFO] <AngryRhetoric> but he's not into her, she's a bit what's the term, needy and asked lots of questions heh
2011-02-07 19:14:59 [INFO] <nawf> heh, well fool around could mean finger painting
2011-02-07 19:15:04 [INFO] <AngryRhetoric> not his type i guess
2011-02-07 19:15:05 [INFO] <AngryRhetoric> LOL
2011-02-07 19:15:06 [INFO] <AngryRhetoric> yes
2011-02-07 19:15:07 [INFO] <redux06790> sigh... sometimes i miss my days of being a cocksman
2011-02-07 19:15:09 [INFO] <redux06790> hahaha
2011-02-07 19:15:11 [INFO] <redux06790> fingerpainting
2011-02-07 19:15:16 [INFO] <AngryRhetoric> they read dolstoyevsky (sic) that was their fooling around
2011-02-07 19:15:24 [INFO] <nawf> rofl, yeah
2011-02-07 19:15:38 [INFO] <nawf> I was a bit off put on how she followed him outside
2011-02-07 19:15:48 [INFO] <nawf> or was staring at him from my front door
2011-02-07 19:15:50 [INFO] <nawf> that was weird
2011-02-07 19:15:55 [INFO] <redux06790> what is (sic) ive seen it a bunch of time?
2011-02-07 19:16:11 [INFO] <AngryRhetoric> wait i was doing that too, wer eyou put off by me?
2011-02-07 19:16:20 [INFO] <redux06790> haha
2011-02-07 19:16:24 [INFO] <AngryRhetoric> (sic) meaning spelling incorrect i think
2011-02-07 19:16:26 [INFO] <nawf> a little
2011-02-07 19:16:42 [INFO] <redux06790> you guys suck i wish i wasnt stuck with my inlaws yesterday
2011-02-07 19:16:43 [INFO] <redux06790> lol
2011-02-07 19:16:53 [INFO] <AngryRhetoric> yeah the party was awesome
2011-02-07 19:17:13 [INFO] <redux06790> were there naked titties at any point?
2011-02-07 19:17:18 [INFO] <redux06790> naked FEMALE titties?
2011-02-07 19:17:19 [INFO] <nawf> just jacks
2011-02-07 19:17:21 [INFO] <AngryRhetoric> yes, jack lotko's
2011-02-07 19:17:26 [INFO] <AngryRhetoric> darn you prefaced it
2011-02-07 19:17:42 [INFO] <nawf> there are two things I'm fast at
2011-02-07 19:17:44 [INFO] <nawf> typing
2011-02-07 19:17:45 [INFO] <nawf> and sex
2011-02-07 19:17:48 [INFO] <redux06790> haha
2011-02-07 19:18:03 [INFO] <redux06790> baby...
2011-02-07 19:18:07 [INFO] <redux06790> my couch pulls out
2011-02-07 19:18:10 [INFO] <redux06790> but i dont...
2011-02-07 19:18:41 [INFO] <redux06790> or are we not doing akward pickup lines?
2011-02-07 19:18:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 19:19:04 [INFO] <nawf> no I was being serious
2011-02-07 19:19:20 [INFO] <redux06790> lol dude ive been with the same woman so long now
2011-02-07 19:19:32 [INFO] <redux06790> that having sex takes at least an hour
2011-02-07 19:19:35 [INFO] <AngryRhetoric> LOL
2011-02-07 19:19:47 [INFO] <redux06790> if i were with someone new, i would probably prematurely ejeculate
2011-02-07 19:20:06 [INFO] <nawf> I never think of it as premature, just efficient
2011-02-07 19:20:11 [INFO] <redux06790> hahaha
2011-02-07 19:20:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 19:20:12 [INFO] <AngryRhetoric> stand-up comedian line: My cock died can i bury it in you?
2011-02-07 19:20:43 [INFO] <redux06790> baby... i excel at ejaculatory efficiency
2011-02-07 19:21:33 [INFO] <redux06790> so guys
2011-02-07 19:21:35 [INFO] <redux06790> question
2011-02-07 19:21:41 [INFO] <redux06790> sandstone...
2011-02-07 19:21:47 [INFO] <redux06790> what should we build out of it?
2011-02-07 19:22:02 [INFO] <AngryRhetoric> sandstone?
2011-02-07 19:22:05 [INFO] <redux06790> yeah
2011-02-07 19:22:08 [INFO] <redux06790> you know...
2011-02-07 19:22:09 [INFO] <AngryRhetoric> you mean sand?
2011-02-07 19:22:11 [INFO] <redux06790> stone
2011-02-07 19:22:13 [INFO] <redux06790> made from sand
2011-02-07 19:22:18 [INFO] <redux06790> no i mean sandstone
2011-02-07 19:22:18 [INFO] <AngryRhetoric> whoa whoa whoa
2011-02-07 19:22:24 [INFO] <redux06790> do any of you read the patch notes?
2011-02-07 19:22:31 [INFO] <AngryRhetoric> no maam
2011-02-07 19:22:37 [INFO] <redux06790> 4 sand makes a sandstone block
2011-02-07 19:22:38 [INFO] <nawf> I knew it, there are a couple pieces floating around someplace
2011-02-07 19:22:46 [INFO] <AngryRhetoric> is that new??
2011-02-07 19:22:51 [INFO] <redux06790> yes last patch
2011-02-07 19:22:59 [INFO] <redux06790> like two weeks ago
2011-02-07 19:23:07 [INFO] <redux06790> wait
2011-02-07 19:23:13 [INFO] <redux06790> that came out with the note blocks didnt it?
2011-02-07 19:23:58 [INFO] <nawf> yeah
2011-02-07 19:24:25 [INFO] <redux06790> oh john
2011-02-07 19:24:29 [INFO] <nawf> oh erik
2011-02-07 19:24:29 [INFO] <redux06790> you would know the particulars
2011-02-07 19:24:30 [INFO] <AngryRhetoric> sandstone!! cool
2011-02-07 19:24:30 [INFO] <nawf> more
2011-02-07 19:24:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 19:24:42 [INFO] <nawf> er, I mean erin
2011-02-07 19:24:50 [INFO] <nawf> I only know generalizations
2011-02-07 19:24:50 [INFO] <redux06790> how many levels of light are needed to prevent mob spawning
2011-02-07 19:24:56 [INFO] <nawf> 9?
2011-02-07 19:25:04 [INFO] <redux06790> and how big is the bubble around the player that prevents mob spawning?
2011-02-07 19:25:04 [INFO] <nawf> yeah
2011-02-07 19:25:11 [INFO] <nawf> 24 blcoks
2011-02-07 19:25:11 [INFO] <redux06790> i thought it was 24 blocks?
2011-02-07 19:25:16 [INFO] <redux06790> k
2011-02-07 19:25:58 [INFO] <redux06790> because im going to build a low yield small footprint mob spawner at some point
2011-02-07 19:26:17 [INFO] <nawf> that seems redundant but whatever
2011-02-07 19:26:22 [INFO] <redux06790> well
2011-02-07 19:26:40 [INFO] <redux06790> my island paradise is like 1500 blocks away
2011-02-07 19:30:24 [INFO] <redux06790> booo
2011-02-07 19:30:29 [INFO] <redux06790> no diamonds in this branch
2011-02-07 19:30:44 [INFO] <AngryRhetoric> we should build a rail path to it haha
2011-02-07 19:30:53 [INFO] <AngryRhetoric> the minecraft chunnel
2011-02-07 19:30:54 [INFO] <redux06790> my branch mine?
2011-02-07 19:31:03 [INFO] <AngryRhetoric> no PFF
2011-02-07 19:31:15 [INFO] <AngryRhetoric> Pig Fucker Farms for the uneducated
2011-02-07 19:31:46 [INFO] <redux06790> i need to get the Z of the railway at the grinder base
2011-02-07 19:31:56 [INFO] <redux06790> so i can tunnel straight to it
2011-02-07 19:33:06 [INFO] <redux06790> this is going to be a gargantuan cave after i blow it all up haha
2011-02-07 19:33:10 [INFO] <redux06790> beb daddy duty
2011-02-07 19:33:14 [INFO] <redux06790> *brb
2011-02-07 19:33:17 [INFO] <AngryRhetoric> k
2011-02-07 19:34:54 [INFO] <nawf> damnit, I got a ""server down fu omg lol wtf email""
2011-02-07 19:34:56 [INFO] <nawf> brb
2011-02-07 19:38:15 [INFO] <AngryRhetoric> no more creepers spawning in the castle basement
2011-02-07 19:38:25 [INFO] <AngryRhetoric> haha gl with the server
2011-02-07 19:40:23 [INFO] <nawf> its just the customer being dumb
2011-02-07 19:40:34 [INFO] <nawf> the re-route some traffic internally
2011-02-07 19:40:47 [INFO] <nawf> and some guy is trying to connect to one of our ips using a 198.168 address
2011-02-07 19:40:55 [INFO] <nawf> durp herp
2011-02-07 19:41:09 [INFO] <AngryRhetoric> herpes?
2011-02-07 19:41:17 [INFO] <nawf> hurp derp
2011-02-07 19:41:33 [INFO] <AngryRhetoric> hah why is ths local ip address not connecting outside my network???
2011-02-07 19:41:35 [INFO] <redux06790> sometimes you herp... but mostly you derp
2011-02-07 19:41:54 [INFO] <AngryRhetoric> i prefer to derp myself
2011-02-07 19:41:57 [INFO] <nawf> yeah, and this guy is a developer
2011-02-07 19:42:01 [INFO] <nawf> dicks
2011-02-07 19:42:14 [INFO] <AngryRhetoric> F'ing developers...oh wait
2011-02-07 19:42:24 [INFO] <nawf> lol, messin with my schemas
2011-02-07 19:42:32 [INFO] <AngryRhetoric> hahaha
2011-02-07 19:42:36 [INFO] <AngryRhetoric> YEAH!!
2011-02-07 19:42:42 [INFO] <nawf> wtf constraint?  DROP
2011-02-07 19:42:48 [INFO] <AngryRhetoric> haha
2011-02-07 19:42:54 [INFO] <AngryRhetoric> WTF's an APK?? get that outta there
2011-02-07 19:43:13 [INFO] <AngryRhetoric> dude my shfit key hates me
2011-02-07 19:43:21 [INFO] <redux06790> hate it back
2011-02-07 19:43:29 [INFO] <AngryRhetoric> i'm running out of ham!
2011-02-07 19:43:45 [INFO] <nawf> WHEN SHE PUTS IN THE FRIEND ZONE PUT HER IN THE RAPE ZONE
2011-02-07 19:43:52 [INFO] <AngryRhetoric> ylol
2011-02-07 19:43:55 [INFO] <AngryRhetoric> wtf!
2011-02-07 19:44:00 [INFO] <redux06790> THE RAPE TRAIN HAS NO BRAKES!!!!
2011-02-07 19:44:03 [INFO] <AngryRhetoric> stalkers motto?
2011-02-07 19:44:16 [INFO] <AngryRhetoric> more coal for the rape train
2011-02-07 19:44:41 [INFO] <redux06790> OH NOES
2011-02-07 19:44:53 [INFO] <redux06790> blocks r not gooin in 2 mah inventoreh
2011-02-07 19:44:54 [INFO] <AngryRhetoric> right through your pants!!
2011-02-07 19:44:57 [INFO] <redux06790> i is confuse
2011-02-07 19:45:04 [INFO] <AngryRhetoric> i can has dumb
2011-02-07 19:45:06 [INFO] <redux06790> y u no have more inventoreh
2011-02-07 19:46:17 [INFO] <redux06790> 6 stacks +44 coal woot
2011-02-07 19:46:23 [INFO] <redux06790> not counting whats in my forges
2011-02-07 19:46:30 [INFO] <AngryRhetoric> tits
2011-02-07 19:47:37 [INFO] <redux06790> sooo
2011-02-07 19:47:43 [INFO] <redux06790> how badly is coal needed over there?
2011-02-07 19:48:20 [INFO] <nawf> dunno, I think we are good
2011-02-07 19:48:29 [INFO] <redux06790> damn
2011-02-07 19:48:39 [INFO] <redux06790> i was going to try to dupe someone into bringing me logs haha
2011-02-07 19:48:41 [INFO] <redux06790> brb
2011-02-07 19:48:43 [INFO] <AngryRhetoric> haha
2011-02-07 19:48:48 [INFO] <AngryRhetoric> ( . Y . )
2011-02-07 19:49:24 [INFO] <AngryRhetoric> you guys should add your own houses to the floating islands
2011-02-07 19:50:27 [INFO] <redux06790> back
2011-02-07 19:50:30 [INFO] <redux06790> ill add one
2011-02-07 19:50:39 [INFO] <redux06790> itll be testicles hanging from one island
2011-02-07 19:50:42 [INFO] <redux06790> pink testicles
2011-02-07 19:50:54 [INFO] <AngryRhetoric> hahaha
2011-02-07 19:52:49 [INFO] <nawf> lol, now these fucks are saying ""omg it changed we have to test omg wtf""
2011-02-07 19:53:09 [INFO] <nawf> so I replied all with the email thread from 1/19 when they understood and accepted the change
2011-02-07 19:53:40 [INFO] <AngryRhetoric> haha
2011-02-07 19:53:50 [INFO] <AngryRhetoric> attn developer, see your prev email, idiot
2011-02-07 19:53:52 [INFO] <nawf> this guy was trying to cya, nope fucker, I got you!
2011-02-07 19:55:37 [INFO] <nawf> OH YEAH BIOOOOOYY
2011-02-07 19:55:50 [INFO] <nawf> guy wimpers back... yeah... I forgot to change something
2011-02-07 19:56:01 [INFO] <nawf> GET YOUR WEAK ASS GAME OUT OF MY HOUSE
2011-02-07 19:56:22 [INFO] <redux06790> NEEEERRRD RAAAAGE!!!!
2011-02-07 19:56:24 [INFO] <AngryRhetoric> hahah
2011-02-07 19:56:33 [INFO] <AngryRhetoric> *peter griffin laugh hehehehehehehehehehheh
2011-02-07 19:56:50 [INFO] <nawf> customers tryin to front yo
2011-02-07 19:56:55 [INFO] <redux06790> well shit
2011-02-07 19:57:01 [INFO] <redux06790> this is an unforseen contingency
2011-02-07 19:57:15 [INFO] <nawf> its always a war between client and venfor to prove who is being a bigger idiot
2011-02-07 19:57:20 [INFO] <redux06790> when i make a branch mine i just go in one direction until i hit lava
2011-02-07 19:57:32 [INFO] <AngryRhetoric> mmm lav
2011-02-07 19:57:33 [INFO] <redux06790> well ive hit lapiz
2011-02-07 19:57:34 [INFO] <AngryRhetoric> a
2011-02-07 19:57:36 [INFO] <redux06790> do i stop?
2011-02-07 19:57:36 [INFO] <nawf> you shouldn't branch in the lava levels
2011-02-07 19:57:50 [INFO] <redux06790> im branch mining at the bedrock
2011-02-07 19:58:14 [INFO] <nawf> thats bad
2011-02-07 19:58:20 [INFO] <redux06790> how so
2011-02-07 19:58:25 [INFO] <nawf> there is almost no diamond there
2011-02-07 19:58:27 [INFO] <redux06790> ive always gotten plenty of diamond this way
2011-02-07 19:58:47 [INFO] <redux06790> then where would you suggest i go?
2011-02-07 19:58:52 [INFO] <redux06790> i dont want to hit caves
2011-02-07 19:58:57 [INFO] <redux06790> because then i have to explore them haha
2011-02-07 19:59:23 [INFO] <nawf> 19 and 20
2011-02-07 19:59:38 [INFO] <nawf> well, depends if you are looking for lapis
2011-02-07 19:59:42 [INFO] <nawf> lapis is best at 20
2011-02-07 19:59:53 [INFO] <redux06790> meaning 20 up from bedrock
2011-02-07 19:59:55 [INFO] <nawf> best diamon is 16-19, I posted a chart on your facebook wall
2011-02-07 20:00:01 [INFO] <AngryRhetoric> lapis just dyes wool blue right?
2011-02-07 20:00:01 [INFO] <nawf> yeah
2011-02-07 20:00:06 [INFO] <nawf> yeah
2011-02-07 20:00:11 [INFO] <AngryRhetoric> woowee
2011-02-07 20:00:12 [INFO] <nawf> well and lightblue and purple
2011-02-07 20:00:24 [INFO] <redux06790> well you can make lapiz blocks too... but why you would do that idk
2011-02-07 20:00:37 [INFO] <AngryRhetoric> i want a blue house
2011-02-07 20:00:40 [INFO] <redux06790> im thinking about stopping branches when i hit restone too
2011-02-07 20:01:05 [INFO] <nawf> so if you stay 16+ you hit the diamond sweet spot and no lava thread
2011-02-07 20:01:07 [INFO] <nawf> threat
2011-02-07 20:01:32 [INFO] <redux06790> well then get me some TNT so i can blow this branch mine to thy kingdom come
2011-02-07 20:01:54 [INFO] <nawf> no way
2011-02-07 20:02:17 [INFO] <redux06790> yes way
2011-02-07 20:02:49 [INFO] <redux06790> im coming for your sulphur john
2011-02-07 20:03:04 [INFO] <nawf> I think we have half a chest
2011-02-07 20:03:11 [INFO] <nawf> I haven't been idling lately
2011-02-07 20:03:41 [INFO] <AngryRhetoric> 16+? is that the y coord?
2011-02-07 20:03:50 [INFO] <nawf> yeah
2011-02-07 20:04:07 [INFO] <nawf> diamon is best from 4-19 or something
2011-02-07 20:04:20 [INFO] <AngryRhetoric> hmm
2011-02-07 20:04:20 [INFO] <nawf> but 12 is lava level
2011-02-07 20:04:32 [INFO] <nawf> well mostly, now there are lava caves and shit even on the surface
2011-02-07 20:04:36 [INFO] <nawf> but not those huge flows
2011-02-07 20:07:13 [INFO] <redux06790> mindy wants a homunculus coming out of her nose
2011-02-07 20:07:19 [INFO] <redux06790> an african homunculus
2011-02-07 20:07:46 [INFO] <AngryRhetoric> homunculus??
2011-02-07 20:07:57 [INFO] <redux06790> (sic) lol
2011-02-07 20:08:11 [INFO] <redux06790> no i was right
2011-02-07 20:08:18 [INFO] <redux06790> homunculus
2011-02-07 20:08:40 [INFO] <redux06790> a very small person who is otherwise not deformed aside from size
2011-02-07 20:08:56 [INFO] <nawf> are you coming back erin?
2011-02-07 20:09:01 [INFO] <redux06790> yeah
2011-02-07 20:09:05 [INFO] <nawf> damn
2011-02-07 20:09:06 [INFO] <redux06790> im just getting some sand
2011-02-07 20:09:09 [INFO] <redux06790> why?
2011-02-07 20:09:14 [INFO] <redux06790> i havent left yet
2011-02-07 20:09:18 [INFO] <AngryRhetoric> ahhhh thanks i had heard of that word before but forgot
2011-02-07 20:09:20 [INFO] <nawf> kev we should have built that dick in the skulls ear earlier
2011-02-07 20:09:30 [INFO] <redux06790> lol fuck you
2011-02-07 20:09:33 [INFO] <AngryRhetoric> haha true, erin signed on before you though
2011-02-07 20:10:31 [INFO] <AngryRhetoric> we'll need a lot of black wool
2011-02-07 20:10:41 [INFO] <nawf> yeah
2011-02-07 20:11:01 [INFO] <redux06790> ...
2011-02-07 20:11:07 [INFO] <redux06790> i literally dont know what to say haha
2011-02-07 20:11:25 [INFO] <AngryRhetoric> hahaha
2011-02-07 20:14:29 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-07 20:17:18 [INFO] Disconnecting redux06790 [/69.119.8.191:49297]: Took too long to log in
2011-02-07 20:17:34 [INFO] redux06790 [/69.119.8.191:49300] lost connection
2011-02-07 20:17:41 [INFO] Disconnecting redux06790 [/69.119.8.191:49300]: Failed to verify username!
2011-02-07 20:17:41 [INFO] redux06790 [/69.119.8.191:49303] logged in with entity id 8442004
2011-02-07 20:17:44 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 20:17:45 [INFO] <redux06790> derp
2011-02-07 20:17:55 [INFO] <AngryRhetoric> herp
2011-02-07 20:17:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 20:18:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 20:20:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 20:20:23 [INFO] <redux06790> where is that desert biome?
2011-02-07 20:20:39 [INFO] <redux06790> we really need to make a building with a directory of coord
2011-02-07 20:20:41 [INFO] <redux06790> coords
2011-02-07 20:20:55 [INFO] <AngryRhetoric> not a bad idea, basically a lot of signs
2011-02-07 20:21:18 [INFO] <redux06790> seriously we need that sign mod on this server
2011-02-07 20:22:22 [INFO] <nawf> that shoudl be the first room in the castle
2011-02-07 20:22:45 [INFO] <nawf> we could just put it on one of the walls too
2011-02-07 20:23:00 [INFO] <redux06790> i have returned from my journey
2011-02-07 20:23:15 [INFO] <redux06790> wtf
2011-02-07 20:23:21 [INFO] <redux06790> that arrow is going apeshit
2011-02-07 20:23:43 [INFO] <redux06790> lol
2011-02-07 20:23:51 [INFO] <AngryRhetoric> i hate you
2011-02-07 20:23:56 [INFO] <redux06790> hahaha
2011-02-07 20:24:05 [INFO] <redux06790> im lauging so fucking hard right now
2011-02-07 20:24:08 [INFO] <nawf> don't blame me
2011-02-07 20:24:11 [INFO] <nawf> it was a team effort
2011-02-07 20:24:31 [INFO] <AngryRhetoric> i was drowning blubh blubh
2011-02-07 20:24:45 [INFO] <nawf> I think my forearm is sore from the shakeweight
2011-02-07 20:24:56 [INFO] <AngryRhetoric> haha
2011-02-07 20:26:05 [INFO] <AngryRhetoric> i need iron
2011-02-07 20:26:11 [INFO] <redux06790> herp
2011-02-07 20:26:16 [INFO] <redux06790> how much iron?
2011-02-07 20:26:34 [INFO] <AngryRhetoric> 30ish
2011-02-07 20:26:38 [INFO] <redux06790> wellllll
2011-02-07 20:26:43 [INFO] <redux06790> if youre willing to take a trip
2011-02-07 20:26:45 [INFO] <redux06790> lol
2011-02-07 20:26:48 [INFO] <AngryRhetoric> haha
2011-02-07 20:26:52 [INFO] <redux06790> oh wait
2011-02-07 20:26:59 [INFO] <redux06790> theres some down here
2011-02-07 20:27:05 [INFO] <redux06790> in the grinder base
2011-02-07 20:32:10 [INFO] <AngryRhetoric> i might m ake a trip to the south villa mmm yeesssss
2011-02-07 20:32:37 [INFO] <redux06790> do you have beacons leading to it?
2011-02-07 20:32:42 [INFO] <nawf> bacon?
2011-02-07 20:33:01 [INFO] <redux06790> a plank block with a torch on it
2011-02-07 20:33:09 [INFO] <redux06790> bread crumbs
2011-02-07 20:33:14 [INFO] <redux06790> a trail...
2011-02-07 20:34:06 [INFO] <AngryRhetoric> hah bacons
2011-02-07 20:34:12 [INFO] <redux06790> WELL!? ARE THERE!?!?
2011-02-07 20:34:18 [INFO] <AngryRhetoric> nope
2011-02-07 20:34:23 [INFO] <AngryRhetoric> i only have coords heh
2011-02-07 20:34:23 [INFO] <redux06790> ...
2011-02-07 20:34:59 [INFO] <AngryRhetoric> did you really want to go?
2011-02-07 20:35:07 [INFO] <redux06790> yeah when the sun comes up i will
2011-02-07 20:36:15 [INFO] <AngryRhetoric> i need supplie
2011-02-07 20:36:17 [INFO] <AngryRhetoric> s
2011-02-07 20:36:21 [INFO] <redux06790> ll
2011-02-07 20:36:23 [INFO] <redux06790> lol
2011-02-07 20:36:27 [INFO] <AngryRhetoric> haha
2011-02-07 20:36:30 [INFO] <AngryRhetoric> i failed
2011-02-07 20:37:18 [INFO] <redux06790> so
2011-02-07 20:37:21 [INFO] <AngryRhetoric> yarr
2011-02-07 20:37:23 [INFO] <redux06790> my wife is watching chuck
2011-02-07 20:37:36 [INFO] <redux06790> and the chick that plays sara is belly dancing
2011-02-07 20:38:54 [INFO] <redux06790> i wish my dick could shoot ramen noodles
2011-02-07 20:39:03 [INFO] <AngryRhetoric> that would be scary
2011-02-07 20:39:04 [INFO] <redux06790> oriental ramen noodles
2011-02-07 20:39:12 [INFO] <redux06790> that would be fucking awesome
2011-02-07 20:39:12 [INFO] <AngryRhetoric> wait good luck chuck?
2011-02-07 20:39:16 [INFO] <redux06790> no
2011-02-07 20:39:18 [INFO] <redux06790> just chuck
2011-02-07 20:39:20 [INFO] <redux06790> the series
2011-02-07 20:39:26 [INFO] <redux06790> with zachary levi
2011-02-07 20:39:44 [INFO] <nawf> I'll be back later, gotta do some shit for a bit
2011-02-07 20:39:47 [INFO] <nawf> peace
2011-02-07 20:39:49 [INFO] nawf lost connection: disconnect.quitting
2011-02-07 20:39:51 [INFO] <redux06790> get out of here
2011-02-07 20:39:54 [INFO] <redux06790> ...
2011-02-07 20:39:57 [INFO] <redux06790> damnit
2011-02-07 20:40:04 [INFO] <redux06790> he actually left haha
2011-02-07 20:40:08 [INFO] <AngryRhetoric> haha yeah
2011-02-07 20:40:40 [INFO] <AngryRhetoric> ok i'mr eady
2011-02-07 20:40:47 [INFO] <redux06790> dude we need to get some addons on this bitch
2011-02-07 20:40:51 [INFO] <redux06790> they have this addon
2011-02-07 20:40:58 [INFO] <redux06790> where you can turn signs into teleporters
2011-02-07 20:41:09 [INFO] <AngryRhetoric> cool
2011-02-07 20:41:14 [INFO] <AngryRhetoric> thta'd be handy
2011-02-07 20:41:23 [INFO] <redux06790> im on the bridge at the skull tower
2011-02-07 20:41:36 [INFO] <AngryRhetoric> one sec
2011-02-07 20:42:06 [INFO] <AngryRhetoric> afk
2011-02-07 20:42:09 [INFO] <AngryRhetoric> lol HEY
2011-02-07 20:42:11 [INFO] <redux06790> lol
2011-02-07 20:42:16 [INFO] <redux06790> im a bully
2011-02-07 20:43:30 [INFO] <redux06790> cmon cmon its daytime!!!
2011-02-07 20:45:14 [INFO] <AngryRhetoric> ok back
2011-02-07 20:46:15 [INFO] <redux06790> dude
2011-02-07 20:46:21 [INFO] <redux06790> is this an internment camp?
2011-02-07 20:46:23 [INFO] <AngryRhetoric> haha
2011-02-07 20:46:36 [INFO] <AngryRhetoric> its uh post-modern prefab haha
2011-02-07 20:47:45 [INFO] <redux06790> lol
2011-02-07 20:47:51 [INFO] <AngryRhetoric> smoooth
2011-02-07 20:47:56 [INFO] <redux06790> like buttah
2011-02-07 20:49:49 [INFO] <AngryRhetoric> desert!
2011-02-07 20:50:06 [INFO] <redux06790> imma steal it
2011-02-07 20:50:52 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-07 20:51:01 [INFO] redux06790 [/69.119.8.191:49322] logged in with entity id 8498178
2011-02-07 20:51:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 20:51:08 [INFO] <AngryRhetoric> yo
2011-02-07 20:51:25 [INFO] <redux06790> SEC
2011-02-07 20:51:26 [INFO] <AngryRhetoric> where'd you go?
2011-02-07 20:51:27 [INFO] <AngryRhetoric> ok
2011-02-07 20:51:38 [INFO] <redux06790> found a fuckton of red shrooms
2011-02-07 20:52:09 [INFO] <AngryRhetoric> gotta get my bearings
2011-02-07 20:52:32 [INFO] <redux06790> dude
2011-02-07 20:52:39 [INFO] <redux06790> this spot is awesome
2011-02-07 20:52:43 [INFO] <AngryRhetoric> yeah
2011-02-07 20:52:52 [INFO] <AngryRhetoric> cool hills
2011-02-07 20:53:04 [INFO] <AngryRhetoric> we're half way there
2011-02-07 20:54:02 [INFO] <redux06790> OMG!!!!
2011-02-07 20:54:09 [INFO] <AngryRhetoric> lol yeah
2011-02-07 20:55:03 [INFO] <redux06790> i gtg after we get there
2011-02-07 20:55:06 [INFO] <AngryRhetoric> haha ok
2011-02-07 20:57:53 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-07 20:57:53 [INFO] <AngryRhetoric> night travel!
2011-02-07 20:58:02 [INFO] redux06790 [/69.119.8.191:49331] logged in with entity id 8585609
2011-02-07 20:58:20 [INFO] <AngryRhetoric> finally
2011-02-07 20:58:27 [INFO] <redux06790> saftey!
2011-02-07 20:58:31 [INFO] <redux06790> SAFETY!!!
2011-02-07 20:59:41 [INFO] <AngryRhetoric> welcome
2011-02-07 20:59:42 [INFO] <redux06790> my god
2011-02-07 20:59:52 [INFO] <AngryRhetoric> nice eh
2011-02-07 20:59:53 [INFO] <redux06790> awww its in the clouds
2011-02-07 21:00:03 [INFO] <redux06790> interesting bed
2011-02-07 21:00:06 [INFO] <AngryRhetoric> haha yeah high up
2011-02-07 21:00:07 [INFO] <AngryRhetoric> thx
2011-02-07 21:00:20 [INFO] <redux06790> nice dude
2011-02-07 21:00:22 [INFO] <redux06790> i gtg though
2011-02-07 21:00:26 [INFO] <AngryRhetoric> ok
2011-02-07 21:00:30 [INFO] <redux06790> the wife requests my company haha
2011-02-07 21:00:37 [INFO] <redux06790> if you get bored check my place again
2011-02-07 21:00:38 [INFO] <AngryRhetoric> lol that's reason enough!
2011-02-07 21:00:41 [INFO] <redux06790> peace dude
2011-02-07 21:00:43 [INFO] <AngryRhetoric> yeah will do laters
2011-02-07 21:00:46 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-07 21:14:27 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-07 21:14:35 [INFO] AngryRhetoric [/24.147.183.4:57028] logged in with entity id 8610668
2011-02-07 21:14:39 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 21:18:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 21:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 21:23:20 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-07 21:23:37 [INFO] AngryRhetoric [/24.147.183.4:57369] logged in with entity id 8622722
2011-02-07 21:23:40 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 21:42:31 [INFO] efess [/192.168.0.198:19818] logged in with entity id 8643771
2011-02-07 21:42:38 [INFO] <efess> yo
2011-02-07 21:42:42 [INFO] <AngryRhetoric> sup joe!
2011-02-07 21:42:46 [INFO] <efess> hey kevin
2011-02-07 21:44:14 [INFO] <efess> Still got garlic on my breath
2011-02-07 21:44:15 [INFO] <efess> lol
2011-02-07 21:44:20 [INFO] <AngryRhetoric> hahahaha permanent
2011-02-07 21:44:25 [INFO] <efess> true
2011-02-07 21:44:26 [INFO] <AngryRhetoric> that stuff was fierce
2011-02-07 21:44:29 [INFO] <AngryRhetoric> but tasty
2011-02-07 21:44:33 [INFO] <efess> ya!
2011-02-07 21:44:38 [INFO] <AngryRhetoric> not first-date food hahaha
2011-02-07 21:49:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 21:51:39 [INFO] <efess> bbl
2011-02-07 21:51:39 [INFO] efess lost connection: disconnect.quitting
2011-02-07 22:09:17 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-07 22:09:41 [INFO] AngryRhetoric [/24.147.183.4:59069] logged in with entity id 8694435
2011-02-07 22:09:44 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 22:18:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 22:25:33 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 22:33:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-07 22:59:20 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-08 13:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 13:18:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 14:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 14:19:06 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 15:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 15:18:40 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 16:18:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 17:12:44 [INFO] nawf [/76.23.232.27:55232] logged in with entity id 9153961
2011-02-08 17:15:42 [INFO] nawf lost connection: disconnect.genericReason
2011-02-08 17:18:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 18:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 18:42:05 [INFO] redux06790 [/69.119.8.191:49398] logged in with entity id 9159233
2011-02-08 18:42:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 18:42:13 [INFO] <redux06790> anyone here?
2011-02-08 18:44:18 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-08 19:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 19:18:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 19:31:09 [INFO] /69.119.8.191:49457 lost connection
2011-02-08 19:31:43 [INFO] Disconnecting /69.119.8.191:49460: Took too long to log in
2011-02-08 19:33:15 [INFO] Disconnecting redux06790 [/69.119.8.191:49487]: Took too long to log in
2011-02-08 19:33:24 [INFO] /69.119.8.191:49536 lost connection
2011-02-08 19:33:29 [INFO] /69.119.8.191:49538 lost connection
2011-02-08 19:48:11 [INFO] /69.119.8.191:49668 lost connection
2011-02-08 19:51:36 [INFO] /69.119.8.191:49779 lost connection
2011-02-08 19:51:46 [INFO] /69.119.8.191:49782 lost connection
2011-02-08 19:56:27 [INFO] Disconnecting redux06790 [/69.119.8.191:49934]: Took too long to log in
2011-02-08 19:56:46 [INFO] /69.119.8.191:49936 lost connection
2011-02-08 19:57:12 [INFO] redux06790 [/69.119.8.191:49939] lost connection
2011-02-08 19:57:45 [INFO] Disconnecting /69.119.8.191:49942: Took too long to log in
2011-02-08 19:58:19 [INFO] /69.119.8.191:49944 lost connection
2011-02-08 19:58:31 [INFO] /69.119.8.191:49947 lost connection
2011-02-08 19:58:38 [INFO] /69.119.8.191:49949 lost connection
2011-02-08 19:58:43 [INFO] /69.119.8.191:49951 lost connection
2011-02-08 19:59:37 [INFO] Disconnecting /69.119.8.191:49954: Took too long to log in
2011-02-08 20:00:20 [INFO] Disconnecting /69.119.8.191:49957: Took too long to log in
2011-02-08 20:00:56 [INFO] Disconnecting /69.119.8.191:49960: Took too long to log in
2011-02-08 20:01:51 [INFO] Disconnecting /69.119.8.191:49963: Took too long to log in
2011-02-08 20:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 20:21:13 [INFO] Disconnecting /24.147.183.4:55214: Took too long to log in
2011-02-08 20:22:13 [INFO] /24.147.183.4:55271 lost connection
2011-02-08 20:22:47 [INFO] /24.147.183.4:55296 lost connection
2011-02-08 20:23:18 [INFO] /24.147.183.4:55317 lost connection
2011-02-08 20:23:34 [INFO] /24.147.183.4:55325 lost connection
2011-02-08 20:26:54 [INFO] Disconnecting /24.147.183.4:55438: Took too long to log in
2011-02-08 20:28:59 [INFO] /24.147.183.4:55537 lost connection
2011-02-08 20:29:13 [INFO] /24.147.183.4:55545 lost connection
2011-02-08 20:29:31 [INFO] /24.147.183.4:55559 lost connection
2011-02-08 20:29:38 [INFO] /24.147.183.4:55568 lost connection
2011-02-08 20:31:58 [INFO] /24.218.113.229:37926 lost connection
2011-02-08 20:33:05 [INFO] /24.218.113.229:37932 lost connection
2011-02-08 20:33:24 [INFO] /24.147.183.4:55701 lost connection
2011-02-08 20:33:30 [INFO] k0n2ad [/24.218.113.229:37935] logged in with entity id 9161282
2011-02-08 20:34:04 [INFO] /24.147.183.4:55727 lost connection
2011-02-08 20:34:25 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 20:35:17 [INFO] /24.147.183.4:55778 lost connection
2011-02-08 20:35:33 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-08 20:36:00 [INFO] k0n2ad [/24.218.113.229:37954] logged in with entity id 9167519
2011-02-08 20:36:11 [INFO] AngryRhetoric [/24.147.183.4:55819] logged in with entity id 9167793
2011-02-08 20:36:16 [INFO] <AngryRhetoric> FINALLLY!!!!
2011-02-08 20:36:18 [INFO] <k0n2ad> dude
2011-02-08 20:36:28 [INFO] <AngryRhetoric> fucking minecraft wouldn't let me in hahah hey sup konrad
2011-02-08 20:36:32 [INFO] <k0n2ad> minecraft is bugging yo
2011-02-08 20:36:42 [INFO] <k0n2ad> yea, that, and try to dig up some dirt
2011-02-08 20:36:42 [INFO] <AngryRhetoric> i'm blacking out..blacking out blacking out out outout
2011-02-08 20:36:56 [INFO] <k0n2ad> every time i dig the block comes back
2011-02-08 20:37:10 [INFO] <AngryRhetoric> yeah that was hapening to me last night
2011-02-08 20:37:13 [INFO] <AngryRhetoric> where you at dog
2011-02-08 20:37:15 [INFO] <k0n2ad> wtf\
2011-02-08 20:37:36 [INFO] <k0n2ad> -34 83
2011-02-08 20:37:54 [INFO] <AngryRhetoric> that's x and z
2011-02-08 20:37:55 [INFO] <AngryRhetoric> right?
2011-02-08 20:38:04 [INFO] <k0n2ad> xy
2011-02-08 20:38:12 [INFO] <AngryRhetoric> z is more critical heh
2011-02-08 20:38:23 [INFO] <AngryRhetoric> but it sounds like you're near the big castle
2011-02-08 20:38:32 [INFO] <k0n2ad> -70 z
2011-02-08 20:38:34 [INFO] <AngryRhetoric> no one else is on?
2011-02-08 20:38:52 [INFO] <k0n2ad> nope. and im going to leave if these blocks won't go away
2011-02-08 20:39:09 [INFO] <k0n2ad> im going to restart and come back
2011-02-08 20:39:18 [INFO] <AngryRhetoric> ok, gl getting back in
2011-02-08 20:39:32 [INFO] <k0n2ad> lol - are your blocks digging?
2011-02-08 20:39:58 [INFO] <k0n2ad> ????
2011-02-08 20:40:06 [INFO] <AngryRhetoric> that's personal
2011-02-08 20:40:13 [INFO] <k0n2ad> theriously
2011-02-08 20:40:19 [INFO] <AngryRhetoric> haha yeth
2011-02-08 20:40:24 [INFO] <k0n2ad> ok brb
2011-02-08 20:40:26 [INFO] <AngryRhetoric> dirt's getting removed
2011-02-08 20:40:27 [INFO] <k0n2ad> hopefully
2011-02-08 20:40:30 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-08 20:41:56 [INFO] Disconnecting k0n2ad [/24.218.113.229:38033]: Took too long to log in
2011-02-08 20:42:26 [INFO] /24.218.113.229:38044 lost connection
2011-02-08 20:43:03 [INFO] Disconnecting k0n2ad [/24.218.113.229:38048]: Took too long to log in
2011-02-08 20:43:39 [INFO] k0n2ad [/24.218.113.229:38055] logged in with entity id 9172992
2011-02-08 20:44:06 [INFO] <AngryRhetoric> villkommen
2011-02-08 20:44:28 [INFO] <k0n2ad> ya
2011-02-08 20:47:56 [INFO] <AngryRhetoric> yesterday i made it 3 day's journey to the south
2011-02-08 20:48:00 [INFO] <AngryRhetoric> found a ton of clay and died hahaha
2011-02-08 20:48:12 [INFO] <k0n2ad> lol
2011-02-08 20:48:25 [INFO] <k0n2ad> im going to build myself a house
2011-02-08 20:48:28 [INFO] <k0n2ad> shanty
2011-02-08 20:48:36 [INFO] <AngryRhetoric> haha nice there's room in the floating islands
2011-02-08 20:52:27 [INFO] <AngryRhetoric> i connected the 4 floating islands behind the big skull
2011-02-08 20:52:48 [INFO] <k0n2ad> haha, with what
2011-02-08 20:52:52 [INFO] <AngryRhetoric> dirt!!!
2011-02-08 20:53:01 [INFO] <k0n2ad> of course
2011-02-08 20:55:03 [INFO] <k0n2ad> DARKNESS
2011-02-08 20:55:07 [INFO] <AngryRhetoric> haha
2011-02-08 21:00:13 [INFO] <AngryRhetoric> you in the caves?
2011-02-08 21:00:27 [INFO] <k0n2ad> nope, still building my shanty
2011-02-08 21:00:32 [INFO] <AngryRhetoric> haha cool
2011-02-08 21:00:40 [INFO] <k0n2ad> need to settle in before i start exploring
2011-02-08 21:00:56 [INFO] <AngryRhetoric> yeah that's my usual operating pattern
2011-02-08 21:01:11 [INFO] <AngryRhetoric> i took erin to the southern home yesterday heh
2011-02-08 21:01:30 [INFO] <k0n2ad> southern home?
2011-02-08 21:01:41 [INFO] <AngryRhetoric> yeah i walked almost 2 days' south
2011-02-08 21:01:47 [INFO] <k0n2ad> lol
2011-02-08 21:01:53 [INFO] <AngryRhetoric> x coord is 1826
2011-02-08 21:01:58 [INFO] <k0n2ad> hahaha
2011-02-08 21:02:00 [INFO] <AngryRhetoric> to give you an idea
2011-02-08 21:02:02 [INFO] <k0n2ad> crazy
2011-02-08 21:02:08 [INFO] <AngryRhetoric> yeah its cool
2011-02-08 21:03:33 [INFO] <AngryRhetoric> sunrise
2011-02-08 21:03:42 [INFO] <k0n2ad> nice i can come out now
2011-02-08 21:04:37 [INFO] <k0n2ad> ah, the beautiful sounds of skeltons frying
2011-02-08 21:04:43 [INFO] <AngryRhetoric> lol yes
2011-02-08 21:06:44 [INFO] <AngryRhetoric> coool i found a mob spawning room
2011-02-08 21:06:52 [INFO] <k0n2ad> niiice
2011-02-08 21:07:01 [INFO] <k0n2ad> time to grab some loot
2011-02-08 21:09:54 [INFO] <AngryRhetoric> minecraft on the pc, star trek on syfy on the tv, doesn't get any nerdier
2011-02-08 21:10:34 [INFO] <k0n2ad> hahaha
2011-02-08 21:10:40 [INFO] <k0n2ad> the only way to live
2011-02-08 21:10:49 [INFO] <k0n2ad> im installing ubuntu on other pc
2011-02-08 21:10:59 [INFO] <AngryRhetoric> haha wow that's nerdier than my situation
2011-02-08 21:11:17 [INFO] <AngryRhetoric> mmm chunk errors
2011-02-08 21:11:24 [INFO] <k0n2ad> lol
2011-02-08 21:11:28 [INFO] <AngryRhetoric> i will try to rejoin
2011-02-08 21:11:35 [INFO] <k0n2ad> k
2011-02-08 21:11:42 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-08 21:12:18 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:58075]: Took too long to log in
2011-02-08 21:13:32 [INFO] AngryRhetoric [/24.147.183.4:58136] logged in with entity id 9236438
2011-02-08 21:13:37 [INFO] <AngryRhetoric> schweeeeet
2011-02-08 21:13:38 [INFO] <k0n2ad> welcome back
2011-02-08 21:16:17 [INFO] <AngryRhetoric> hwil hweaton is on the tv
2011-02-08 21:17:39 [INFO] <AngryRhetoric> so i deployed voucher tracking at 8pm tonight, yeahh i love work
2011-02-08 21:18:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 21:18:09 [INFO] <k0n2ad> haha, at least you get payd $$ bling bling
2011-02-08 21:18:24 [INFO] <AngryRhetoric> i didn't ask for comptime but maybe i should heh
2011-02-08 21:18:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 21:18:51 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 21:19:41 [INFO] <k0n2ad> holy shit that skeleton freaking me out
2011-02-08 21:20:02 [INFO] <AngryRhetoric> where's this shanty of yours
2011-02-08 21:20:05 [INFO] <AngryRhetoric> this lean-to
2011-02-08 21:20:14 [INFO] <k0n2ad> see if you can find it
2011-02-08 21:20:18 [INFO] <AngryRhetoric> hooverville
2011-02-08 21:20:29 [INFO] <AngryRhetoric> is it at least near any of our existing buildings?
2011-02-08 21:20:38 [INFO] <k0n2ad> not far
2011-02-08 21:21:18 [INFO] <k0n2ad> right now it's surrounded by mobs
2011-02-08 21:21:26 [INFO] <AngryRhetoric> yeah i kinda imagined
2011-02-08 21:21:33 [INFO] nawf [/76.23.232.27:55150] logged in with entity id 9246557
2011-02-08 21:21:40 [INFO] <k0n2ad> what up behtch
2011-02-08 21:21:45 [INFO] <AngryRhetoric> and then there's johnmn
2011-02-08 21:22:36 [INFO] <AngryRhetoric> i better find it in the daytime lol
2011-02-08 21:22:50 [INFO] <AngryRhetoric> i just burned through a stack of arrows
2011-02-08 21:22:54 [INFO] <k0n2ad> lol mad mobs
2011-02-08 21:23:06 [INFO] <AngryRhetoric> default setting for the server is hard
2011-02-08 21:23:24 [INFO] <nawf> yo
2011-02-08 21:23:35 [INFO] <k0n2ad> yo dawhg
2011-02-08 21:24:32 [INFO] <k0n2ad> yea iron
2011-02-08 21:25:23 [INFO] <AngryRhetoric> well you're not west of the castle
2011-02-08 21:25:40 [INFO] <k0n2ad> muhahaha wheres waldo
2011-02-08 21:25:56 [INFO] <AngryRhetoric> good thing you gave me coords at the beginning
2011-02-08 21:26:06 [INFO] <k0n2ad> doh
2011-02-08 21:26:38 [INFO] <k0n2ad> mobs be dyin
2011-02-08 21:27:44 [INFO] <AngryRhetoric> whoa north of the castle has  a cool almost floating hill
2011-02-08 21:28:10 [INFO] <nawf> where are you guys?
2011-02-08 21:28:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 21:28:25 [INFO] <AngryRhetoric> konrad built a shanty and i have to find it lol
2011-02-08 21:28:33 [INFO] <k0n2ad> still building it
2011-02-08 21:28:43 [INFO] <k0n2ad> log cabin
2011-02-08 21:28:48 [INFO] <AngryRhetoric> i'm at x -300
2011-02-08 21:28:53 [INFO] <AngryRhetoric> z - 129
2011-02-08 21:29:50 [INFO] <AngryRhetoric> dammit bobby!!!!!!
2011-02-08 21:30:24 [INFO] <k0n2ad> cows always sound pissed its funny
2011-02-08 21:32:42 [INFO] <AngryRhetoric> dam my version of the matrix is chunked again lol brb
2011-02-08 21:32:45 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-08 21:33:17 [INFO] /24.147.183.4:58874 lost connection
2011-02-08 21:34:09 [INFO] /24.147.183.4:58909 lost connection
2011-02-08 21:34:49 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:58931]: Took too long to log in
2011-02-08 21:35:28 [INFO] AngryRhetoric [/24.147.183.4:58961] logged in with entity id 9273809
2011-02-08 21:35:50 [INFO] <AngryRhetoric> i put the IP in instead of the domain name and it works!
2011-02-08 21:38:14 [INFO] <AngryRhetoric> do you have any torches around this thing?
2011-02-08 21:38:25 [INFO] <k0n2ad> a couple
2011-02-08 21:38:37 [INFO] <nawf> he says with a wimper
2011-02-08 21:38:47 [INFO] <AngryRhetoric> lol
2011-02-08 21:39:01 [INFO] <k0n2ad> i am a savage
2011-02-08 21:39:16 [INFO] <nawf> did you savage that needy chick?
2011-02-08 21:39:22 [INFO] <AngryRhetoric> lol
2011-02-08 21:39:56 [INFO] <AngryRhetoric> john what was it you said about a rape train yesterday?
2011-02-08 21:40:02 [INFO] <AngryRhetoric> i was laughing about it today but can't remember it
2011-02-08 21:40:09 [INFO] <nawf> oh yeah
2011-02-08 21:40:09 [INFO] <k0n2ad> we fooled around, did what needed to be done
2011-02-08 21:40:16 [INFO] <AngryRhetoric> git R done
2011-02-08 21:40:32 [INFO] <nawf> thats the most pathetic description of a sexual act I've ever read
2011-02-08 21:40:55 [INFO] <k0n2ad> if you want AIDS ill give you her number
2011-02-08 21:40:55 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 21:40:55 [INFO] <nawf> SHE PUT YOU IN THE FRIEND ZONE?  PUT HER IN THE RAPE ZONE!
2011-02-08 21:41:04 [INFO] <AngryRhetoric> LOL
2011-02-08 21:41:06 [INFO] <nawf> no sloppy seconds
2011-02-08 21:41:07 [INFO] <AngryRhetoric> that was it
2011-02-08 21:41:11 [INFO] <k0n2ad> no, i put her in the friend zone
2011-02-08 21:41:27 [INFO] <k0n2ad> she was weirding me out
2011-02-08 21:41:50 [INFO] <AngryRhetoric> can't slow wn the RAPE TRAIN
2011-02-08 21:42:01 [INFO] <AngryRhetoric> *down
2011-02-08 21:42:17 [INFO] <nawf> I thought it was weird how she always stared through the door when we were smoking
2011-02-08 21:42:23 [INFO] <nawf> I mean kevin did that too but I'm used to him
2011-02-08 21:42:32 [INFO] <AngryRhetoric> yeah i'm an OK kind of wierd
2011-02-08 21:42:34 [INFO] <k0n2ad> lol, only the 1/100th of it
2011-02-08 21:42:35 [INFO] <AngryRhetoric> awkward but ok
2011-02-08 21:42:56 [INFO] <AngryRhetoric> konrad is it even remotely close to the giant castle??
2011-02-08 21:43:00 [INFO] <k0n2ad> there is good wierd and then there is inst
2011-02-08 21:43:12 [INFO] <k0n2ad> need a hint
2011-02-08 21:43:19 [INFO] <AngryRhetoric> Yeayah
2011-02-08 21:43:35 [INFO] <k0n2ad> hold on, im scared to leave my cabin
2011-02-08 21:43:56 [INFO] <k0n2ad> im on a hill
2011-02-08 21:44:01 [INFO] <AngryRhetoric> lol
2011-02-08 21:44:11 [INFO] <nawf> thats like saying ""there are trees nearby""
2011-02-08 21:44:14 [INFO] <k0n2ad> looking at sunrise over a castle thing
2011-02-08 21:44:29 [INFO] <k0n2ad> and in my window, hssssssss
2011-02-08 21:45:44 [INFO] <AngryRhetoric> YES
2011-02-08 21:45:49 [INFO] <k0n2ad> see it?
2011-02-08 21:45:59 [INFO] <AngryRhetoric> DUDE there's a chunk error right below your hut
2011-02-08 21:46:08 [INFO] <k0n2ad> lol
2011-02-08 21:46:11 [INFO] <AngryRhetoric> that's hilarious
2011-02-08 21:46:12 [INFO] <k0n2ad> i dont know what that means
2011-02-08 21:46:22 [INFO] <k0n2ad> all i saw was barage of arrows
2011-02-08 21:46:25 [INFO] <AngryRhetoric> chunk error means the blocks ALL of them are gone below your hut
2011-02-08 21:46:33 [INFO] <k0n2ad> are you invisible?
2011-02-08 21:46:38 [INFO] <k0n2ad> hahaha
2011-02-08 21:46:39 [INFO] <AngryRhetoric> you can't see me? nice
2011-02-08 21:46:43 [INFO] <k0n2ad> no
2011-02-08 21:46:50 [INFO] <AngryRhetoric> this f'ing game.... brb
2011-02-08 21:46:52 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-08 21:47:20 [INFO] AngryRhetoric [/24.147.183.4:59423] logged in with entity id 9290153
2011-02-08 21:47:28 [INFO] <k0n2ad> i see you kill that shit
2011-02-08 21:47:43 [INFO] <AngryRhetoric> lol
2011-02-08 21:47:48 [INFO] <k0n2ad> wtf lol
2011-02-08 21:48:08 [INFO] <AngryRhetoric> that was john
2011-02-08 21:48:17 [INFO] <k0n2ad> betch!!!
2011-02-08 21:48:30 [INFO] <nawf> sweet hut
2011-02-08 21:48:33 [INFO] <AngryRhetoric> you were surrounded by creepers
2011-02-08 21:48:34 [INFO] <k0n2ad> lol
2011-02-08 21:48:47 [INFO] <k0n2ad> its my home. im the resident hermit
2011-02-08 21:49:00 [INFO] <AngryRhetoric> coool
2011-02-08 21:49:06 [INFO] <AngryRhetoric> let me get my flint
2011-02-08 21:49:11 [INFO] <k0n2ad> yea this is where i will bring my GF
2011-02-08 21:49:29 [INFO] <AngryRhetoric> haha
2011-02-08 21:49:36 [INFO] <nawf> I laid down torches so you won't be mobbed
2011-02-08 21:49:36 [INFO] <AngryRhetoric> and put her in the RAPE ZONE??
2011-02-08 21:49:38 [INFO] <nawf> so hard
2011-02-08 21:49:51 [INFO] <k0n2ad> haha, thanks
2011-02-08 21:50:23 [INFO] <AngryRhetoric> this basement is excessive
2011-02-08 21:50:34 [INFO] <k0n2ad> lol
2011-02-08 21:50:42 [INFO] <k0n2ad> thats where i take the girls after
2011-02-08 21:50:43 [INFO] <nawf> this is a cool spot up here
2011-02-08 21:50:50 [INFO] <AngryRhetoric> haha you got a freezer box down there??
2011-02-08 21:51:02 [INFO] <k0n2ad> hmmm good idea
2011-02-08 21:51:11 [INFO] <AngryRhetoric> john i took erin to the southern home
2011-02-08 21:51:15 [INFO] <AngryRhetoric> 2 day's of walking haha
2011-02-08 21:51:27 [INFO] <nawf> lol
2011-02-08 21:51:36 [INFO] <AngryRhetoric> i walked another day south, found 18 clay and then died :(
2011-02-08 21:51:43 [INFO] <nawf> :.(
2011-02-08 21:51:43 [INFO] <AngryRhetoric> i was at x + 3000
2011-02-08 21:52:36 [INFO] <k0n2ad> my goal is to build a tunnel from my place to your giant cave
2011-02-08 21:52:47 [INFO] <AngryRhetoric> that sounds sexual
2011-02-08 21:52:56 [INFO] <k0n2ad> lol, it IS
2011-02-08 21:53:10 [INFO] <AngryRhetoric> zone switching
2011-02-08 21:54:00 [INFO] <k0n2ad> something about mining makes me feel comfortable
2011-02-08 21:55:32 [INFO] <AngryRhetoric> fyi konrad you're near the spawn zone which i think means you can't remove those blocks...
2011-02-08 21:55:54 [INFO] <nawf> you'll be comfortable forever
2011-02-08 21:56:07 [INFO] <k0n2ad> yea i know where it is
2011-02-08 21:56:27 [INFO] <k0n2ad> wait, is that everyone's spawn zone?
2011-02-08 21:56:38 [INFO] <nawf> eah
2011-02-08 21:56:40 [INFO] <AngryRhetoric> why YYYYEESSSS
2011-02-08 21:56:48 [INFO] <k0n2ad> aw for real?
2011-02-08 21:57:05 [INFO] <AngryRhetoric> hence the coords almost set to 0
2011-02-08 21:57:06 [INFO] <k0n2ad> thought i was special
2011-02-08 21:57:18 [INFO] <nawf> cause your a creep?
2011-02-08 21:57:28 [INFO] <k0n2ad> im a wierdo
2011-02-08 21:57:41 [INFO] <AngryRhetoric> your so f'ing special
2011-02-08 21:57:58 [INFO] <k0n2ad> what the hell am i doin heeeeeeeeeeere
2011-02-08 21:58:02 [INFO] <AngryRhetoric> your skin makes me cry
2011-02-08 21:58:23 [INFO] <AngryRhetoric> seriously...shower you dirty bastard
2011-02-08 21:58:30 [INFO] <k0n2ad> need moar torches
2011-02-08 22:00:55 [INFO] <k0n2ad> so what are u guys working on
2011-02-08 22:01:04 [INFO] <AngryRhetoric> getting more arrows
2011-02-08 22:01:16 [INFO] <AngryRhetoric> adding more floor to the giant castle
2011-02-08 22:01:23 [INFO] <k0n2ad> there is a creeper at my door
2011-02-08 22:01:27 [INFO] <AngryRhetoric> might head sOUth
2011-02-08 22:01:29 [INFO] <k0n2ad> staring
2011-02-08 22:01:32 [INFO] <AngryRhetoric> to the roof and kill him
2011-02-08 22:01:43 [INFO] <k0n2ad> no arrows
2011-02-08 22:01:53 [INFO] <AngryRhetoric> i can bring some
2011-02-08 22:02:04 [INFO] <k0n2ad> actually i can make some
2011-02-08 22:02:10 [INFO] <nawf> lol
2011-02-08 22:02:19 [INFO] <AngryRhetoric> touchey
2011-02-08 22:02:22 [INFO] <nawf> I'm still working on these castle walls
2011-02-08 22:02:22 [INFO] <AngryRhetoric> *touche
2011-02-08 22:02:34 [INFO] <k0n2ad> sorry, i have arrows, no bow
2011-02-08 22:02:36 [INFO] <k0n2ad> need string
2011-02-08 22:04:54 [INFO] <k0n2ad> FUCKERS
2011-02-08 22:05:00 [INFO] <k0n2ad> blew up my house
2011-02-08 22:05:11 [INFO] <AngryRhetoric> that sucks
2011-02-08 22:05:42 [INFO] <nawf> I like your houssssssss right there
2011-02-08 22:05:48 [INFO] <nawf> Hope you dont
2011-02-08 22:05:52 [INFO] <nawf> Sssssssssssss
2011-02-08 22:05:58 [INFO] <k0n2ad> hahah
2011-02-08 22:07:11 [INFO] <AngryRhetoric> yo
2011-02-08 22:07:19 [INFO] <AngryRhetoric> you at your hut?
2011-02-08 22:07:20 [INFO] <k0n2ad> yo
2011-02-08 22:07:44 [INFO] <k0n2ad> once again u are invisibule
2011-02-08 22:07:51 [INFO] <AngryRhetoric> dammit!
2011-02-08 22:08:20 [INFO] <AngryRhetoric> arrows in nyour door
2011-02-08 22:08:23 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-08 22:08:34 [INFO] AngryRhetoric [/24.147.183.4:60217] logged in with entity id 9325592
2011-02-08 22:08:52 [INFO] <k0n2ad> thanks!
2011-02-08 22:08:54 [INFO] <AngryRhetoric> np
2011-02-08 22:08:56 [INFO] <nawf> gtg for a bit, more work to do
2011-02-08 22:08:58 [INFO] <k0n2ad> i need string though
2011-02-08 22:09:02 [INFO] <k0n2ad> or a bow
2011-02-08 22:09:07 [INFO] <k0n2ad> k
2011-02-08 22:09:09 [INFO] <nawf> they got me ramping up the new guy and I have to hand off a project by thursday
2011-02-08 22:09:11 [INFO] <nawf> :(
2011-02-08 22:09:11 [INFO] <AngryRhetoric> you don't have a bow? lol i thought we got you one
2011-02-08 22:09:15 [INFO] nawf lost connection: disconnect.quitting
2011-02-08 22:09:19 [INFO] <k0n2ad> nah i killed myself
2011-02-08 22:09:24 [INFO] <AngryRhetoric> hah
2011-02-08 22:09:33 [INFO] <AngryRhetoric> aight
2011-02-08 22:09:45 [INFO] <k0n2ad> sweeet
2011-02-08 22:10:04 [INFO] <k0n2ad> that was sad watching you walk away into the darkness
2011-02-08 22:10:07 [INFO] <k0n2ad> lol
2011-02-08 22:10:10 [INFO] <AngryRhetoric> hahaha
2011-02-08 22:10:17 [INFO] <AngryRhetoric> darkness? oh under the trees
2011-02-08 22:10:22 [INFO] <k0n2ad> yea lol
2011-02-08 22:14:11 [INFO] <k0n2ad> im building a water slide
2011-02-08 22:14:24 [INFO] <AngryRhetoric> haha cool
2011-02-08 22:16:56 [INFO] <k0n2ad> holy shit it's already 10 15
2011-02-08 22:17:11 [INFO] <AngryRhetoric> scary huh?
2011-02-08 22:17:32 [INFO] <k0n2ad> yea, time flies
2011-02-08 22:18:06 [INFO] <k0n2ad> ok im going, got some shiat to do... will see u tomorrow brah
2011-02-08 22:18:14 [INFO] <AngryRhetoric> hahaha later brah!
2011-02-08 22:18:22 [INFO] <AngryRhetoric> good games
2011-02-08 22:18:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 22:18:25 [INFO] <AngryRhetoric> haha
2011-02-08 22:18:34 [INFO] <k0n2ad> yea, more to come
2011-02-08 22:18:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 22:19:13 [INFO] <AngryRhetoric> almost got the castle floor complete
2011-02-08 22:19:28 [INFO] <k0n2ad> nice!
2011-02-08 22:19:50 [INFO] <AngryRhetoric> yeah its going to be amassive building
2011-02-08 22:20:07 [INFO] <k0n2ad> ok peace
2011-02-08 22:20:12 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-08 22:26:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 22:32:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 22:52:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-08 22:56:01 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-09 00:18:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 02:18:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 02:19:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 03:18:29 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 03:18:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 04:18:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 04:18:44 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 05:21:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 06:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 06:18:28 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 07:18:06 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 15:18:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 16:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 16:44:15 [INFO] redux06790 [/69.119.8.191:49269] logged in with entity id 9572150
2011-02-09 16:44:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 16:44:21 [INFO] <redux06790> wow
2011-02-09 16:44:29 [INFO] <redux06790> minecraft isnt up to any faggotry today
2011-02-09 16:46:57 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 17:04:02 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-09 17:04:20 [INFO] redux06790 [/69.119.8.191:49277] logged in with entity id 9630210
2011-02-09 17:04:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 17:05:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 17:08:38 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 17:18:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 17:55:31 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-09 17:55:44 [INFO] redux06790 [/69.119.8.191:49286] logged in with entity id 9745689
2011-02-09 17:55:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 17:57:38 [INFO] efess [/192.168.0.198:32911] logged in with entity id 9760504
2011-02-09 17:57:52 [INFO] <efess> yo!
2011-02-09 18:04:15 [INFO] efess lost connection: disconnect.quitting
2011-02-09 18:06:54 [INFO] Disconnecting /192.168.0.198:33342: Took too long to log in
2011-02-09 18:08:07 [INFO] efess [/192.168.0.198:33424] logged in with entity id 9779853
2011-02-09 18:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 18:18:28 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 18:18:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 18:19:19 [INFO] efess lost connection: disconnect.quitting
2011-02-09 18:23:02 [INFO] nawf [/76.23.232.27:55120] logged in with entity id 9882609
2011-02-09 18:23:08 [INFO] <nawf> yo
2011-02-09 18:40:18 [INFO] efess [/192.168.0.198:34514] lost connection
2011-02-09 18:40:41 [INFO] /192.168.0.198:34532 lost connection
2011-02-09 18:40:49 [INFO] <redux06790> OH HAI!
2011-02-09 18:41:03 [INFO] <nawf> omg hai
2011-02-09 18:41:11 [INFO] <redux06790> dude enough with these remote bases
2011-02-09 18:41:11 [INFO] /192.168.0.198:34551 lost connection
2011-02-09 18:41:12 [INFO] <redux06790> lol
2011-02-09 18:41:18 [INFO] <redux06790> its a pain in the ass when you die
2011-02-09 18:41:20 [INFO] <nawf> I don't build them
2011-02-09 18:41:27 [INFO] <redux06790> yeah i know
2011-02-09 18:41:41 [INFO] <redux06790> but derp...
2011-02-09 18:42:05 [INFO] /192.168.0.198:34575 lost connection
2011-02-09 18:42:33 [INFO] <redux06790> oh shit
2011-02-09 18:42:35 [INFO] <redux06790> ive been afk
2011-02-09 18:42:38 [INFO] Disconnecting efess [/192.168.0.198:34588]: Took too long to log in
2011-02-09 18:42:42 [INFO] <redux06790> and i have about 4 creepers outside my cabin
2011-02-09 18:42:46 [INFO] <redux06790> what do?
2011-02-09 18:42:54 [INFO] <nawf> accept your fate, die like a man
2011-02-09 18:43:01 [INFO] <redux06790> NO U!
2011-02-09 18:43:06 [INFO] efess [/192.168.0.198:34617] lost connection
2011-02-09 18:43:22 [INFO] efess [/192.168.0.198:34635] lost connection
2011-02-09 18:43:40 [INFO] Disconnecting efess [/192.168.0.198:34635]: Failed to verify username!
2011-02-09 18:43:41 [INFO] efess [/192.168.0.198:34653] logged in with entity id 9905220
2011-02-09 18:43:41 [INFO] efess lost connection: disconnect.endOfStream
2011-02-09 18:43:41 [INFO] efess lost connection: disconnect.endOfStream
2011-02-09 18:43:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 18:43:48 [INFO] <nawf> wtf
2011-02-09 18:44:08 [INFO] /192.168.0.198:34666 lost connection
2011-02-09 18:44:32 [INFO] /192.168.0.198:34685 lost connection
2011-02-09 18:45:12 [INFO] efess [/192.168.0.198:34719] logged in with entity id 9906266
2011-02-09 18:45:13 [INFO] <redux06790> hmm
2011-02-09 18:45:18 [INFO] <efess> omg hi
2011-02-09 18:45:22 [INFO] <redux06790> do creepers destroy less when they pop now?
2011-02-09 18:45:25 [INFO] <efess> took like 20 tries to login
2011-02-09 18:45:38 [INFO] <nawf> thats actually normal
2011-02-09 18:46:18 [INFO] <efess> john you making that larger?
2011-02-09 18:46:34 [INFO] <nawf> naw, just changing it
2011-02-09 18:50:11 [INFO] <redux06790> so whats the big project these days?
2011-02-09 18:50:23 [INFO] <efess> castle kick ass
2011-02-09 18:50:37 [INFO] <redux06790> i prefer castle big dick but thats just me
2011-02-09 18:50:44 [INFO] <redux06790> sounds more intimidating
2011-02-09 18:51:36 [INFO] <redux06790> i think im going to do some good old fashioned deforesting
2011-02-09 18:51:45 [INFO] <efess> woot
2011-02-09 18:54:33 [INFO] <redux06790> fuck i havent been back to the castle in... well since we spleefed whats his face
2011-02-09 18:54:52 [INFO] <nawf> oh yeah, that was awesome
2011-02-09 18:54:56 [INFO] <nawf> angry was idling
2011-02-09 18:55:00 [INFO] <nawf> on the castle floor
2011-02-09 18:55:04 [INFO] <redux06790> omfg i was pissing myself laughing
2011-02-09 18:55:12 [INFO] <nawf> so we put water down, and erun cleared out the blocks under him
2011-02-09 18:55:24 [INFO] <nawf> so we ended up in the basement and we replaced the blocks
2011-02-09 18:55:31 [INFO] <nawf> so HE, angry, ended up...
2011-02-09 18:55:31 [INFO] <redux06790> lol
2011-02-09 18:55:33 [INFO] <redux06790> wellll
2011-02-09 18:55:39 [INFO] <redux06790> technically you saved him john
2011-02-09 18:55:47 [INFO] <redux06790> because i was going to do it with or without the water haha
2011-02-09 18:55:51 [INFO] <nawf> lol
2011-02-09 18:55:59 [INFO] <efess> lol
2011-02-09 18:56:31 [INFO] <redux06790> im going to check my fb while its night
2011-02-09 18:56:32 [INFO] <redux06790> brb
2011-02-09 19:13:50 [INFO] <redux06790> have any of you guys ever been on a SMPRP server?
2011-02-09 19:13:59 [INFO] <efess> no
2011-02-09 19:14:02 [INFO] <nawf> nope
2011-02-09 19:14:10 [INFO] <redux06790> i cant imagine that would be interesting
2011-02-09 19:15:03 [INFO] <redux06790> i mean... if im going to RP im breaking out the dice... amiriet?
2011-02-09 19:15:16 [INFO] <nawf> or the sexy nurse outfit
2011-02-09 19:15:21 [INFO] <redux06790> only for you
2011-02-09 19:15:25 [INFO] <nawf> ;)
2011-02-09 19:15:35 [INFO] <redux06790> no wax next time though, i got blisters
2011-02-09 19:15:55 [INFO] <nawf> well at least you didn't have the candle up your ass
2011-02-09 19:16:15 [INFO] <redux06790> how you managed to keep it lit at both ends still amazes me
2011-02-09 19:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 19:18:37 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 19:19:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 19:21:19 [INFO] <efess> bbl
2011-02-09 19:21:20 [INFO] efess lost connection: disconnect.quitting
2011-02-09 19:22:30 [INFO] <nawf> I gotta get back to work
2011-02-09 19:22:34 [INFO] <nawf> see yah erin
2011-02-09 19:22:44 [INFO] nawf lost connection: disconnect.quitting
2011-02-09 19:28:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 19:30:58 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-09 19:31:16 [INFO] redux06790 [/69.119.8.191:49517] lost connection
2011-02-09 19:31:22 [INFO] /69.119.8.191:49519 lost connection
2011-02-09 19:31:25 [INFO] redux06790 [/69.119.8.191:49522] logged in with entity id 10029486
2011-02-09 19:32:29 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 19:37:49 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-09 20:15:15 [INFO] k0n2ad [/24.218.113.229:8001] logged in with entity id 10062516
2011-02-09 20:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 20:18:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 20:21:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 20:42:17 [INFO] Unknown console command. Type ""help"" for help.
2011-02-09 20:42:19 [INFO] To run the server without a gui, start it like this:
2011-02-09 20:42:19 [INFO]    java -Xmx1024M -Xms1024M -jar minecraft_server.jar nogui
2011-02-09 20:42:19 [INFO] Console commands:
2011-02-09 20:42:19 [INFO]    help  or  ?               shows this message
2011-02-09 20:42:19 [INFO]    kick <player>             removes a player from the server
2011-02-09 20:42:19 [INFO]    ban <player>              bans a player from the server
2011-02-09 20:42:19 [INFO]    pardon <player>           pardons a banned player so that they can connect again
2011-02-09 20:42:19 [INFO]    ban-ip <ip>               bans an IP address from the server
2011-02-09 20:42:19 [INFO]    pardon-ip <ip>            pardons a banned IP address so that they can connect again
2011-02-09 20:42:19 [INFO]    op <player>               turns a player into an op
2011-02-09 20:42:19 [INFO]    deop <player>             removes op status from a player
2011-02-09 20:42:19 [INFO]    tp <player1> <player2>    moves one player to the same location as another player
2011-02-09 20:42:19 [INFO]    give <player> <id> [num]  gives a player a resource
2011-02-09 20:42:19 [INFO]    tell <player> <message>   sends a private message to a player
2011-02-09 20:42:19 [INFO]    stop                      gracefully stops the server
2011-02-09 20:42:19 [INFO]    save-all                  forces a server-wide level save
2011-02-09 20:42:19 [INFO]    save-off                  disables terrain saving (useful for backup scripts)
2011-02-09 20:42:19 [INFO]    save-on                   re-enables terrain saving
2011-02-09 20:42:19 [INFO]    list                      lists all currently connected players
2011-02-09 20:42:19 [INFO]    say <message>             broadcasts a message to all players
2011-02-09 21:05:09 [INFO] efess [/192.168.0.198:38522] logged in with entity id 10122026
2011-02-09 21:05:14 [INFO] <efess> Yo
2011-02-09 21:05:19 [INFO] <k0n2ad> yoooo
2011-02-09 21:05:23 [INFO] <efess> what up dave
2011-02-09 21:05:45 [INFO] <k0n2ad> not much joe... exploring your ridiculously huge world of wonders
2011-02-09 21:06:05 [INFO] <efess> haha
2011-02-09 21:06:06 [INFO] <efess> nice
2011-02-09 21:06:11 [INFO] <efess> you get a proper tour?
2011-02-09 21:06:30 [INFO] <k0n2ad> a little bit here and there... but im coming around
2011-02-09 21:06:34 [INFO] <efess> ya
2011-02-09 21:06:34 [INFO] <k0n2ad> yo
2011-02-09 21:06:37 [INFO] <efess> see the spawner?
2011-02-09 21:06:59 [INFO] <k0n2ad> no where is that
2011-02-09 21:07:07 [INFO] <efess> the mob grinder
2011-02-09 21:07:11 [INFO] <k0n2ad> oh yea
2011-02-09 21:07:29 [INFO] <k0n2ad> so this is going to be the big ass castle?
2011-02-09 21:07:30 [INFO] <efess> that thing is fkn awesome
2011-02-09 21:07:40 [INFO] <k0n2ad> it's amazing man
2011-02-09 21:07:44 [INFO] <efess> yea john's doing a pretty kick ass job with the front
2011-02-09 21:07:45 [INFO] <k0n2ad> i was marveling at it earlier
2011-02-09 21:08:00 [INFO] <efess> I'm not really sure what to do for the interior though
2011-02-09 21:08:10 [INFO] <k0n2ad> im sure ideas will come up
2011-02-09 21:08:14 [INFO] <efess> ya
2011-02-09 21:08:18 [INFO] <k0n2ad> im going to go do some more exploring
2011-02-09 21:08:26 [INFO] <efess> sweet
2011-02-09 21:08:33 [INFO] <k0n2ad> it's really overwhelming - when i play single, shit is so hard to find
2011-02-09 21:08:33 [INFO] <efess> feel free to modify or add on to anything we made
2011-02-09 21:08:40 [INFO] <k0n2ad> you guys have like everything out here
2011-02-09 21:08:49 [INFO] <k0n2ad> thanks
2011-02-09 21:08:53 [INFO] <efess> haha yea splunking
2011-02-09 21:09:28 [INFO] <k0n2ad> i dug my ass up from a cave just came to surface when you got here
2011-02-09 21:09:39 [INFO] <efess> lol
2011-02-09 21:09:47 [INFO] <efess> most of the caves around here are already explorered
2011-02-09 21:09:53 [INFO] <efess> explored*
2011-02-09 21:10:40 [INFO] <efess> the end of the rail system takes you to some un-explored caves
2011-02-09 21:10:47 [INFO] <efess> if you're looking for some
2011-02-09 21:11:06 [INFO] <k0n2ad> yea, dude you guys built an awesome rail ssystem
2011-02-09 21:11:15 [INFO] <efess> thanks :D
2011-02-09 21:11:18 [INFO] <k0n2ad> we need to expand that shite
2011-02-09 21:11:42 [INFO] <efess> yea eventually I want to move this base's rail station to inside the castle
2011-02-09 21:12:22 [INFO] <k0n2ad> nice
2011-02-09 21:14:50 [INFO] <efess> i'm working on a minecraft server wrapper in c# :D
2011-02-09 21:15:08 [INFO] <k0n2ad> for real?
2011-02-09 21:15:19 [INFO] <efess> yea sorta like that McAdmin app
2011-02-09 21:15:32 [INFO] <k0n2ad> dunno what that is
2011-02-09 21:15:39 [INFO] <efess> oh its a minecraft admin tool
2011-02-09 21:16:10 [INFO] <k0n2ad> oic
2011-02-09 21:16:15 [INFO] <k0n2ad> thats awesome man
2011-02-09 21:16:49 [INFO] <efess> well its mostly for server backups
2011-02-09 21:17:15 [INFO] <k0n2ad> the wrapper?
2011-02-09 21:17:18 [INFO] <efess> and w/e else I want to do w/ the server, i'll be able to do it remotely
2011-02-09 21:17:19 [INFO] <efess> ya
2011-02-09 21:17:32 [INFO] <k0n2ad> what can you do, what kind of stuff
2011-02-09 21:17:52 [INFO] <efess> eh maybe warp people around
2011-02-09 21:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 21:18:02 [INFO] <efess> one annoying thing is the lack of a player list
2011-02-09 21:18:07 [INFO] <efess> when you join you can't tell who's here
2011-02-09 21:18:10 [INFO] <k0n2ad> yea can't see who's playing
2011-02-09 21:18:27 [INFO] <efess> so you'll be able to type !players
2011-02-09 21:18:35 [INFO] <efess> and it'll tell you who
2011-02-09 21:18:35 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 21:18:38 [INFO] <efess> s here
2011-02-09 21:18:47 [INFO] <k0n2ad> good idea - so this guy built an API that you can call?
2011-02-09 21:19:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 21:19:01 [INFO] <efess> well not really, when you start the server, it's just a console app
2011-02-09 21:19:22 [INFO] <efess> so the wrapper will just take the input/output from the server
2011-02-09 21:19:27 [INFO] <efess> keep state in memory
2011-02-09 21:19:32 [INFO] <efess> and respond to user message
2011-02-09 21:19:33 [INFO] <efess> s
2011-02-09 21:20:00 [INFO] <k0n2ad> oh ok... but what about other in game stuff, won't you have to call directly to mc?
2011-02-09 21:20:25 [INFO] <efess> well it'll direct some input to the server console
2011-02-09 21:20:36 [INFO] <efess> there's no real api yet
2011-02-09 21:20:44 [INFO] <k0n2ad> gotcha
2011-02-09 21:21:35 [INFO] <k0n2ad> holy shit what is this
2011-02-09 21:21:41 [INFO] <efess> ?
2011-02-09 21:21:49 [INFO] <k0n2ad> this place right here
2011-02-09 21:22:04 [INFO] <efess> are you near me?
2011-02-09 21:22:10 [INFO] <k0n2ad> lol right under you
2011-02-09 21:22:17 [INFO] <efess> ah your invisible
2011-02-09 21:22:18 [INFO] <efess> brb
2011-02-09 21:22:20 [INFO] efess lost connection: disconnect.quitting
2011-02-09 21:22:23 [INFO] efess [/192.168.0.198:38978] logged in with entity id 10153458
2011-02-09 21:22:28 [INFO] <efess> there you are
2011-02-09 21:22:36 [INFO] <efess> I donno just some interior
2011-02-09 21:22:45 [INFO] <efess> an interior room lol
2011-02-09 21:22:48 [INFO] <k0n2ad> yea this happened yest. kevin kept going invisible
2011-02-09 21:22:53 [INFO] <k0n2ad> its big
2011-02-09 21:23:15 [INFO] <efess> ya happens to john all the time
2011-02-09 21:23:21 [INFO] <efess> first time it happend to me though
2011-02-09 21:23:31 [INFO] <k0n2ad> wierd
2011-02-09 21:42:12 [INFO] <efess> hey
2011-02-09 21:42:18 [INFO] <k0n2ad> yo
2011-02-09 21:42:19 [INFO] <efess> did you take some minecarts from the boosters?
2011-02-09 21:42:41 [INFO] <efess> :P
2011-02-09 21:42:44 [INFO] <k0n2ad> i grabbed 1 or 2 at some point but put them back on the track
2011-02-09 21:42:48 [INFO] <efess> ah
2011-02-09 21:42:48 [INFO] <k0n2ad> what are boosters?
2011-02-09 21:43:03 [INFO] <efess> never heard about boosters?
2011-02-09 21:43:06 [INFO] <efess> well sir!
2011-02-09 21:43:16 [INFO] <k0n2ad> lol
2011-02-09 21:43:19 [INFO] <efess> so there's a bug in minecraft
2011-02-09 21:43:37 [INFO] <efess> if you ride a minecart next to another minecart on an adjacent track
2011-02-09 21:43:50 [INFO] <efess> the other minecart will accelerate you
2011-02-09 21:44:01 [INFO] <k0n2ad> ah ive noticed that
2011-02-09 21:44:17 [INFO] <efess> yea so there's a bunch of short track sections around with minecarts idling
2011-02-09 21:44:19 [INFO] <efess> as boosters
2011-02-09 21:44:41 [INFO] <k0n2ad> oic - leave those there
2011-02-09 21:44:47 [INFO] <efess> yea :D
2011-02-09 21:44:52 [INFO] <k0n2ad> np
2011-02-09 21:44:56 [INFO] <k0n2ad> thanks for letting me know
2011-02-09 21:45:11 [INFO] <efess> sure, usually there should be a chest w/ mninecarts stocked up
2011-02-09 21:45:28 [INFO] <efess> also at the main base, there's a minecart dispensor
2011-02-09 21:45:33 [INFO] <efess> but it's been empty
2011-02-09 21:45:34 [INFO] <efess> lol
2011-02-09 21:45:46 [INFO] <k0n2ad> which one is main base?
2011-02-09 21:45:52 [INFO] <efess> the one next to the spawn
2011-02-09 21:49:24 [INFO] <efess> im a fkn lumberjack
2011-02-09 21:49:37 [INFO] <k0n2ad> haha.. did you see my log cabin?
2011-02-09 21:49:41 [INFO] <efess> nah where is it?
2011-02-09 21:49:54 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 21:49:56 [INFO] <k0n2ad> near the spawn point, above water slide
2011-02-09 21:50:13 [INFO] <efess> nice i'll check it out when I get back
2011-02-09 21:50:17 [INFO] <k0n2ad> k
2011-02-09 21:50:24 [INFO] <efess> deforestation at work
2011-02-09 21:50:38 [INFO] <k0n2ad> haha... show those trees
2011-02-09 22:03:06 [INFO] AngryRhetoric [/24.147.183.4:49572] logged in with entity id 10232077
2011-02-09 22:03:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 22:03:11 [INFO] <efess> hey!
2011-02-09 22:03:12 [INFO] <AngryRhetoric> SUP!
2011-02-09 22:03:15 [INFO] <AngryRhetoric> hey joe
2011-02-09 22:03:19 [INFO] <efess> what up kev
2011-02-09 22:03:28 [INFO] <k0n2ad> yo bieathc
2011-02-09 22:03:37 [INFO] <AngryRhetoric> hahaha hey kontad is on ;)
2011-02-09 22:03:54 [INFO] <k0n2ad> watch out at the bottom of your island steps
2011-02-09 22:04:34 [INFO] <AngryRhetoric> i'm at the southern home haha
2011-02-09 22:05:14 [INFO] <AngryRhetoric> just got back from that date with rachel :)
2011-02-09 22:05:22 [INFO] <k0n2ad> oh shi- how did it go?
2011-02-09 22:05:39 [INFO] <AngryRhetoric> very well actually, she seemed to be having a good time too
2011-02-09 22:05:49 [INFO] <AngryRhetoric> we're prolly gettin together on saturday
2011-02-09 22:05:53 [INFO] <k0n2ad> nice.. intersted in her ?
2011-02-09 22:06:07 [INFO] <AngryRhetoric> yeah definitely!
2011-02-09 22:06:14 [INFO] <k0n2ad> shweet
2011-02-09 22:06:19 [INFO] <efess> :D
2011-02-09 22:06:43 [INFO] <AngryRhetoric> we'll see how things go but for first dates it couldn't go better
2011-02-09 22:06:52 [INFO] <k0n2ad> good to hear
2011-02-09 22:07:28 [INFO] <AngryRhetoric> now to go hunting for clay or return to the main base....
2011-02-09 22:10:54 [INFO] <efess> how many stacks of logs is enough...
2011-02-09 22:11:01 [INFO] <AngryRhetoric> haha for what
2011-02-09 22:11:04 [INFO] <k0n2ad> never enough
2011-02-09 22:11:05 [INFO] <efess> is there such a thing?
2011-02-09 22:11:09 [INFO] <efess> right
2011-02-09 22:11:13 [INFO] <AngryRhetoric> haha
2011-02-09 22:11:15 [INFO] <k0n2ad> lol
2011-02-09 22:11:23 [INFO] <AngryRhetoric> you can always have more
2011-02-09 22:13:22 [INFO] <AngryRhetoric> sweeet clay!
2011-02-09 22:15:15 [INFO] <AngryRhetoric> alkmost 4 stacks of clay
2011-02-09 22:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 22:18:48 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 22:20:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 22:20:17 [INFO] <AngryRhetoric> what are you guys working on?
2011-02-09 22:20:32 [INFO] <efess> lumberjacking for castle roofs
2011-02-09 22:20:43 [INFO] <AngryRhetoric> the big castle roof?
2011-02-09 22:20:45 [INFO] <efess> ya
2011-02-09 22:20:46 [INFO] <k0n2ad> im just walking around for now... about to depart, as once again, it's fucking 10:20
2011-02-09 22:20:58 [INFO] <AngryRhetoric> haha how long have you been on?
2011-02-09 22:21:18 [INFO] <k0n2ad> since 8ish
2011-02-09 22:21:23 [INFO] <AngryRhetoric> haha niiice
2011-02-09 22:21:29 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-09 22:21:46 [INFO] <AngryRhetoric> if you feel like wandering south let me know
2011-02-09 22:21:57 [INFO] <AngryRhetoric> and joe wouldn't the castle roof be stone? or maybe a combo
2011-02-09 22:22:00 [INFO] <k0n2ad> lol, which way is south
2011-02-09 22:22:12 [INFO] <efess> well
2011-02-09 22:22:17 [INFO] <k0n2ad> ill have to wait till the sun rises
2011-02-09 22:22:31 [INFO] <efess> for the inside ""house rooms"" will be wood ceilling
2011-02-09 22:22:41 [INFO] <AngryRhetoric> oh yeah good point
2011-02-09 22:22:45 [INFO] <efess> I don't think we're going to cover the entire thing
2011-02-09 22:22:50 [INFO] <efess> just the buildings inside
2011-02-09 22:22:53 [INFO] <AngryRhetoric> plus john was talking about a library, and stuff too
2011-02-09 22:22:58 [INFO] <efess> ya
2011-02-09 22:23:06 [INFO] <efess> i started building a model building in the basement
2011-02-09 22:23:12 [INFO] <AngryRhetoric> ooh good call
2011-02-09 22:23:22 [INFO] <AngryRhetoric> we can work out a 1/10th scale down there haha
2011-02-09 22:23:27 [INFO] <efess> lol
2011-02-09 22:24:50 [INFO] <AngryRhetoric> ahh sunrise
2011-02-09 22:26:07 [INFO] <AngryRhetoric> buurrn zombies burn
2011-02-09 22:28:18 [INFO] <efess> alright gonna hit the sack
2011-02-09 22:28:20 [INFO] <efess> night guys
2011-02-09 22:28:24 [INFO] <AngryRhetoric> later joe
2011-02-09 22:28:26 [INFO] efess lost connection: disconnect.quitting
2011-02-09 22:28:30 [INFO] <k0n2ad> night joe
2011-02-09 22:28:35 [INFO] <k0n2ad> doh
2011-02-09 22:28:43 [INFO] <AngryRhetoric> haha close
2011-02-09 22:31:10 [INFO] <k0n2ad> ok im out too
2011-02-09 22:31:16 [INFO] <k0n2ad> c u tomorrow
2011-02-09 22:31:24 [INFO] <AngryRhetoric> alright man, laaters
2011-02-09 22:31:26 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-09 23:07:14 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-10 00:18:33 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 01:18:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 02:18:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 05:59:58 [INFO] Starting minecraft server version Beta 1.2_01
2011-02-10 05:59:58 [INFO] Loading properties
2011-02-10 05:59:58 [INFO] Starting Minecraft server on *:25565
2011-02-10 05:59:58 [INFO] Preparing level ""world""
2011-02-10 05:59:58 [INFO] Preparing start region
2011-02-10 06:00:00 [INFO] Preparing spawn area: 16%
2011-02-10 06:00:01 [INFO] Preparing spawn area: 24%
2011-02-10 06:00:02 [INFO] Preparing spawn area: 28%
2011-02-10 06:00:03 [INFO] Preparing spawn area: 40%
2011-02-10 06:00:04 [INFO] Preparing spawn area: 48%
2011-02-10 06:00:05 [INFO] Preparing spawn area: 60%
2011-02-10 06:00:06 [INFO] Preparing spawn area: 73%
2011-02-10 06:00:07 [INFO] Preparing spawn area: 85%
2011-02-10 06:00:08 [INFO] Preparing spawn area: 97%
2011-02-10 06:00:08 [INFO] Done! For help, type ""help"" or ""?""
2011-02-10 06:19:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 06:21:37 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 07:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 07:18:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 08:18:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 08:18:31 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 08:19:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 09:19:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 10:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 11:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 11:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 12:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 12:18:33 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 13:18:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 15:18:20 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 18:55:30 [INFO] redux06790 [/69.119.8.191:49217] logged in with entity id 211
2011-02-10 18:55:33 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 18:56:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 18:57:16 [INFO] <redux06790> omfg
2011-02-10 18:57:20 [INFO] <redux06790> anyone on?
2011-02-10 19:07:55 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 19:09:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 19:13:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 19:31:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 19:31:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:06:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:18:21 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:18:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:18:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:19:01 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:20:58 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-10 20:49:37 [INFO] redux06790 [/69.119.8.191:49268] logged in with entity id 243186
2011-02-10 20:51:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:59:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 20:59:43 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-10 21:00:11 [INFO] /69.119.8.191:49275 lost connection
2011-02-10 21:00:21 [INFO] redux06790 [/69.119.8.191:49277] lost connection
2011-02-10 21:00:25 [INFO] redux06790 [/69.119.8.191:49280] lost connection
2011-02-10 21:00:43 [INFO] /69.119.8.191:49286 lost connection
2011-02-10 21:00:46 [INFO] /69.119.8.191:49288 lost connection
2011-02-10 21:01:07 [INFO] /69.119.8.191:49295 lost connection
2011-02-10 21:01:10 [INFO] /69.119.8.191:49297 lost connection
2011-02-10 21:01:58 [INFO] redux06790 [/69.119.8.191:49318] lost connection
2011-02-10 21:02:44 [INFO] /69.119.8.191:49323 lost connection
2011-02-10 21:02:58 [INFO] redux06790 [/69.119.8.191:49326] logged in with entity id 265757
2011-02-10 21:15:49 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 21:18:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 21:19:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 21:20:28 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 21:21:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 21:23:29 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-10 21:23:53 [INFO] redux06790 [/69.119.8.191:49353] logged in with entity id 312765
2011-02-10 21:35:52 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-10 22:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-10 23:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 00:18:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 01:18:25 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 01:18:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 02:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 03:18:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 05:18:33 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 05:18:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 06:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 07:18:40 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 08:26:01 [INFO] redux06790 [/69.119.8.191:49362] logged in with entity id 320182
2011-02-11 08:26:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 08:26:51 [INFO] <redux06790> derp
2011-02-11 08:29:24 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-11 09:18:01 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 09:55:57 [INFO] AngryRhetoric [/24.147.183.4:51718] logged in with entity id 322296
2011-02-11 09:56:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 09:56:12 [INFO] <AngryRhetoric> hola?
2011-02-11 09:56:38 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:05:33 [INFO] redux06790 [/69.119.8.191:49526] logged in with entity id 337275
2011-02-11 10:05:39 [INFO] <AngryRhetoric> hey sup erin
2011-02-11 10:05:44 [INFO] <redux06790> MY DICK!!!!!!!!
2011-02-11 10:05:48 [INFO] <redux06790> FUCK YEA!
2011-02-11 10:05:49 [INFO] <AngryRhetoric> lol good call
2011-02-11 10:06:01 [INFO] <redux06790> ive never gone longer than 4 hours without an erection
2011-02-11 10:06:12 [INFO] <redux06790> its been 3.75 hours
2011-02-11 10:06:13 [INFO] <AngryRhetoric> that sounds like a stand up comedian line
2011-02-11 10:06:18 [INFO] <AngryRhetoric> you're overdue!!
2011-02-11 10:06:23 [INFO] <redux06790> lawl
2011-02-11 10:06:33 [INFO] <redux06790> im thinking of turning the spawn into a contemporary home
2011-02-11 10:06:48 [INFO] <redux06790> if i could figure out exactly what block the spawn is
2011-02-11 10:06:48 [INFO] <AngryRhetoric> haha nice
2011-02-11 10:06:58 [INFO] <AngryRhetoric> yeah i've got that in the south here
2011-02-11 10:07:01 [INFO] <redux06790> since it seems like every time i die i land on a random block at the spawn
2011-02-11 10:07:12 [INFO] <redux06790> did you see my waypoint buildings i made you?
2011-02-11 10:07:45 [INFO] <redux06790> no?
2011-02-11 10:07:56 [INFO] <redux06790> lag?
2011-02-11 10:08:01 [INFO] <redux06790> MARCO!!!
2011-02-11 10:08:05 [INFO] <AngryRhetoric> POLO!!
2011-02-11 10:08:15 [INFO] <AngryRhetoric> polo bitches
2011-02-11 10:08:29 [INFO] <redux06790> so did you see the buildings i made heading to your house?
2011-02-11 10:08:40 [INFO] <AngryRhetoric> haha wait no
2011-02-11 10:08:44 [INFO] <redux06790> yeah
2011-02-11 10:08:49 [INFO] <redux06790> hang on ill come to the spawn
2011-02-11 10:08:55 [INFO] <redux06790> ill take the fast way
2011-02-11 10:09:12 [INFO] <AngryRhetoric> i gotta check that out lol i made some additions myself but didn't see your stuff
2011-02-11 10:09:25 [INFO] <AngryRhetoric> sunrise, gogogogoggo hah
2011-02-11 10:09:34 [INFO] <redux06790> omw
2011-02-11 10:09:44 [INFO] <redux06790> brt
2011-02-11 10:09:49 [INFO] <redux06790> im leaving my house now lol
2011-02-11 10:10:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:10:09 [INFO] <redux06790> lol i took the fast way
2011-02-11 10:10:21 [INFO] <redux06790> aka dying
2011-02-11 10:10:24 [INFO] <redux06790> where are you?
2011-02-11 10:10:38 [INFO] <AngryRhetoric> at the southern home wayyy south
2011-02-11 10:10:43 [INFO] <redux06790> oh man
2011-02-11 10:10:45 [INFO] <redux06790> lol
2011-02-11 10:10:47 [INFO] <AngryRhetoric> did you build buildings near the castle?
2011-02-11 10:10:53 [INFO] <AngryRhetoric> i can come north
2011-02-11 10:11:03 [INFO] <redux06790> hang on
2011-02-11 10:11:31 [INFO] <redux06790> ive taken to dying to get back to spawn haha
2011-02-11 10:11:56 [INFO] <redux06790> start heading north
2011-02-11 10:11:59 [INFO] <AngryRhetoric> you were at your northern hut right?
2011-02-11 10:12:06 [INFO] <redux06790> you might see one of the buildings i made
2011-02-11 10:12:09 [INFO] <redux06790> its a hike tho
2011-02-11 10:12:10 [INFO] <redux06790> yeah
2011-02-11 10:12:14 [INFO] <redux06790> i just leave my gear there
2011-02-11 10:13:05 [INFO] <redux06790> dude
2011-02-11 10:13:08 [INFO] <redux06790> i was pissed
2011-02-11 10:13:51 [INFO] <redux06790> you there?
2011-02-11 10:13:54 [INFO] <AngryRhetoric> coming
2011-02-11 10:14:00 [INFO] <redux06790> hmm
2011-02-11 10:14:20 [INFO] <redux06790> that would be why youre not talking haha
2011-02-11 10:14:30 [INFO] <AngryRhetoric> haha can't do both!
2011-02-11 10:14:34 [INFO] <AngryRhetoric> haven't seen bldgs yet
2011-02-11 10:14:36 [INFO] <redux06790> wtb autorun button
2011-02-11 10:14:43 [INFO] <redux06790> its KINDA hiddenish
2011-02-11 10:14:46 [INFO] <redux06790> both of them
2011-02-11 10:14:49 [INFO] <AngryRhetoric> how close to the house did you make... ah ok
2011-02-11 10:14:57 [INFO] <AngryRhetoric> in the forsest?
2011-02-11 10:14:57 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:15:04 [INFO] <redux06790> um on a hill and in the ground
2011-02-11 10:15:46 [INFO] <redux06790> you know the desert biome?
2011-02-11 10:15:52 [INFO] <AngryRhetoric> yeah
2011-02-11 10:16:00 [INFO] <redux06790> ok well if youre going TO your base
2011-02-11 10:16:06 [INFO] <redux06790> the first one is past the desert biome
2011-02-11 10:16:15 [INFO] <redux06790> the second one is about a minute walk after that
2011-02-11 10:16:33 [INFO] <AngryRhetoric> ok i'm still in the forest
2011-02-11 10:16:38 [INFO] <redux06790> im trying to follow your your torches
2011-02-11 10:16:46 [INFO] <AngryRhetoric> i made a walkway
2011-02-11 10:16:52 [INFO] <AngryRhetoric> over water
2011-02-11 10:17:02 [INFO] <redux06790> i saw
2011-02-11 10:17:25 [INFO] <redux06790> i kinda did a massive deforesting mission
2011-02-11 10:17:32 [INFO] <AngryRhetoric> nice
2011-02-11 10:17:52 [INFO] <redux06790> so if you see about 25 saplings...
2011-02-11 10:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:18:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:18:27 [INFO] <AngryRhetoric> haha nice i see the walkway has a door
2011-02-11 10:18:34 [INFO] <redux06790> HAHA
2011-02-11 10:18:37 [INFO] <redux06790> i forgot about that
2011-02-11 10:18:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:19:02 [INFO] <AngryRhetoric> wait this isn't a doorway! lol bastid
2011-02-11 10:19:09 [INFO] <redux06790> haha im a fuck
2011-02-11 10:19:13 [INFO] <AngryRhetoric> free sign!
2011-02-11 10:19:18 [INFO] <redux06790> fuck
2011-02-11 10:19:30 [INFO] <redux06790> i forgot what it said too
2011-02-11 10:19:40 [INFO] <AngryRhetoric> free sign 8===D
2011-02-11 10:19:48 [INFO] <redux06790> oh yea
2011-02-11 10:19:48 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:19:55 [INFO] <redux06790> i debated calling you a faggot
2011-02-11 10:20:18 [INFO] <redux06790> FUU
2011-02-11 10:20:19 [INFO] <redux06790> im lost
2011-02-11 10:20:22 [INFO] <AngryRhetoric> haha
2011-02-11 10:20:25 [INFO] <redux06790> ill have to wait till you happen by
2011-02-11 10:20:39 [INFO] <AngryRhetoric> my current Z coord is -200
2011-02-11 10:20:44 [INFO] <AngryRhetoric> x 1128
2011-02-11 10:20:51 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-11 10:20:59 [INFO] redux06790 [/69.119.8.191:49535] logged in with entity id 376412
2011-02-11 10:21:05 [INFO] <AngryRhetoric> crap sunset
2011-02-11 10:21:08 [INFO] <redux06790> shit the sun is going down
2011-02-11 10:21:09 [INFO] <redux06790> RUN
2011-02-11 10:21:31 [INFO] <redux06790> ill look out for your name plaque
2011-02-11 10:21:35 [INFO] <AngryRhetoric> i see you
2011-02-11 10:22:06 [INFO] <AngryRhetoric> hahaha chaaaarrrlieeee
2011-02-11 10:22:07 [INFO] <AngryRhetoric> nice hut
2011-02-11 10:22:14 [INFO] <redux06790> dude its bitchen
2011-02-11 10:22:19 [INFO] <redux06790> check it
2011-02-11 10:22:21 [INFO] <redux06790> attic
2011-02-11 10:22:25 [INFO] <AngryRhetoric> how'd you do the picture??
2011-02-11 10:22:30 [INFO] <redux06790> sticks and wool
2011-02-11 10:22:41 [INFO] <AngryRhetoric> can you paint whatever you want?
2011-02-11 10:22:45 [INFO] <redux06790> sticks like youre going to make a box
2011-02-11 10:22:48 [INFO] <redux06790> and wool in the middle
2011-02-11 10:22:49 [INFO] <redux06790> and no
2011-02-11 10:23:15 [INFO] <AngryRhetoric> i'm gonna add paintings and bookshelves to the southern house
2011-02-11 10:23:20 [INFO] <redux06790> hell yea
2011-02-11 10:23:22 [INFO] <AngryRhetoric> this is cool
2011-02-11 10:23:25 [INFO] <redux06790> wait till you see the other base
2011-02-11 10:23:26 [INFO] <AngryRhetoric> can't get in the bed haha
2011-02-11 10:23:30 [INFO] <AngryRhetoric> ima pee on the bed
2011-02-11 10:23:33 [INFO] <redux06790> lemme make a sword
2011-02-11 10:23:52 [INFO] <redux06790> shitballs
2011-02-11 10:23:55 [INFO] <redux06790> can you break these
2011-02-11 10:24:23 [INFO] <redux06790> no?
2011-02-11 10:24:34 [INFO] <redux06790> i needed two blocks lol
2011-02-11 10:25:14 [INFO] <redux06790> wanna see the next place?
2011-02-11 10:26:34 [INFO] <redux06790> hence the pork
2011-02-11 10:27:08 [INFO] <redux06790> you ready?
2011-02-11 10:27:19 [INFO] <AngryRhetoric> for what
2011-02-11 10:27:23 [INFO] <AngryRhetoric> oh yeah
2011-02-11 10:27:24 [INFO] <redux06790> to see the next place
2011-02-11 10:27:25 [INFO] <AngryRhetoric> next place
2011-02-11 10:28:14 [INFO] <redux06790> fuck when did zombies get reach?
2011-02-11 10:28:23 [INFO] <AngryRhetoric> yeah they suck
2011-02-11 10:28:55 [INFO] <redux06790> lol heees lookin for you
2011-02-11 10:29:34 [INFO] <redux06790> THE SUN!!!
2011-02-11 10:29:39 [INFO] <AngryRhetoric> finally
2011-02-11 10:29:45 [INFO] <redux06790> 3 hearts left here
2011-02-11 10:29:50 [INFO] <AngryRhetoric> ouch need a ham? haha
2011-02-11 10:29:55 [INFO] <redux06790> nah
2011-02-11 10:29:59 [INFO] <redux06790> i dont have anything good on me
2011-02-11 10:30:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:30:50 [INFO] <redux06790> hmm
2011-02-11 10:30:55 [INFO] <redux06790> maybe i hid it too well lol
2011-02-11 10:31:00 [INFO] <redux06790> oh nvm
2011-02-11 10:31:02 [INFO] <AngryRhetoric> lol
2011-02-11 10:31:04 [INFO] <redux06790> i see
2011-02-11 10:31:34 [INFO] <AngryRhetoric> hahahaha
2011-02-11 10:31:43 [INFO] <AngryRhetoric> i don't see it, it can't be near the sign that says it isn't here
2011-02-11 10:31:57 [INFO] <AngryRhetoric> coool
2011-02-11 10:32:31 [INFO] <redux06790> so yea
2011-02-11 10:32:35 [INFO] <redux06790> the reason i made these
2011-02-11 10:32:38 [INFO] <AngryRhetoric> this one is def hidden
2011-02-11 10:32:48 [INFO] <redux06790> i got assfucked like 10 times by creepers trying to get to spawn
2011-02-11 10:32:53 [INFO] <redux06790> so i made these at night
2011-02-11 10:33:04 [INFO] <AngryRhetoric> yeah this will provide safe houses on the journey south
2011-02-11 10:33:11 [INFO] <redux06790> and provisions ahaha
2011-02-11 10:33:17 [INFO] <redux06790> brb in like 10
2011-02-11 10:33:29 [INFO] <AngryRhetoric> ok i gotta quit soon
2011-02-11 10:33:33 [INFO] <redux06790> k
2011-02-11 10:33:36 [INFO] <AngryRhetoric> maybe 15-20 mins more tops
2011-02-11 10:34:11 [INFO] <AngryRhetoric> i added some provisions to the chest
2011-02-11 10:41:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 10:43:41 [INFO] <redux06790> omfg
2011-02-11 10:43:49 [INFO] <redux06790> i would sell my nigger for these they are so good
2011-02-11 10:43:59 [INFO] <AngryRhetoric> hah you have just one?
2011-02-11 10:44:04 [INFO] <redux06790> lol omg
2011-02-11 10:44:05 [INFO] <AngryRhetoric> what is so good lol
2011-02-11 10:44:18 [INFO] <redux06790> sea salt and cracked pepper cape cod chips
2011-02-11 10:44:28 [INFO] <AngryRhetoric> GAY
2011-02-11 10:44:31 [INFO] <AngryRhetoric> lol jk sounds tasty
2011-02-11 10:44:41 [INFO] <redux06790> BUT
2011-02-11 10:44:46 [INFO] <redux06790> you have to eat them while
2011-02-11 10:45:10 [INFO] <redux06790> getting blown by an 11 year old girl with her hair gelled back
2011-02-11 10:45:16 [INFO] <redux06790> so she looks like a boy
2011-02-11 10:45:22 [INFO] <AngryRhetoric> LOL
2011-02-11 10:45:25 [INFO] <AngryRhetoric> niice
2011-02-11 10:45:34 [INFO] <redux06790> im twisted
2011-02-11 10:45:35 [INFO] <redux06790> i know
2011-02-11 10:45:46 [INFO] <AngryRhetoric> that is def twisted, but paints an interesting picture haha
2011-02-11 10:46:10 [INFO] <redux06790> my god
2011-02-11 10:46:13 [INFO] <redux06790> my wifes tits are awesome
2011-02-11 10:46:18 [INFO] <AngryRhetoric> squeeze em!!
2011-02-11 10:46:29 [INFO] <redux06790> i just jammed the remote in them
2011-02-11 10:46:33 [INFO] <redux06790> and it dissapeared
2011-02-11 10:46:41 [INFO] <AngryRhetoric> hahahw
2011-02-11 10:46:58 [INFO] <redux06790> you could smuggle a chink in her cleavage
2011-02-11 10:47:10 [INFO] <redux06790> or at least a mexican
2011-02-11 10:47:18 [INFO] <redux06790> btw im not racist i just love derogatory terms
2011-02-11 10:47:21 [INFO] <AngryRhetoric> LOL
2011-02-11 10:47:29 [INFO] <AngryRhetoric> i know you're just messin
2011-02-11 10:47:47 [INFO] <AngryRhetoric> your wife has pesos in between there!
2011-02-11 10:47:49 [INFO] <redux06790> i love how mexican is derogarory enough to not need a word for it
2011-02-11 10:48:16 [INFO] <redux06790> the jokes are always like: So a nigger, a chink, and a MEXICAN...
2011-02-11 10:48:17 [INFO] <AngryRhetoric> haha
2011-02-11 10:48:36 [INFO] <AngryRhetoric> yeah, you could always switch to spic but i gues you dont' have to
2011-02-11 10:48:42 [INFO] <redux06790> well i mean
2011-02-11 10:48:45 [INFO] <redux06790> thats for ricans
2011-02-11 10:48:50 [INFO] <redux06790> and dominicans
2011-02-11 10:48:55 [INFO] <AngryRhetoric> ahh
2011-02-11 10:49:01 [INFO] <redux06790> and cubans
2011-02-11 10:49:05 [INFO] <redux06790> ... fucking cubans
2011-02-11 10:49:16 [INFO] <redux06790> COOBANOES!!!
2011-02-11 10:49:29 [INFO] <AngryRhetoric> say hallow too my leetle freeyend
2011-02-11 10:49:35 [INFO] <redux06790> i love the bottom of a bag of chips
2011-02-11 10:49:44 [INFO] <redux06790> because its where all the flavor dust settles
2011-02-11 10:49:50 [INFO] <AngryRhetoric> mmm dust
2011-02-11 10:49:53 [INFO] <redux06790> and its like youre getting skullfucked by flavor
2011-02-11 10:50:47 [INFO] <redux06790> whats better than tying up an 8 year old boy with barbed wire and raping him?
2011-02-11 10:50:55 [INFO] <AngryRhetoric> go on
2011-02-11 10:50:58 [INFO] <redux06790> NOTHING!
2011-02-11 10:51:00 [INFO] <AngryRhetoric> LOL
2011-02-11 10:51:06 [INFO] <AngryRhetoric> its like those dead babies jokes
2011-02-11 10:51:16 [INFO] <redux06790> how did the dead baby drive away?
2011-02-11 10:51:18 [INFO] <AngryRhetoric> what's the difference between a cadillac and a pile of dead babies?
2011-02-11 10:51:28 [INFO] <redux06790> you dont have a cadillac in your garage?
2011-02-11 10:51:30 [INFO] <AngryRhetoric> yeah
2011-02-11 10:51:36 [INFO] <redux06790> lol that one gets me every time
2011-02-11 10:51:54 [INFO] <redux06790> so
2011-02-11 10:52:00 [INFO] <redux06790> how did the dead baby drive away?
2011-02-11 10:52:02 [INFO] <AngryRhetoric> how
2011-02-11 10:52:09 [INFO] <redux06790> in the back of the garbage truck
2011-02-11 10:52:14 [INFO] <AngryRhetoric> hahaha
2011-02-11 10:52:33 [INFO] <redux06790> would you rather unload a truck full of dead babies, or cinderblocks?
2011-02-11 10:52:44 [INFO] <AngryRhetoric> cinderblocks are too heavy
2011-02-11 10:52:55 [INFO] <redux06790> babies, that way i could use a pitchfork
2011-02-11 10:52:59 [INFO] <AngryRhetoric> lol
2011-02-11 10:53:12 [INFO] <redux06790> ...
2011-02-11 10:53:16 [INFO] <redux06790> and im a dad
2011-02-11 10:53:16 [INFO] <AngryRhetoric> too good
2011-02-11 10:53:24 [INFO] <AngryRhetoric> haha good that way you can teach your kid these
2011-02-11 10:53:38 [INFO] <redux06790> why is asprin white?
2011-02-11 10:54:02 [INFO] <AngryRhetoric> why
2011-02-11 10:54:07 [INFO] <redux06790> you want it to work right?
2011-02-11 10:54:11 [INFO] <AngryRhetoric> LOL
2011-02-11 10:54:20 [INFO] <redux06790> lulz
2011-02-11 10:54:23 [INFO] <AngryRhetoric> ima remember that one
2011-02-11 10:54:37 [INFO] <redux06790> man i used to have black friends too...
2011-02-11 10:54:43 [INFO] <AngryRhetoric> used to huh
2011-02-11 10:54:44 [INFO] <redux06790> then my dad sold them
2011-02-11 10:55:06 [INFO] <redux06790> derp
2011-02-11 10:55:06 [INFO] <AngryRhetoric> yeahHHH hahaha
2011-02-11 10:55:12 [INFO] <redux06790> orchard?
2011-02-11 10:55:17 [INFO] <AngryRhetoric> tree farm
2011-02-11 10:55:26 [INFO] <redux06790> aka orchard
2011-02-11 10:55:35 [INFO] <AngryRhetoric> yes lol
2011-02-11 10:55:45 [INFO] <AngryRhetoric> finishing up the internment camp
2011-02-11 10:56:06 [INFO] <redux06790> whats the difference between a pizza and a jew?
2011-02-11 10:56:06 [INFO] <AngryRhetoric> i mean village
2011-02-11 10:56:21 [INFO] <AngryRhetoric> you can't put a pizza in the oven? haha something like that
2011-02-11 10:56:24 [INFO] <redux06790> pizzas dont scream when you put them in the oven
2011-02-11 10:56:28 [INFO] <AngryRhetoric> lol that's it'
2011-02-11 10:56:44 [INFO] <redux06790> when did the chink go to the dentist?
2011-02-11 10:57:04 [INFO] <redux06790> two thirty... GET IT!? TOOF HURTY!?
2011-02-11 10:57:15 [INFO] <AngryRhetoric> hahaha nice
2011-02-11 10:57:24 [INFO] <redux06790> whats red and smells like blue paint?
2011-02-11 10:57:27 [INFO] <redux06790> red paint...
2011-02-11 10:57:29 [INFO] <AngryRhetoric> i'm not surprised you know all these
2011-02-11 10:57:40 [INFO] <AngryRhetoric> lol what?? haha
2011-02-11 10:57:50 [INFO] <redux06790> where did napolean keep his armies?
2011-02-11 10:57:55 [INFO] <redux06790> in his sleevies
2011-02-11 10:58:18 [INFO] <AngryRhetoric> hmm i don't get that one
2011-02-11 10:58:23 [INFO] <redux06790> ...
2011-02-11 10:58:25 [INFO] <redux06790> arms
2011-02-11 10:58:27 [INFO] <redux06790> sleeves
2011-02-11 10:58:28 [INFO] <redux06790> armies
2011-02-11 10:58:31 [INFO] <redux06790> sleevies
2011-02-11 10:58:34 [INFO] <AngryRhetoric> ohh man
2011-02-11 10:58:38 [INFO] <AngryRhetoric> lol
2011-02-11 10:58:44 [INFO] <redux06790> i trollface so hard when i tell that one
2011-02-11 10:58:56 [INFO] <AngryRhetoric> yeah haha
2011-02-11 10:59:25 [INFO] <redux06790> what do you call a black guy that flies a plane?
2011-02-11 10:59:51 [INFO] <AngryRhetoric> dead?
2011-02-11 10:59:52 [INFO] <AngryRhetoric> haha
2011-02-11 10:59:58 [INFO] <redux06790> a pilot idiot...
2011-02-11 11:00:00 [INFO] <redux06790> lol
2011-02-11 11:00:07 [INFO] <AngryRhetoric> LOL
2011-02-11 11:00:09 [INFO] <redux06790> OR if someone says pilot
2011-02-11 11:00:11 [INFO] <AngryRhetoric> shazam
2011-02-11 11:00:18 [INFO] <redux06790> you say... no, a nigger you idiot
2011-02-11 11:00:21 [INFO] <redux06790> either way they lose
2011-02-11 11:00:26 [INFO] <AngryRhetoric> hahah of course!
2011-02-11 11:00:42 [INFO] <redux06790> what do you call a black guy in a business suit?
2011-02-11 11:00:48 [INFO] <AngryRhetoric> a business man?
2011-02-11 11:00:50 [INFO] <redux06790> a nigger
2011-02-11 11:01:02 [INFO] <AngryRhetoric> bruce willis confirms
2011-02-11 11:01:04 [INFO] <redux06790> when black dudes poop
2011-02-11 11:01:09 [INFO] <redux06790> it looks like they have two dicks
2011-02-11 11:01:33 [INFO] <AngryRhetoric> haha
2011-02-11 11:01:41 [INFO] <redux06790> a black guy told me that on
2011-02-11 11:01:43 [INFO] <redux06790> one
2011-02-11 11:02:33 [INFO] <redux06790> whats the difference between meditation and a hooker?
2011-02-11 11:02:46 [INFO] <AngryRhetoric> HEH
2011-02-11 11:03:08 [INFO] <redux06790> one helps you not sweat the petty stuff
2011-02-11 11:03:21 [INFO] <redux06790> the other helps you not pet your sweaty stuff
2011-02-11 11:03:33 [INFO] <AngryRhetoric> hahahaha i like that one
2011-02-11 11:03:38 [INFO] <redux06790> derp derp derp
2011-02-11 11:03:44 [INFO] <AngryRhetoric> exactly
2011-02-11 11:03:53 [INFO] <redux06790> so do you know what 4chan is?
2011-02-11 11:03:59 [INFO] <AngryRhetoric> thanks to john and konrad yes
2011-02-11 11:04:03 [INFO] <redux06790> haha
2011-02-11 11:04:04 [INFO] <AngryRhetoric> and i've only been to it once haha
2011-02-11 11:04:11 [INFO] <AngryRhetoric> the bottom of the internet
2011-02-11 11:04:14 [INFO] <redux06790> i have an idea for original content for there
2011-02-11 11:04:33 [INFO] <redux06790> its a side by side of god and some defib paddles
2011-02-11 11:05:09 [INFO] <redux06790> and it says ""God brought back the dead once... Science has done it thousands of times
2011-02-11 11:05:09 [INFO] <AngryRhetoric> mm lag
2011-02-11 11:05:42 [INFO] <AngryRhetoric> huh
2011-02-11 11:05:46 [INFO] <redux06790> and watch all the religious/athiest argument begin
2011-02-11 11:06:01 [INFO] <AngryRhetoric> you like tossing the grenade in the middle of the crowd i see ;)
2011-02-11 11:06:06 [INFO] <redux06790> i do
2011-02-11 11:06:19 [INFO] <redux06790> im like john, i heart a good trolling every now and then
2011-02-11 11:06:41 [INFO] <redux06790> OH SHIT i forgot there were addons i wanted to get for MC
2011-02-11 11:06:51 [INFO] <redux06790> im going to go look into those so ill be on and off
2011-02-11 11:06:53 [INFO] <AngryRhetoric> yeah i haven't messed with  those
2011-02-11 11:06:57 [INFO] <AngryRhetoric> crap its 11
2011-02-11 11:06:59 [INFO] <AngryRhetoric> i gotta go
2011-02-11 11:07:01 [INFO] <AngryRhetoric> laaters
2011-02-11 11:07:02 [INFO] <redux06790> k dude
2011-02-11 11:07:03 [INFO] <redux06790> late
2011-02-11 11:07:05 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-11 11:08:40 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-11 11:18:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 11:18:32 [INFO] redux06790 [/69.119.8.191:49982] logged in with entity id 561915
2011-02-11 11:18:50 [INFO] <redux06790> omfg
2011-02-11 11:18:56 [INFO] <redux06790> better light is AMAZING
2011-02-11 11:19:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 11:20:11 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-11 11:21:45 [INFO] redux06790 [/69.119.8.191:49990] logged in with entity id 565007
2011-02-11 11:30:09 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-11 11:30:12 [INFO] redux06790 [/69.119.8.191:49993] logged in with entity id 570952
2011-02-11 12:24:24 [INFO] To run the server without a gui, start it like this:
2011-02-11 12:24:24 [INFO]    java -Xmx1024M -Xms1024M -jar minecraft_server.jar nogui
2011-02-11 12:24:24 [INFO] Console commands:
2011-02-11 12:24:24 [INFO]    help  or  ?               shows this message
2011-02-11 12:24:24 [INFO]    kick <player>             removes a player from the server
2011-02-11 12:24:24 [INFO]    ban <player>              bans a player from the server
2011-02-11 12:24:24 [INFO]    pardon <player>           pardons a banned player so that they can connect again
2011-02-11 12:24:24 [INFO]    ban-ip <ip>               bans an IP address from the server
2011-02-11 12:24:24 [INFO]    pardon-ip <ip>            pardons a banned IP address so that they can connect again
2011-02-11 12:24:24 [INFO]    op <player>               turns a player into an op
2011-02-11 12:24:24 [INFO]    deop <player>             removes op status from a player
2011-02-11 12:24:24 [INFO]    tp <player1> <player2>    moves one player to the same location as another player
2011-02-11 12:24:24 [INFO]    give <player> <id> [num]  gives a player a resource
2011-02-11 12:24:24 [INFO]    tell <player> <message>   sends a private message to a player
2011-02-11 12:24:24 [INFO]    stop                      gracefully stops the server
2011-02-11 12:24:24 [INFO]    save-all                  forces a server-wide level save
2011-02-11 12:24:24 [INFO]    save-off                  disables terrain saving (useful for backup scripts)
2011-02-11 12:24:24 [INFO]    save-on                   re-enables terrain saving
2011-02-11 12:24:24 [INFO]    list                      lists all currently connected players
2011-02-11 12:24:24 [INFO]    say <message>             broadcasts a message to all players
2011-02-11 12:24:34 [INFO] [CONSOLE] hello erin
2011-02-11 13:19:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 13:21:10 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 14:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 14:18:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 15:18:27 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 17:18:21 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 17:18:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 17:20:41 [INFO] k0n2ad [/24.218.113.229:31901] logged in with entity id 595495
2011-02-11 17:40:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 18:18:06 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 18:18:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 18:18:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 19:18:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 19:18:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 19:22:33 [INFO] <redux06790> Derp
2011-02-11 19:22:40 [INFO] <redux06790> I forgot I was AFK
2011-02-11 19:23:29 [INFO] <k0n2ad> yo
2011-02-11 19:23:37 [INFO] <redux06790> sup
2011-02-11 19:23:44 [INFO] <redux06790> man ive been idling for hours lol
2011-02-11 19:24:00 [INFO] <k0n2ad> lol - is there no way to tell if people are on the server?
2011-02-11 19:24:07 [INFO] <redux06790> no
2011-02-11 19:24:14 [INFO] <k0n2ad> sneaky
2011-02-11 19:24:24 [INFO] <redux06790> i mean there would be if efess decided to put some addons on the server
2011-02-11 19:24:27 [INFO] <redux06790> but no otherwise
2011-02-11 19:28:11 [INFO] <redux06790> so what are you working on?
2011-02-11 19:28:40 [INFO] <k0n2ad> just my little shanty for now, going to build a bigger place next to it
2011-02-11 19:28:43 [INFO] <k0n2ad> you?
2011-02-11 19:29:50 [INFO] <redux06790> nothing really
2011-02-11 19:29:55 [INFO] <redux06790> just got raped by a zombie
2011-02-11 19:30:15 [INFO] <redux06790> im thinking of making a nice contemporary home
2011-02-11 19:30:27 [INFO] <k0n2ad> hehe go for it
2011-02-11 19:30:42 [INFO] <redux06790> brb
2011-02-11 19:30:45 [INFO] <k0n2ad> yep
2011-02-11 19:34:42 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-11 19:39:41 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-11 19:39:45 [INFO] k0n2ad [/24.218.113.229:32941] logged in with entity id 724787
2011-02-11 20:18:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 20:18:56 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 20:43:58 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 21:09:57 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-11 21:10:13 [INFO] k0n2ad [/24.218.113.229:33383] logged in with entity id 804237
2011-02-11 21:27:07 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-11 21:31:47 [INFO] AngryRhetoric [/24.147.183.4:52419] logged in with entity id 822025
2011-02-11 21:31:51 [INFO] <AngryRhetoric> yoyoyoyoyo
2011-02-11 21:34:50 [INFO] <AngryRhetoric> friday night and i'm the only one playin hahaha
2011-02-11 22:04:43 [INFO] nawf [/76.23.232.27:55162] logged in with entity id 851465
2011-02-11 22:05:01 [INFO] <AngryRhetoric> look who it is
2011-02-11 22:05:08 [INFO] <AngryRhetoric> sup
2011-02-11 22:05:15 [INFO] <nawf> chillin
2011-02-11 22:12:26 [INFO] <AngryRhetoric> castle buildin?
2011-02-11 22:13:03 [INFO] <nawf> yeah, finally figured out how I want to make these walls
2011-02-11 22:13:08 [INFO] <AngryRhetoric> nice
2011-02-11 22:13:16 [INFO] <AngryRhetoric> need help?
2011-02-11 22:13:18 [INFO] <nawf> I'll make them enclosed so the inside has a courtyardish feel
2011-02-11 22:13:30 [INFO] <AngryRhetoric> hmm
2011-02-11 22:13:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 22:13:53 [INFO] <nawf> or do you think the walls should link up with the rest of the castle?
2011-02-11 22:14:57 [INFO] <AngryRhetoric> well if we have them not supporting the roof, sort of frank lloyd wright style
2011-02-11 22:14:59 [INFO] <AngryRhetoric> i like it heh
2011-02-11 22:15:35 [INFO] <AngryRhetoric> lets go for it
2011-02-11 22:15:38 [INFO] <nawf> I got it, I figure this wall will be the ""outer"" castle, and then it connects the inner one
2011-02-11 22:17:47 [INFO] <AngryRhetoric> this game def needs an auto-run
2011-02-11 22:18:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 22:18:41 [INFO] <AngryRhetoric> nice tower
2011-02-11 22:18:51 [INFO] <nawf> thanks, I didn't like the last one
2011-02-11 22:19:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 22:19:05 [INFO] <AngryRhetoric> should it have a spire on top?
2011-02-11 22:19:10 [INFO] <AngryRhetoric> a pointy spire
2011-02-11 22:19:16 [INFO] <nawf> absolutly
2011-02-11 22:19:22 [INFO] <AngryRhetoric> i have a tonne of cobblestone
2011-02-11 22:19:30 [INFO] <nawf> your the master spire builder
2011-02-11 22:19:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 22:19:34 [INFO] <AngryRhetoric> but i'm thinking smooth stone
2011-02-11 22:24:19 [INFO] <AngryRhetoric> brb afk
2011-02-11 22:24:31 [INFO] <nawf> brb too, I'll prob be in and out for a while
2011-02-11 22:24:32 [INFO] nawf lost connection: disconnect.quitting
2011-02-11 22:28:39 [INFO] nawf [/76.23.232.27:55056] logged in with entity id 891945
2011-02-11 22:38:49 [INFO] <AngryRhetoric> tits
2011-02-11 22:39:12 [INFO] <nawf> hey now, minecraft and porn don't mix
2011-02-11 22:39:19 [INFO] <AngryRhetoric> lol
2011-02-11 22:39:22 [INFO] <AngryRhetoric> porncraft
2011-02-11 22:39:26 [INFO] <nawf> or just don't tell me your mixing
2011-02-11 22:39:30 [INFO] <AngryRhetoric> dude we could make a serious amoutn of money
2011-02-11 22:39:53 [INFO] <AngryRhetoric> i seriously haven't looked at porn in over 2 weeks
2011-02-11 22:40:16 [INFO] <AngryRhetoric> i just felt like saying tits
2011-02-11 22:43:36 [INFO] <nawf> fuck
2011-02-11 22:43:40 [INFO] <AngryRhetoric> that didnt' sound good
2011-02-11 22:44:05 [INFO] <nawf> nope, creeper blew up one of the half block columns
2011-02-11 22:44:11 [INFO] <AngryRhetoric> huh so that's how you make charcoal
2011-02-11 22:44:14 [INFO] <nawf> and you can't just repair those, have to redo it all the way up
2011-02-11 22:44:16 [INFO] <AngryRhetoric> dam creepers
2011-02-11 22:44:17 [INFO] <nawf> or you can use coal
2011-02-11 22:44:28 [INFO] <nawf> but I figure since we have a lot of wood
2011-02-11 22:47:10 [INFO] <AngryRhetoric> yeah
2011-02-11 22:47:24 [INFO] <AngryRhetoric> the tower needs more than one entrance
2011-02-11 22:47:37 [INFO] <AngryRhetoric> oh dam
2011-02-11 22:47:40 [INFO] <AngryRhetoric> i see it
2011-02-11 22:48:54 [INFO] <nawf> see, you have to go all the way up
2011-02-11 22:48:57 [INFO] <AngryRhetoric> wtf !
2011-02-11 22:49:13 [INFO] <nawf> we can put another door inside here
2011-02-11 22:49:14 [INFO] <AngryRhetoric> ther's another creeper
2011-02-11 22:49:15 [INFO] <AngryRhetoric> haha
2011-02-11 22:49:48 [INFO] <AngryRhetoric> problem solved
2011-02-11 22:51:11 [INFO] <AngryRhetoric> it matches the rest of the wall anyway
2011-02-11 22:51:27 [INFO] <nawf> thats true, looks cool
2011-02-11 22:53:16 [INFO] <nawf> that looks weird?
2011-02-11 22:53:35 [INFO] <AngryRhetoric> it matches the window above
2011-02-11 22:53:45 [INFO] <nawf> well I mean with the torch holes
2011-02-11 22:53:50 [INFO] <AngryRhetoric> but i thought this was going to be a wall here
2011-02-11 22:54:05 [INFO] <nawf> I was going to keep this part opener
2011-02-11 22:54:12 [INFO] <nawf> to kinda go into the main base
2011-02-11 22:54:41 [INFO] <AngryRhetoric> gott alevel off this dirt
2011-02-11 22:54:46 [INFO] <nawf> yeah
2011-02-11 22:54:57 [INFO] <nawf> I don't know what I'm doing here, just building stuff
2011-02-11 22:56:27 [INFO] <nawf> the part I don't see 100% yet is what the main building will look like
2011-02-11 22:56:44 [INFO] <AngryRhetoric> yeah i have some ideas
2011-02-11 22:56:48 [INFO] <nawf> did you have ideas?
2011-02-11 22:56:50 [INFO] <nawf> oh cool
2011-02-11 22:57:00 [INFO] <AngryRhetoric> the corners towers, the walls and perimeters multiple bedrooms
2011-02-11 22:57:06 [INFO] <AngryRhetoric> a  main hall coming in of course
2011-02-11 22:57:13 [INFO] <AngryRhetoric> which should determine the dimensions of the rooms around it
2011-02-11 22:57:24 [INFO] <AngryRhetoric> a huge half-stone staircase going up to floor two
2011-02-11 22:57:53 [INFO] <nawf> damn, nice
2011-02-11 22:58:00 [INFO] <AngryRhetoric> going left and right of course
2011-02-11 22:58:01 [INFO] <nawf> build it now!
2011-02-11 22:58:04 [INFO] <AngryRhetoric> haha ok
2011-02-11 22:58:08 [INFO] <AngryRhetoric> ready?
2011-02-11 22:58:21 [INFO] <AngryRhetoric> done
2011-02-11 22:58:30 [INFO] <AngryRhetoric> lol ooh i'm cold now
2011-02-11 22:58:42 [INFO] <nawf> I wish I had flint on me
2011-02-11 22:58:46 [INFO] <AngryRhetoric> hahah oh mannn
2011-02-11 22:59:09 [INFO] <AngryRhetoric> self made barbecue murder
2011-02-11 22:59:20 [INFO] <nawf> player grinder
2011-02-11 22:59:23 [INFO] <AngryRhetoric> hahhaa
2011-02-11 22:59:30 [INFO] <AngryRhetoric> look at me .. aww i 'm dead again
2011-02-11 22:59:59 [INFO] <AngryRhetoric> hmm yeah a courtyard around the outside is good, with trees eventually
2011-02-11 23:00:04 [INFO] <AngryRhetoric> bedrooms will look out at it
2011-02-11 23:00:24 [INFO] <nawf> thats what I was thinking, work it into the mountain somehow
2011-02-11 23:00:25 [INFO] <AngryRhetoric> you got any dirt? i use that for modeling
2011-02-11 23:00:35 [INFO] <nawf> I think ther eis some inside
2011-02-11 23:00:36 [INFO] <AngryRhetoric> that waterfall could be brought into the courtyard
2011-02-11 23:00:58 [INFO] <AngryRhetoric> niice
2011-02-11 23:01:01 [INFO] <AngryRhetoric> cha-ching
2011-02-11 23:01:14 [INFO] <nawf> like build a wall up here?
2011-02-11 23:01:22 [INFO] <AngryRhetoric> over there?
2011-02-11 23:01:27 [INFO] <AngryRhetoric> that's too far away
2011-02-11 23:01:32 [INFO] <nawf> yeah, make this part of the courtyard
2011-02-11 23:01:37 [INFO] <AngryRhetoric> hmmm
2011-02-11 23:01:57 [INFO] <nawf> kinda tie it into the main base
2011-02-11 23:01:57 [INFO] <AngryRhetoric> i'd vote for the wall to be uniform
2011-02-11 23:02:15 [INFO] <nawf> on the bottom and on top you mean?
2011-02-11 23:02:37 [INFO] <AngryRhetoric> yeah here going this way
2011-02-11 23:02:43 [INFO] <nawf> oic, ok
2011-02-11 23:02:53 [INFO] <AngryRhetoric> mimic what you have over here
2011-02-11 23:04:30 [INFO] <nawf> damn, joe's got some shit going on in the basement
2011-02-11 23:04:47 [INFO] <AngryRhetoric> yeah he said he wanted to build a model of the castle down there
2011-02-11 23:05:13 [INFO] <nawf> oh like a smaller one?
2011-02-11 23:05:19 [INFO] <AngryRhetoric> scale model i think
2011-02-11 23:05:19 [INFO] <nawf> so we can build it out on top?
2011-02-11 23:05:28 [INFO] <AngryRhetoric> not sure haha
2011-02-11 23:05:46 [INFO] <AngryRhetoric> we need a dungeon!!
2011-02-11 23:06:28 [INFO] <AngryRhetoric> huh
2011-02-11 23:06:50 [INFO] <AngryRhetoric> hmm these pillars aren't even
2011-02-11 23:06:51 [INFO] <AngryRhetoric> dammit
2011-02-11 23:06:56 [INFO] <nawf> yeah
2011-02-11 23:07:04 [INFO] <nawf> I'll tear it down
2011-02-11 23:07:09 [INFO] <nawf> that was an earlier model pillar
2011-02-11 23:12:59 [INFO] <AngryRhetoric> this might be too great of a hall, not sure yet
2011-02-11 23:13:31 [INFO] <nawf> well we can always make the entire casle bigger, not just th ebasment
2011-02-11 23:13:50 [INFO] <AngryRhetoric> haha true but this should be good for now haha
2011-02-11 23:14:10 [INFO] <AngryRhetoric> maybe pillars in this great hall
2011-02-11 23:14:18 [INFO] <AngryRhetoric> doors on both sides giong to rooms on the first floor
2011-02-11 23:14:46 [INFO] <AngryRhetoric> ooh an X-shaped stairwell with an entrance in the middle
2011-02-11 23:15:19 [INFO] <nawf> that sounds cool
2011-02-11 23:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-11 23:23:20 [INFO] <nawf> lol
2011-02-11 23:23:23 [INFO] <AngryRhetoric> note to self
2011-02-11 23:23:50 [INFO] <nawf> that was funny, I just saw your name drop
2011-02-11 23:23:55 [INFO] <AngryRhetoric> hahaha
2011-02-11 23:24:01 [INFO] <AngryRhetoric> there were 2 creepers down there
2011-02-11 23:24:09 [INFO] <nawf> safety first
2011-02-11 23:24:16 [INFO] <AngryRhetoric> where's the harness
2011-02-11 23:27:20 [INFO] <AngryRhetoric> since i only put down one layer of half-stone i'm wondering if the whole floor will need a 2nd layer
2011-02-11 23:27:30 [INFO] <nawf> only if we build on i
2011-02-11 23:27:32 [INFO] <nawf> tt
2011-02-11 23:27:50 [INFO] <AngryRhetoric> hmm ok
2011-02-11 23:28:19 [INFO] <nawf> it will look multi layered
2011-02-11 23:28:28 [INFO] <nawf> oh yeah, next update has half wood and cobble blocks
2011-02-11 23:29:05 [INFO] <AngryRhetoric> this is tougher than i thought haha
2011-02-11 23:29:05 [INFO] <nawf> am I in the way?
2011-02-11 23:29:11 [INFO] <AngryRhetoric> nooo
2011-02-11 23:29:13 [INFO] <AngryRhetoric> no no no not at all
2011-02-11 23:29:24 [INFO] <AngryRhetoric> haha
2011-02-11 23:29:53 [INFO] <AngryRhetoric> hmm gold might be required for this castle
2011-02-11 23:29:54 [INFO] <nawf> once you get the hallway done or planned I can change the entrance to better fit it
2011-02-11 23:32:38 [INFO] <nawf> did konrad make a waterfall?
2011-02-11 23:32:49 [INFO] <AngryRhetoric> haha where
2011-02-11 23:33:04 [INFO] <nawf> x-46
2011-02-11 23:33:13 [INFO] <nawf> z -21
2011-02-11 23:33:39 [INFO] <nawf> oh it links up to his house
2011-02-11 23:33:59 [INFO] <AngryRhetoric> wow that's nice
2011-02-11 23:34:02 [INFO] <nawf> lol, follow the cobblestone tree bridge
2011-02-11 23:35:15 [INFO] <AngryRhetoric> huh
2011-02-11 23:35:32 [INFO] <AngryRhetoric> goin down the riverrrrrrr
2011-02-11 23:36:00 [INFO] <AngryRhetoric> what the
2011-02-11 23:36:05 [INFO] <AngryRhetoric> this must go back to base
2011-02-11 23:36:33 [INFO] <nawf> ooo
2011-02-11 23:36:33 [INFO] <AngryRhetoric> is that a pig in there?
2011-02-11 23:36:38 [INFO] <nawf> we need a spider spawner
2011-02-11 23:36:41 [INFO] <nawf> yeah
2011-02-11 23:36:46 [INFO] <AngryRhetoric> pig spawner
2011-02-11 23:36:51 [INFO] <AngryRhetoric> why we don't need string
2011-02-11 23:37:15 [INFO] <nawf> yeah for wool
2011-02-11 23:37:24 [INFO] <AngryRhetoric> ohhh
2011-02-11 23:37:37 [INFO] <nawf> oh joe and I already explored this
2011-02-11 23:38:37 [INFO] <AngryRhetoric> hmm
2011-02-11 23:38:47 [INFO] <nawf> you lost?
2011-02-11 23:38:52 [INFO] <AngryRhetoric> oh yeha
2011-02-11 23:38:58 [INFO] <nawf> I'm at the railway
2011-02-11 23:38:59 [INFO] <AngryRhetoric> i mined coal and fell down to a lower ave
2011-02-11 23:39:00 [INFO] <AngryRhetoric> cave
2011-02-11 23:39:06 [INFO] <AngryRhetoric> ok
2011-02-11 23:39:30 [INFO] <AngryRhetoric> dahhHHHh
2011-02-11 23:40:01 [INFO] <AngryRhetoric> now how do you get the cart to move once you're in it?
2011-02-11 23:40:16 [INFO] <nawf> oh its not working
2011-02-11 23:40:27 [INFO] <nawf> gotta do it manually
2011-02-11 23:40:38 [INFO] <AngryRhetoric> yeah i can't do it manually hahaha
2011-02-11 23:41:56 [INFO] <nawf> I'm going to get going, I'll see yah tomorrow
2011-02-11 23:41:59 [INFO] <nawf> later
2011-02-11 23:42:09 [INFO] <AngryRhetoric> alright later !
2011-02-11 23:42:12 [INFO] nawf lost connection: disconnect.quitting
2011-02-12 00:00:00 [INFO] k0n2ad [/24.218.113.229:35913] logged in with entity id 1039779
2011-02-12 00:00:07 [INFO] <AngryRhetoric> sup!
2011-02-12 00:00:19 [INFO] <k0n2ad> yooo
2011-02-12 00:00:26 [INFO] <k0n2ad> im only on for a little bit
2011-02-12 00:00:28 [INFO] <k0n2ad> tired
2011-02-12 00:00:32 [INFO] <AngryRhetoric> john and i were admiring your waterfall haha
2011-02-12 00:00:41 [INFO] <k0n2ad> lol, i heard
2011-02-12 00:00:41 [INFO] <AngryRhetoric> yeah its midnight, heh
2011-02-12 00:01:49 [INFO] <AngryRhetoric> i'm working on a master staircase and grand hall for ye newe castle
2011-02-12 00:02:15 [INFO] <k0n2ad> nice
2011-02-12 00:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 00:18:20 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 00:18:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 00:29:33 [INFO] <AngryRhetoric> i can't stop playing!!
2011-02-12 00:29:41 [INFO] <k0n2ad> i know wtf
2011-02-12 00:29:53 [INFO] <k0n2ad> my eyes are all bloodshit
2011-02-12 00:29:57 [INFO] <k0n2ad> shot
2011-02-12 00:30:00 [INFO] <AngryRhetoric> this staircase is the shit
2011-02-12 00:30:02 [INFO] <AngryRhetoric> LOL
2011-02-12 00:30:03 [INFO] <AngryRhetoric> bloodshit
2011-02-12 00:30:10 [INFO] <AngryRhetoric> what have you been eating
2011-02-12 00:35:05 [INFO] <k0n2ad> my brreaiiins
2011-02-12 00:35:39 [INFO] <AngryRhetoric> mmm tasty, brains = bloodshit
2011-02-12 01:07:36 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-12 01:18:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 01:18:28 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-12 01:18:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 01:18:53 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 02:18:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 02:18:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 05:18:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 05:19:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 06:18:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 06:19:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 07:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 07:18:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 08:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 08:18:38 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 09:23:21 [INFO] efess [/192.168.0.191:54055] logged in with entity id 1157110
2011-02-12 09:23:28 [INFO] <efess> hi!
2011-02-12 09:25:01 [INFO] efess lost connection: disconnect.quitting
2011-02-12 10:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 10:18:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 11:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 12:18:14 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 12:25:14 [INFO] AngryRhetoric [/24.147.183.4:53139] logged in with entity id 1158001
2011-02-12 12:34:23 [INFO] redux06790 [/69.119.8.191:49250] logged in with entity id 1165260
2011-02-12 12:34:40 [INFO] <redux06790> ohh hello
2011-02-12 12:34:45 [INFO] <AngryRhetoric> sup!
2011-02-12 12:34:53 [INFO] <redux06790> i knew someone was here
2011-02-12 12:34:56 [INFO] <redux06790> i just found minecarts
2011-02-12 12:34:56 [INFO] <AngryRhetoric> haha
2011-02-12 12:35:09 [INFO] <AngryRhetoric> minecarts? i didn't do it
2011-02-12 12:36:43 [INFO] <redux06790> dude this addon is awesome
2011-02-12 12:36:45 [INFO] <redux06790> betterlight
2011-02-12 12:36:52 [INFO] <redux06790> the game looks soooo much better this way
2011-02-12 12:36:59 [INFO] <AngryRhetoric> is that the one that ups the graphics? cooll
2011-02-12 12:37:24 [INFO] <redux06790> it doesnt up the graphics it just makes the light look smoother
2011-02-12 12:37:27 [INFO] <redux06790> and more dynamic
2011-02-12 12:37:30 [INFO] <AngryRhetoric> oh ok
2011-02-12 12:37:58 [INFO] <AngryRhetoric> cool so no pitch black underneath a block ?
2011-02-12 12:38:05 [INFO] <redux06790> yeah more or less
2011-02-12 12:38:08 [INFO] <redux06790> i think
2011-02-12 12:38:21 [INFO] <redux06790> ok so
2011-02-12 12:38:34 [INFO] <AngryRhetoric> you know what i mean where you dynamite ground and sometimes if a block stays on top its all bblack
2011-02-12 12:38:36 [INFO] <redux06790> i want to build a sexy ass house pretty much ON the spawn or very close to it
2011-02-12 12:38:54 [INFO] <redux06790> yeah or there is a half block space that isnt lit
2011-02-12 12:38:59 [INFO] <redux06790> yea i know what you mean
2011-02-12 12:39:08 [INFO] <redux06790> notch has a way to go before this game is out of beta i would say
2011-02-12 12:39:09 [INFO] <AngryRhetoric> yeah
2011-02-12 12:39:26 [INFO] <AngryRhetoric> still not too shabby lol
2011-02-12 12:39:47 [INFO] <redux06790> better than anything i can do
2011-02-12 12:39:51 [INFO] <redux06790> since i cant do anyhing
2011-02-12 12:39:58 [INFO] <AngryRhetoric> haha
2011-02-12 12:39:59 [INFO] <AngryRhetoric> i can relate
2011-02-12 12:40:41 [INFO] <redux06790> was the grinder base abandoned?
2011-02-12 12:40:49 [INFO] <AngryRhetoric> i don't think so no
2011-02-12 12:40:58 [INFO] <AngryRhetoric> not a lot of activity there but
2011-02-12 12:40:59 [INFO] <redux06790> the stone stores are empty
2011-02-12 12:41:12 [INFO] <AngryRhetoric> yeah most of that has been used up in the castle
2011-02-12 12:41:17 [INFO] <AngryRhetoric> i think
2011-02-12 12:41:26 [INFO] <AngryRhetoric> there's a couple of chests still left
2011-02-12 12:47:21 [INFO] nawf [/76.23.232.27:55086] logged in with entity id 1183717
2011-02-12 12:47:30 [INFO] <AngryRhetoric> sup john
2011-02-12 12:47:34 [INFO] <redux06790> and then i was like wow john you really can suck that many dicks
2011-02-12 12:47:39 [INFO] <redux06790> oh hey youre here hey man
2011-02-12 12:47:41 [INFO] <nawf> hey
2011-02-12 12:47:49 [INFO] <AngryRhetoric> we were just talking about you
2011-02-12 12:47:53 [INFO] <redux06790> lol
2011-02-12 12:48:42 [INFO] <redux06790> soooo
2011-02-12 12:48:46 [INFO] <redux06790> idk what to build
2011-02-12 12:48:50 [INFO] <redux06790> new world?
2011-02-12 12:48:52 [INFO] <redux06790> :P
2011-02-12 12:49:11 [INFO] <AngryRhetoric> could help build the castle
2011-02-12 12:49:13 [INFO] <redux06790> i think im going to empty the desert biome on the way to angrys house
2011-02-12 12:49:21 [INFO] <AngryRhetoric> haha noOOOOoo
2011-02-12 12:49:21 [INFO] <redux06790> and use all the sand to make a massive pyramid
2011-02-12 12:49:25 [INFO] <AngryRhetoric> hmm
2011-02-12 12:49:31 [INFO] <AngryRhetoric> use sandstone that'd be cool
2011-02-12 12:49:41 [INFO] <AngryRhetoric> or make an al qaeda training camp
2011-02-12 12:49:43 [INFO] <AngryRhetoric> wait
2011-02-12 12:50:02 [INFO] <redux06790> i wanna make a building that looks like a giant sandwich
2011-02-12 12:50:07 [INFO] <nawf> these stairs are cool
2011-02-12 12:50:15 [INFO] <AngryRhetoric> thanks! the dirt is temporary
2011-02-12 12:50:17 [INFO] <AngryRhetoric> for measurements
2011-02-12 12:50:23 [INFO] <nawf> no leave it
2011-02-12 12:50:27 [INFO] <AngryRhetoric> yes
2011-02-12 12:50:28 [INFO] <AngryRhetoric> haha
2011-02-12 12:50:32 [INFO] <AngryRhetoric> dirty dirty castle
2011-02-12 12:50:51 [INFO] <redux06790> omfg john
2011-02-12 12:50:54 [INFO] <redux06790> btw
2011-02-12 12:51:00 [INFO] <redux06790> betterlight
2011-02-12 12:51:02 [INFO] <redux06790> AMAZING
2011-02-12 12:51:10 [INFO] <nawf> right?
2011-02-12 12:51:15 [INFO] <AngryRhetoric> why are skeletons on the half stone
2011-02-12 12:51:17 [INFO] <nawf> I love better grass too
2011-02-12 12:51:27 [INFO] <redux06790> why notch doesnt incorporate this into the game is beyond me
2011-02-12 12:51:30 [INFO] <redux06790> hes a fool not to
2011-02-12 12:51:37 [INFO] <AngryRhetoric> john did you see the tower? heh
2011-02-12 12:51:38 [INFO] <redux06790> yeah better grass makes everything look more natural
2011-02-12 12:51:44 [INFO] <nawf> oh sweet
2011-02-12 12:51:46 [INFO] <AngryRhetoric> heh
2011-02-12 12:52:13 [INFO] <AngryRhetoric> it needs one more wooden stairway in there i think
2011-02-12 12:53:00 [INFO] <redux06790> what are the spawn coords?
2011-02-12 12:53:04 [INFO] <AngryRhetoric> 0
2011-02-12 12:53:10 [INFO] <redux06790> derp
2011-02-12 12:53:15 [INFO] <AngryRhetoric> haha
2011-02-12 12:53:19 [INFO] <redux06790> youll ALWAYS spawn at zero?
2011-02-12 12:53:28 [INFO] <AngryRhetoric> i think you spawn near it
2011-02-12 12:53:36 [INFO] <AngryRhetoric> in a box around 0
2011-02-12 12:54:14 [INFO] <redux06790> hrmm
2011-02-12 12:54:23 [INFO] <redux06790> i would love to have a spawn building is all
2011-02-12 12:54:54 [INFO] <redux06790> is there anything to the west?
2011-02-12 12:54:56 [INFO] <AngryRhetoric> i don't think you can manipulate the blocks around there
2011-02-12 12:55:12 [INFO] <AngryRhetoric> i was thinking of going west, and wondering if you see the sunset longer than here
2011-02-12 12:55:20 [INFO] <AngryRhetoric> sunrise later
2011-02-12 12:55:29 [INFO] <AngryRhetoric> how cool would that be
2011-02-12 12:55:47 [INFO] <redux06790> it would be cool but i think the sunrise is global
2011-02-12 12:56:19 [INFO] <redux06790> ohh something i havent seen
2011-02-12 12:56:42 [INFO] <redux06790> that would be hilarious if you could fall through chunk errors
2011-02-12 12:56:53 [INFO] <AngryRhetoric> you can drop into them lol
2011-02-12 12:57:30 [INFO] <redux06790> brb i have to use the potty to make a grumpy
2011-02-12 12:57:39 [INFO] <AngryRhetoric> lol wtf
2011-02-12 12:58:45 [INFO] <nawf> people with kids always say things like that about shitting
2011-02-12 12:58:57 [INFO] <AngryRhetoric> dam kids
2011-02-12 12:59:47 [INFO] <redux06790> 5 pounds lighter
2011-02-12 13:00:00 [INFO] <redux06790> i think i just shit out an adobe brick
2011-02-12 13:00:12 [INFO] <AngryRhetoric> haha
2011-02-12 13:00:55 [INFO] <redux06790> so what all is going to be down here?
2011-02-12 13:01:02 [INFO] <AngryRhetoric> a pornography filming studio
2011-02-12 13:01:06 [INFO] <redux06790> a village?
2011-02-12 13:01:23 [INFO] <AngryRhetoric> i think joe was making a model of the castle for up here, not sure
2011-02-12 13:01:32 [INFO] <redux06790> ohh can we make a preteen rape factory/abortion clinic?
2011-02-12 13:01:49 [INFO] <nawf> we def need a sweet as library
2011-02-12 13:01:53 [INFO] <AngryRhetoric> ooh its a duplex? or they perform both services at the same spot
2011-02-12 13:02:03 [INFO] <redux06790> same spot
2011-02-12 13:02:10 [INFO] <AngryRhetoric> rape factory, assembly-line-style
2011-02-12 13:02:49 [INFO] <redux06790> lol
2011-02-12 13:02:55 [INFO] <AngryRhetoric> dahhh
2011-02-12 13:03:17 [INFO] <AngryRhetoric> out of half stone
2011-02-12 13:03:22 [INFO] <redux06790> kneeling looks somewhat sexual
2011-02-12 13:03:28 [INFO] <AngryRhetoric> really?
2011-02-12 13:03:40 [INFO] <redux06790> watch
2011-02-12 13:03:57 [INFO] <AngryRhetoric> he goes from no neck to negative neck
2011-02-12 13:06:07 [INFO] <AngryRhetoric> nice
2011-02-12 13:06:14 [INFO] <AngryRhetoric> i need a ham
2011-02-12 13:08:33 [INFO] <redux06790> ive got a ham for you
2011-02-12 13:08:35 [INFO] <redux06790> and by ham
2011-02-12 13:08:39 [INFO] <AngryRhetoric> hah
2011-02-12 13:08:41 [INFO] <redux06790> i mean penis
2011-02-12 13:08:48 [INFO] <AngryRhetoric> can you put a penis inthe oven?
2011-02-12 13:09:05 [INFO] <redux06790> i mean
2011-02-12 13:09:10 [INFO] <redux06790> i SUPPOSE you could
2011-02-12 13:09:34 [INFO] <redux06790> dude
2011-02-12 13:09:36 [INFO] <AngryRhetoric> haha
2011-02-12 13:09:42 [INFO] <redux06790> this skeleton is a suck shot
2011-02-12 13:10:38 [INFO] <AngryRhetoric> fOOdstuffs
2011-02-12 13:10:59 [INFO] <redux06790> mushroom soup fucking gives you like a billion hearts
2011-02-12 13:11:07 [INFO] <AngryRhetoric> really? hmm
2011-02-12 13:11:13 [INFO] <redux06790> well like 5
2011-02-12 13:11:19 [INFO] <redux06790> idk what ham gives you
2011-02-12 13:13:32 [INFO] <AngryRhetoric> haha konrad put 2 tnt on my bed in my island home
2011-02-12 13:13:40 [INFO] <AngryRhetoric> ham is 4 ithink
2011-02-12 13:13:52 [INFO] <AngryRhetoric> can you extract tnt without blowing it up?
2011-02-12 13:14:02 [INFO] <redux06790> is there a way to get rid of TNT once its placed without blowing it up?
2011-02-12 13:14:09 [INFO] <nawf> yeah, surround with water
2011-02-12 13:14:16 [INFO] <AngryRhetoric> all sides?
2011-02-12 13:14:26 [INFO] <nawf> I think
2011-02-12 13:14:29 [INFO] <AngryRhetoric> hmm
2011-02-12 13:15:26 [INFO] <redux06790> man thats a big ass tree outside the castle
2011-02-12 13:15:39 [INFO] <nawf> yeah, thats why I've left it alone
2011-02-12 13:15:43 [INFO] <nawf> its kinda cool
2011-02-12 13:15:59 [INFO] <redux06790> i hate chopping down big trees
2011-02-12 13:16:09 [INFO] <redux06790> i think wood should be effected by gravity lol
2011-02-12 13:16:42 [INFO] <AngryRhetoric> yeah you gotta get all the wood
2011-02-12 13:17:05 [INFO] <redux06790> ive found a location for my contemporary home
2011-02-12 13:17:11 [INFO] <redux06790> its going to be turrable
2011-02-12 13:17:18 [INFO] <AngryRhetoric> hah
2011-02-12 13:17:56 [INFO] <AngryRhetoric> charcoal lasts longer than coal>?>
2011-02-12 13:18:28 [INFO] <AngryRhetoric> i cooked 5 hams on one charcoal
2011-02-12 13:18:37 [INFO] <redux06790> good observation
2011-02-12 13:18:37 [INFO] <nawf> naw, you can't smelt with charcoal
2011-02-12 13:18:49 [INFO] <redux06790> i thought you could
2011-02-12 13:18:50 [INFO] <nawf> its only for torches
2011-02-12 13:19:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 13:19:34 [INFO] <AngryRhetoric> um you can smelt with charcoal
2011-02-12 13:19:38 [INFO] <AngryRhetoric> and cook ham
2011-02-12 13:19:43 [INFO] <nawf> orly?
2011-02-12 13:19:50 [INFO] <AngryRhetoric> apparently yes
2011-02-12 13:21:03 [INFO] <AngryRhetoric> castle floor  = DONE
2011-02-12 13:21:11 [INFO] <nawf> nice
2011-02-12 13:21:16 [INFO] <redux06790> *golfclap*
2011-02-12 13:21:22 [INFO] <AngryRhetoric> hah
2011-02-12 13:21:59 [INFO] <nawf> hey angry, is this the top floor of the hall?
2011-02-12 13:22:06 [INFO] <nawf> is this the ceiling?
2011-02-12 13:22:09 [INFO] <AngryRhetoric> no
2011-02-12 13:22:15 [INFO] <AngryRhetoric> but i wanted the staircase to go up to the 2nd floor
2011-02-12 13:22:20 [INFO] <nawf> ok
2011-02-12 13:22:26 [INFO] <AngryRhetoric> this part of the stairwell
2011-02-12 13:22:37 [INFO] <AngryRhetoric> connects to the second floor the ceiling of the great hall has to be great!
2011-02-12 13:22:47 [INFO] <AngryRhetoric> i'm going to mimic the tower top
2011-02-12 13:22:56 [INFO] <nawf> the spinneret?
2011-02-12 13:22:57 [INFO] <redux06790> wtf whats the height between sea level and the clouds?
2011-02-12 13:23:00 [INFO] <AngryRhetoric> ooh a chandelier would be awesome but hard to pull off
2011-02-12 13:23:07 [INFO] <nawf> we can do it
2011-02-12 13:23:33 [INFO] <AngryRhetoric> well the lava level is 0 for y i think
2011-02-12 13:23:39 [INFO] <AngryRhetoric> sky is 200 maybe?
2011-02-12 13:23:40 [INFO] <nawf> naw, 16 I think
2011-02-12 13:23:44 [INFO] <AngryRhetoric> oh ok
2011-02-12 13:23:55 [INFO] <nawf> I forget the sky, its like 20 past cloudes or someting
2011-02-12 13:24:54 [INFO] <redux06790> welcome to castle mondo
2011-02-12 13:24:59 [INFO] <AngryRhetoric> yeah
2011-02-12 13:25:12 [INFO] <AngryRhetoric> castle gigundus
2011-02-12 13:25:23 [INFO] <redux06790> we should make like a wizards library in the top of the towers
2011-02-12 13:25:31 [INFO] <nawf> do it
2011-02-12 13:25:32 [INFO] <AngryRhetoric> hah cool
2011-02-12 13:25:33 [INFO] <redux06790> i wish there were more decorative items
2011-02-12 13:25:38 [INFO] <redux06790> like beakers and shit
2011-02-12 13:26:12 [INFO] <nawf> I gotta take a break from tower building for a bit
2011-02-12 13:26:16 [INFO] <nawf> its starting to feel like a job
2011-02-12 13:26:32 [INFO] <AngryRhetoric> hah like the castle floor
2011-02-12 13:26:33 [INFO] <nawf> prob going to go dig out the tunnel to connect the castle to the underground river
2011-02-12 13:26:51 [INFO] <AngryRhetoric> i find it hard to do the 2nd instance of something because i have to imitate exactly what i did 1st
2011-02-12 13:27:28 [INFO] <nawf> yeah, thats where I'm struggling now
2011-02-12 13:27:46 [INFO] <nawf> oh yeah, kev, remind me to bring the walking dead books next time we meet up
2011-02-12 13:27:49 [INFO] <redux06790> i wish i didnt build my farm so damn far away
2011-02-12 13:27:52 [INFO] <AngryRhetoric> ok cool
2011-02-12 13:27:56 [INFO] <AngryRhetoric> haha
2011-02-12 13:27:59 [INFO] <AngryRhetoric> that's hafl the fu
2011-02-12 13:28:04 [INFO] <AngryRhetoric> oh boy *half the fun
2011-02-12 13:28:10 [INFO] <nawf> we do need a farm by the castle
2011-02-12 13:28:19 [INFO] <redux06790> john have you read the scott pilgrem comics?
2011-02-12 13:28:22 [INFO] <nawf> naw
2011-02-12 13:28:26 [INFO] <redux06790> pilgrim derp
2011-02-12 13:28:30 [INFO] <AngryRhetoric> i found the cobble stone
2011-02-12 13:28:30 [INFO] <redux06790> you should
2011-02-12 13:28:36 [INFO] <redux06790> they are awesome
2011-02-12 13:28:49 [INFO] <nawf> I'm re-kindling my inner geek
2011-02-12 13:28:55 [INFO] <nawf> I played magic with kev last weekend
2011-02-12 13:28:58 [INFO] <nawf> well two weekends ago
2011-02-12 13:29:01 [INFO] <redux06790> nice
2011-02-12 13:29:04 [INFO] <nawf> and now I want to buy all these comics
2011-02-12 13:29:13 [INFO] <redux06790> i was thinking of writing a simple DnD campaign just to play
2011-02-12 13:29:25 [INFO] <nawf> cool, dnd takes up a lot of time though
2011-02-12 13:29:29 [INFO] <redux06790> not really
2011-02-12 13:29:43 [INFO] <redux06790> not if you come with a character already made
2011-02-12 13:29:59 [INFO] <redux06790> problem is i dont fully undertand the gameplay rules lol
2011-02-12 13:31:02 [INFO] <redux06790> dude i had to bust a hole in the floor to drop a creeper through
2011-02-12 13:31:08 [INFO] <redux06790> now hes pissed
2011-02-12 13:31:12 [INFO] <AngryRhetoric> haha
2011-02-12 13:31:26 [INFO] <AngryRhetoric> run bitch!
2011-02-12 13:31:32 [INFO] <redux06790> time to get back to contemporary building
2011-02-12 13:34:50 [INFO] <AngryRhetoric> there's a shit-ton of work to be done on this castle
2011-02-12 13:35:07 [INFO] <redux06790> thats why i dont like building castles
2011-02-12 13:35:18 [INFO] <AngryRhetoric> yeah but its rewarding when you're done
2011-02-12 13:39:00 [INFO] <redux06790> i need to smelt like 1000000000000 sand
2011-02-12 13:39:06 [INFO] <redux06790> where you been getting your sand john?
2011-02-12 13:39:12 [INFO] <AngryRhetoric> from your mom's vag!!
2011-02-12 13:39:14 [INFO] <AngryRhetoric> whooooaaa
2011-02-12 13:39:21 [INFO] <redux06790> OHHHHHH!!!!!!!!
2011-02-12 13:39:28 [INFO] <AngryRhetoric> haha sorry i couldn't pass the opportunity by
2011-02-12 13:39:35 [INFO] <redux06790> yeah it comes out in stacks of 64 from there
2011-02-12 13:39:40 [INFO] <redux06790> but it smells bad
2011-02-12 13:41:25 [INFO] <AngryRhetoric> haha
2011-02-12 13:41:50 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-12 13:42:03 [INFO] redux06790 [/69.119.8.191:49511] logged in with entity id 1272753
2011-02-12 13:42:15 [INFO] <AngryRhetoric> you can go to one of those desert biomes to get tons o' sand
2011-02-12 13:42:36 [INFO] <redux06790> FUUUU RUN!!!!
2011-02-12 13:43:14 [INFO] <redux06790> phew
2011-02-12 13:43:16 [INFO] <redux06790> im safe now
2011-02-12 13:43:38 [INFO] <AngryRhetoric> the grand hall alone will take a day to build
2011-02-12 13:43:50 [INFO] <redux06790> yikes
2011-02-12 13:43:57 [INFO] <redux06790> dude i built a hotel in my last smp
2011-02-12 13:44:03 [INFO] <redux06790> nobody gave a fuck
2011-02-12 13:44:06 [INFO] <redux06790> the thing was massive
2011-02-12 13:44:09 [INFO] <redux06790> it had fountains
2011-02-12 13:44:11 [INFO] <redux06790> and churches
2011-02-12 13:44:17 [INFO] <AngryRhetoric> nice
2011-02-12 13:44:19 [INFO] <redux06790> and kegs
2011-02-12 13:44:26 [INFO] <redux06790> and gardens
2011-02-12 13:44:39 [INFO] <redux06790> and everyone was like ""merp, this is neat""
2011-02-12 13:44:58 [INFO] <AngryRhetoric> and that was the end huh
2011-02-12 13:45:03 [INFO] <redux06790> yea
2011-02-12 13:45:09 [INFO] <redux06790> that and they had SOOOO many addons
2011-02-12 13:45:18 [INFO] <redux06790> that the server was constantly lagging
2011-02-12 13:45:46 [INFO] <redux06790> and the straw that broke the camels back
2011-02-12 13:46:05 [INFO] <redux06790> the dude wouldnt zip and email the world map to me so i could make templates of my buidlings
2011-02-12 13:46:13 [INFO] <redux06790> in a world editor
2011-02-12 13:46:19 [INFO] <AngryRhetoric> why wouldn't he
2011-02-12 13:46:31 [INFO] <redux06790> because he was 16 years old
2011-02-12 13:46:36 [INFO] <redux06790> and ""didnt feel like it""
2011-02-12 13:46:41 [INFO] <AngryRhetoric> hah
2011-02-12 13:46:43 [INFO] <AngryRhetoric> bastid
2011-02-12 13:46:49 [INFO] <redux06790> so yea
2011-02-12 13:47:31 [INFO] <redux06790> wtb sunshine
2011-02-12 13:47:49 [INFO] <AngryRhetoric> is that street talk for crack?
2011-02-12 13:47:51 [INFO] <AngryRhetoric> haha
2011-02-12 13:47:55 [INFO] <redux06790> no
2011-02-12 13:48:04 [INFO] <redux06790> its a euphemism for penis
2011-02-12 13:48:31 [INFO] <AngryRhetoric> oh cuz i assumed it was a colloquialism for vag!
2011-02-12 13:48:50 [INFO] <nawf> ii
2011-02-12 13:49:53 [INFO] <redux06790> ugh how the fuck long is the night time?
2011-02-12 13:50:59 [INFO] <AngryRhetoric> sun approacheth
2011-02-12 13:51:40 [INFO] <AngryRhetoric> back in a little bit
2011-02-12 13:51:43 [INFO] <AngryRhetoric> i need some coffee!
2011-02-12 13:51:47 [INFO] <redux06790> OMG CLAY!!!!
2011-02-12 13:51:50 [INFO] <nawf> OMG!
2011-02-12 13:52:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 13:53:23 [INFO] <AngryRhetoric> i have 150 bricks of clay buwahahah
2011-02-12 13:53:36 [INFO] <redux06790> well fuck a doodle doo
2011-02-12 13:54:25 [INFO] <redux06790> i have a feeling if i go on too long of an adventure here im going to eat shit lol
2011-02-12 13:56:02 [INFO] <nawf> brb
2011-02-12 13:56:04 [INFO] nawf lost connection: disconnect.quitting
2011-02-12 13:56:54 [INFO] <redux06790> omfg
2011-02-12 13:57:14 [INFO] <redux06790> seriously man
2011-02-12 13:57:23 [INFO] <redux06790> ive just found the most amazing natural formation
2011-02-12 13:58:40 [INFO] <redux06790> dude no lie
2011-02-12 13:58:47 [INFO] <redux06790> this is a spectacular area
2011-02-12 13:59:42 [INFO] <AngryRhetoric> what's the coords?
2011-02-12 14:00:02 [INFO] <redux06790> -217X
2011-02-12 14:00:10 [INFO] <redux06790> 461 Z
2011-02-12 14:07:31 [INFO] <redux06790> how long until day? :P
2011-02-12 14:10:35 [INFO] <AngryRhetoric> long enough for me to make coffee mmm
2011-02-12 14:10:47 [INFO] <redux06790> finally day is coming
2011-02-12 14:11:13 [INFO] <AngryRhetoric> you went west
2011-02-12 14:11:17 [INFO] <redux06790> yes
2011-02-12 14:11:44 [INFO] <AngryRhetoric> i like the sign
2011-02-12 14:11:46 [INFO] <redux06790> bring ham!
2011-02-12 14:11:59 [INFO] <AngryRhetoric> fine
2011-02-12 14:12:04 [INFO] <redux06790> go out the castle main door
2011-02-12 14:12:08 [INFO] <redux06790> follow the beach
2011-02-12 14:12:12 [INFO] <AngryRhetoric> the very top of our castle tower is at cloud level thta's perfect
2011-02-12 14:12:13 [INFO] <redux06790> hop to the island
2011-02-12 14:12:14 [INFO] <redux06790> and boom
2011-02-12 14:12:57 [INFO] <AngryRhetoric> i bring ham
2011-02-12 14:13:11 [INFO] <AngryRhetoric> i bring lemon pledge
2011-02-12 14:14:58 [INFO] <redux06790> Y U NO HERE YET!?
2011-02-12 14:15:25 [INFO] <AngryRhetoric> noOOoooo
2011-02-12 14:17:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 14:17:38 [INFO] <AngryRhetoric> i see what you mean
2011-02-12 14:17:44 [INFO] <redux06790> ?
2011-02-12 14:17:51 [INFO] <AngryRhetoric> these mountains
2011-02-12 14:18:00 [INFO] <redux06790> dude youre there?
2011-02-12 14:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 14:18:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 14:18:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 14:18:47 [INFO] <redux06790> i didnt even see you go by
2011-02-12 14:18:56 [INFO] <AngryRhetoric> i'm up the mountain
2011-02-12 14:19:05 [INFO] <redux06790> im making a safehouse
2011-02-12 14:19:15 [INFO] <AngryRhetoric> your coords are on top of a tree lol
2011-02-12 14:19:40 [INFO] <redux06790> i was underground when i gave them out
2011-02-12 14:20:10 [INFO] <AngryRhetoric> x - 217 Z 461 right?
2011-02-12 14:20:17 [INFO] <redux06790> i think so
2011-02-12 14:20:21 [INFO] <redux06790> i dont remember
2011-02-12 14:20:22 [INFO] <redux06790> im at
2011-02-12 14:20:38 [INFO] <redux06790> -49z 419X
2011-02-12 14:20:39 [INFO] <AngryRhetoric> this hill is cool and way above the clouds
2011-02-12 14:20:49 [INFO] <redux06790> err 319
2011-02-12 14:20:52 [INFO] <AngryRhetoric> wait lol
2011-02-12 14:20:56 [INFO] <redux06790> fuck
2011-02-12 14:20:57 [INFO] <redux06790> FUUU
2011-02-12 14:21:00 [INFO] <AngryRhetoric> hahaha
2011-02-12 14:21:02 [INFO] <redux06790> let me do that again
2011-02-12 14:21:07 [INFO] <AngryRhetoric> FUUU ijust wanderd into the wildernerss
2011-02-12 14:21:13 [INFO] <redux06790> IM AT -49X 319Z
2011-02-12 14:21:25 [INFO] <AngryRhetoric> ok
2011-02-12 14:22:14 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-12 14:22:28 [INFO] redux06790 [/69.119.8.191:49573] logged in with entity id 1327171
2011-02-12 14:23:23 [INFO] <redux06790> HAM!!!
2011-02-12 14:23:28 [INFO] <AngryRhetoric> ooh i forgot
2011-02-12 14:23:37 [INFO] <redux06790> phew
2011-02-12 14:23:39 [INFO] <redux06790> lol
2011-02-12 14:23:41 [INFO] <redux06790> thanks
2011-02-12 14:23:44 [INFO] <AngryRhetoric> i ws on that hill over ther
2011-02-12 14:23:59 [INFO] <redux06790> im going to call it the anvil
2011-02-12 14:24:05 [INFO] <AngryRhetoric> that hill?
2011-02-12 14:24:09 [INFO] <redux06790> yea
2011-02-12 14:24:12 [INFO] <AngryRhetoric> nce
2011-02-12 14:24:15 [INFO] <AngryRhetoric> nice why not
2011-02-12 14:26:59 [INFO] nawf [/76.23.232.27:55036] logged in with entity id 1381591
2011-02-12 14:27:15 [INFO] <AngryRhetoric> he's back
2011-02-12 14:27:23 [INFO] <nawf> nun uh
2011-02-12 14:27:28 [INFO] <AngryRhetoric> doh
2011-02-12 14:28:18 [INFO] <AngryRhetoric> its a good thing he didn't implement sharks
2011-02-12 14:30:36 [INFO] <AngryRhetoric> aight i gotta run
2011-02-12 14:30:40 [INFO] <redux06790> RUN!!!
2011-02-12 14:30:44 [INFO] <AngryRhetoric> DHAHHHHHHhh
2011-02-12 14:30:46 [INFO] <AngryRhetoric> oh wait
2011-02-12 14:30:55 [INFO] <AngryRhetoric> haha peace
2011-02-12 14:30:56 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-12 14:31:10 [INFO] <redux06790> dude john i found an amazing mountain
2011-02-12 14:37:08 [INFO] <nawf> cool
2011-02-12 14:44:56 [INFO] <redux06790> well molly is awake i gtg
2011-02-12 14:44:57 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-12 15:07:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 15:18:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 15:19:20 [INFO] k0n2ad [/24.218.113.229:45141] logged in with entity id 1444090
2011-02-12 15:19:32 [INFO] <nawf> sup brah
2011-02-12 15:19:44 [INFO] <k0n2ad> herp durp
2011-02-12 15:20:05 [INFO] <k0n2ad> hows life
2011-02-12 15:20:14 [INFO] <nawf> absurd
2011-02-12 15:20:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 15:20:29 [INFO] <k0n2ad> as it should be
2011-02-12 15:21:12 [INFO] <k0n2ad> whoaaa
2011-02-12 15:21:29 [INFO] <k0n2ad> is that the new castle i see in the distance?
2011-02-12 15:21:35 [INFO] <k0n2ad> that looks sweet
2011-02-12 15:21:41 [INFO] <nawf> I have no idea
2011-02-12 15:21:45 [INFO] <nawf> because I don't know wher eyou are
2011-02-12 15:21:53 [INFO] <k0n2ad> at my shanty
2011-02-12 15:22:09 [INFO] <k0n2ad> 78 -15
2011-02-12 15:22:18 [INFO] <nawf> oh yeah, thats kevins spinneret
2011-02-12 15:22:30 [INFO] <k0n2ad> how do you guys usually specify coordinates?
2011-02-12 15:22:44 [INFO] <nawf> I understood what you mean
2011-02-12 15:30:04 [INFO] <k0n2ad> the sun is in my goddamned eyee
2011-02-12 15:30:08 [INFO] <k0n2ad> cant see shit
2011-02-12 15:53:00 [INFO] <nawf> I'll help
2011-02-12 15:53:09 [INFO] <k0n2ad> what?
2011-02-12 15:53:27 [INFO] <k0n2ad> dude, i cs
2011-02-12 15:53:34 [INFO] <nawf> rofl
2011-02-12 15:53:36 [INFO] <k0n2ad> FUCKER
2011-02-12 15:53:41 [INFO] <k0n2ad> YOU ARE INVISIBLE
2011-02-12 15:53:44 [INFO] <nawf> lol
2011-02-12 15:53:56 [INFO] <k0n2ad> i hate you thats my yard
2011-02-12 15:54:32 [INFO] <k0n2ad> dude get visible
2011-02-12 15:54:46 [INFO] <k0n2ad> now what am i going to do about this mess
2011-02-12 15:54:54 [INFO] <nawf> I thought you were cleaing it ou
2011-02-12 15:55:01 [INFO] <k0n2ad> No
2011-02-12 15:55:09 [INFO] <nawf> oh, sorry
2011-02-12 15:55:12 [INFO] <k0n2ad> just a couple blocks not a whole fucking thing
2011-02-12 15:55:18 [INFO] <nawf> lol
2011-02-12 15:55:52 [INFO] <k0n2ad> maybe ill make that a pool
2011-02-12 15:56:14 [INFO] <nawf> your waterfall is cool
2011-02-12 15:56:23 [INFO] <k0n2ad> thanks
2011-02-12 15:56:31 [INFO] <k0n2ad> why dont you blow it up
2011-02-12 15:56:46 [INFO] <nawf> I heard you put tnt on kevins bed
2011-02-12 15:56:52 [INFO] <k0n2ad> LOL
2011-02-12 15:56:59 [INFO] <k0n2ad> yea, but i didnt set it off
2011-02-12 15:57:15 [INFO] <nawf> yeah but there is almost no way to get rid of it without destroying shit
2011-02-12 15:57:39 [INFO] <k0n2ad> really? ive never really used it
2011-02-12 15:57:55 [INFO] <k0n2ad> lol oh shit
2011-02-12 15:59:50 [INFO] <k0n2ad> that's a nice EVERYTHING you have there
2011-02-12 16:00:02 [INFO] <k0n2ad> was he pisseD?
2011-02-12 16:00:20 [INFO] <nawf> dunno, wait and see what the retribution is like
2011-02-12 16:00:53 [INFO] <k0n2ad> i need meat
2011-02-12 16:02:41 [INFO] <k0n2ad> days go by quick on server
2011-02-12 16:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 16:18:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 16:18:55 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 16:19:25 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 16:27:19 [INFO] <nawf> mother fucker
2011-02-12 16:27:30 [INFO] <k0n2ad> lol i can hear youblowing shit up
2011-02-12 16:27:31 [INFO] <nawf> creeper just took out my furnace with the only iron I had
2011-02-12 16:27:54 [INFO] <k0n2ad> lol
2011-02-12 16:28:17 [INFO] <k0n2ad> i just finished hooking the tunnels up from new castle to shanty
2011-02-12 16:30:02 [INFO] AngryRhetoric [/24.147.183.4:62549] logged in with entity id 1571794
2011-02-12 16:30:10 [INFO] <k0n2ad> yo
2011-02-12 16:30:15 [INFO] <AngryRhetoric> hey
2011-02-12 16:30:26 [INFO] <AngryRhetoric> i can't stay away from the minecraft!!
2011-02-12 16:30:52 [INFO] <k0n2ad> its a drug
2011-02-12 16:30:58 [INFO] <k0n2ad> just when i thought i was out
2011-02-12 16:31:00 [INFO] <AngryRhetoric> oh yeah
2011-02-12 16:31:01 [INFO] <AngryRhetoric> hahah
2011-02-12 16:31:04 [INFO] <k0n2ad> they pull me back in
2011-02-12 16:31:06 [INFO] <AngryRhetoric> they PULL me back in
2011-02-12 16:31:09 [INFO] <nawf> at least we have a support group
2011-02-12 16:31:24 [INFO] <AngryRhetoric> haha yes, that also encourages more playtime
2011-02-12 16:31:47 [INFO] <k0n2ad> lol
2011-02-12 16:31:58 [INFO] <AngryRhetoric> oh yeah and Thanks for the TNT on  my bed in my island home
2011-02-12 16:32:03 [INFO] <k0n2ad> hahaha
2011-02-12 16:32:10 [INFO] <k0n2ad> did you get it off?
2011-02-12 16:32:12 [INFO] <AngryRhetoric> lol i'm not sure how to get rid of that
2011-02-12 16:32:22 [INFO] <AngryRhetoric> john said surround it in water
2011-02-12 16:32:49 [INFO] <k0n2ad> i didnt know it was that hard, but it adds to the funny
2011-02-12 16:32:56 [INFO] <AngryRhetoric> haha yes
2011-02-12 16:33:01 [INFO] <AngryRhetoric> so easy to plant and so hard to remove
2011-02-12 16:33:19 [INFO] <AngryRhetoric> i now consider it a good thing you don't know where my southern home is
2011-02-12 16:33:32 [INFO] <k0n2ad> lol, not for long
2011-02-12 16:33:35 [INFO] <AngryRhetoric> haha
2011-02-12 16:33:58 [INFO] <k0n2ad> this caving is sprawlling john what are you looking for
2011-02-12 16:34:02 [INFO] <nawf> iron
2011-02-12 16:34:15 [INFO] <AngryRhetoric> where you caving?
2011-02-12 16:34:17 [INFO] <k0n2ad> me too, you want some?
2011-02-12 16:34:39 [INFO] <AngryRhetoric> oh i see you
2011-02-12 16:34:41 [INFO] <nawf> by the existing tracks
2011-02-12 16:34:50 [INFO] <nawf> a creeper blew up my iron furnace with all my iron
2011-02-12 16:34:56 [INFO] <nawf> going to go on a sand run, needed hsovels
2011-02-12 16:35:14 [INFO] <AngryRhetoric> you lose all the iron in it? that blows
2011-02-12 16:35:24 [INFO] <nawf> yeah, only 9 but I think that was all we had
2011-02-12 16:35:57 [INFO] <AngryRhetoric> yeah the creeper blew up near the castle here i see
2011-02-12 16:36:11 [INFO] <nawf> well that was me removing the moutain too
2011-02-12 16:37:46 [INFO] <k0n2ad> i need to find some diamond
2011-02-12 16:37:56 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-12 16:38:00 [INFO] AngryRhetoric [/24.147.183.4:62856] logged in with entity id 1612650
2011-02-12 16:38:04 [INFO] <AngryRhetoric> oops wrong button haha
2011-02-12 16:38:19 [INFO] <AngryRhetoric> we have almost 40 diamond back at base
2011-02-12 16:38:26 [INFO] <nawf> nope, I just saw 11
2011-02-12 16:38:30 [INFO] <AngryRhetoric> ouch
2011-02-12 16:38:36 [INFO] <AngryRhetoric> someone was using it then
2011-02-12 16:38:46 [INFO] <k0n2ad> i took enough to make a sword and pickaxe
2011-02-12 16:38:51 [INFO] <k0n2ad> so 5
2011-02-12 16:38:58 [INFO] <k0n2ad> thats why i want to get more
2011-02-12 16:38:58 [INFO] <nawf> sword? lol
2011-02-12 16:39:12 [INFO] <k0n2ad> yea im not a coward
2011-02-12 16:39:17 [INFO] <AngryRhetoric> famous s-words
2011-02-12 16:39:36 [INFO] <AngryRhetoric> NOOO
2011-02-12 16:39:45 [INFO] <AngryRhetoric> LOL
2011-02-12 16:39:48 [INFO] <k0n2ad> lol
2011-02-12 16:39:49 [INFO] <AngryRhetoric> hatred
2011-02-12 16:40:00 [INFO] <k0n2ad> lol
2011-02-12 16:40:14 [INFO] <k0n2ad> rofl
2011-02-12 16:40:21 [INFO] <AngryRhetoric> elevator up?
2011-02-12 16:40:34 [INFO] <AngryRhetoric> that was not a question
2011-02-12 16:40:45 [INFO] <AngryRhetoric> the castle's gonna be great
2011-02-12 16:40:51 [INFO] <AngryRhetoric> looks awesome from up here
2011-02-12 16:40:58 [INFO] <k0n2ad> have fun getting down
2011-02-12 16:41:09 [INFO] <AngryRhetoric> you undermined me didn't you
2011-02-12 16:41:16 [INFO] <AngryRhetoric> shit
2011-02-12 16:41:18 [INFO] <k0n2ad> LOL
2011-02-12 16:41:27 [INFO] <k0n2ad> i wont take your shit
2011-02-12 16:41:37 [INFO] <AngryRhetoric> much appreciated
2011-02-12 16:41:45 [INFO] <AngryRhetoric> haha
2011-02-12 16:41:59 [INFO] <AngryRhetoric> is holding shift important? studies say yes
2011-02-12 16:42:03 [INFO] <k0n2ad> that was too funny, sorry
2011-02-12 16:42:11 [INFO] <k0n2ad> i got a kick out of it
2011-02-12 16:42:18 [INFO] <k0n2ad> Dakness
2011-02-12 16:42:18 [INFO] <AngryRhetoric> that must've looked funny from your position
2011-02-12 16:42:25 [INFO] <k0n2ad> yea, death
2011-02-12 16:42:42 [INFO] <k0n2ad> dont forget your pants
2011-02-12 16:42:53 [INFO] <AngryRhetoric> sky voice *aww man my shit's everywhere
2011-02-12 16:42:58 [INFO] <k0n2ad> lol
2011-02-12 16:43:17 [INFO] <k0n2ad> do you see this tnt?
2011-02-12 16:43:34 [INFO] <k0n2ad> its glowing - in that cliff over there
2011-02-12 16:43:46 [INFO] <k0n2ad> yea
2011-02-12 16:43:52 [INFO] <AngryRhetoric> whoa someone carved out the inside
2011-02-12 16:43:53 [INFO] <k0n2ad> do you see it?
2011-02-12 16:43:58 [INFO] <AngryRhetoric> oh i know what that is
2011-02-12 16:44:07 [INFO] <AngryRhetoric> that's an artifact
2011-02-12 16:44:30 [INFO] <AngryRhetoric> thx
2011-02-12 16:44:30 [INFO] <k0n2ad> what is
2011-02-12 16:44:33 [INFO] <k0n2ad> np
2011-02-12 16:44:41 [INFO] <AngryRhetoric> the glowing dynamite is from an exploded tnt that stays leftover
2011-02-12 16:44:42 [INFO] <k0n2ad> it looks like a glitch
2011-02-12 16:44:44 [INFO] <AngryRhetoric> it is
2011-02-12 16:44:53 [INFO] <AngryRhetoric> i don't see it cuz i didn't see the explosion
2011-02-12 16:44:53 [INFO] <k0n2ad> oh ok, so you see it too
2011-02-12 16:44:58 [INFO] <AngryRhetoric> i've seen it before
2011-02-12 16:45:03 [INFO] <k0n2ad> gotcha
2011-02-12 16:45:18 [INFO] <AngryRhetoric> i guess i have to deconstruct my dirt tower
2011-02-12 16:46:14 [INFO] <k0n2ad> john i put some iron here
2011-02-12 16:46:24 [INFO] <k0n2ad> what are you using it for?
2011-02-12 16:46:33 [INFO] <nawf> shovels, need a sand run
2011-02-12 16:46:35 [INFO] <nawf> for more tnt
2011-02-12 16:46:40 [INFO] <k0n2ad> ok check it
2011-02-12 16:46:58 [INFO] <nawf> sweet, thanks
2011-02-12 16:47:00 [INFO] <k0n2ad> np
2011-02-12 16:47:11 [INFO] <AngryRhetoric> how much iron did you get?
2011-02-12 16:47:31 [INFO] <AngryRhetoric> i need some but can mine it myself if neeeded
2011-02-12 16:47:32 [INFO] <k0n2ad> not too much, it was under my shanty
2011-02-12 16:47:43 [INFO] <k0n2ad> there is some int he stove over there
2011-02-12 16:48:03 [INFO] <AngryRhetoric> nice we nee dmore
2011-02-12 16:48:07 [INFO] <k0n2ad> who built that long passage that goes to the waterfall?
2011-02-12 16:48:17 [INFO] <AngryRhetoric> i thought you did
2011-02-12 16:48:27 [INFO] <k0n2ad> i built the one to the cabin
2011-02-12 16:48:31 [INFO] <nawf> I didn't
2011-02-12 16:48:34 [INFO] <AngryRhetoric> hmm
2011-02-12 16:48:34 [INFO] <k0n2ad> but the other one coming here
2011-02-12 16:48:46 [INFO] <nawf> oh, yeah
2011-02-12 16:48:47 [INFO] <nawf> kev
2011-02-12 16:49:03 [INFO] <nawf> I think its better if we build this wall, by the staging area, out farther
2011-02-12 16:49:08 [INFO] <nawf> becase we have all that open space
2011-02-12 16:49:21 [INFO] <AngryRhetoric> you mean the courtyard wall?
2011-02-12 16:49:24 [INFO] <nawf> yeah
2011-02-12 16:49:33 [INFO] <AngryRhetoric> well you already started it a certain length away from the castle
2011-02-12 16:49:42 [INFO] <AngryRhetoric> i was thiniking keep it the same all the way around but we don't have to
2011-02-12 16:49:51 [INFO] <k0n2ad> lol this iron is unminable
2011-02-12 16:50:04 [INFO] <nawf> I think it would be cool to make it more asymetrical in places
2011-02-12 16:50:06 [INFO] <AngryRhetoric> lol!
2011-02-12 16:50:12 [INFO] <k0n2ad> what  atease
2011-02-12 16:50:12 [INFO] <nawf> especially to work in the existing base
2011-02-12 16:50:16 [INFO] <AngryRhetoric> too close to the spawn point
2011-02-12 16:50:26 [INFO] <AngryRhetoric> ah ok
2011-02-12 16:50:44 [INFO] <AngryRhetoric> yeah that's fine with me, we should have the dirt be level with the castle at lesat then
2011-02-12 16:50:50 [INFO] <nawf> yeah
2011-02-12 16:51:44 [INFO] <AngryRhetoric> its like an ant hill down here
2011-02-12 16:51:49 [INFO] <k0n2ad> hahah
2011-02-12 16:52:05 [INFO] <k0n2ad> get lost easily
2011-02-12 16:52:08 [INFO] <AngryRhetoric> oh yeah
2011-02-12 16:53:46 [INFO] <AngryRhetoric> whoa where did this waterfall come from
2011-02-12 16:53:54 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 16:53:54 [INFO] <k0n2ad> where
2011-02-12 16:54:08 [INFO] <AngryRhetoric> i'm at it now
2011-02-12 16:54:26 [INFO] <k0n2ad> lol
2011-02-12 16:54:30 [INFO] <AngryRhetoric> if you get lost make your own trail haha
2011-02-12 16:54:42 [INFO] <k0n2ad> yea i saw this earlier
2011-02-12 16:55:22 [INFO] <AngryRhetoric> lol
2011-02-12 16:55:26 [INFO] <k0n2ad> fug
2011-02-12 16:55:26 [INFO] <AngryRhetoric> cave in!
2011-02-12 16:55:39 [INFO] <AngryRhetoric> no iron
2011-02-12 16:55:45 [INFO] <k0n2ad> hey how di you get up
2011-02-12 16:56:05 [INFO] <k0n2ad> nice
2011-02-12 16:56:09 [INFO] <AngryRhetoric> yeah
2011-02-12 16:56:23 [INFO] <AngryRhetoric> i know where we are
2011-02-12 16:56:30 [INFO] <k0n2ad> did you build the new castle tower thing?
2011-02-12 16:56:43 [INFO] <AngryRhetoric> the tower for the new castle, the big one?
2011-02-12 16:56:46 [INFO] <k0n2ad> yea
2011-02-12 16:56:53 [INFO] <AngryRhetoric> i built the spire on top, john built the tower
2011-02-12 16:56:56 [INFO] <AngryRhetoric> its pretty hot
2011-02-12 16:57:04 [INFO] <k0n2ad> that things looks fucking sweet
2011-02-12 16:57:18 [INFO] <nawf> kevin is a spinneret master
2011-02-12 16:57:22 [INFO] <AngryRhetoric> hahaha
2011-02-12 16:57:33 [INFO] <AngryRhetoric> matching towers on the other 3 corners and we're in bidness
2011-02-12 17:00:29 [INFO] <AngryRhetoric> yo dog where the iron at
2011-02-12 17:00:40 [INFO] <k0n2ad> lol
2011-02-12 17:01:12 [INFO] <AngryRhetoric> YES!
2011-02-12 17:01:19 [INFO] <k0n2ad> found some?
2011-02-12 17:01:26 [INFO] <AngryRhetoric> 4 blocks
2011-02-12 17:01:28 [INFO] <AngryRhetoric> haha
2011-02-12 17:01:29 [INFO] <k0n2ad> nice
2011-02-12 17:01:36 [INFO] <AngryRhetoric> its typically near coal so that's the only clue
2011-02-12 17:08:18 [INFO] <nawf> I think we need to do some branch mining and restock our supplies
2011-02-12 17:08:27 [INFO] <nawf> joe has some branch mines setup near the spawner
2011-02-12 17:08:35 [INFO] <k0n2ad> branch mine?
2011-02-12 17:08:37 [INFO] <nawf> I think thats what I'm going to do next after I finish the sand run
2011-02-12 17:08:51 [INFO] <AngryRhetoric> gotta get some iron
2011-02-12 17:08:56 [INFO] <nawf> yeah, you mine a 1 wide, 3 tall tunnel
2011-02-12 17:09:03 [INFO] <nawf> and then every 3 spaces another branch
2011-02-12 17:09:11 [INFO] <nawf> so you cover the most amount of blocks
2011-02-12 17:09:30 [INFO] <nawf> and you do it around level 16 so you find diamonds, gold, lapis as well as iron and coal
2011-02-12 17:09:32 [INFO] <k0n2ad> got that shit down to a science huh
2011-02-12 17:09:45 [INFO] <nawf> yeah, its boring as fuck but its the most efficient way to get shit
2011-02-12 17:09:57 [INFO] <nawf> and if all three of us do it we'll replenish fast
2011-02-12 17:10:09 [INFO] <nawf> joe found 60ish diamonds in 4 hours
2011-02-12 17:10:15 [INFO] <nawf> well maybe 6 I htink
2011-02-12 17:10:20 [INFO] <AngryRhetoric> haha
2011-02-12 17:10:24 [INFO] <k0n2ad> i actually have to get going soon, but i will do that at some point
2011-02-12 17:10:39 [INFO] <AngryRhetoric> i've a lways found it easiest to find diamonds in existing caves, the big ones that go way down
2011-02-12 17:12:50 [INFO] <k0n2ad> who needs iron right now
2011-02-12 17:13:04 [INFO] <AngryRhetoric> i have 4 haha
2011-02-12 17:13:19 [INFO] <k0n2ad> you need more?
2011-02-12 17:13:32 [INFO] <AngryRhetoric> whoa wtf happened here at the castle, dam creeper
2011-02-12 17:13:40 [INFO] <AngryRhetoric> um sure maybe a couple more
2011-02-12 17:13:48 [INFO] <k0n2ad> where are you
2011-02-12 17:13:59 [INFO] <AngryRhetoric> by the castle
2011-02-12 17:14:25 [INFO] <k0n2ad> yo
2011-02-12 17:14:28 [INFO] <k0n2ad> turn aroung
2011-02-12 17:14:29 [INFO] <AngryRhetoric> ioh
2011-02-12 17:14:38 [INFO] <AngryRhetoric> nice thx!
2011-02-12 17:14:59 [INFO] <k0n2ad> ok im out for now
2011-02-12 17:15:02 [INFO] <k0n2ad> later guys
2011-02-12 17:15:03 [INFO] <AngryRhetoric> same
2011-02-12 17:15:08 [INFO] <AngryRhetoric> be back on later tonight maybe
2011-02-12 17:15:09 [INFO] k0n2ad lost connection: disconnect.quitting
2011-02-12 17:15:10 [INFO] <nawf> later
2011-02-12 17:15:49 [INFO] <AngryRhetoric> laters
2011-02-12 17:15:50 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-12 17:18:29 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 17:33:49 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 18:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 18:18:49 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 18:19:26 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 19:18:12 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 19:18:45 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 19:35:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 20:18:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 20:19:19 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 20:23:28 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 20:44:46 [INFO] nawf lost connection: disconnect.quitting
2011-02-12 21:18:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 21:19:35 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 21:24:29 [INFO] nawf [/76.23.232.27:55046] logged in with entity id 2070402
2011-02-12 22:08:39 [INFO] nawf lost connection: disconnect.quitting
2011-02-12 22:14:32 [INFO] nawf [/76.23.232.27:55099] logged in with entity id 2128639
2011-02-12 22:18:32 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 22:19:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 22:19:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 23:18:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 23:18:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 23:18:25 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 23:18:48 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-12 23:31:27 [INFO] nawf lost connection: disconnect.quitting
2011-02-13 00:17:23 [INFO] redux06790 [/69.119.8.191:49714] logged in with entity id 2226623
2011-02-13 00:17:27 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 00:17:33 [INFO] <redux06790> so
2011-02-13 00:17:34 [INFO] <redux06790> very
2011-02-13 00:17:36 [INFO] <redux06790> tired
2011-02-13 00:18:18 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 00:18:46 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 01:18:04 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 01:19:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 01:25:33 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 02:18:29 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 03:18:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 05:18:09 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 06:18:15 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 06:18:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 09:18:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 10:18:08 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 10:19:00 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 10:19:34 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 10:23:01 [INFO] nawf [/76.23.232.27:55167] logged in with entity id 2567642
2011-02-13 10:23:05 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 10:37:13 [INFO] To run the server without a gui, start it like this:
2011-02-13 10:37:13 [INFO]    java -Xmx1024M -Xms1024M -jar minecraft_server.jar nogui
2011-02-13 10:37:13 [INFO] Console commands:
2011-02-13 10:37:13 [INFO]    help  or  ?               shows this message
2011-02-13 10:37:13 [INFO]    kick <player>             removes a player from the server
2011-02-13 10:37:13 [INFO]    ban <player>              bans a player from the server
2011-02-13 10:37:13 [INFO]    pardon <player>           pardons a banned player so that they can connect again
2011-02-13 10:37:13 [INFO]    ban-ip <ip>               bans an IP address from the server
2011-02-13 10:37:13 [INFO]    pardon-ip <ip>            pardons a banned IP address so that they can connect again
2011-02-13 10:37:13 [INFO]    op <player>               turns a player into an op
2011-02-13 10:37:13 [INFO]    deop <player>             removes op status from a player
2011-02-13 10:37:13 [INFO]    tp <player1> <player2>    moves one player to the same location as another player
2011-02-13 10:37:13 [INFO]    give <player> <id> [num]  gives a player a resource
2011-02-13 10:37:13 [INFO]    tell <player> <message>   sends a private message to a player
2011-02-13 10:37:13 [INFO]    stop                      gracefully stops the server
2011-02-13 10:37:13 [INFO]    save-all                  forces a server-wide level save
2011-02-13 10:37:13 [INFO]    save-off                  disables terrain saving (useful for backup scripts)
2011-02-13 10:37:13 [INFO]    save-on                   re-enables terrain saving
2011-02-13 10:37:13 [INFO]    list                      lists all currently connected players
2011-02-13 10:37:13 [INFO]    say <message>             broadcasts a message to all players
2011-02-13 10:37:25 [INFO] [CONSOLE] what up john
2011-02-13 10:37:42 [INFO] <nawf> splunking
2011-02-13 10:37:54 [INFO] [CONSOLE] nice where
2011-02-13 10:38:14 [INFO] <nawf> right in front of the main base
2011-02-13 10:38:27 [INFO] <nawf> there was a cave I found about 2 months ago
2011-02-13 10:38:29 [INFO] [CONSOLE] what really, there's more caves?
2011-02-13 10:38:33 [INFO] <nawf> and I just left it
2011-02-13 10:38:47 [INFO] Unknown console command. Type ""help"" for help.
2011-02-13 10:38:49 [INFO] [CONSOLE] nice
2011-02-13 10:38:52 [INFO] <nawf> I'm at -66, 223 right no
2011-02-13 10:38:57 [INFO] [CONSOLE] k
2011-02-13 10:39:09 [INFO] <nawf> pretty big cave right by the lava
2011-02-13 10:39:09 [INFO] [CONSOLE] i'll join a little later, gotta finish some chores
2011-02-13 10:39:25 [INFO] [CONSOLE] animal cages
2011-02-13 10:39:30 [INFO] [CONSOLE] gotta deal with tons of shit
2011-02-13 10:46:26 [INFO] nawf lost connection: disconnect.quitting
2011-02-13 11:18:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 11:18:47 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 11:38:59 [INFO] nawf [/76.23.232.27:55151] logged in with entity id 2589131
2011-02-13 11:39:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:00:35 [INFO] <nawf> rofl
2011-02-13 12:05:21 [INFO] efess [/192.168.0.191:63771] logged in with entity id 2613397
2011-02-13 12:05:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:05:35 [INFO] <efess> yo!
2011-02-13 12:06:01 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:06:14 [INFO] <nawf> yo
2011-02-13 12:06:23 [INFO] <nawf> I just surfaced after splunking
2011-02-13 12:06:27 [INFO] <efess> nice
2011-02-13 12:06:29 [INFO] <nawf> right next to erins ""far away"" house
2011-02-13 12:06:41 [INFO] <efess> his single player house
2011-02-13 12:06:45 [INFO] <nawf> yeah
2011-02-13 12:07:55 [INFO] <nawf> well it worked out
2011-02-13 12:08:02 [INFO] <nawf> I only surfaced because I needed arrows
2011-02-13 12:08:07 [INFO] <nawf> he had some, left him some goodies
2011-02-13 12:08:56 [INFO] <efess> he's going to need a rail line at some point :D
2011-02-13 12:09:11 [INFO] <nawf> yeah
2011-02-13 12:16:39 [INFO] <nawf> FUCK
2011-02-13 12:16:39 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:16:42 [INFO] <efess> ?
2011-02-13 12:16:47 [INFO] <nawf> I died
2011-02-13 12:16:54 [INFO] <nawf> zombie pushed me into lava
2011-02-13 12:16:55 [INFO] <efess> ouch, all thew ay out there?
2011-02-13 12:17:00 [INFO] <nawf> 60 iron, 1 diamond
2011-02-13 12:17:09 [INFO] <efess> shitty
2011-02-13 12:19:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:20:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:22:22 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:24:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:24:58 [INFO] <nawf> oh man, I lost mossy cobble too, I had plans for that
2011-02-13 12:25:36 [INFO] <efess> damn
2011-02-13 12:25:46 [INFO] <efess> well I knwo where there's two dungeons
2011-02-13 12:27:16 [INFO] <efess> you still working on the castle walls?
2011-02-13 12:27:28 [INFO] <nawf> yeah, just took a break
2011-02-13 12:27:36 [INFO] <efess> cool.
2011-02-13 12:27:45 [INFO] <efess> going out to here?
2011-02-13 12:27:46 [INFO] <nawf> we were running low on diamond and iron so I did some branch mining and then some splunking
2011-02-13 12:27:54 [INFO] <nawf> naw, farhter I think
2011-02-13 12:27:57 [INFO] <efess> sweet
2011-02-13 12:28:01 [INFO] <nawf> see up there
2011-02-13 12:28:14 [INFO] <efess> ya
2011-02-13 12:28:19 [INFO] <efess> damn
2011-02-13 12:28:19 [INFO] <nawf> want to make this a courtyard, tie it into the old base
2011-02-13 12:28:24 [INFO] <efess> nice
2011-02-13 12:28:42 [INFO] <efess> FUUUUUU
2011-02-13 12:29:02 [INFO] <nawf> I have no weapons
2011-02-13 12:29:38 [INFO] <efess> man spiders fuckin suck
2011-02-13 12:30:27 [INFO] <nawf> I got him
2011-02-13 12:30:40 [INFO] <efess> thx
2011-02-13 12:30:54 [INFO] <efess> glitch
2011-02-13 12:30:55 [INFO] <efess> lol
2011-02-13 12:31:03 [INFO] <nawf> some of your shit is in that hole
2011-02-13 12:31:40 [INFO] <nawf> I removed a mountain
2011-02-13 12:31:53 [INFO] <efess> ya there used to be one here huh
2011-02-13 12:31:53 [INFO] <efess> lol
2011-02-13 12:32:22 [INFO] <efess> this thing will never be done
2011-02-13 12:32:23 [INFO] <efess> lol
2011-02-13 12:32:26 [INFO] <nawf> lol
2011-02-13 12:32:35 [INFO] <nawf> one step at a time
2011-02-13 12:32:38 [INFO] <efess> ya
2011-02-13 12:33:14 [INFO] <nawf> alright, I'm equipped for spunking
2011-02-13 12:33:19 [INFO] <efess> k
2011-02-13 12:33:22 [INFO] <nawf> gonna head back
2011-02-13 12:33:38 [INFO] <efess> i'll do some at the end of those rails
2011-02-13 12:33:47 [INFO] <efess> still some unexplored caves
2011-02-13 12:33:53 [INFO] <efess> i'll get that mossy shit for you too
2011-02-13 12:34:04 [INFO] <nawf> I went to the first major break in the tracks, then left, and then all the way back to the base
2011-02-13 12:34:12 [INFO] <nawf> only 8 diamonds :(
2011-02-13 12:34:27 [INFO] <efess> ah, that place is dry now/
2011-02-13 12:34:38 [INFO] <efess> ?
2011-02-13 12:34:40 [INFO] <nawf> well I mean I did a side branch
2011-02-13 12:34:52 [INFO] <efess> oh okay
2011-02-13 12:36:43 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:39:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:44:20 [INFO] <nawf> OMG YES
2011-02-13 12:44:24 [INFO] <nawf> my shit made it
2011-02-13 12:44:26 [INFO] <nawf> lol
2011-02-13 12:44:31 [INFO] <efess> haha
2011-02-13 12:44:47 [INFO] <efess> make a chest nao!
2011-02-13 12:46:50 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 12:47:52 [INFO] <nawf> phew, chest made
2011-02-13 12:47:57 [INFO] <nawf> goodies saved
2011-02-13 12:48:00 [INFO] <nawf> taking a break
2011-02-13 12:48:04 [INFO] <efess> :D
2011-02-13 12:48:10 [INFO] <nawf> brb 15 or so
2011-02-13 12:48:18 [INFO] <nawf> maybe more, need rl fud
2011-02-13 12:48:23 [INFO] nawf lost connection: disconnect.quitting
2011-02-13 12:49:24 [INFO] redux06790 [/69.119.8.191:49214] lost connection
2011-02-13 12:49:33 [INFO] redux06790 [/69.119.8.191:49216] lost connection
2011-02-13 12:49:47 [INFO] redux06790 [/69.119.8.191:49219] lost connection
2011-02-13 12:49:47 [INFO] Disconnecting redux06790 [/69.119.8.191:49214]: Failed to verify username!
2011-02-13 12:50:03 [INFO] redux06790 [/69.119.8.191:49222] lost connection
2011-02-13 12:50:04 [INFO] Disconnecting redux06790 [/69.119.8.191:49216]: Failed to verify username!
2011-02-13 12:50:09 [INFO] Disconnecting redux06790 [/69.119.8.191:49219]: Failed to verify username!
2011-02-13 12:50:34 [INFO] redux06790 [/69.119.8.191:49228] lost connection
2011-02-13 12:51:06 [INFO] Disconnecting redux06790 [/69.119.8.191:49231]: Took too long to log in
2011-02-13 12:51:17 [INFO] redux06790 [/69.119.8.191:49234] logged in with entity id 2759153
2011-02-13 12:51:22 [INFO] <efess> what up
2011-02-13 12:55:15 [INFO] <redux06790> sorry was tabbed out
2011-02-13 12:55:20 [INFO] <redux06790> was taking forever to connect
2011-02-13 12:55:29 [INFO] <redux06790> dude sheep dont work in a mob grinder
2011-02-13 12:55:41 [INFO] <efess> ya I know
2011-02-13 12:55:44 [INFO] <redux06790> fuuu
2011-02-13 12:55:51 [INFO] <efess> manual wool
2011-02-13 12:55:51 [INFO] <redux06790> wool is the best block ever
2011-02-13 12:56:03 [INFO] <redux06790> im thinking of making a livestock slaughterhouse
2011-02-13 12:56:06 [INFO] <efess> lol
2011-02-13 12:56:18 [INFO] <efess> looks like that's what you gotta do
2011-02-13 12:56:33 [INFO] <efess> I read somewhere that sheep used to get their wool back too
2011-02-13 12:56:36 [INFO] <efess> by eating grass
2011-02-13 12:56:39 [INFO] <redux06790> yeah in test
2011-02-13 12:58:08 [INFO] <redux06790> i found basically a mountain of sand
2011-02-13 12:58:15 [INFO] <efess> found a desert?
2011-02-13 12:58:16 [INFO] <redux06790> ive been chipping away at it making sandstone
2011-02-13 12:58:17 [INFO] <redux06790> yea
2011-02-13 12:58:42 [INFO] <redux06790> im actually looking for clay
2011-02-13 12:58:49 [INFO] <redux06790> but in the process found a huge desert
2011-02-13 12:58:56 [INFO] <efess> making a brick house?
2011-02-13 12:59:03 [INFO] <redux06790> dunno yet
2011-02-13 12:59:05 [INFO] <redux06790> just want the brick
2011-02-13 12:59:24 [INFO] <redux06790> maybe to add to castle mondo
2011-02-13 12:59:26 [INFO] <redux06790> i dunno
2011-02-13 12:59:37 [INFO] <efess> its got a name now?
2011-02-13 12:59:38 [INFO] <efess> hehe
2011-02-13 12:59:48 [INFO] <redux06790> thats just what i personally call it
2011-02-13 13:00:11 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 13:01:14 [INFO] <redux06790> so what project are you working on?
2011-02-13 13:01:20 [INFO] <efess> just some splunking
2011-02-13 13:01:29 [INFO] <redux06790> best way to get coal
2011-02-13 13:01:33 [INFO] <efess> ya
2011-02-13 13:01:38 [INFO] <redux06790> and iron
2011-02-13 13:01:53 [INFO] <redux06790> i never find diamonds caving though
2011-02-13 13:02:36 [INFO] <efess> resources are in huge demand for castle mondo
2011-02-13 13:02:46 [INFO] <redux06790> and i usually get my ass handed to me by creepers
2011-02-13 13:02:55 [INFO] <redux06790> you mean STONE is in huge demand?
2011-02-13 13:03:24 [INFO] <efess> yea and I'll need iron for more rail
2011-02-13 13:03:31 [INFO] <efess> you have a house far out right?
2011-02-13 13:03:44 [INFO] <redux06790> shit its night
2011-02-13 13:04:04 [INFO] <efess> splunk for the night
2011-02-13 13:04:07 [INFO] <efess> stay down for 3 hours
2011-02-13 13:05:05 [INFO] <redux06790> ive just been hiding in my pod at night
2011-02-13 13:06:42 [INFO] <redux06790> hmm
2011-02-13 13:08:35 [INFO] <efess> watching science channel do a segment on tunnelling
2011-02-13 13:08:42 [INFO] <efess> lol.
2011-02-13 13:09:02 [INFO] <redux06790> anything useful?
2011-02-13 13:09:14 [INFO] <efess> ya be careful around sand/water
2011-02-13 13:09:14 [INFO] <efess> haha
2011-02-13 13:10:16 [INFO] <efess> a huge underground drill
2011-02-13 13:10:18 [INFO] <efess> that's what we need
2011-02-13 13:10:28 [INFO] <redux06790> i was thinking of making a reverse tower
2011-02-13 13:10:33 [INFO] <redux06790> like just a big ass hole
2011-02-13 13:11:02 [INFO] <efess> there are natural occurances of htat
2011-02-13 13:11:08 [INFO] <redux06790> yeah i found one
2011-02-13 13:11:16 [INFO] <redux06790> its about 30 blocks deep
2011-02-13 13:14:02 [INFO] <redux06790> ok
2011-02-13 13:14:07 [INFO] <redux06790> time to bring in my haul
2011-02-13 13:14:32 [INFO] <efess> gotta drop off your load
2011-02-13 13:15:36 [INFO] <redux06790> if i can remember how to get back
2011-02-13 13:17:17 [INFO] <redux06790> looks so promising
2011-02-13 13:17:19 [INFO] <redux06790> this hole
2011-02-13 13:19:29 [INFO] <redux06790> so... much... treasure
2011-02-13 13:19:51 [INFO] <efess> im definitely lost
2011-02-13 13:20:16 [INFO] <redux06790> lol adventuring?
2011-02-13 13:20:21 [INFO] <efess> splunking
2011-02-13 13:20:26 [INFO] <redux06790> oh
2011-02-13 13:20:41 [INFO] <redux06790> i prefer adventuring on the surface to spelunking
2011-02-13 13:21:04 [INFO] <efess> im a diamond addict
2011-02-13 13:21:14 [INFO] <redux06790> i just branch mine for diamonds
2011-02-13 13:22:02 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 13:22:11 [INFO] nawf [/76.23.232.27:55112] logged in with entity id 3158452
2011-02-13 13:22:17 [INFO] <redux06790> oh shit son
2011-02-13 13:22:25 [INFO] <nawf> yo erin
2011-02-13 13:22:29 [INFO] <nawf> I found your island house
2011-02-13 13:22:33 [INFO] <redux06790> lol
2011-02-13 13:22:40 [INFO] <redux06790> nice huh?
2011-02-13 13:22:50 [INFO] <nawf> it has a stairway to a cave now
2011-02-13 13:22:55 [INFO] <redux06790> lol tnt?
2011-02-13 13:23:10 [INFO] <nawf> nope, I'm splunking and I surfaced right next to it
2011-02-13 13:23:24 [INFO] <redux06790> ahh there is a cave a did some exploring in
2011-02-13 13:23:31 [INFO] <redux06790> i wonder if its connected
2011-02-13 13:23:35 [INFO] <nawf> I think so
2011-02-13 13:23:54 [INFO] <nawf> there is another entrance to that cave just east? of the spawn
2011-02-13 13:24:14 [INFO] <nawf> I think this is the one you said may be large
2011-02-13 13:24:15 [INFO] <nawf> it is
2011-02-13 13:24:16 [INFO] <redux06790> idk
2011-02-13 13:24:19 [INFO] <redux06790> yeah
2011-02-13 13:24:24 [INFO] <redux06790> i know it was
2011-02-13 13:24:27 [INFO] <redux06790> i ran through it for a bit
2011-02-13 13:24:29 [INFO] <nawf> oh, I found a spider spawner too
2011-02-13 13:24:31 [INFO] <redux06790> without placing torches
2011-02-13 13:24:33 [INFO] <redux06790> woot
2011-02-13 13:24:34 [INFO] <nawf> if you need a wool farm
2011-02-13 13:24:35 [INFO] <redux06790> dont break it
2011-02-13 13:24:37 [INFO] <redux06790> i do
2011-02-13 13:24:42 [INFO] <redux06790> omg i do
2011-02-13 13:24:43 [INFO] <nawf> its at 40, 39, 178
2011-02-13 13:24:53 [INFO] <redux06790> leave a sign on my house with coords
2011-02-13 13:24:59 [INFO] <efess> the dungeon destroying party is on its way
2011-02-13 13:25:00 [INFO] <nawf> if I get there again
2011-02-13 13:25:15 [INFO] <nawf> I'm sofa king lost atm
2011-02-13 13:25:58 [INFO] <redux06790> lol
2011-02-13 13:26:09 [INFO] <redux06790> theres a chunk missing right in the middle of castle mchugeypants
2011-02-13 13:26:29 [INFO] <redux06790> im dropping off about 7 stack of cobble
2011-02-13 13:26:38 [INFO] <redux06790> for it
2011-02-13 13:27:51 [INFO] <redux06790> so i think ill contribute to the castle by providing materials
2011-02-13 13:27:54 [INFO] <nawf> oh, and I took your arrows
2011-02-13 13:28:02 [INFO] <redux06790> meh
2011-02-13 13:28:03 [INFO] <nawf> but I left some goodies in return
2011-02-13 13:28:08 [INFO] <redux06790> ohhh
2011-02-13 13:28:13 [INFO] <redux06790> did you restock on food?
2011-02-13 13:28:22 [INFO] <redux06790> i have a chest fullllll to the asshole with food
2011-02-13 13:28:25 [INFO] <nawf> naw, just needed arrows
2011-02-13 13:28:31 [INFO] <nawf> thats was the only reason I surfaced
2011-02-13 13:28:45 [INFO] <redux06790> where did you start in that cave anyway?
2011-02-13 13:29:03 [INFO] <nawf> just slightly east? of the base
2011-02-13 13:29:09 [INFO] <redux06790> wow
2011-02-13 13:29:10 [INFO] <nawf> like if you go out the front door of the main base
2011-02-13 13:29:15 [INFO] <redux06790> thats a big fucking ass cave
2011-02-13 13:29:18 [INFO] <nawf> and follow the torches you'll find it
2011-02-13 13:29:30 [INFO] <nawf> oh its even bigger
2011-02-13 13:30:07 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 13:30:08 [INFO] <redux06790> bitch night needs to end
2011-02-13 13:30:14 [INFO] <redux06790> wtb runecraft for this server
2011-02-13 13:30:24 [INFO] <efess> runecraft?
2011-02-13 13:30:28 [INFO] <redux06790> its an addon
2011-02-13 13:30:33 [INFO] <redux06790> that lets you do spells
2011-02-13 13:30:35 [INFO] <redux06790> like flying
2011-02-13 13:30:39 [INFO] <redux06790> making night to day
2011-02-13 13:30:45 [INFO] <redux06790> and power picks and shit
2011-02-13 13:30:47 [INFO] <redux06790> its amazing
2011-02-13 13:30:50 [INFO] <nawf> psh
2011-02-13 13:31:21 [INFO] <redux06790> psh nothing
2011-02-13 13:31:23 [INFO] <redux06790> its awesome
2011-02-13 13:31:27 [INFO] <efess> haha
2011-02-13 13:31:44 [INFO] <redux06790> and its not like youll not be doing stuff legit still
2011-02-13 13:31:59 [INFO] <efess> not legit?
2011-02-13 13:32:04 [INFO] <redux06790> yea
2011-02-13 13:32:07 [INFO] <redux06790> like... cheating
2011-02-13 13:32:31 [INFO] <efess> giving spells seems like cheating
2011-02-13 13:32:34 [INFO] <redux06790> theres also an addon that allows you to turn signs into teleporters
2011-02-13 13:32:45 [INFO] <redux06790> which could be insanely useful
2011-02-13 13:32:59 [INFO] <nawf> I think that takes away the fun
2011-02-13 13:33:01 [INFO] <redux06790> for moving about
2011-02-13 13:33:05 [INFO] <nawf> why would you make rails then?
2011-02-13 13:33:10 [INFO] <redux06790> when the map gets HUGE it doesnt
2011-02-13 13:33:38 [INFO] <redux06790> then again i did ponder the idea of making rails to my island house
2011-02-13 13:44:04 [INFO] <redux06790> imma go get lunch
2011-02-13 13:44:11 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 13:58:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 14:06:18 [INFO] <efess> still need mossy cobble?
2011-02-13 14:06:36 [INFO] <nawf> probably, can't hurt
2011-02-13 14:18:30 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 14:18:56 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 14:25:19 [INFO] <efess> gonna do some work bbl
2011-02-13 14:25:26 [INFO] <nawf> ok
2011-02-13 14:25:30 [INFO] efess lost connection: disconnect.quitting
2011-02-13 14:38:23 [INFO] nawf lost connection: disconnect.quitting
2011-02-13 15:18:13 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 15:18:41 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 15:43:13 [INFO] Disconnecting redux06790 [/69.119.8.191:49296]: Took too long to log in
2011-02-13 15:43:59 [INFO] redux06790 [/69.119.8.191:49299] logged in with entity id 3368250
2011-02-13 15:44:12 [INFO] <redux06790> oh herro mongorian
2011-02-13 15:44:17 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 15:51:13 [INFO] nawf [/76.23.232.27:55019] logged in with entity id 3373879
2011-02-13 15:51:16 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 15:52:08 [INFO] <redux06790> IT'S RIGHT BEHIND YOU JOHN RUN YOU FUCKER RUN RUN RUN!!!
2011-02-13 15:52:21 [INFO] <redux06790> YOURE NOT SAFE!!!!
2011-02-13 15:52:27 [INFO] <nawf> naw, no noises, I'm safe
2011-02-13 15:53:05 [INFO] <redux06790> im going to make a 25 block wide round hole that goes straight to the bedrock
2011-02-13 15:56:25 [INFO] <redux06790> hows the caving going?
2011-02-13 15:56:40 [INFO] <nawf> ok, only 9 diamonds so far
2011-02-13 15:56:43 [INFO] <nawf> tons of iron though
2011-02-13 15:56:54 [INFO] <redux06790> caving = best way to get coal ever
2011-02-13 15:57:08 [INFO] <nawf> oh yeah, I have 400ish coal
2011-02-13 16:08:18 [INFO] <redux06790> ugh
2011-02-13 16:08:24 [INFO] <redux06790> im going to need to march to my house
2011-02-13 16:08:29 [INFO] <redux06790> out of diamond tools
2011-02-13 16:08:32 [INFO] <redux06790> need to make more
2011-02-13 16:09:24 [INFO] <nawf> there weren't any tools in your house
2011-02-13 16:09:28 [INFO] <nawf> err diamon
2011-02-13 16:09:29 [INFO] <nawf> d
2011-02-13 16:09:33 [INFO] <redux06790> there is
2011-02-13 16:09:36 [INFO] <redux06790> on the second floor
2011-02-13 16:10:48 [INFO] <redux06790> or did you not go up there?
2011-02-13 16:11:38 [INFO] <nawf> yeah, def no diamonds
2011-02-13 16:11:42 [INFO] <redux06790> wtf
2011-02-13 16:11:42 [INFO] <nawf> at your island home
2011-02-13 16:11:55 [INFO] <redux06790> thats fucked because i had like at least 10
2011-02-13 16:12:23 [INFO] <redux06790> now i have to go check just to make sure you didnt miss them
2011-02-13 16:12:29 [INFO] <redux06790> the sun approacheth
2011-02-13 16:13:05 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 16:18:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 16:18:54 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 16:29:04 [INFO] redux06790 [/69.119.8.191:49367] logged in with entity id 3414346
2011-02-13 16:29:52 [INFO] <redux06790> you here?
2011-02-13 16:30:22 [INFO] <nawf> yeah
2011-02-13 16:30:23 [INFO] <nawf> fuck
2011-02-13 16:30:28 [INFO] <nawf> fought a zombie spawner
2011-02-13 16:30:39 [INFO] <redux06790> you know a game is good when youre willing to deal with its instability to play it
2011-02-13 16:31:01 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 16:31:42 [INFO] <nawf> your island house has the skull painting right?
2011-02-13 16:32:29 [INFO] <redux06790> sec
2011-02-13 16:32:51 [INFO] <redux06790> spiders are the worst
2011-02-13 16:33:29 [INFO] <redux06790> k im at my house
2011-02-13 16:33:36 [INFO] <redux06790> after getting raped by 6 spiders
2011-02-13 16:34:33 [INFO] <redux06790> dude i still have diamonds here
2011-02-13 16:34:47 [INFO] <nawf> your house is the one with the skull painting?
2011-02-13 16:34:51 [INFO] <redux06790> um
2011-02-13 16:34:56 [INFO] <redux06790> no
2011-02-13 16:35:11 [INFO] <nawf> oh
2011-02-13 16:35:48 [INFO] <nawf> whats with the private stash anyway?
2011-02-13 16:35:58 [INFO] <redux06790> what private stash?
2011-02-13 16:36:06 [INFO] <nawf> you said you had diamonds are your house
2011-02-13 16:36:12 [INFO] <redux06790> yea
2011-02-13 16:36:27 [INFO] <redux06790> but my house is like 1200 blocks away from the spawn
2011-02-13 16:36:38 [INFO] <redux06790> i NEED to have diamonds out here
2011-02-13 16:37:51 [INFO] <nawf> I guess, seems weird unless you mined them yourself
2011-02-13 16:37:59 [INFO] <redux06790> i did
2011-02-13 16:38:26 [INFO] <redux06790> everything at my house i got at or below my island
2011-02-13 16:39:01 [INFO] <nawf> oh alright, I just want to know where all the diamonds went, we had 60 a week ago
2011-02-13 16:39:07 [INFO] <redux06790> idk
2011-02-13 16:39:15 [INFO] <redux06790> ive been using mine
2011-02-13 16:39:30 [INFO] <redux06790> i feel wierd using ""communal"" diamonds
2011-02-13 16:40:00 [INFO] <redux06790> like diamond, obby and brick are all blocks i get for myself
2011-02-13 16:40:14 [INFO] <redux06790> they seem too valuable to just be communal
2011-02-13 16:40:26 [INFO] <nawf> I guess it was different with just joe and I
2011-02-13 16:40:42 [INFO] <redux06790> joe is efess right?
2011-02-13 16:40:45 [INFO] <nawf> yeah
2011-02-13 16:40:54 [INFO] <nawf> because we were doing the same sort of things together
2011-02-13 16:40:54 [INFO] AngryRhetoric [/24.147.183.4:51154] logged in with entity id 3440941
2011-02-13 16:41:04 [INFO] <redux06790> well technically he could just /give diamonds lol
2011-02-13 16:41:11 [INFO] <AngryRhetoric> sup!
2011-02-13 16:41:14 [INFO] <redux06790> heyoooo
2011-02-13 16:41:46 [INFO] <AngryRhetoric> who else is on? unless you're talking to yourself again ;)
2011-02-13 16:41:50 [INFO] <redux06790> john
2011-02-13 16:42:40 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 16:42:47 [INFO] <redux06790> where is that house you thought was mine again john?
2011-02-13 16:43:00 [INFO] <nawf> hold on, I'm not at it right now
2011-02-13 16:43:17 [INFO] <AngryRhetoric> time to go hunting for iron
2011-02-13 16:43:22 [INFO] <nawf> I've got plenty
2011-02-13 16:43:25 [INFO] <redux06790> i have a ton of iron if you want
2011-02-13 16:43:31 [INFO] <AngryRhetoric> yeah? sure
2011-02-13 16:43:53 [INFO] <nawf> the house is at
2011-02-13 16:43:56 [INFO] <redux06790> yeah im outside the castle
2011-02-13 16:43:58 [INFO] <nawf> -49
2011-02-13 16:43:59 [INFO] <AngryRhetoric> if you have lots then i'll take 20-25? if not then 10 would be fine
2011-02-13 16:44:05 [INFO] <nawf> 319
2011-02-13 16:44:23 [INFO] <nawf> has a skull painting and loft
2011-02-13 16:44:45 [INFO] <nawf> its like 3x5
2011-02-13 16:45:13 [INFO] <redux06790> is it on an island?
2011-02-13 16:45:16 [INFO] <nawf> yeah
2011-02-13 16:45:20 [INFO] <redux06790> thats just a safehouse
2011-02-13 16:45:25 [INFO] <redux06790> got like a bed in in and shit
2011-02-13 16:45:29 [INFO] <nawf> yeah
2011-02-13 16:45:33 [INFO] <redux06790> and a couple furnaces firing clay?
2011-02-13 16:45:37 [INFO] <nawf> yeah
2011-02-13 16:45:44 [INFO] <nawf> thats where I surfaced from that cave
2011-02-13 16:45:45 [INFO] <redux06790> yeah thats just a waypoint house
2011-02-13 16:45:56 [INFO] <redux06790> chunk error brb
2011-02-13 16:45:57 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 16:46:00 [INFO] redux06790 [/69.119.8.191:49374] logged in with entity id 3452809
2011-02-13 16:46:04 [INFO] <AngryRhetoric> nice house near the castle
2011-02-13 16:46:09 [INFO] <redux06790> thank
2011-02-13 16:46:11 [INFO] <redux06790> thanks
2011-02-13 16:46:16 [INFO] <redux06790> its NOWHERE near done
2011-02-13 16:46:26 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-13 16:46:33 [INFO] /69.119.8.191:49379 lost connection
2011-02-13 16:46:39 [INFO] /69.119.8.191:49381 lost connection
2011-02-13 16:46:45 [INFO] /69.119.8.191:49384 lost connection
2011-02-13 16:46:52 [INFO] <nawf> ok, well I'll be making a supply drop
2011-02-13 16:46:53 [INFO] /69.119.8.191:49389 lost connection
2011-02-13 16:47:06 [INFO] redux06790 [/69.119.8.191:49395] logged in with entity id 3453931
2011-02-13 16:47:07 [INFO] <nawf> I have 140 iron on me, and another 100 something in a chest
2011-02-13 16:47:09 [INFO] <redux06790> FUUU
2011-02-13 16:47:29 [INFO] <AngryRhetoric> dammm that's a lot of iron, did you go mining for it?
2011-02-13 16:47:39 [INFO] <nawf> splunking
2011-02-13 16:47:50 [INFO] <AngryRhetoric> coool
2011-02-13 16:48:05 [INFO] <AngryRhetoric> iron blocks eh? that's awesome
2011-02-13 16:48:08 [INFO] <nawf> hey if you guys come across mossy cobble and don't need it
2011-02-13 16:48:10 [INFO] <nawf> can you save it
2011-02-13 16:48:11 [INFO] <redux06790> is t
2011-02-13 16:48:16 [INFO] <AngryRhetoric> ok
2011-02-13 16:48:19 [INFO] <redux06790> FUUUUU
2011-02-13 16:48:25 [INFO] <redux06790> help me light this place up
2011-02-13 16:48:42 [INFO] <AngryRhetoric> thx erin
2011-02-13 16:49:09 [INFO] <AngryRhetoric> oh shit
2011-02-13 16:49:09 [INFO] <redux06790> WHAT THE FUCK!!!!
2011-02-13 16:49:11 [INFO] <redux06790> fucking nigger
2011-02-13 16:49:23 [INFO] <redux06790> 70000000 creepers
2011-02-13 16:49:25 [INFO] <AngryRhetoric> you've got diamond floating now lol
2011-02-13 16:49:27 [INFO] <AngryRhetoric> i'll watch it
2011-02-13 16:50:12 [INFO] <redux06790> i hate notches face right now
2011-02-13 16:50:16 [INFO] <AngryRhetoric> this place is swarming!
2011-02-13 16:51:02 [INFO] <AngryRhetoric> your pants
2011-02-13 16:51:05 [INFO] <AngryRhetoric> over here haha
2011-02-13 16:51:27 [INFO] <redux06790> where?
2011-02-13 16:51:30 [INFO] <redux06790> o
2011-02-13 16:51:32 [INFO] <AngryRhetoric> by the tree
2011-02-13 16:51:44 [INFO] <redux06790> im getting so fucking sick of creepers
2011-02-13 16:51:49 [INFO] <redux06790> you dont understand
2011-02-13 16:51:50 [INFO] <redux06790> lol
2011-02-13 16:52:05 [INFO] <nawf> thats what you get for traveling at night
2011-02-13 16:52:06 [INFO] <nawf> ;)
2011-02-13 16:52:39 [INFO] <redux06790> no thats what i get for forgetting to not light shit up
2011-02-13 16:53:27 [INFO] <AngryRhetoric> burned thru a stack of arrows out here
2011-02-13 16:54:00 [INFO] <AngryRhetoric> going to get ham and arrows
2011-02-13 16:54:16 [INFO] <redux06790> OK back to digging a massive hole
2011-02-13 16:54:22 [INFO] <AngryRhetoric> hah why
2011-02-13 16:54:29 [INFO] <redux06790> because i want to
2011-02-13 16:54:38 [INFO] <AngryRhetoric> why not??? haha
2011-02-13 16:54:38 [INFO] <redux06790> because i love a good deep hole
2011-02-13 16:54:46 [INFO] <redux06790> ;)
2011-02-13 16:54:55 [INFO] <AngryRhetoric> so big its like throwing a hot dog down a hall way?
2011-02-13 16:55:17 [INFO] <AngryRhetoric> hey john
2011-02-13 16:55:25 [INFO] <AngryRhetoric> a chunk error is showing me moss cobble stone
2011-02-13 16:55:29 [INFO] <AngryRhetoric> a dungeon
2011-02-13 16:55:41 [INFO] <nawf> go concour it
2011-02-13 16:55:42 [INFO] <AngryRhetoric> which we might already know about not sure
2011-02-13 16:55:56 [INFO] <AngryRhetoric> in fact we must know about it i can see \torches in it
2011-02-13 16:55:59 [INFO] <redux06790> thats why i always mine out mossy
2011-02-13 16:56:42 [INFO] <AngryRhetoric> i'll mine it even if we know about it buwhahaha
2011-02-13 16:56:56 [INFO] <redux06790> anyone think you should be able to turn gold into coins?
2011-02-13 16:57:21 [INFO] <AngryRhetoric> the introduction of currency in this game would vastly change it heh
2011-02-13 16:57:36 [INFO] <nawf> I'd sell sexual favors
2011-02-13 16:57:41 [INFO] <AngryRhetoric> haha for coinage
2011-02-13 16:57:43 [INFO] <redux06790> it would make large servers more stable
2011-02-13 16:58:02 [INFO] <redux06790> economically speaking
2011-02-13 16:58:28 [INFO] <redux06790> plus how awesome would it be to have stacks of coins in your house?
2011-02-13 16:59:05 [INFO] <AngryRhetoric> giant chest full of coins
2011-02-13 16:59:11 [INFO] <AngryRhetoric> brb
2011-02-13 16:59:13 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-13 16:59:22 [INFO] AngryRhetoric [/24.147.183.4:51857] logged in with entity id 3478030
2011-02-13 17:01:25 [INFO] <redux06790> ohh yeah
2011-02-13 17:01:28 [INFO] <redux06790> this hole is sexy
2011-02-13 17:03:34 [INFO] <nawf> total haul
2011-02-13 17:03:43 [INFO] <redux06790> oh rapture
2011-02-13 17:03:44 [INFO] <nawf> 318 iron
2011-02-13 17:03:47 [INFO] <nawf> 17 diamonds
2011-02-13 17:04:03 [INFO] <redux06790> how much coal?
2011-02-13 17:04:30 [INFO] <redux06790> come look at the start of my hole
2011-02-13 17:04:43 [INFO] <nawf> 622 coal
2011-02-13 17:04:45 [INFO] <AngryRhetoric> moss cobble
2011-02-13 17:04:47 [INFO] <redux06790> jeez
2011-02-13 17:04:48 [INFO] <redux06790> youre set
2011-02-13 17:04:49 [INFO] <nawf> and 1 saddle
2011-02-13 17:04:51 [INFO] <AngryRhetoric> haha
2011-02-13 17:04:59 [INFO] <AngryRhetoric> what would mcguyver do with all that
2011-02-13 17:06:15 [INFO] <nawf> this are castle building supplies
2011-02-13 17:06:19 [INFO] <nawf> these
2011-02-13 17:06:26 [INFO] <redux06790> thats why im making a hole
2011-02-13 17:06:30 [INFO] <redux06790> to get cobble
2011-02-13 17:07:22 [INFO] <nawf> kev did you see I took out the mountainw
2011-02-13 17:07:39 [INFO] <AngryRhetoric> which one?
2011-02-13 17:07:50 [INFO] <AngryRhetoric> oh shit
2011-02-13 17:07:53 [INFO] <AngryRhetoric> daaam
2011-02-13 17:08:07 [INFO] <AngryRhetoric> interesting
2011-02-13 17:08:22 [INFO] <nawf> the river goes to the spawner
2011-02-13 17:08:26 [INFO] <AngryRhetoric> we can level out the courtyard area but it might have to be brought up to 1st floor level
2011-02-13 17:08:33 [INFO] <AngryRhetoric> all the way tot he spawner??
2011-02-13 17:08:51 [INFO] <nawf> what do you mean?
2011-02-13 17:08:54 [INFO] <nawf> over here?
2011-02-13 17:09:00 [INFO] <AngryRhetoric> yeah
2011-02-13 17:09:11 [INFO] <nawf> yeah, we can do that
2011-02-13 17:09:24 [INFO] <AngryRhetoric> maybe not maybe it can drop down to here but it might look nicer at 1st floor lvl
2011-02-13 17:09:31 [INFO] <nawf> I was going to slope it down
2011-02-13 17:10:00 [INFO] <AngryRhetoric> fight club is on hahaha
2011-02-13 17:10:06 [INFO] <redux06790> WUT!?
2011-02-13 17:10:09 [INFO] <redux06790> what channel?
2011-02-13 17:10:09 [INFO] <AngryRhetoric> yeayayh
2011-02-13 17:10:24 [INFO] <AngryRhetoric> hmm a gradual slow down wouldn't look bad
2011-02-13 17:12:04 [INFO] <redux06790> damn i need to dump my load
2011-02-13 17:13:39 [INFO] <redux06790> 675 cobble added to the heap
2011-02-13 17:14:52 [INFO] <redux06790> so ive decided my contribution to the castle will be supplying the materials
2011-02-13 17:15:30 [INFO] <AngryRhetoric> niice hey we can use it
2011-02-13 17:15:38 [INFO] <redux06790> come look at my hole
2011-02-13 17:15:46 [INFO] <AngryRhetoric> we'll still need a wall to surround the courtyard
2011-02-13 17:16:10 [INFO] <nawf> well this wasn't goig to be part of the courtyard, just a better entrance
2011-02-13 17:16:15 [INFO] <nawf> I'll make a normal wall here
2011-02-13 17:18:23 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 17:18:28 [INFO] <redux06790> can someone do me a favor?
2011-02-13 17:18:30 [INFO] <nawf> I just wanted it to be more interesting than, exit, wall
2011-02-13 17:18:51 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 17:19:30 [INFO] <redux06790> ne?
2011-02-13 17:19:33 [INFO] <redux06790> no?
2011-02-13 17:19:34 [INFO] <nawf> oh what?
2011-02-13 17:19:40 [INFO] <redux06790> i need a stack of ladders
2011-02-13 17:19:51 [INFO] <redux06790> otherwise i wont be able to get out of this thing when its done
2011-02-13 17:19:56 [INFO] <nawf> oh lol
2011-02-13 17:20:01 [INFO] <nawf> how far away are you?
2011-02-13 17:20:06 [INFO] <redux06790> just outside the castle
2011-02-13 17:20:07 [INFO] <AngryRhetoric> hahahaha
2011-02-13 17:20:19 [INFO] <AngryRhetoric> we have tons of wood here i can turn it into ladders
2011-02-13 17:20:36 [INFO] <nawf> bah, leave him in there
2011-02-13 17:20:36 [INFO] <redux06790> you know where my sign is that says i went on a great edventure?
2011-02-13 17:21:04 [INFO] <redux06790> basically just go out the main entrance of the castle
2011-02-13 17:21:09 [INFO] <redux06790> and im slightly to the right
2011-02-13 17:21:10 [INFO] <redux06790> dont fall in
2011-02-13 17:22:04 [INFO] <redux06790> im thinking this can be a mini spleef arena
2011-02-13 17:22:10 [INFO] <redux06790> brb
2011-02-13 17:22:31 [INFO] <nawf> I love it when you talk dirty to me
2011-02-13 17:22:46 [INFO] <AngryRhetoric> lol
2011-02-13 17:22:56 [INFO] <AngryRhetoric> i made 84 ladders
2011-02-13 17:24:02 [INFO] <redux06790> back
2011-02-13 17:24:10 [INFO] <redux06790> woot
2011-02-13 17:24:33 [INFO] <AngryRhetoric> you know what you should do instead of ladders?
2011-02-13 17:24:36 [INFO] <redux06790> so what do you think?
2011-02-13 17:24:40 [INFO] <redux06790> water ladder?
2011-02-13 17:24:43 [INFO] <AngryRhetoric> since youre' doing a circle do a spiral staircase
2011-02-13 17:24:50 [INFO] <AngryRhetoric> going around the outside,
2011-02-13 17:24:52 [INFO] <redux06790> i was thinking about doing that
2011-02-13 17:24:58 [INFO] <redux06790> but temporary is ladders
2011-02-13 17:24:59 [INFO] <AngryRhetoric> you could have dual stairs
2011-02-13 17:25:21 [INFO] <redux06790> i was thinking of using half blocks for a spiral staircase
2011-02-13 17:25:26 [INFO] <AngryRhetoric> not bad
2011-02-13 17:25:32 [INFO] <redux06790> this is an epic hole no?
2011-02-13 17:25:39 [INFO] <AngryRhetoric> since its near the castle you might need to cover the top eventually, keep things sightly ;)
2011-02-13 17:25:46 [INFO] <AngryRhetoric> yeah it is
2011-02-13 17:26:14 [INFO] <redux06790> i was thinking of making a cobble wall around it and filling it with water haha
2011-02-13 17:26:20 [INFO] <redux06790> GIANT WELL!!!!
2011-02-13 17:27:05 [INFO] <AngryRhetoric> haha
2011-02-13 17:27:14 [INFO] <nawf> I ran out of arrows :(
2011-02-13 17:27:26 [INFO] <nawf> halp kevin
2011-02-13 17:27:28 [INFO] <nawf> halp
2011-02-13 17:27:36 [INFO] <redux06790> i wish there was a way to make an ""up flow"" with water
2011-02-13 17:27:46 [INFO] <AngryRhetoric> where you at
2011-02-13 17:28:03 [INFO] <nawf> spider below me
2011-02-13 17:28:12 [INFO] <nawf> thanks
2011-02-13 17:28:12 [INFO] <AngryRhetoric> he was looking at you!
2011-02-13 17:28:19 [INFO] <AngryRhetoric> haha
2011-02-13 17:28:28 [INFO] <redux06790> ok guys
2011-02-13 17:28:28 [INFO] <AngryRhetoric> i have 10 arrows left, i'm heading back to main base
2011-02-13 17:28:32 [INFO] <redux06790> ill be back in a bit
2011-02-13 17:28:35 [INFO] <redux06790> dinner time
2011-02-13 17:28:36 [INFO] <AngryRhetoric> aight
2011-02-13 17:28:39 [INFO] <nawf> I think I stashed some inside
2011-02-13 17:28:47 [INFO] <AngryRhetoric> ohw
2011-02-13 17:28:53 [INFO] <nawf> no, I lied
2011-02-13 17:29:01 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 17:29:30 [INFO] <AngryRhetoric> i don't see any
2011-02-13 17:29:32 [INFO] <AngryRhetoric> haha darn
2011-02-13 17:29:39 [INFO] <nawf> yeah, I thought I brought extra
2011-02-13 17:30:59 [INFO] <nawf> I may take a break too kev, I'll be back
2011-02-13 17:31:03 [INFO] <nawf> lol, you made a creeper friend
2011-02-13 17:31:10 [INFO] <AngryRhetoric> lol bastid
2011-02-13 17:31:18 [INFO] <AngryRhetoric> ok sounds good, see you back on later
2011-02-13 17:31:19 [INFO] <nawf> I heard it
2011-02-13 17:31:24 [INFO] <AngryRhetoric> hahah yeah
2011-02-13 17:31:29 [INFO] nawf lost connection: disconnect.quitting
2011-02-13 17:52:28 [INFO] redux06790 [/69.119.8.191:49485] logged in with entity id 3569313
2011-02-13 17:52:41 [INFO] <redux06790> UNLEASH THE KRAKEN!!!
2011-02-13 17:52:41 [INFO] Disconnecting nawf [/76.23.232.27:55324]: Took too long to log in
2011-02-13 17:52:43 [INFO] <AngryRhetoric> haha
2011-02-13 17:52:46 [INFO] <AngryRhetoric> YAH
2011-02-13 17:52:52 [INFO] <AngryRhetoric> minecraft kraken
2011-02-13 17:52:58 [INFO] <redux06790> that would fuckin suck
2011-02-13 17:53:01 [INFO] nawf [/76.23.232.27:55334] logged in with entity id 3569720
2011-02-13 17:53:06 [INFO] <AngryRhetoric> haha as we shoot pathetic arrows at it
2011-02-13 17:55:13 [INFO] <AngryRhetoric> the 1st rule of fight club:
2011-02-13 17:55:33 [INFO] <redux06790> do not talk about fight club
2011-02-13 17:55:41 [INFO] <redux06790> 2nd rule do not talk about fight club
2011-02-13 17:55:46 [INFO] <AngryRhetoric> haha
2011-02-13 17:55:53 [INFO] <AngryRhetoric> where the dirt at w
2011-02-13 17:55:56 [INFO] <redux06790> third rule if someone yells stop taps out goes limp the fight is over
2011-02-13 17:56:05 [INFO] <redux06790> ok ill stop lol
2011-02-13 17:56:12 [INFO] <nawf> dirt?I'm using a lot of it
2011-02-13 17:56:13 [INFO] <AngryRhetoric> haha
2011-02-13 17:56:19 [INFO] <redux06790> interestingly enough
2011-02-13 17:56:24 [INFO] <AngryRhetoric> hmm ok
2011-02-13 17:56:29 [INFO] <redux06790> the rules arent in the book
2011-02-13 17:56:33 [INFO] <redux06790> not in a list anyway
2011-02-13 17:57:02 [INFO] <redux06790> what could you be doing with all that dirt?
2011-02-13 17:58:38 [INFO] <nawf> landscaping
2011-02-13 17:58:53 [INFO] <AngryRhetoric> oh yeah he's building the castle courtyard
2011-02-13 18:00:44 [INFO] <redux06790> i need an opinion
2011-02-13 18:01:01 [INFO] <redux06790> do you think it would be quicker to make this hole in columns or rows?
2011-02-13 18:01:51 [INFO] <nawf> hexagonsall the way
2011-02-13 18:02:02 [INFO] <redux06790> that doesnt make any sense
2011-02-13 18:02:12 [INFO] <redux06790> im thinking if i just do columns it will be quicker
2011-02-13 18:02:13 [INFO] <nawf> pssh, tell that to spiders
2011-02-13 18:02:15 [INFO] <nawf> or bees
2011-02-13 18:02:38 [INFO] <redux06790> maybe youre confusing what im asking
2011-02-13 18:02:51 [INFO] <redux06790> meaning should i dig one block down to the bedrock at a time
2011-02-13 18:03:02 [INFO] <redux06790> or shave off a layer at a time till i get to the bedrock?
2011-02-13 18:03:11 [INFO] <nawf> if you dig straight down you will die in lava
2011-02-13 18:03:32 [INFO] <redux06790> you bring up a  powerful argument
2011-02-13 18:03:37 [INFO] <redux06790> but what if there is no lava?
2011-02-13 18:04:02 [INFO] <nawf> I forget the exact math, but if you take a random block and go straight down 1/6 times
2011-02-13 18:04:05 [INFO] <nawf> it will be lava
2011-02-13 18:04:30 [INFO] <redux06790> and i have a circle thats 25 blocks across
2011-02-13 18:04:30 [INFO] <AngryRhetoric> niice
2011-02-13 18:04:34 [INFO] <AngryRhetoric> ""never dig down""
2011-02-13 18:04:36 [INFO] <redux06790> whats the area of that then?
2011-02-13 18:06:52 [INFO] <AngryRhetoric> argh
2011-02-13 18:07:47 [INFO] <nawf> uneven?
2011-02-13 18:07:50 [INFO] <redux06790> so you know how there are dungeons?
2011-02-13 18:08:01 [INFO] <nawf> lots of mob sounds
2011-02-13 18:08:03 [INFO] <AngryRhetoric> no i'm good just laaag
2011-02-13 18:08:12 [INFO] <redux06790> do you think it would make the game better if there were like random cabins on the curface?
2011-02-13 18:08:16 [INFO] <nawf> and you can see the spawner and torches if you hit f really fast
2011-02-13 18:08:45 [INFO] <AngryRhetoric> i like that there's nothing man-made
2011-02-13 18:08:49 [INFO] <AngryRhetoric> at lesat on the surface
2011-02-13 18:09:02 [INFO] <AngryRhetoric> its all nature, that we as humans get to rape and conform to our will
2011-02-13 18:09:45 [INFO] <redux06790> the mindcraft guy
2011-02-13 18:09:53 [INFO] <AngryRhetoric> hah
2011-02-13 18:09:54 [INFO] <redux06790> fuuu
2011-02-13 18:09:56 [INFO] <redux06790> spiders
2011-02-13 18:10:02 [INFO] <redux06790> the minecraft guy is like a superhero
2011-02-13 18:10:12 [INFO] <redux06790> he can punch through solid stone
2011-02-13 18:10:58 [INFO] <redux06790> good sir dost thou haveth any ham thou canst rain down upon me?
2011-02-13 18:11:04 [INFO] <AngryRhetoric> haha
2011-02-13 18:11:10 [INFO] <AngryRhetoric> its not ham, but i think you'll like it
2011-02-13 18:11:15 [INFO] <nawf> lava?
2011-02-13 18:11:16 [INFO] <AngryRhetoric> ok its ham
2011-02-13 18:11:18 [INFO] <redux06790> woot
2011-02-13 18:11:27 [INFO] <redux06790> my hero
2011-02-13 18:11:33 [INFO] <AngryRhetoric> haha
2011-02-13 18:11:40 [INFO] <redux06790> i got buttfucked hard by a spider
2011-02-13 18:12:06 [INFO] <nawf> hahaha
2011-02-13 18:12:17 [INFO] <nawf> I just figured out how to climb a vertical surface with a water bucket
2011-02-13 18:12:23 [INFO] <nawf> the game has changed forever
2011-02-13 18:12:33 [INFO] <AngryRhetoric> climb up?
2011-02-13 18:12:37 [INFO] <redux06790> mostly because im a faggot and refuse to give up 3 slots of space for a bow and arrows
2011-02-13 18:13:02 [INFO] <AngryRhetoric> bow and arrow is the most critical thing to have
2011-02-13 18:13:07 [INFO] <redux06790> do you know how to make a water ladder john?
2011-02-13 18:13:29 [INFO] <nawf> yeah
2011-02-13 18:13:43 [INFO] <nawf> kevin, should I put a big window here or many?
2011-02-13 18:13:49 [INFO] <nawf> I don't know how big you want the rooms to be
2011-02-13 18:14:11 [INFO] <AngryRhetoric> hmm
2011-02-13 18:14:21 [INFO] <nawf> because I'm on the 3rd floor here
2011-02-13 18:14:55 [INFO] <AngryRhetoric> yeah 3rd floor needs windows for bedrooms
2011-02-13 18:15:25 [INFO] <AngryRhetoric> i would say imitate the tower windows
2011-02-13 18:15:28 [INFO] <nawf> and we'll need a hallway
2011-02-13 18:15:32 [INFO] <nawf> well how many?
2011-02-13 18:15:47 [INFO] <AngryRhetoric> the hallway will come to the stairway
2011-02-13 18:15:49 [INFO] <AngryRhetoric> dam phone brb
2011-02-13 18:17:40 [INFO] <redux06790> lol
2011-02-13 18:18:08 [INFO] <nawf> oh no, don't kill him
2011-02-13 18:18:20 [INFO] <redux06790> drop a bucket on him
2011-02-13 18:18:24 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 18:19:30 [INFO] <redux06790> lol did it work?
2011-02-13 18:19:35 [INFO] <nawf> yeah, lol
2011-02-13 18:19:37 [INFO] <AngryRhetoric> i hate you
2011-02-13 18:19:40 [INFO] <nawf> rofl
2011-02-13 18:19:41 [INFO] <redux06790> HAHAHAHA
2011-02-13 18:20:01 [INFO] <redux06790> he will learn eventually ...
2011-02-13 18:20:09 [INFO] AngryRhetoric lost connection: disconnect.quitting
2011-02-13 18:20:13 [INFO] <redux06790> lol
2011-02-13 18:20:23 [INFO] <redux06790> him are butthurt
2011-02-13 18:21:07 [INFO] <redux06790> lol did we cross the line? i can never tell
2011-02-13 18:21:20 [INFO] <nawf> he prob had to go or something
2011-02-13 18:21:34 [INFO] <redux06790> i was laughing so hard man
2011-02-13 18:22:37 [INFO] <redux06790> im going to log on one day and my island paradise wont exsist anymore
2011-02-13 18:22:52 [INFO] <redux06790> since he knows where it is haha
2011-02-13 18:23:01 [INFO] <nawf> konrad put pieces of tnt on his bed
2011-02-13 18:23:04 [INFO] <nawf> now that was over the line
2011-02-13 18:23:08 [INFO] <redux06790> HAHA OMFG
2011-02-13 18:23:16 [INFO] Disconnecting AngryRhetoric [/24.147.183.4:54971]: Took too long to log in
2011-02-13 18:23:22 [INFO] <redux06790> i mean the worst ive thought about doing is making an arrow trap
2011-02-13 18:23:39 [INFO] /24.147.183.4:55008 lost connection
2011-02-13 18:24:06 [INFO] efess [/192.168.0.191:9963] logged in with entity id 3620485
2011-02-13 18:24:10 [INFO] <redux06790> oh herrow
2011-02-13 18:24:11 [INFO] <efess> yo!
2011-02-13 18:24:15 [INFO] <nawf> yo
2011-02-13 18:24:18 [INFO] <efess> HI
2011-02-13 18:24:18 [INFO] AngryRhetoric [/24.147.183.4:55031] logged in with entity id 3621534
2011-02-13 18:24:21 [INFO] <redux06790> awww
2011-02-13 18:24:22 [INFO] <efess> HI!
2011-02-13 18:24:27 [INFO] <redux06790> i thought we actually got him to rage quit
2011-02-13 18:24:29 [INFO] <AngryRhetoric> heyy sup joe!
2011-02-13 18:24:35 [INFO] <AngryRhetoric> RAAGE QUIT!!
2011-02-13 18:24:37 [INFO] <efess> nm kev
2011-02-13 18:24:38 [INFO] <redux06790> lawl
2011-02-13 18:24:45 [INFO] <nawf> we sent angry into the basement again
2011-02-13 18:24:54 [INFO] <efess> lolol
2011-02-13 18:24:54 [INFO] <redux06790> lol im still laughing so hard
2011-02-13 18:24:55 [INFO] <AngryRhetoric> i take a phone call for two seconds!
2011-02-13 18:24:59 [INFO] <AngryRhetoric> and then there's water and zombies
2011-02-13 18:25:00 [INFO] <redux06790> haha
2011-02-13 18:25:01 [INFO] <efess> you mad brah?
2011-02-13 18:25:06 [INFO] <AngryRhetoric> LOL
2011-02-13 18:25:08 [INFO] <nawf> lol
2011-02-13 18:25:14 [INFO] <AngryRhetoric> sall good brah
2011-02-13 18:25:17 [INFO] <efess> haha
2011-02-13 18:25:21 [INFO] <redux06790> problem gravity?
2011-02-13 18:25:32 [INFO] <efess> ;)
2011-02-13 18:25:36 [INFO] <efess> ascii needs a good troll face
2011-02-13 18:25:38 [INFO] <redux06790> 4chan melted my braid
2011-02-13 18:25:52 [INFO] <redux06790> i was thinking about building a trollface with all my wool
2011-02-13 18:25:56 [INFO] <redux06790> and making it into my house
2011-02-13 18:26:06 [INFO] <nawf> ok, back to hallways
2011-02-13 18:26:07 [INFO] <efess> it woudl have to be booby trapped to hell
2011-02-13 18:26:13 [INFO] <redux06790> hahaha
2011-02-13 18:26:14 [INFO] <redux06790> yea
2011-02-13 18:26:19 [INFO] <AngryRhetoric> braid melting mm
2011-02-13 18:26:42 [INFO] <redux06790> why the fuck do zombies have like 30 foot arms what the fuck?
2011-02-13 18:26:54 [INFO] <nawf> so the hallway, down this?
2011-02-13 18:27:01 [INFO] <AngryRhetoric> there's a racist joke in there somewhere but i'll leave that to you
2011-02-13 18:27:17 [INFO] <nawf> and then rooms on both sides?
2011-02-13 18:27:22 [INFO] <AngryRhetoric> yes
2011-02-13 18:27:36 [INFO] <AngryRhetoric> a hallway just on the other side of the great hallway
2011-02-13 18:27:38 [INFO] <nawf> and what about sizes?  make them equal?
2011-02-13 18:27:44 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 18:27:49 [INFO] <redux06790> i makin a hole, you jus jelly
2011-02-13 18:28:04 [INFO] <efess> shit's breakfast?
2011-02-13 18:28:13 [INFO] <AngryRhetoric> hah
2011-02-13 18:28:26 [INFO] <AngryRhetoric> our castle's being invated
2011-02-13 18:28:29 [INFO] <AngryRhetoric> invaded
2011-02-13 18:29:01 [INFO] <AngryRhetoric> hmm
2011-02-13 18:29:01 [INFO] <redux06790> you get about 7 stacks of stone for each layer i go down in my hole
2011-02-13 18:29:11 [INFO] <nawf> maybe make the rooms below massive?
2011-02-13 18:29:26 [INFO] <AngryRhetoric> the 1st floor should have libraries and the like
2011-02-13 18:29:27 [INFO] <redux06790> OMG
2011-02-13 18:29:31 [INFO] <nawf> gotcha
2011-02-13 18:29:32 [INFO] <redux06790> i just got an idea for this hole
2011-02-13 18:29:41 [INFO] <efess> going to put a horse in it?
2011-02-13 18:29:45 [INFO] <redux06790> GUISE!!!
2011-02-13 18:29:47 [INFO] <AngryRhetoric> the hallway should follow the line of the big hallway
2011-02-13 18:29:54 [INFO] <redux06790> we can make a tower that goes over the clouds
2011-02-13 18:30:04 [INFO] <redux06790> then its like an uber uderground tower
2011-02-13 18:30:04 [INFO] <nawf> oic
2011-02-13 18:30:13 [INFO] <redux06790> and we can connect it to the castle via badass bridge
2011-02-13 18:30:34 [INFO] <nawf> so the hallway hugs the great hallway?
2011-02-13 18:31:18 [INFO] <efess> I feel like loading up ultima
2011-02-13 18:31:24 [INFO] <efess> check out castle designs
2011-02-13 18:31:25 [INFO] <nawf> nice
2011-02-13 18:31:28 [INFO] <efess> ;P
2011-02-13 18:31:28 [INFO] <AngryRhetoric> t\exactly john
2011-02-13 18:31:37 [INFO] <nawf> ok, and just rooms on one side?
2011-02-13 18:31:38 [INFO] <redux06790> john do you know if spleef is turn based or realtime?
2011-02-13 18:31:43 [INFO] <nawf> realtime
2011-02-13 18:31:58 [INFO] <redux06790> k because it will factor into my stadiums design
2011-02-13 18:32:52 [INFO] <nawf> ok, I'll build the library cieling first
2011-02-13 18:32:56 [INFO] <AngryRhetoric> wow we have soo much stone
2011-02-13 18:32:59 [INFO] <nawf> because we need to have something underneath
2011-02-13 18:33:03 [INFO] <redux06790> youre welcome
2011-02-13 18:33:06 [INFO] <nawf> so we can do carpeted floors
2011-02-13 18:33:21 [INFO] <AngryRhetoric> ooh carpeted floors
2011-02-13 18:33:24 [INFO] <AngryRhetoric> like colored wool?
2011-02-13 18:33:29 [INFO] <redux06790> red carpet?
2011-02-13 18:33:33 [INFO] <AngryRhetoric> haha
2011-02-13 18:33:41 [INFO] <AngryRhetoric> red carpet for the main hallway is not a bad idea
2011-02-13 18:33:43 [INFO] <nawf> yeah, we'll make patterns and other shit
2011-02-13 18:33:55 [INFO] <redux06790> with gold blocks as the trim! get mining!
2011-02-13 18:33:57 [INFO] <AngryRhetoric> wall tapestries! heh
2011-02-13 18:33:59 [INFO] <AngryRhetoric> niice
2011-02-13 18:34:07 [INFO] <AngryRhetoric> yeah gold will be nice, we have tons of that
2011-02-13 18:34:13 [INFO] <redux06790> so
2011-02-13 18:34:16 [INFO] <redux06790> what youre saying is
2011-02-13 18:34:20 [INFO] <redux06790> we need tons of flowers?
2011-02-13 18:34:28 [INFO] <AngryRhetoric> hahaha
2011-02-13 18:34:40 [INFO] <AngryRhetoric> is that for the library ceiling?
2011-02-13 18:34:41 [INFO] <redux06790> basically i wanna get this castle built
2011-02-13 18:34:44 [INFO] <redux06790> but i dont wanna build it
2011-02-13 18:34:51 [INFO] <redux06790> so if you guys need something
2011-02-13 18:34:54 [INFO] <efess> haha
2011-02-13 18:34:57 [INFO] <nawf> yeah, because we need a lower layer
2011-02-13 18:34:59 [INFO] <redux06790> post a sign at my house that im working on
2011-02-13 18:35:01 [INFO] <nawf> so we can put wool on top
2011-02-13 18:35:13 [INFO] <nawf> hmm, I should make a pattern
2011-02-13 18:35:53 [INFO] <redux06790> got it?
2011-02-13 18:36:27 [INFO] <AngryRhetoric> brad pitt is getting his ass kicked and laughing about it (fight club)
2011-02-13 18:36:27 [INFO] <redux06790> so what then, are some high priority materials that the castle needs?
2011-02-13 18:36:39 [INFO] <redux06790> YOU DONT KNOW WHERE IVE BEEN LOU!!!!
2011-02-13 18:36:47 [INFO] <AngryRhetoric> hahaha
2011-02-13 18:36:53 [INFO] <AngryRhetoric> *spits blood on him*
2011-02-13 18:37:16 [INFO] <redux06790> guys, what materials do i need to stock up on for the castle work?
2011-02-13 18:37:22 [INFO] <nawf> sand for glass
2011-02-13 18:37:29 [INFO] <nawf> I think we need more dirt
2011-02-13 18:37:31 [INFO] <nawf> well I do
2011-02-13 18:37:31 [INFO] <AngryRhetoric> yeah, we're high on stone for now so that's good
2011-02-13 18:37:37 [INFO] <redux06790> ok
2011-02-13 18:37:45 [INFO] <redux06790> ill be right back with more sand than you can piss on
2011-02-13 18:37:47 [INFO] <AngryRhetoric> joe what you workin on?
2011-02-13 18:37:54 [INFO] <efess> i'm going to pimp out this basement
2011-02-13 18:38:08 [INFO] <AngryRhetoric> hahah sweeet
2011-02-13 18:38:16 [INFO] <nawf> you should put a basement in the basement so we can basement while we basement
2011-02-13 18:38:23 [INFO] <efess> yo dawg,
2011-02-13 18:38:39 [INFO] <efess> I put a yo in your yo yo
2011-02-13 18:39:01 [INFO] <redux06790> sand and dirt
2011-02-13 18:39:06 [INFO] <redux06790> brb
2011-02-13 18:39:31 [INFO] <redux06790> not afk btw just brb with sand and dirt
2011-02-13 18:42:44 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 18:42:48 [INFO] redux06790 [/69.119.8.191:49554] logged in with entity id 3644484
2011-02-13 18:44:52 [INFO] <redux06790> FUUU
2011-02-13 18:46:35 [INFO] <redux06790> jesus motherfucking christ
2011-02-13 18:46:41 [INFO] <redux06790> the spiders in the game are retarded
2011-02-13 18:46:49 [INFO] <nawf> carry a bow idiot
2011-02-13 18:46:49 [INFO] <redux06790> they always come at me 6 at a time what the fuck
2011-02-13 18:46:55 [INFO] <redux06790> i died
2011-02-13 18:47:08 [INFO] <AngryRhetoric> nice
2011-02-13 18:47:10 [INFO] <redux06790> becauze of zhe gravities
2011-02-13 18:47:28 [INFO] <redux06790> unless you wanna give be a bow so i can carve a swath
2011-02-13 18:47:36 [INFO] <AngryRhetoric> you're not the contents of your wallet
2011-02-13 18:48:25 [INFO] <redux06790> ...
2011-02-13 18:48:29 [INFO] <redux06790> i r need arroes!!!
2011-02-13 18:49:48 [INFO] <efess> maths are hard
2011-02-13 18:49:50 [INFO] <nawf> joe why are you in the block
2011-02-13 18:50:08 [INFO] <nawf> I'm showing you being in he block
2011-02-13 18:50:13 [INFO] <nawf> oh, now your out
2011-02-13 18:50:15 [INFO] <efess> silly minecraft
2011-02-13 18:51:46 [INFO] <redux06790> this track needs more boosters
2011-02-13 18:51:56 [INFO] <AngryRhetoric> haha
2011-02-13 18:51:57 [INFO] <efess> which one
2011-02-13 18:52:09 [INFO] <redux06790> the one going from the grinder base to the main base
2011-02-13 18:52:39 [INFO] <efess> ya for some reason the boosters sometimes don't give you
2011-02-13 18:52:41 [INFO] <efess> enough momentum
2011-02-13 18:56:08 [INFO] <nawf> going to grinder to pick up die and shit, we need anything else?  I think arrows are lowish
2011-02-13 18:57:04 [INFO] <redux06790> fucking miracle
2011-02-13 18:57:09 [INFO] <redux06790> i got my shit back
2011-02-13 18:57:31 [INFO] <redux06790> bbl
2011-02-13 18:57:32 [INFO] redux06790 lost connection: disconnect.quitting
2011-02-13 18:58:07 [INFO] <AngryRhetoric> listen up maggots, you are not special
2011-02-13 18:58:16 [INFO] <AngryRhetoric> you are the same decaying matter as everyone else
2011-02-13 18:58:23 [INFO] <AngryRhetoric> we are all part of the same compost heap
2011-02-13 19:00:34 [INFO] <AngryRhetoric> yeah more arrows are good
2011-02-13 19:00:41 [INFO] <AngryRhetoric> i stocked 2 or 3 stacks in the chests near the castle
2011-02-13 19:07:27 [INFO] <AngryRhetoric> ouch
2011-02-13 19:13:20 [INFO] <AngryRhetoric> nice john!
2011-02-13 19:13:46 [INFO] <AngryRhetoric> you gonna match down this end what's on that end?
2011-02-13 19:13:53 [INFO] <nawf> I'm going to try
2011-02-13 19:13:54 [INFO] <nawf> ;)
2011-02-13 19:14:04 [INFO] <AngryRhetoric> it has to be EXACT dammit!!!
2011-02-13 19:14:21 [INFO] <AngryRhetoric> *Stewie* - for every block that doesn't match i shall KEEL YOU!!!
2011-02-13 19:14:39 [INFO] <nawf> fuuu
2011-02-13 19:14:48 [INFO] <AngryRhetoric> haha
2011-02-13 19:14:53 [INFO] <nawf> Go to build stuff out of wood, forget the wood.
2011-02-13 19:15:11 [INFO] <AngryRhetoric> hah
2011-02-13 19:15:15 [INFO] <AngryRhetoric> got wood
2011-02-13 19:16:03 [INFO] <AngryRhetoric> this castle's lookin goOOOOod
2011-02-13 19:16:19 [INFO] <nawf> yeah, for 1/100th done its pretty sweet
2011-02-13 19:16:31 [INFO] <AngryRhetoric> haha
2011-02-13 19:16:36 [INFO] <AngryRhetoric> i'd say we're a good 25% done
2011-02-13 19:17:14 [INFO] <AngryRhetoric> crap
2011-02-13 19:18:20 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 19:18:38 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 19:31:22 [INFO] <AngryRhetoric> no smooth stone?
2011-02-13 19:31:32 [INFO] <nawf> naw, this is just temporary
2011-02-13 19:32:13 [INFO] <nawf> I got scared because a creeper was close
2011-02-13 19:32:21 [INFO] <nawf> creeper boom = we lose whole chests
2011-02-13 19:32:38 [INFO] <AngryRhetoric> heh yeah
2011-02-13 19:32:49 [INFO] <AngryRhetoric> bigger fence outside would help too
2011-02-13 19:33:13 [INFO] <nawf> trhe, but then we could still get shot
2011-02-13 19:33:54 [INFO] redux06790 [/69.119.8.191:49613] logged in with entity id 3732147
2011-02-13 19:34:01 [INFO] <redux06790> back
2011-02-13 19:34:02 [INFO] <AngryRhetoric> yeah
2011-02-13 19:34:03 [INFO] <AngryRhetoric> sup
2011-02-13 19:34:09 [INFO] <redux06790> why is there a pig in this mob spawner?
2011-02-13 19:34:16 [INFO] <redux06790> it was a zombie spawner before
2011-02-13 19:37:24 [INFO] <AngryRhetoric> LOL
2011-02-13 19:37:24 [INFO] <efess> !
2011-02-13 19:37:29 [INFO] <redux06790> ?
2011-02-13 19:37:30 [INFO] <AngryRhetoric> my dirt block!
2011-02-13 19:37:33 [INFO] <efess> :P
2011-02-13 19:37:38 [INFO] <AngryRhetoric> you took one and then left
2011-02-13 19:38:07 [INFO] <AngryRhetoric> yay dURT!
2011-02-13 19:38:14 [INFO] <efess> its raining dirt!
2011-02-13 19:38:20 [INFO] <efess> halleluia!
2011-02-13 19:38:26 [INFO] <AngryRhetoric> dirty dirt haha
2011-02-13 19:38:31 [INFO] <AngryRhetoric> dirt is my scaffolding
2011-02-13 19:39:05 [INFO] <redux06790> john still here?
2011-02-13 19:39:14 [INFO] <nawf> yeah, I'm trying to org the staging area
2011-02-13 19:39:22 [INFO] <nawf> you should just look at this mess erin
2011-02-13 19:39:29 [INFO] <nawf> your ocd will kick in and you'll do it
2011-02-13 19:39:42 [INFO] <redux06790> ok so 16-20 is the sweet spot for the diamond right?
2011-02-13 19:39:46 [INFO] <AngryRhetoric> haha my ocd's kicking in with the 2nd tower
2011-02-13 19:40:09 [INFO] <efess> lol
2011-02-13 19:40:14 [INFO] <redux06790> no?
2011-02-13 19:40:18 [INFO] <nawf> which one is that?
2011-02-13 19:40:24 [INFO] <nawf> yeah, 16-20
2011-02-13 19:40:43 [INFO] <redux06790> ok is that 16-20 up from the first bedrock? or the bottom bedrock?
2011-02-13 19:41:03 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 19:41:11 [INFO] <nawf> f3
2011-02-13 19:41:18 [INFO] <redux06790> gg erin
2011-02-13 19:41:22 [INFO] <redux06790> im retarded sometimes
2011-02-13 19:41:32 [INFO] <efess> holy color
2011-02-13 19:41:50 [INFO] <AngryRhetoric> heh
2011-02-13 19:41:52 [INFO] <nawf> I'm going to have to punch a fuckton of sheep
2011-02-13 19:41:56 [INFO] <efess> no shit
2011-02-13 19:42:01 [INFO] <efess> and a shitton of flowers
2011-02-13 19:42:29 [INFO] <redux06790> ohhh jooooooohnnnn
2011-02-13 19:42:42 [INFO] <redux06790> i happen to have a solar mass of wool
2011-02-13 19:43:00 [INFO] <nawf> yeah I could use that
2011-02-13 19:43:02 [INFO] <redux06790> that i would be happy to contribute
2011-02-13 19:43:14 [INFO] <efess> k gonna work on the wrapper some more
2011-02-13 19:43:17 [INFO] <redux06790> check my house outside the castle
2011-02-13 19:43:18 [INFO] <efess> bbl
2011-02-13 19:43:21 [INFO] efess lost connection: disconnect.quitting
2011-02-13 19:44:10 [INFO] <redux06790> do we need red flowers?
2011-02-13 19:45:16 [INFO] <nawf> yeah
2011-02-13 19:47:40 [INFO] <redux06790> did you check my contemporary house?
2011-02-13 19:49:51 [INFO] <nawf> not really
2011-02-13 19:50:02 [INFO] <redux06790> well thats where the wool is i think
2011-02-13 19:51:07 [INFO] <AngryRhetoric> thx
2011-02-13 19:51:12 [INFO] <AngryRhetoric> still trying to figure out the best configuratino
2011-02-13 19:51:15 [INFO] <AngryRhetoric> *configuration
2011-02-13 19:52:10 [INFO] <nawf> I'm not a fan of touch lines, but its your great hallway :p
2011-02-13 19:52:30 [INFO] <redux06790> touch lines?
2011-02-13 19:52:38 [INFO] <nawf> yeah, just lines of torches
2011-02-13 19:52:47 [INFO] <AngryRhetoric> hmm
2011-02-13 19:52:48 [INFO] <redux06790> TORCH lines
2011-02-13 19:52:48 [INFO] <redux06790> ahh
2011-02-13 19:52:56 [INFO] <redux06790> yeah i prefer fireplaces
2011-02-13 19:52:57 [INFO] <redux06790> imo
2011-02-13 19:52:58 [INFO] <nawf> lol, touch lines
2011-02-13 19:53:04 [INFO] <nawf> ooo, we need fireplaces
2011-02-13 19:53:06 [INFO] <AngryRhetoric> i was wondering what a touch line was
2011-02-13 19:53:07 [INFO] <redux06790> more grand if you ask me
2011-02-13 19:53:08 [INFO] <AngryRhetoric> haha
2011-02-13 19:53:28 [INFO] <AngryRhetoric> a great hall can't have a fireplace in it, and minecraft would require multiple
2011-02-13 19:53:43 [INFO] <AngryRhetoric> i had a square pattern of torches and that was not good
2011-02-13 19:53:49 [INFO] <redux06790> why cant a great hall have braziers?
2011-02-13 19:54:02 [INFO] <AngryRhetoric> hmm
2011-02-13 19:54:34 [INFO] <redux06790> fucking lava
2011-02-13 19:54:36 [INFO] <AngryRhetoric> i'm up for suggestions on lighting, wait, would chandeliers be enough?? hmm not likely
2011-02-13 19:54:47 [INFO] <redux06790> you lied to me john
2011-02-13 19:54:55 [INFO] <redux06790> i am a master of lighting ideas
2011-02-13 19:55:00 [INFO] <redux06790> because im a decorating niggerfaggot
2011-02-13 19:55:09 [INFO] <AngryRhetoric> oh thtop it
2011-02-13 19:55:18 [INFO] <nawf> no wool in here erin
2011-02-13 19:55:28 [INFO] <redux06790> what the fucking fuck
2011-02-13 19:55:29 [INFO] <nawf> well there are 6
2011-02-13 19:55:32 [INFO] <redux06790> i just died for NO reason
2011-02-13 19:55:47 [INFO] <redux06790> ok well ill go get the wool
2011-02-13 19:56:07 [INFO] <nawf> anytime, I have to finish up the tower before kevins ocd kills me
2011-02-13 19:56:12 [INFO] <redux06790> can i use 4 of your diamonds?
2011-02-13 19:56:18 [INFO] <AngryRhetoric> LOL
2011-02-13 19:56:20 [INFO] <nawf> yeah
2011-02-13 19:56:21 [INFO] <AngryRhetoric> get it RIIIIGGGHT
2011-02-13 19:56:29 [INFO] <redux06790> k
2011-02-13 19:56:35 [INFO] <redux06790> its going to be a bit
2011-02-13 19:56:42 [INFO] <AngryRhetoric> any ideas on torches john? staggered maybe?
2011-02-13 19:56:42 [INFO] <redux06790> i have to run back to my faggot corpse
2011-02-13 19:56:46 [INFO] <redux06790> then out to my island
2011-02-13 19:57:03 [INFO] <nawf> well whenever, I should go for a while, can't mc all day
2011-02-13 19:57:23 [INFO] <redux06790> says who?
2011-02-13 19:57:24 [INFO] <nawf> I may be back later, gotta get some shit done around the apt
2011-02-13 19:57:36 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 19:57:42 [INFO] nawf lost connection: disconnect.quitting
2011-02-13 19:57:46 [INFO] redux06790 lost connection: disconnect.genericReason
2011-02-13 20:00:31 [INFO] Disconnecting redux06790 [/69.119.8.191:49689]: Took too long to log in
2011-02-13 20:00:41 [INFO] /69.119.8.191:49696 lost connection
2011-02-13 20:01:03 [INFO] /69.119.8.191:49700 lost connection
2011-02-13 20:01:25 [INFO] /69.119.8.191:49706 lost connection
2011-02-13 20:02:42 [INFO] Disconnecting redux06790 [/69.119.8.191:49714]: Took too long to log in
2011-02-13 20:03:05 [INFO] redux06790 [/69.119.8.191:49717] logged in with entity id 3798379
2011-02-13 20:05:30 [INFO] <AngryRhetoric> i'll be afk for a bit
2011-02-13 20:07:45 [INFO] <redux06790> k
2011-02-13 20:17:59 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?
2011-02-13 20:18:42 [WARNING] Can't keep up! Did the system time change, or is the server overloaded?";
        }
    }
}

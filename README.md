# cs2-cheat

> Counter-Strike 2 · cheat · esp · aimbot · wallhack · triggerbot

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4)](https://dot.net)
[![Cheat](https://img.shields.io/badge/type-cheat-red)]()
[![Game](https://img.shields.io/badge/game-Counter--Strike%202-orange)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

**cs2-cheat** is an external Counter-Strike 2 cheat: ESP, aim assist, triggerbot, recoil, bhop, radar and misc.

tested on latest patch. for research and educational purposes only.

## features

- **ESP** — box, health bar, distance, name tags, skeleton, snaplines
- **Aim Assist** — configurable FOV circle, smooth factor, bone select, recoil compensation
- **TriggerBot** — reaction delay with jitter, burst mode, team check
- **Bunny Hop** — auto-jump on ground flag detect
- **Radar** — force enemy spotted on minimap
- **No Flash** — override flash duration to zero
- **Config** — JSON profiles under %APPDATA%, import/export, hotkeys

## build

requires .NET 10 SDK.

```
dotnet build
```

run:

```
.\build\bin\cs2-cheat.Loader\net10.0\cs2cheat.exe
```

Counter-Strike 2 must be running before you start the loader.

## config

profiles auto-save to `%APPDATA%\cs2-cheat\profiles\default.json`.

```json
{
  "aim": {
    "enabled": true,
    "fov": 5.0,
    "smooth": 3.5,
    "bone": "Head",
    "rcs": true
  },
  "esp": {
    "enabled": true,
    "box": true,
    "health": true,
    "skeleton": false,
    "distance": true
  },
  "trigger": {
    "enabled": false,
    "delayMs": 50,
    "jitter": 15,
    "burstCount": 1
  },
  "misc": {
    "bhop": false,
    "noFlash": false,
    "radar": false
  }
}
```

## keybinds

| key | action |
|---|---|
| INSERT | toggle menu |
| F1 | aim assist |
| F2 | esp |
| F3 | triggerbot |
| F4 | bhop |
| MOUSE5 | aim key (hold) |
| HOME | reload config |
| END | panic — clean exit |

## anti-cheat

targets **VAC / VAC-NET**. no bypass included.
detection is expected without additional evasion layers.

## disclaimer

educational / research project for game hacking concepts.
not affiliated with the developers of Counter-Strike 2.
don't use in online matchmaking — you **will** get banned.


---

## Topics

![cs2](https://img.shields.io/badge/cs2-111827?style=flat-square) ![cs2-cheat](https://img.shields.io/badge/cs2%20cheat-111827?style=flat-square) ![counter-strike-2](https://img.shields.io/badge/counter%20strike%202-111827?style=flat-square) ![cheat](https://img.shields.io/badge/cheat-111827?style=flat-square) ![hack](https://img.shields.io/badge/hack-111827?style=flat-square) ![esp](https://img.shields.io/badge/esp-111827?style=flat-square) ![aimbot](https://img.shields.io/badge/aimbot-111827?style=flat-square) ![triggerbot](https://img.shields.io/badge/triggerbot-111827?style=flat-square)

`cs2` `cs2-cheat` `counter-strike-2` `cheat` `hack` `esp` `aimbot` `triggerbot` `wallhack` `bhop` `skin-changer` `undetected` `external` `overlay` `source2` `vac` `game-hacking` `free` `csharp`

Search: cs2-cheat · cs2 · cheat · esp · aimbot · undetected · CS2 cheat — ESP, aimbot, triggerbot, skin changer, bhop. External overlay, undetected, stream-proof.

---

<sub>CS2 cheat — ESP, aimbot, triggerbot, skin changer, bhop. External overlay, undetected, stream-proof.</sub>

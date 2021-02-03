# Type For Me

**`typeforme`** is a basic typewriter program made for linux-x64 terminal emulators.
It simulates typing, from left to right, with linear speed and on-the-fly text formatting.

Tested only from Linux environment.

## Origin

It started as a workaround for subtitling text-to-speech services, as a bash script.

I made a sketch with different tts voices, as in competing between themselves for who was the better english voice, with insults and laughs.

Later on, I decided to step again into C# to learn programming (this time, without Unity), rewriting the tool again to make it more fun!

## Features

* Text and in-line background coloring options (standard 16-color set).
* Text formatting:
  * bold, italic, underline, blink, highlight, strikethrough and dual underlining.
* Change its typing speed and place delays in milliseconds.
* Hide text cursor. (**NEW**)
* Much more! :)

## A note

This is my first personal project I ever upload to a repository, I'm using it as a stepping stone. 

Feature requests from the Issues section, after consideration, will be put in motion once I thoroughly understand how to write clean code.

## Usage

```
typeforme ['text']...
typeforme ['text'] [options]...
typeforme [options] ['text']...
```

Try `--help` for all available options!

### Examples

Basic:

```bash
typeforme 'The lazy dog rocket jumped over the silly rabbit.'
```

Speed changing (`--speed`):

```bash
typeforme 'The lazy' --speed 500 ' dog' \
	--speed 125 ' rocket jumped' --speed 40 ' over the silly rabbit.'
```

Applying delays (`--delay`):

```bash
typeforme 'The lazy dog' --delay 400 ' rocket' --delay 200 ' jumped' \
	--delay 600 ' over the' --delay 100 ' silly' --delay 200 ' rabbit!!'
```

Text formatting:

```bash
typeforme 'The lazy ' +italic 'dog ' -italic \
	+bold 'rocket jumped ' -bold 'over the silly rabbit.'
```

Text coloring:

```bash
typeforme 'The lazy ' --color-fg-bright-white 'dog' \
	--color-fg-bright-red +bold 'rocket jumped' --color-fg-bright-red -bold \
	'over the silly rabbit.'
```

## Download

Go to Releases, try latest.

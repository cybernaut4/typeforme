**`typeforme`** is a basic typewriter program made for linux-x64 terminal emulators.
It simulates typing, from left to right, with linear speed and on-the-fly text formatting.

Tested only from Linux environment.

### Features

Supports :

* Text and in-line background coloring options (standard 16-color set).

* Text formatting:
  * bold, italic, underline, blink, highlight, strikethrough and dual underlining.
* Ability to change typing speed, and place delays with milliseconds (1000 per second).

### Usage

```
typeforme ['text']...
typeforme [options] ['text']...
```

Try `--help` for all available options!

#### Example

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
typeforme 'The lazy ' +color-fg-bright-white 'dog' \
	+color-fg-bright-red +bold 'rocket jumped' +color-fg-bright-red -bold \
	'over the silly rabbit.'
```





###  Download

Go to Releases, try latest.
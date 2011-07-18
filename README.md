# Getting the source

- Download the source from the link above; or 
- Clone it to your machine via "git clone git://github.com/davidalpert/nuserve.git"

# Building the source

This sample project uses several nuget packages that are not included in the source.  In order to build the projects, you will need to install those nugets yourself.

If ruby makes you nervous, we have a [support group](http://winnipegrb.org/ "The most fun you can have with your pants on") for that.  In the meantime you will have to install the nugets yourself from a command-line using the [nuget.exe](http://blog.davidebbo.com/2011/01/installing-nuget-packages-directly-from.html "Installing NuGet packages directly from the command line") tool.

If, on the other hand, ruby is exciting, follow the instructions below and the included rakefile will download and configure the missing dependencies for you.

Happy spelunking!

## ... using Rake

1. Download and install [ruby](http://rubyinstaller.org/ "The easy way to install Ruby on Windows!)
1. Install [rake](http://rake.rubyforge.org/): "gem install rake"
1. Install [bundler](http://gembundler.com/): "gem install bundler"
1. Open a console and change to the root of the project source tree (where the rakefile is)
1. Run "rake -T" to list the available script tasks (targets)
1. "rake setup" will download and configure the required packages

You should now be set up to build the project from the command line (via "rake") or from visual studio.

Drop me a line if you run into trouble.

David.

# build dependencies

1. Download & install Ruby 1.8.7 +

## Install the Ruby DevKit

You may need to install the Ruby DevKit 

1. Download the [DevKit](http://github.com/downloads/oneclick/rubyinstaller/DevKit-tdm-32-4.5.2-20110712-1620-sfx.exe) from http://rubyinstaller.org/
1. Unzip it and open a command window into that folder with ruby in the path
1. run "ruby dk.rb init"
1. run "ruby dk.rb install"

## Setup ANSCICON to enable colored Cucumber output

1. Go to http://adoxa.110mb.com/ansicon/
1. Download [ANSICON v1.40](http://adoxa.110mb.com/ansicon/dl.php?f=ansicon)
1. Unzip it to somewhere permanent and open a command window to that folder
1. Change to the x86 or x64 folder and run "ansicon.exe -i" to install ansicon

## Build and go!

1. open a command window into the project folder
1. run "setup.bat" to install rake and bundler
1. run "rake" to build, test, and package into ~/build/

#!/usr/bin/perl
use strict;
use warnings;
use File::Basename;
use File::Spec;

# Get command line arguments
my $directory = $ARGV[0];
my $meme      = '~/meme/bin/meme'; 
my $dir       = "";
my $ext       = "";
my $file      = "";
my $out       = $ARGV[1];

mkdir $out;
print "MEME output root is $out\n\n";

# Opening the directory
opendir (DIR, $directory) or die $!;

# Reading the directory
while (my $bpDir = readdir(DIR)) {
           
    print "   ===> dir://$bpDir\n";
       
    if ($bpDir eq ".")  {
        next; 
    }
    if ($bpDir eq "..") {
        next; 
    }   
        
    # Start batch invoke task......
    $bpDir = "$directory/$bpDir/";
	mkdir "$out/$bpDir/";
	
	print "try open source directory   $bpDir\n";
    # Opening the directory
    opendir (faDIR, $bpDir) or die $!;

    # Reading the directory
    while (my $file = readdir(faDIR)) {
            
       if ($file eq ".")  {
           next; 
       }
       if ($file eq "..") {
           next; 
       }   
    
       $file = "$bpDir/$file"; 
       print "   ===> file://$file\n";

       my $matrix = "$file";    
 
         ($matrix,$dir,$ext) = fileparse($file, qr/\.[^.]*/);
       my $bplen  = basename $dir;
       my $outbp  = "$out/$bplen/";
       my $outDir = "$outbp/$matrix/";      
       my $args   = "$file -dna -maxsize 1000000000 -maxw 50 -mod zoops -nmotifs 100 -evt 10 -o \"$outDir\"";
          $args   = "$meme $args &";
  
       mkdir $outbp;
     
       print "$args\n\n";
       system($args);
	   sleep(1);
    }
    closedir(faDIR);  
}
closedir(DIR);

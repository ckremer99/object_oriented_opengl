#ifndef FILESYSTEM_H
#define FILESYSTEM_H

#include <string>
#include <iostream>

class FileSystem
{
public:
    static std::string getPath(const std::string &path)
    {
        // Adjust the path based on your project structure
        // This assumes that your executable is located in the "bin" directory,
        // and resources are one level up from that.
        return "./" + path;
    }
};

#endif


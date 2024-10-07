#version 330 core
out vec4 FragColor;
  
in vec3 ourColor;
in vec3 Normal; 
in vec2 TexCoord;

// Declare uniforms outside the if-statement

uniform bool texture_loaded;
uniform sampler2D ourTexture; // Moved outside the if-statement
uniform vec3 color;           // Moved outside the if-statement

void main()
{
    if (texture_loaded) {
        // Use the texture if it is loaded
        FragColor = texture(ourTexture, TexCoord);
    } else {
        // Use the fallback color if no texture is loaded
        FragColor = vec4(color, 1.0);
    }
}


#!/bin/bash
find src/Library -name "*.cs" -type f -not -path "*/obj/*" -not -path "*/bin/*" | while read file; do
  if ! grep -q "using System;" "$file"; then
    # Create a temporary file
    temp_file=$(mktemp)
    # Add using directives at the top of the file
    echo 'using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;' > "$temp_file"
    # Append the original file content
    cat "$file" >> "$temp_file"
    # Replace the original file with the temporary file
    mv "$temp_file" "$file"
    echo "Added using directives to $file"
  fi
done

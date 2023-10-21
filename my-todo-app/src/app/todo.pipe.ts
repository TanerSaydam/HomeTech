import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'todoPipe'
})
export class TodoPipe implements PipeTransform {

  transform(value: string[], search: string) {
    if(search == "") return value;
    return value.filter(p=> p.includes(search));
  }

}

import {Directive, HostBinding} from '@angular/core';

@Directive({
  selector: '[buttonStyle]'
})
export class ButtonStyleDirective {
  @HostBinding('class') class = 'btn btn-primary';
  @HostBinding('style.width') width = '100%';
  @HostBinding('style.marginLeft') marginLeft='5px';

}

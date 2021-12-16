import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DirectiveIfComponent } from './directive-if/directive-if.component';
import { DataBindingComponent } from './data-binding/data-binding.component';
import { PipeDemoComponent } from './pipe-demo/pipe-demo.component';
import { MyPipePipe } from './my-pipe.pipe';
import { TempConvertPipe } from './temp-convert.pipe';

@NgModule({
  declarations: [
    AppComponent,
    DirectiveIfComponent,
    DataBindingComponent,
    PipeDemoComponent,
    MyPipePipe,
    TempConvertPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent,DataBindingComponent]
})
export class AppModule { }

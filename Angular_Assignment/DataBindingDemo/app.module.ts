import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DirectiveIfComponent } from './directive-if/directive-if.component';
import { DataBindingComponent } from './data-binding/data-binding.component';
import { PipeDemoComponent } from './pipe-demo/pipe-demo.component';
import { MyPipePipe } from './my-pipe.pipe';
import { TempConvertPipe } from './temp-convert.pipe';
//import { AttributeDemoComponent } from './attribute-demo/attribute-demo.component';
import { TwoWayDemoComponent } from './two-way-demo/two-way-demo.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ClassStyleBindingComponent } from './class-style-binding/class-style-binding.component';
import { PipeAssignmentPipe } from './pipe-assignment.pipe';
import { BankComponent } from './bank/bank.component';
import { LifeCycleComponent } from './life-cycle/life-cycle.component';
import { FormDemoComponent } from './form-demo/form-demo.component';
import { ReactiveFormComponent } from './reactive-form/reactive-form.component';
import { ReactiveFormGroupComponent } from './reactive-form-group/reactive-form-group.component';

@NgModule({
  declarations: [
    AppComponent,
    DirectiveIfComponent,
    DataBindingComponent,
    PipeDemoComponent,
    MyPipePipe,
    TempConvertPipe,
    //AttributeDemoComponent,
    TwoWayDemoComponent,
    ClassStyleBindingComponent,
    PipeAssignmentPipe,
    BankComponent,
    LifeCycleComponent,
    FormDemoComponent,
    ReactiveFormComponent,
    ReactiveFormGroupComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent,DataBindingComponent]
})
export class AppModule { }

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GlobalServeComponent } from './global-serve.component';

describe('GlobalServeComponent', () => {
  let component: GlobalServeComponent;
  let fixture: ComponentFixture<GlobalServeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GlobalServeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GlobalServeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CubeServeDemoComponent } from './cube-serve-demo.component';

describe('CubeServeDemoComponent', () => {
  let component: CubeServeDemoComponent;
  let fixture: ComponentFixture<CubeServeDemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CubeServeDemoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CubeServeDemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
